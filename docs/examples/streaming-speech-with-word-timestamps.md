# Realtime speech with word timestamps

`SmallestAITtsLiveRealtimeClient` streams Lightning audio over a WebSocket so
playback can start before synthesis finishes. Audio arrives as base64 `chunk`
frames, interleaved with `word_timestamp` frames when `wordTimestamps` is on,
and the stream ends with a `complete` frame.

Word timestamps are a WebSocket-only feature — the synchronous HTTP and SSE
routes accept the flag but ignore it. They are available on English and Hindi
voices.

This example assumes `using SmallestAI;` is in scope and `apiKey` contains your SmallestAI API key.

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