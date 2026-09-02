using System.Buffers.Binary;
using System.Text;

namespace SmallestAI.IntegrationTests;

/// <summary>
/// Builds a two-speaker audio fixture at test time instead of committing a
/// binary WAV: two contrasting Lightning voices are synthesized and their PCM
/// concatenated, which gives Pulse something real to diarize while keeping the
/// repository free of opaque test assets.
/// </summary>
public partial class Tests
{
    private const int FixtureSampleRate = 16000;

    private const string FirstSpeakerLine =
        "Hello, thanks for calling support. How can I help you today?";

    private const string SecondSpeakerLine =
        "Hi. I need to reset my password, and I cannot find the link anywhere.";

    private static async Task<byte[]> BuildTwoSpeakerWavAsync(
        SmallestAIClient client,
        CancellationToken cancellationToken = default)
    {
        var (firstVoiceId, secondVoiceId) = await PickContrastingVoicesAsync(client, cancellationToken);

        var first = await SynthesizeWavAsync(client, firstVoiceId, FirstSpeakerLine, cancellationToken);
        var second = await SynthesizeWavAsync(client, secondVoiceId, SecondSpeakerLine, cancellationToken);

        return WriteWav(
            [.. ReadPcm(first), .. ReadPcm(second)],
            FixtureSampleRate);
    }

    /// <summary>
    /// Picks two voices of different gender so the diarizer has an acoustic
    /// difference to separate, falling back to any two distinct voices.
    /// </summary>
    private static async Task<(string First, string Second)> PickContrastingVoicesAsync(
        SmallestAIClient client,
        CancellationToken cancellationToken = default)
    {
        var response = await client.Voices.GetWavesVoicesAsync(
            cancellationToken: cancellationToken);

        var voices = response.Voices;
        if (voices is not { Count: >= 2 })
        {
            throw new AssertInconclusiveException("Smallest returned fewer than two voices to build the fixture from.");
        }

        var male = voices.FirstOrDefault(voice =>
            string.Equals(voice.Tags?.Gender, "male", StringComparison.OrdinalIgnoreCase));
        var female = voices.FirstOrDefault(voice =>
            string.Equals(voice.Tags?.Gender, "female", StringComparison.OrdinalIgnoreCase));

        return male is not null && female is not null
            ? (male.VoiceId, female.VoiceId)
            : (voices[0].VoiceId, voices[1].VoiceId);
    }

    private static Task<byte[]> SynthesizeWavAsync(
        SmallestAIClient client,
        string voiceId,
        string text,
        CancellationToken cancellationToken = default) =>
        client.TextToSpeech.SynthesizeSpeechAsync(
            new TtsRequest
            {
                Text = text,
                VoiceId = voiceId,
                SampleRate = TtsRequestSampleRate.x16000,
                OutputFormat = TtsRequestOutputFormat.Wav,
            },
            cancellationToken: cancellationToken);

    /// <summary>
    /// Extracts the PCM payload of a RIFF/WAVE buffer by walking its chunks.
    /// The header is not assumed to be 44 bytes — Lightning emits a LIST chunk
    /// on some voices.
    /// </summary>
    private static byte[] ReadPcm(byte[] wav)
    {
        if (wav.Length < 12 ||
            Encoding.ASCII.GetString(wav, 0, 4) != "RIFF" ||
            Encoding.ASCII.GetString(wav, 8, 4) != "WAVE")
        {
            throw new AssertInconclusiveException("Smallest returned audio that is not a RIFF/WAVE buffer.");
        }

        var offset = 12;
        while (offset + 8 <= wav.Length)
        {
            var chunkId = Encoding.ASCII.GetString(wav, offset, 4);
            var chunkSize = BinaryPrimitives.ReadInt32LittleEndian(wav.AsSpan(offset + 4, 4));
            var body = offset + 8;

            if (chunkId == "data")
            {
                var length = Math.Min(chunkSize, wav.Length - body);
                return wav.AsSpan(body, length).ToArray();
            }

            // Chunks are word-aligned, so an odd size carries a pad byte.
            offset = body + chunkSize + (chunkSize % 2);
        }

        throw new AssertInconclusiveException("Smallest returned a WAVE buffer with no data chunk.");
    }

    private static byte[] WriteWav(byte[] pcm, int sampleRate)
    {
        const short channels = 1;
        const short bitsPerSample = 16;
        var byteRate = sampleRate * channels * bitsPerSample / 8;
        var blockAlign = (short)(channels * bitsPerSample / 8);

        var wav = new byte[44 + pcm.Length];
        var span = wav.AsSpan();

        Encoding.ASCII.GetBytes("RIFF").CopyTo(span);
        BinaryPrimitives.WriteInt32LittleEndian(span[4..], 36 + pcm.Length);
        Encoding.ASCII.GetBytes("WAVEfmt ").CopyTo(span[8..]);
        BinaryPrimitives.WriteInt32LittleEndian(span[16..], 16);
        BinaryPrimitives.WriteInt16LittleEndian(span[20..], 1);
        BinaryPrimitives.WriteInt16LittleEndian(span[22..], channels);
        BinaryPrimitives.WriteInt32LittleEndian(span[24..], sampleRate);
        BinaryPrimitives.WriteInt32LittleEndian(span[28..], byteRate);
        BinaryPrimitives.WriteInt16LittleEndian(span[32..], blockAlign);
        BinaryPrimitives.WriteInt16LittleEndian(span[34..], bitsPerSample);
        Encoding.ASCII.GetBytes("data").CopyTo(span[36..]);
        BinaryPrimitives.WriteInt32LittleEndian(span[40..], pcm.Length);
        pcm.CopyTo(span[44..]);

        return wav;
    }
}
