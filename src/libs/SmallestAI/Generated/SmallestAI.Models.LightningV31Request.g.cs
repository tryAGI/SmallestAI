
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LightningV31Request
    {
        /// <summary>
        /// The text to convert to speech.<br/>
        /// Default Value: Hey i am your a text to speech model
        /// </summary>
        /// <default>"Hey i am your a text to speech model"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; } = "Hey i am your a text to speech model";

        /// <summary>
        /// The voice identifier to use for speech generation.<br/>
        /// Default Value: daniel
        /// </summary>
        /// <default>"daniel"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; } = "daniel";

        /// <summary>
        /// The sample rate for the generated audio.<br/>
        /// Default Value: 44100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.LightningV31RequestSampleRateJsonConverter))]
        public global::SmallestAI.LightningV31RequestSampleRate? SampleRate { get; set; }

        /// <summary>
        /// The speed of the generated speech.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Language code for synthesis. Influences pronunciation, number/date<br/>
        /// normalization, and phoneme selection.<br/>
        /// - **Indian:** `en`, `hi`, `mr` (Marathi), `kn` (Kannada), `ta` (Tamil),<br/>
        ///   `bn` (Bengali), `gu` (Gujarati), `te` (Telugu), `ml` (Malayalam),<br/>
        ///   `pa` (Punjabi), `or` (Odia)<br/>
        /// - **European:** `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `sv` (Swedish),<br/>
        ///   `pt` (Portuguese)<br/>
        /// - **MENA:** `ar` (Arabic), `he` (Hebrew)<br/>
        /// - `auto` — auto-detect from input text (recommended for code-switching)<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.LightningV31RequestLanguageJsonConverter))]
        public global::SmallestAI.LightningV31RequestLanguage? Language { get; set; }

        /// <summary>
        /// Format of the returned audio. `pcm` is the lowest-latency option<br/>
        /// but requires a decoder to play; `mp3` and `wav` are directly<br/>
        /// playable in browsers and most media players. The server default<br/>
        /// is `pcm` when the field is omitted — the API playground uses<br/>
        /// `mp3` so the generated audio is directly playable.<br/>
        /// Default Value: pcm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.LightningV31RequestOutputFormatJsonConverter))]
        public global::SmallestAI.LightningV31RequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// The IDs of the pronunciation dictionaries to use for speech generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dicts")]
        public global::System.Collections.Generic.IList<string>? PronunciationDicts { get; set; }

        /// <summary>
        /// Optional client-provided session identifier for correlation. Only alphanumeric characters, hyphens, underscores, and dots are allowed. Max 128 characters. Echoed back in response headers as `X-External-Session-Id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Optional client-provided request identifier for correlation. Only alphanumeric characters, hyphens, underscores, and dots are allowed. Max 128 characters. Echoed back in response headers as `X-External-Request-Id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LightningV31Request" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to convert to speech.<br/>
        /// Default Value: Hey i am your a text to speech model
        /// </param>
        /// <param name="voiceId">
        /// The voice identifier to use for speech generation.<br/>
        /// Default Value: daniel
        /// </param>
        /// <param name="sampleRate">
        /// The sample rate for the generated audio.<br/>
        /// Default Value: 44100
        /// </param>
        /// <param name="speed">
        /// The speed of the generated speech.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="language">
        /// Language code for synthesis. Influences pronunciation, number/date<br/>
        /// normalization, and phoneme selection.<br/>
        /// - **Indian:** `en`, `hi`, `mr` (Marathi), `kn` (Kannada), `ta` (Tamil),<br/>
        ///   `bn` (Bengali), `gu` (Gujarati), `te` (Telugu), `ml` (Malayalam),<br/>
        ///   `pa` (Punjabi), `or` (Odia)<br/>
        /// - **European:** `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `sv` (Swedish),<br/>
        ///   `pt` (Portuguese)<br/>
        /// - **MENA:** `ar` (Arabic), `he` (Hebrew)<br/>
        /// - `auto` — auto-detect from input text (recommended for code-switching)<br/>
        /// Default Value: en
        /// </param>
        /// <param name="outputFormat">
        /// Format of the returned audio. `pcm` is the lowest-latency option<br/>
        /// but requires a decoder to play; `mp3` and `wav` are directly<br/>
        /// playable in browsers and most media players. The server default<br/>
        /// is `pcm` when the field is omitted — the API playground uses<br/>
        /// `mp3` so the generated audio is directly playable.<br/>
        /// Default Value: pcm
        /// </param>
        /// <param name="pronunciationDicts">
        /// The IDs of the pronunciation dictionaries to use for speech generation.
        /// </param>
        /// <param name="sessionId">
        /// Optional client-provided session identifier for correlation. Only alphanumeric characters, hyphens, underscores, and dots are allowed. Max 128 characters. Echoed back in response headers as `X-External-Session-Id`.
        /// </param>
        /// <param name="requestId">
        /// Optional client-provided request identifier for correlation. Only alphanumeric characters, hyphens, underscores, and dots are allowed. Max 128 characters. Echoed back in response headers as `X-External-Request-Id`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LightningV31Request(
            string text,
            string voiceId,
            global::SmallestAI.LightningV31RequestSampleRate? sampleRate,
            double? speed,
            global::SmallestAI.LightningV31RequestLanguage? language,
            global::SmallestAI.LightningV31RequestOutputFormat? outputFormat,
            global::System.Collections.Generic.IList<string>? pronunciationDicts,
            string? sessionId,
            string? requestId)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.SampleRate = sampleRate;
            this.Speed = speed;
            this.Language = language;
            this.OutputFormat = outputFormat;
            this.PronunciationDicts = pronunciationDicts;
            this.SessionId = sessionId;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LightningV31Request" /> class.
        /// </summary>
        public LightningV31Request()
        {
        }
    }
}