/*
order: 40
title: Realtime speech with word timestamps
slug: streaming-speech-with-word-timestamps

`SmallestAITtsLiveRealtimeClient` streams Lightning audio over a WebSocket so
playback can start before synthesis finishes. Audio arrives as base64 `chunk`
frames, interleaved with `word_timestamp` frames when `wordTimestamps` is on,
and the stream ends with a `complete` frame.

Word timestamps are a WebSocket-only feature — the synchronous HTTP and SSE
routes accept the flag but ignore it. They are available on English and Hindi
voices.
*/

using SmallestAI.Realtime;

namespace SmallestAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_StreamingSpeechWithWordTimestamps()
    {
        using var client = GetAuthenticatedClient();

        var (voiceId, _) = await PickContrastingVoicesAsync(client, TestContext.CancellationToken);

        await using var realtime = new SmallestAITtsLiveRealtimeClient(GetApiKey());

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

        completed.Should().BeTrue("the server terminates the stream with a complete frame");
        audioBytes.Should().BePositive();

        words.Should().NotBeEmpty();
        words.Should().BeInAscendingOrder(word => word.Id);
        words.Should().OnlyContain(word => word.Start != null && word.End != null);
    }
}
