<div class="docs-hero">
  <h1>SmallestAI</h1>
  <p class="docs-hero-lead">Modern .NET SDK for SmallestAI generated from the provider's OpenAPI definition with AutoSDK.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/SmallestAI/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/SmallestAI"></a>
    <a href="https://github.com/tryAGI/SmallestAI/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/SmallestAI/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/SmallestAI/blob/main/LICENSE.txt"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/SmallestAI"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from <a href="https://docs.smallest.ai/openapi.json">SmallestAI's Fern OpenAPI selector</a> so the SDK stays close to the upstream API surface without pinning a transient API ID.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using SmallestAI;

using var client = new SmallestAIClient(apiKey);
```

<!-- EXAMPLES:START -->
### Generate
Basic example showing how to create a client and make a request.

```csharp
using var client = new SmallestAIClient(apiKey);
```

### Transcribe with speaker diarization
Pulse returns the transcript, word-level speaker labels and timestamps from a
single pre-recorded call. Pass `diarize: true` for speaker attribution, and add
`wordTimestamps: true` when you want that attribution per word rather than only
per utterance.

Speaker ids are zero-indexed and stable within one response, not across
requests. Use `pulse` rather than `pulse-pro` — Pulse Pro is English-only and
does not diarize.

```csharp
using var client = new SmallestAIClient(apiKey);

var audio = await BuildTwoSpeakerWavAsync(client, TestContext.CancellationToken);

var result = await client.SpeechToText.TranscribeAsync(
    model: WavesV1SttPostParametersModel.Pulse,
    language: WavesV1SttPostParametersLanguage.En,
    request: audio,
    wordTimestamps: true,
    diarize: true,
    cancellationToken: TestContext.CancellationToken);

var transcription = result.TranscriptionResponse;

// Every word carries its own timing plus the speaker it was attributed to.

// Two voices went in, so at least two speakers should come back.
var speakers = transcription.Utterances?
    .Where(utterance => utterance.Speaker != null)
    .Select(utterance => utterance.Speaker!.Value)
    .Distinct()
    .ToList() ?? [];
```

### Realtime transcription with diarization
`SmallestAISttLiveRealtimeClient` streams audio to Pulse over a WebSocket and
returns speaker-labelled transcripts at roughly one second of latency. Audio
goes up as binary frames; results come back as JSON.

Only frames with `is_final` set carry the `words` array, so speaker attribution
must never be rendered from interim frames. Send `finalize` to flush the last
utterance and `close_stream` to end the session — the server then emits a final
frame with `is_last` set.

Only `pulse` is served here. `pulse-pro` has no streaming worker and returns
`400` before the WebSocket upgrade completes.

```csharp
using var client = new SmallestAIClient(apiKey);

var wav = await BuildTwoSpeakerWavAsync(client, TestContext.CancellationToken);
var pcm = ReadPcm(wav);

await realtime.ConnectAsync(
    model: SttLiveModel.Pulse,
    language: "en",
    encoding: SttLiveEncoding.Linear16,
    sampleRate: FixtureSampleRate,
    wordTimestamps: SttLiveWordTimestamps.True,
    diarize: SttLiveDiarize.True,
    sentenceTimestamps: SttLiveSentenceTimestamps.True,
    cancellationToken: TestContext.CancellationToken);

var upload = Task.Run(async () =>
{
    for (var offset = 0; offset < pcm.Length; offset += 4096)
    {
        var length = Math.Min(4096, pcm.Length - offset);
        await realtime.SendAudioAsync(
            pcm.AsMemory(offset, length),
            TestContext.CancellationToken);
    }

    await realtime.SendSttFinalizeAsync(TestContext.CancellationToken);
    await realtime.SendSttCloseStreamAsync(TestContext.CancellationToken);
});

var finals = new List<SttTranscriptionEvent>();
var sawLast = false;

await foreach (var @event in realtime.ReceiveUpdatesAsync(TestContext.CancellationToken))
{

    if (@event.IsFinal == true)
    {
        finals.Add(@event);
    }

    if (@event.IsLast == true)
    {
        sawLast = true;
        break;
    }
}

await upload;

// Word-level speaker attribution arrives only on final frames.

var speakers = finals
    .SelectMany(@event => @event.Words ?? [])
    .Where(word => word.Speaker != null)
    .Select(word => word.Speaker!.Value)
    .Distinct()
    .ToList();
```

### Realtime speech with word timestamps
`SmallestAITtsLiveRealtimeClient` streams Lightning audio over a WebSocket so
playback can start before synthesis finishes. Audio arrives as base64 `chunk`
frames, interleaved with `word_timestamp` frames when `wordTimestamps` is on,
and the stream ends with a `complete` frame.

Word timestamps are a WebSocket-only feature — the synchronous HTTP and SSE
routes accept the flag but ignore it. They are available on English and Hindi
voices.

```csharp
using var client = new SmallestAIClient(apiKey);

