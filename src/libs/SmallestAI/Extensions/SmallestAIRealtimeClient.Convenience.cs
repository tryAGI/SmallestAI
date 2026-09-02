#nullable enable

using System.Net.WebSockets;
using System.Runtime.InteropServices;

namespace SmallestAI.Realtime;

public sealed partial class SmallestAISttLiveRealtimeClient
{
    /// <summary>
    /// Sends a chunk of raw audio as a binary WebSocket frame.
    /// <para>
    /// Pulse expects the encoding and sample rate declared on
    /// <c>ConnectAsync</c> — <c>linear16</c> at 16 kHz mono by default — and
    /// recommends roughly 4096-byte chunks.
    /// </para>
    /// </summary>
    /// <param name="audio">The raw audio bytes to send.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    public global::System.Threading.Tasks.Task SendAudioAsync(
        ReadOnlyMemory<byte> audio,
        CancellationToken cancellationToken = default)
    {
        var segment = MemoryMarshal.TryGetArray(audio, out var array)
            ? array
            : new ArraySegment<byte>(audio.ToArray());

        return SendAsync(segment, WebSocketMessageType.Binary, endOfMessage: true, cancellationToken);
    }

    /// <summary>
    /// Flushes the current utterance so the server emits its final transcript,
    /// keeping the session open for the next one.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token.</param>
    public global::System.Threading.Tasks.Task SendSttFinalizeAsync(
        CancellationToken cancellationToken = default) =>
        SendSttFinalizeAsync(
            new SttFinalizeRequest { Type = SttFinalizeRequestType.Finalize },
            cancellationToken);

    /// <summary>
    /// Ends the session. The server flushes any buffered audio and emits a
    /// final frame with <c>is_last</c> set before closing.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token.</param>
    public global::System.Threading.Tasks.Task SendSttCloseStreamAsync(
        CancellationToken cancellationToken = default) =>
        SendSttCloseStreamAsync(
            new SttCloseStreamRequest { Type = SttCloseStreamRequestType.CloseStream },
            cancellationToken);
}

public sealed partial class SttTranscriptionEvent
{
    /// <summary>
    /// Gets a value indicating whether this frame carries speaker attribution.
    /// <para>
    /// Only frames with <c>is_final</c> set carry the <c>words</c> array, so
    /// speaker labels must never be rendered from interim frames.
    /// </para>
    /// </summary>
    public bool HasSpeakerLabels =>
        IsFinal == true &&
        ((Words is { Count: > 0 } words && words.Any(static word => word.Speaker is not null)) ||
         (Utterances is { Count: > 0 } utterances && utterances.Any(static utterance => utterance.Speaker is not null)));
}

public sealed partial class SmallestAITtsLiveRealtimeClient
{
    /// <summary>
    /// Synthesizes a piece of text with the given voice.
    /// </summary>
    /// <param name="voiceId">The voice to synthesize with.</param>
    /// <param name="text">The text to synthesize.</param>
    /// <param name="model">Optional Lightning model id, for example <c>lightning_v3.1_pro</c>.</param>
    /// <param name="wordTimestamps">Whether to interleave <c>word_timestamp</c> frames. English and Hindi voices only.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    public global::System.Threading.Tasks.Task SendTtsSynthesizeAsync(
        string voiceId,
        string text,
        string? model = null,
        bool? wordTimestamps = null,
        CancellationToken cancellationToken = default) =>
        SendTtsSynthesizeAsync(
            new TtsSynthesizeRequest
            {
                VoiceId = voiceId,
                Text = text,
                Model = model,
                WordTimestamps = wordTimestamps,
            },
            cancellationToken);
}

public sealed partial class TtsLiveEvent
{
    /// <summary>
    /// Decodes the base64 audio payload of a <c>chunk</c> frame.
    /// </summary>
    /// <returns>
    /// The decoded PCM bytes, or <see langword="null"/> when this frame is not
    /// a <c>chunk</c> frame or carries no audio.
    /// </returns>
    public byte[]? GetAudioBytes() =>
        Data?.Audio is { Length: > 0 } audio
            ? Convert.FromBase64String(audio)
            : null;
}
