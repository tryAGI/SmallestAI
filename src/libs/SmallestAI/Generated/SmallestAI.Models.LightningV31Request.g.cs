
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
        /// TTS model to route the request to.<br/>
        /// - `lightning_v3.1` (default) — standard Lightning v3.1 pool.<br/>
        /// - `lightning_v3.1_pro` — Lightning v3.1 Pro pool with a curated<br/>
        ///   voice catalog. See the<br/>
        ///   [Pro model card](/waves/model-cards/text-to-speech/lightning-v-3-1-pro).<br/>
        /// New integrations should use the unified<br/>
        /// `/waves/v1/tts` route instead of this endpoint, but the `model`<br/>
        /// field is supported here for backwards-compatible Pro opt-in.<br/>
        /// Default Value: lightning_v3.1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.LightningV31RequestModelJsonConverter))]
        public global::SmallestAI.LightningV31RequestModel? Model { get; set; }

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
        /// - **European:** `es` (Spanish)<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.LightningV31RequestLanguageJsonConverter))]
        public global::SmallestAI.LightningV31RequestLanguage? Language { get; set; }

        /// <summary>
        /// Optional. Sets the language used to read out numeric content —<br/>
        /// numbers, currency amounts, times, and the numeric parts of dates<br/>
        /// and years — independently of the synthesis voice. Ordinary words<br/>
        /// are not translated.<br/>
        /// - If you **omit `language`**, this value also becomes the<br/>
        ///   synthesis language: model selection and voice routing follow it.<br/>
        /// - If you **set `language` explicitly**, `language` always wins for<br/>
        ///   synthesis and `number_pronunciation_language` only changes how<br/>
        ///   numeric content is normalized. It works both ways — read numbers<br/>
        ///   in Hindi under an English voice, or in English under a Hindi<br/>
        ///   voice (tuned for Indian, often mixed-script, use cases).<br/>
        /// - Omit this field to keep the existing behaviour — normalization<br/>
        ///   follows `language`.<br/>
        /// Note: only numeric tokens are re-spoken; the words around them<br/>
        /// stay in the text language. On a cross-language request names may<br/>
        /// also render in the target script (e.g. "Smith" → "स्मिथ"), which<br/>
        /// is generally the desired reading for native-language voices.<br/>
        /// Accepts the same language codes as `language`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_pronunciation_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.LightningV31RequestNumberPronunciationLanguageJsonConverter))]
        public global::SmallestAI.LightningV31RequestNumberPronunciationLanguage? NumberPronunciationLanguage { get; set; }

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
        /// <param name="model">
        /// TTS model to route the request to.<br/>
        /// - `lightning_v3.1` (default) — standard Lightning v3.1 pool.<br/>
        /// - `lightning_v3.1_pro` — Lightning v3.1 Pro pool with a curated<br/>
        ///   voice catalog. See the<br/>
        ///   [Pro model card](/waves/model-cards/text-to-speech/lightning-v-3-1-pro).<br/>
        /// New integrations should use the unified<br/>
        /// `/waves/v1/tts` route instead of this endpoint, but the `model`<br/>
        /// field is supported here for backwards-compatible Pro opt-in.<br/>
        /// Default Value: lightning_v3.1
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
        /// - **European:** `es` (Spanish)<br/>
        /// Default Value: en
        /// </param>
        /// <param name="numberPronunciationLanguage">
        /// Optional. Sets the language used to read out numeric content —<br/>
        /// numbers, currency amounts, times, and the numeric parts of dates<br/>
        /// and years — independently of the synthesis voice. Ordinary words<br/>
        /// are not translated.<br/>
        /// - If you **omit `language`**, this value also becomes the<br/>
        ///   synthesis language: model selection and voice routing follow it.<br/>
        /// - If you **set `language` explicitly**, `language` always wins for<br/>
        ///   synthesis and `number_pronunciation_language` only changes how<br/>
        ///   numeric content is normalized. It works both ways — read numbers<br/>
        ///   in Hindi under an English voice, or in English under a Hindi<br/>
        ///   voice (tuned for Indian, often mixed-script, use cases).<br/>
        /// - Omit this field to keep the existing behaviour — normalization<br/>
        ///   follows `language`.<br/>
        /// Note: only numeric tokens are re-spoken; the words around them<br/>
        /// stay in the text language. On a cross-language request names may<br/>
        /// also render in the target script (e.g. "Smith" → "स्मिथ"), which<br/>
        /// is generally the desired reading for native-language voices.<br/>
        /// Accepts the same language codes as `language`.
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
            global::SmallestAI.LightningV31RequestModel? model,
            global::SmallestAI.LightningV31RequestSampleRate? sampleRate,
            double? speed,
            global::SmallestAI.LightningV31RequestLanguage? language,
            global::SmallestAI.LightningV31RequestNumberPronunciationLanguage? numberPronunciationLanguage,
            global::SmallestAI.LightningV31RequestOutputFormat? outputFormat,
            global::System.Collections.Generic.IList<string>? pronunciationDicts,
            string? sessionId,
            string? requestId)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Model = model;
            this.SampleRate = sampleRate;
            this.Speed = speed;
            this.Language = language;
            this.NumberPronunciationLanguage = numberPronunciationLanguage;
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