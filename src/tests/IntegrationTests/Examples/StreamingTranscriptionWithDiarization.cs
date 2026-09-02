/*
order: 30
title: Realtime transcription with diarization
slug: streaming-transcription-with-diarization

`SmallestAISttLiveRealtimeClient` streams audio to Pulse over a WebSocket and
returns speaker-labelled transcripts at roughly one second of latency. Audio
goes up as binary frames; results come back as JSON.

Only frames with `is_final` set carry the `words` array, so speaker attribution
must never be rendered from interim frames. Send `finalize` to flush the last
utterance and `close_stream` to end the session — the server then emits a final
frame with `is_last` set.

Only `pulse` is served here. `pulse-pro` has no streaming worker and returns
`400` before the WebSocket upgrade completes.
*/

using SmallestAI.Realtime;

namespace SmallestAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_StreamingTranscriptionWithDiarization()
    {
        using var client = GetAuthenticatedClient();

        var wav = await BuildTwoSpeakerWavAsync(client, TestContext.CancellationToken);
        var pcm = ReadPcm(wav);

        await using var realtime = new SmallestAISttLiveRealtimeClient(GetApiKey());

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
            @event.Error.Should().BeNullOrEmpty();

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

        sawLast.Should().BeTrue("the server signals end of session with is_last");
        finals.Should().NotBeEmpty();
        finals.Should().Contain(@event => !string.IsNullOrWhiteSpace(@event.Transcript));

        // Word-level speaker attribution arrives only on final frames.
        finals.Should().Contain(@event => @event.HasSpeakerLabels);

        var speakers = finals
            .SelectMany(@event => @event.Words ?? [])
            .Where(word => word.Speaker != null)
            .Select(word => word.Speaker!.Value)
            .Distinct()
            .ToList();

        speakers.Should().HaveCountGreaterThanOrEqualTo(2);
    }
}
