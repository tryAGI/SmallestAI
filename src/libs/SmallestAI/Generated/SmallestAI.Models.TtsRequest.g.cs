
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsRequest
    {
        /// <summary>
        /// The text to convert to speech.<br/>
        /// Default Value: Hello from Waves TTS.
        /// </summary>
        /// <default>"Hello from Waves TTS."</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; } = "Hello from Waves TTS.";

        /// <summary>
        /// The voice identifier to use for speech generation. See the model card for available voices per model.<br/>
        /// Default Value: magnus
        /// </summary>
        /// <default>"magnus"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; } = "magnus";

        /// <summary>
        /// TTS model to route the request to. Controls which model pool serves<br/>
        /// this synthesis.<br/>
        /// - `lightning_v3.1` (default) — standard Lightning v3.1.<br/>
        /// - `lightning_v3.1_pro` — Lightning v3.1 Pro pool. Improved audio<br/>
        ///   quality and naturalness, with a curated voice catalog. See the<br/>
        ///   [Lightning v3.1 Pro model card](/waves/model-cards/text-to-speech/lightning-v-3-1-pro)<br/>
        ///   for supported voice IDs.<br/>
        /// Same concurrency and latency profile across both. Other request<br/>
        /// parameters behave identically.<br/>
        /// Default Value: lightning_v3.1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.TtsRequestModelJsonConverter))]
        public global::SmallestAI.TtsRequestModel? Model { get; set; }

        /// <summary>
        /// The sample rate for the generated audio.<br/>
        /// Default Value: 44100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.TtsRequestSampleRateJsonConverter))]
        public global::SmallestAI.TtsRequestSampleRate? SampleRate { get; set; }

        /// <summary>
        /// The speed of the generated speech.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Language code for synthesis. Influences pronunciation, number/date<br/>
        /// normalization, and phoneme selection.<br/>
        /// Each voice has its own `tags.language` set in the voice catalog —<br/>
        /// query `GET /waves/v1/lightning-v3.1/get_voices`. Pass a language<br/>
        /// the voice was trained on; passing other codes is accepted by the<br/>
        /// API but produces English-pronounced output.<br/>
        /// **On `lightning_v3.1`**, the full 12-language catalog applies.<br/>
        /// **On `lightning_v3.1_pro`**:<br/>
        /// - Pass `en` → UK + American accented English.<br/>
        /// - Pass `hi` → Indian accented English + Hindi (code-switching).<br/>
        /// - Pass the ISO 639-1 code of any other Pro language (e.g. `ta`, `de`, `ja`) with a matching Pro voice — 27 additional languages (9 Indian, 8 Asian &amp; Middle Eastern, 10 European) have dedicated Pro voices.<br/>
        /// - Omit `language` → defaults to `en + hi` (mixed Indian + Western English coverage).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.TtsRequestLanguageJsonConverter))]
        public global::SmallestAI.TtsRequestLanguage? Language { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.TtsRequestNumberPronunciationLanguageJsonConverter))]
        public global::SmallestAI.TtsRequestNumberPronunciationLanguage? NumberPronunciationLanguage { get; set; }

        /// <summary>
        /// Format of the returned audio. `pcm` is the lowest-latency option<br/>
        /// but requires a decoder to play; `mp3` and `wav` are directly<br/>
        /// playable in browsers and most media players. The server default<br/>
        /// is `pcm` when the field is omitted — the API playground uses<br/>
        /// `mp3` so the generated audio is directly playable.<br/>
        /// Default Value: pcm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.TtsRequestOutputFormatJsonConverter))]
        public global::SmallestAI.TtsRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// The IDs of the pronunciation dictionaries to use for speech generation. Available on both `lightning_v3.1` and `lightning_v3.1_pro`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dicts")]
        public global::System.Collections.Generic.IList<string>? PronunciationDicts { get; set; }

        /// <summary>
        /// **WebSocket-only feature.** Accepted on this endpoint but ignored — no per-word timing information is returned in the sync HTTP or SSE response shape. To receive `status: "word_timestamp"` frames with per-word `{ id, word, start, end }` data, use the WebSocket endpoint `wss://api.smallest.ai/waves/v1/tts/live`. See [Word-level timestamps](/waves/documentation/text-to-speech-lightning/word-timestamps).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_timestamps")]
        public bool? WordTimestamps { get; set; }

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
        /// Initializes a new instance of the <see cref="TtsRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to convert to speech.<br/>
        /// Default Value: Hello from Waves TTS.
        /// </param>
        /// <param name="voiceId">
        /// The voice identifier to use for speech generation. See the model card for available voices per model.<br/>
        /// Default Value: magnus
        /// </param>
        /// <param name="model">
        /// TTS model to route the request to. Controls which model pool serves<br/>
        /// this synthesis.<br/>
        /// - `lightning_v3.1` (default) — standard Lightning v3.1.<br/>
        /// - `lightning_v3.1_pro` — Lightning v3.1 Pro pool. Improved audio<br/>
        ///   quality and naturalness, with a curated voice catalog. See the<br/>
        ///   [Lightning v3.1 Pro model card](/waves/model-cards/text-to-speech/lightning-v-3-1-pro)<br/>
        ///   for supported voice IDs.<br/>
        /// Same concurrency and latency profile across both. Other request<br/>
        /// parameters behave identically.<br/>
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
        /// Each voice has its own `tags.language` set in the voice catalog —<br/>
        /// query `GET /waves/v1/lightning-v3.1/get_voices`. Pass a language<br/>
        /// the voice was trained on; passing other codes is accepted by the<br/>
        /// API but produces English-pronounced output.<br/>
        /// **On `lightning_v3.1`**, the full 12-language catalog applies.<br/>
        /// **On `lightning_v3.1_pro`**:<br/>
        /// - Pass `en` → UK + American accented English.<br/>
        /// - Pass `hi` → Indian accented English + Hindi (code-switching).<br/>
        /// - Pass the ISO 639-1 code of any other Pro language (e.g. `ta`, `de`, `ja`) with a matching Pro voice — 27 additional languages (9 Indian, 8 Asian &amp; Middle Eastern, 10 European) have dedicated Pro voices.<br/>
        /// - Omit `language` → defaults to `en + hi` (mixed Indian + Western English coverage).
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
        /// The IDs of the pronunciation dictionaries to use for speech generation. Available on both `lightning_v3.1` and `lightning_v3.1_pro`.
        /// </param>
        /// <param name="wordTimestamps">
        /// **WebSocket-only feature.** Accepted on this endpoint but ignored — no per-word timing information is returned in the sync HTTP or SSE response shape. To receive `status: "word_timestamp"` frames with per-word `{ id, word, start, end }` data, use the WebSocket endpoint `wss://api.smallest.ai/waves/v1/tts/live`. See [Word-level timestamps](/waves/documentation/text-to-speech-lightning/word-timestamps).<br/>
        /// Default Value: false
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
        public TtsRequest(
            string text,
            string voiceId,
            global::SmallestAI.TtsRequestModel? model,
            global::SmallestAI.TtsRequestSampleRate? sampleRate,
            double? speed,
            global::SmallestAI.TtsRequestLanguage? language,
            global::SmallestAI.TtsRequestNumberPronunciationLanguage? numberPronunciationLanguage,
            global::SmallestAI.TtsRequestOutputFormat? outputFormat,
            global::System.Collections.Generic.IList<string>? pronunciationDicts,
            bool? wordTimestamps,
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
            this.WordTimestamps = wordTimestamps;
            this.SessionId = sessionId;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRequest" /> class.
        /// </summary>
        public TtsRequest()
        {
        }

    }
}