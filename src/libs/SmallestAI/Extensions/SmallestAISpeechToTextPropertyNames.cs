#nullable enable

namespace SmallestAI;

/// <summary>
/// Additional-property keys used by the SmallestAI Microsoft.Extensions.AI
/// speech-to-text adapter.
/// <para>
/// The MEAI abstractions have no first-class notion of diarization, encoding or
/// redaction, so Pulse-specific knobs are passed through
/// <c>SpeechToTextOptions.AdditionalProperties</c> using these keys, and
/// Pulse-specific results come back through
/// <c>SpeechToTextResponse.AdditionalProperties</c> under the same names.
/// Every key is the literal Pulse wire name.
/// </para>
/// </summary>
public static class SmallestAISpeechToTextPropertyNames
{
    /// <summary>
    /// Request key for <c>diarize</c>: emit speaker labels. Pair with
    /// <see cref="WordTimestamps"/> for per-word attribution.
    /// </summary>
    public const string Diarize = "diarize";

    /// <summary>
    /// Request key for <c>word_timestamps</c>: emit per-word timings.
    /// </summary>
    public const string WordTimestamps = "word_timestamps";

    /// <summary>
    /// Request key for <c>sentence_timestamps</c>: emit sentence-level
    /// utterances. Realtime only.
    /// </summary>
    public const string SentenceTimestamps = "sentence_timestamps";

    /// <summary>
    /// Request key for <c>full_transcript</c>: include the cumulative session
    /// transcript on final frames. Realtime only.
    /// </summary>
    public const string FullTranscript = "full_transcript";

    /// <summary>
    /// Request key for <c>encoding</c> of the streamed audio, for example
    /// <c>linear16</c>. Realtime only.
    /// </summary>
    public const string Encoding = "encoding";

    /// <summary>
    /// Request key for <c>sample_rate</c> of the streamed audio, in Hz.
    /// Realtime only.
    /// </summary>
    public const string SampleRate = "sample_rate";

    /// <summary>
    /// Request key for <c>redact_pii</c>: redact personally identifiable
    /// information from transcripts.
    /// </summary>
    public const string RedactPii = "redact_pii";

    /// <summary>
    /// Request key for <c>redact_pci</c>: redact payment card information from
    /// transcripts.
    /// </summary>
    public const string RedactPci = "redact_pci";

    /// <summary>
    /// Request key for <c>emotion_detection</c>.
    /// </summary>
    public const string EmotionDetection = "emotion_detection";

    /// <summary>
    /// Request key for <c>gender_detection</c>.
    /// </summary>
    public const string GenderDetection = "gender_detection";

    /// <summary>
    /// Request key for <c>numerals</c>: <c>true</c>, <c>false</c> or
    /// <c>auto</c>. Realtime only.
    /// </summary>
    public const string Numerals = "numerals";

    /// <summary>
    /// Request key for <c>keywords</c>: comma-separated
    /// <c>KEYWORD:INTENSIFIER</c> pairs. Realtime only.
    /// </summary>
    public const string Keywords = "keywords";

    /// <summary>
    /// Request key for <c>punctuate</c>. Realtime only.
    /// </summary>
    public const string Punctuate = "punctuate";

    /// <summary>
    /// Request key for <c>capitalize</c>. Realtime only.
    /// </summary>
    public const string Capitalize = "capitalize";

    /// <summary>
    /// Request key for <c>format</c>: apply punctuation and capitalization.
    /// Realtime only.
    /// </summary>
    public const string Format = "format";

    /// <summary>
    /// Request key for <c>itn_normalize</c>: inverse text normalization.
    /// Realtime only.
    /// </summary>
    public const string ItnNormalize = "itn_normalize";

    /// <summary>
    /// Request key for <c>endpointing</c>: finalize promptly on trailing
    /// silence. Realtime only.
    /// </summary>
    public const string Endpointing = "endpointing";

    /// <summary>
    /// Request key for <c>eou_timeout_ms</c>: end-of-utterance timeout.
    /// Realtime only.
    /// </summary>
    public const string EouTimeoutMs = "eou_timeout_ms";

    /// <summary>
    /// Request key for <c>max_words</c>: force finalization after this many
    /// words. Realtime only.
    /// </summary>
    public const string MaxWords = "max_words";

    /// <summary>
    /// Request key for <c>finalize_on_words</c>. Realtime only.
    /// </summary>
    public const string FinalizeOnWords = "finalize_on_words";

    /// <summary>
    /// Request key for <c>webhook_url</c>: deliver the transcription
    /// asynchronously. Pre-recorded only.
    /// </summary>
    public const string WebhookUrl = "webhook_url";

    /// <summary>
    /// Response key carrying per-word timings and speaker labels — a
    /// <c>IList&lt;Word&gt;</c> on pre-recorded responses and a
    /// <c>IList&lt;SmallestAI.Realtime.SttWord&gt;</c> on streaming updates.
    /// </summary>
    public const string Words = "words";

    /// <summary>
    /// Response key carrying sentence-level segments and their speaker labels —
    /// a <c>IList&lt;Utterance&gt;</c> on pre-recorded responses and a
    /// <c>IList&lt;SmallestAI.Realtime.SttUtterance&gt;</c> on streaming updates.
    /// </summary>
    public const string Utterances = "utterances";

    /// <summary>
    /// Response key carrying the detected or configured language code.
    /// </summary>
    public const string Language = "language";

    /// <summary>
    /// Response key carrying emotion scores, when
    /// <see cref="EmotionDetection"/> was requested.
    /// </summary>
    public const string Emotions = "emotions";

    /// <summary>
    /// Response key carrying the detected speaker gender, when
    /// <see cref="GenderDetection"/> was requested.
    /// </summary>
    public const string Gender = "gender";

    /// <summary>
    /// Response key carrying the realtime session identifier.
    /// </summary>
    public const string SessionId = "session_id";

    /// <summary>
    /// Response key carrying the realtime <c>is_final</c> flag.
    /// </summary>
    public const string IsFinal = "is_final";

    /// <summary>
    /// Response key carrying the realtime <c>is_last</c> flag.
    /// </summary>
    public const string IsLast = "is_last";
}
