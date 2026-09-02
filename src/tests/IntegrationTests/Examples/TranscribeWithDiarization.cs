/*
order: 20
title: Transcribe with speaker diarization
slug: transcribe-with-diarization

Pulse returns the transcript, word-level speaker labels and timestamps from a
single pre-recorded call. Pass `diarize: true` for speaker attribution, and add
`wordTimestamps: true` when you want that attribution per word rather than only
per utterance.

Speaker ids are zero-indexed and stable within one response, not across
requests. Use `pulse` rather than `pulse-pro` — Pulse Pro is English-only and
does not diarize.
*/

namespace SmallestAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TranscribeWithDiarization()
    {
        using var client = GetAuthenticatedClient();

        var audio = await BuildTwoSpeakerWavAsync(client, TestContext.CancellationToken);

        var result = await client.SpeechToText.TranscribeAsync(
            model: WavesV1SttPostParametersModel.Pulse,
            language: WavesV1SttPostParametersLanguage.En,
            request: audio,
            wordTimestamps: true,
            diarize: true,
            cancellationToken: TestContext.CancellationToken);

        var transcription = result.TranscriptionResponse;
        transcription.Should().NotBeNull();
        transcription!.Transcription.Should().NotBeNullOrWhiteSpace();

        // Every word carries its own timing plus the speaker it was attributed to.
        transcription.Words.Should().NotBeNullOrEmpty();
        transcription.Words!.Should().Contain(word => word.Speaker != null);
        transcription.Words!.Should().Contain(word => word.SpeakerConfidence != null);

        // Two voices went in, so at least two speakers should come back.
        var speakers = transcription.Utterances?
            .Where(utterance => utterance.Speaker != null)
            .Select(utterance => utterance.Speaker!.Value)
            .Distinct()
            .ToList() ?? [];

        speakers.Should().HaveCountGreaterThanOrEqualTo(2);
    }
}
