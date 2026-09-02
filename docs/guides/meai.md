# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

`SmallestAIClient` implements
[`Microsoft.Extensions.AI.ISpeechToTextClient`](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai)
on top of Pulse, so Smallest drops into any MEAI pipeline alongside the other
tryAGI speech SDKs.

| Interface | Implemented | Backed by |
|-----------|-------------|-----------|
| `ISpeechToTextClient.GetTextAsync` | ✅ | `POST /waves/v1/stt/` (pre-recorded) |
| `ISpeechToTextClient.GetStreamingTextAsync` | ✅ | `wss://api.smallest.ai/waves/v1/stt/live` (realtime) |
| `IChatClient` | ❌ | — |
| `IEmbeddingGenerator` | ❌ | — |

## Installation

```bash
dotnet add package SmallestAI
```

## The `Meai` alias

The generated sub-client interface `SmallestAI.ISpeechToTextClient` collides by
simple name with `Microsoft.Extensions.AI.ISpeechToTextClient`. Inside the
`SmallestAI` namespace you therefore need an alias (or a fully-qualified name):

```csharp
using Meai = Microsoft.Extensions.AI;
```

Outside the `SmallestAI` namespace a plain `using Microsoft.Extensions.AI;`
works as usual.

## Pre-recorded transcription

```csharp
using Meai = Microsoft.Extensions.AI;
using SmallestAI;

using var client = new SmallestAIClient(
    apiKey: Environment.GetEnvironmentVariable("SMALLESTAI_API_KEY")!);

Meai.ISpeechToTextClient speechToText = client;

using var audio = File.OpenRead("call.wav");
var response = await speechToText.GetTextAsync(audio, new Meai.SpeechToTextOptions
{
    ModelId = SmallestAIClient.PulseModelId,
    SpeechLanguage = "en",
});

Console.WriteLine(response.Text);
```

## Speaker diarization

MEAI has no first-class notion of diarization, so Pulse-specific knobs are
passed through `SpeechToTextOptions.AdditionalProperties` and Pulse-specific
results — including `words[].speaker` and `utterances[].speaker` — come back
through the response's `AdditionalProperties`. Every key is a constant on
[`SmallestAISpeechToTextPropertyNames`](https://github.com/tryAGI/SmallestAI/blob/main/src/libs/SmallestAI/Extensions/SmallestAISpeechToTextPropertyNames.cs).

```csharp
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

var response = await speechToText.GetTextAsync(audio, options);

var words = (IList<Word>?)response.AdditionalProperties?[
    SmallestAISpeechToTextPropertyNames.Words];

foreach (var word in words ?? [])
{
    Console.WriteLine($"[speaker {word.Speaker}] {word.Word1}  {word.Start:F2}–{word.End:F2}s");
}
```

`RawRepresentation` carries the full typed `TranscriptionResponse` if you would
rather not go through `AdditionalProperties` at all.

## Realtime transcription

`GetStreamingTextAsync` opens the Pulse WebSocket, uploads the stream as binary
frames and yields interim (`TextUpdating`) and final (`TextUpdated`) updates,
bracketed by `SessionOpen` and `SessionClose`.

```csharp
options.AdditionalProperties![SmallestAISpeechToTextPropertyNames.SampleRate] = 16000;

await foreach (var update in speechToText.GetStreamingTextAsync(microphone, options))
{
    if (update.Kind == Meai.SpeechToTextResponseUpdateKind.TextUpdated)
    {
        Console.WriteLine(update.Text);
    }
}
```

!!! warning "Only final updates carry speaker labels"
    Pulse populates `words[]` only on frames with `is_final` set, so the adapter
    attaches `Words`/`Utterances` to `TextUpdated` updates only. Never render
    speaker attribution from an interim (`TextUpdating`) update.

!!! note "`pulse-pro` cannot stream"
    Pulse Pro has no streaming worker and returns `400` before the WebSocket
    upgrade completes, so `GetStreamingTextAsync` rejects it up front. Use it
    with `GetTextAsync` for pre-recorded English audio instead — note that it
    does not diarize either.

## Next Steps

- [Transcribe with speaker diarization](../examples/transcribe-with-diarization.md)
- [Realtime transcription with diarization](../examples/streaming-transcription-with-diarization.md)
- [Microsoft.Extensions.AI speech-to-text](../examples/speech-to-text-client.md)
- See the [centralized MEAI docs](https://tryagi.github.io/docs/meai/) for cross-SDK comparisons
