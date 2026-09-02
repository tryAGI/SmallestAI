/*
order: 50
title: Microsoft.Extensions.AI speech-to-text
slug: speech-to-text-client

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
*/

using Meai = Microsoft.Extensions.AI;

namespace SmallestAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SpeechToTextClient()
    {
        using var client = GetAuthenticatedClient();

        var audio = await BuildTwoSpeakerWavAsync(client, TestContext.CancellationToken);

        Meai.ISpeechToTextClient speechToText = client;

        speechToText.GetService(typeof(Meai.SpeechToTextClientMetadata))
            .Should().BeOfType<Meai.SpeechToTextClientMetadata>();

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

        response.Text.Should().NotBeNullOrWhiteSpace();
        response.RawRepresentation.Should().BeOfType<TranscriptionResponse>();

        var words = response.AdditionalProperties?[SmallestAISpeechToTextPropertyNames.Words] as IList<Word>;
        words.Should().NotBeNullOrEmpty();
        words!.Should().Contain(word => word.Speaker != null);

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

        updates.Should().Contain(update => update.Kind == Meai.SpeechToTextResponseUpdateKind.SessionOpen);
        updates.Should().Contain(update => update.Kind == Meai.SpeechToTextResponseUpdateKind.TextUpdated);
        updates.Should().Contain(update => update.Kind == Meai.SpeechToTextResponseUpdateKind.SessionClose);
        updates.Should().Contain(update => !string.IsNullOrWhiteSpace(update.Text));
    }
}