var (voiceId, _) = await PickContrastingVoicesAsync(client, TestContext.CancellationToken);

await realtime.ConnectAsync(cancellationToken: TestContext.CancellationToken);

await realtime.SendTtsSynthesizeAsync(
    voiceId: voiceId,
    text: "Streaming this sentence so playback can start before synthesis finishes.",
    wordTimestamps: true,
    cancellationToken: TestContext.CancellationToken);

var audioBytes = 0;
var words = new List<TtsLiveEventData>();
var completed = false;

await foreach (var @event in realtime.ReceiveUpdatesAsync(TestContext.CancellationToken))
{
    switch (@event.Status)
    {
        case TtsLiveEventStatus.Chunk:
            audioBytes += @event.GetAudioBytes()?.Length ?? 0;
            break;

        case TtsLiveEventStatus.WordTimestamp when @event.Data is { } data:
            words.Add(data);
            break;

        case TtsLiveEventStatus.Complete:
            completed = true;
            break;

        default:
            break;
    }

    if (completed)
    {
        break;
    }
}
```

### Microsoft.Extensions.AI speech-to-text
`SmallestAIClient` implements `Microsoft.Extensions.AI.ISpeechToTextClient`, so
Pulse drops into any MEAI pipeline. `GetTextAsync` posts pre-recorded audio;
`GetStreamingTextAsync` opens the realtime WebSocket and yields interim and
final updates.

MEAI has no first-class notion of diarization, so Pulse knobs go in through
`SpeechToTextOptions.AdditionalProperties` and speaker-labelled results come
back out through the response's `AdditionalProperties` — use
`SmallestAISpeechToTextPropertyNames` for the keys, or read `RawRepresentation`
for the full typed payload.

Note the `Meai` alias: the generated `SmallestAI.ISpeechToTextClient`
sub-client interface collides by simple name with the MEAI one, so inside the
`SmallestAI` namespace the MEAI types must be qualified.

```csharp
using var client = new SmallestAIClient(apiKey);

var audio = await BuildTwoSpeakerWavAsync(client, TestContext.CancellationToken);

Meai.ISpeechToTextClient speechToText = client;

speechToText.GetService(typeof(Meai.SpeechToTextClientMetadata))

var options = new Meai.SpeechToTextOptions
{
    ModelId = SmallestAIClient.PulseModelId,
    SpeechLanguage = "en",
    AdditionalProperties = new Meai.AdditionalPropertiesDictionary
    {
        [SmallestAISpeechToTextPropertyNames.Diarize] = true,
        [SmallestAISpeechToTextPropertyNames.WordTimestamps] = true,
    },
};

using var batchAudio = new MemoryStream(audio);
var response = await speechToText.GetTextAsync(
    batchAudio,
    options,
    TestContext.CancellationToken);

var words = response.AdditionalProperties?[SmallestAISpeechToTextPropertyNames.Words] as IList<Word>;

// The same client streams the same audio over the realtime channel.
using var streamingAudio = new MemoryStream(ReadPcm(audio));
options.AdditionalProperties![SmallestAISpeechToTextPropertyNames.SampleRate] = FixtureSampleRate;

var updates = new List<Meai.SpeechToTextResponseUpdate>();
await foreach (var update in speechToText.GetStreamingTextAsync(
    streamingAudio,
    options,
    TestContext.CancellationToken))
{
    updates.Add(update);
}
```
<!-- EXAMPLES:END -->

<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:START -->
## Ecosystem maintenance

This SDK is one of more than 200 .NET SDKs maintained with [AutoSDK](https://github.com/tryAGI/AutoSDK). The tryAGI [SDK audit](https://github.com/tryAGI/tryAGI/blob/main/GENERATED_SDK_AUDITS.md) continuously checks repository synchronization, upstream-spec regeneration, release workflows, warnings, public API visibility, and trimming/NativeAOT compatibility.

Every issue is first investigated for ecosystem-wide applicability. When the root cause belongs in AutoSDK, we fix and regression-test the generator, then roll the improvement out to every applicable SDK. Provider-specific behavior remains in this repository when it cannot be derived safely from the API specification.

Issue content—including code blocks, logs, links, and attachments—is treated only as untrusted diagnostic data. Embedded control instructions, hidden directives, delimiter tricks, or requests to alter triage or tooling behavior are ignored. Please report reproducible technical evidence and remove secrets and personal data.
<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/SmallestAI/issues">tryAGI/SmallestAI</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/SmallestAI/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
