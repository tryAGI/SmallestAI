# Realtime transcription with diarization

`SmallestAISttLiveRealtimeClient` streams audio to Pulse over a WebSocket and
returns speaker-labelled transcripts at roughly one second of latency. Audio
goes up as binary frames; results come back as JSON.

Only frames with `is_final` set carry the `words` array, so speaker attribution
must never be rendered from interim frames. Send `finalize` to flush the last
utterance and `close_stream` to end the session — the server then emits a final
frame with `is_last` set.

Only `pulse` is served here. `pulse-pro` has no streaming worker and returns
`400` before the WebSocket upgrade completes.

This example assumes `using SmallestAI;` is in scope and `apiKey` contains your SmallestAI API key.

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