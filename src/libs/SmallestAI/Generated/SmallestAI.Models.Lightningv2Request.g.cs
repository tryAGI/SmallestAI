
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Lightningv2Request
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
        /// Default Value: malcom
        /// </summary>
        /// <default>"malcom"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; } = "malcom";

        /// <summary>
        /// The sample rate for the generated audio.<br/>
        /// Default Value: 24000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// The speed of the generated speech.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// This parameter controls word repetition and skipping. Decrease it to prevent skipped words, and increase it to prevent repetition.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consistency")]
        public double? Consistency { get; set; }

        /// <summary>
        /// This parameter controls the similarity between the generated speech and the reference audio. Increase it to make the speech more similar to the reference audio.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity")]
        public double? Similarity { get; set; }

        /// <summary>
        /// Enhances speech quality at the cost of increased latency.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhancement")]
        public double? Enhancement { get; set; }

        /// <summary>
        /// Determines how numbers are spelled out. If set to 'en', numbers will be read as individual digits in English. If set to 'hi', numbers will be read as individual digits in Hindi.<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.Lightningv2RequestLanguageJsonConverter))]
        public global::SmallestAI.Lightningv2RequestLanguage? Language { get; set; }

        /// <summary>
        /// The format of the output audio.<br/>
        /// Default Value: pcm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.Lightningv2RequestOutputFormatJsonConverter))]
        public global::SmallestAI.Lightningv2RequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// The IDs of the pronunciation dictionaries to use for speech generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dicts")]
        public global::System.Collections.Generic.IList<string>? PronunciationDicts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Lightningv2Request" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to convert to speech.<br/>
        /// Default Value: Hey i am your a text to speech model
        /// </param>
        /// <param name="voiceId">
        /// The voice identifier to use for speech generation.<br/>
        /// Default Value: malcom
        /// </param>
        /// <param name="sampleRate">
        /// The sample rate for the generated audio.<br/>
        /// Default Value: 24000
        /// </param>
        /// <param name="speed">
        /// The speed of the generated speech.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="consistency">
        /// This parameter controls word repetition and skipping. Decrease it to prevent skipped words, and increase it to prevent repetition.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="similarity">
        /// This parameter controls the similarity between the generated speech and the reference audio. Increase it to make the speech more similar to the reference audio.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="enhancement">
        /// Enhances speech quality at the cost of increased latency.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="language">
        /// Determines how numbers are spelled out. If set to 'en', numbers will be read as individual digits in English. If set to 'hi', numbers will be read as individual digits in Hindi.<br/>
        /// Default Value: en
        /// </param>
        /// <param name="outputFormat">
        /// The format of the output audio.<br/>
        /// Default Value: pcm
        /// </param>
        /// <param name="pronunciationDicts">
        /// The IDs of the pronunciation dictionaries to use for speech generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Lightningv2Request(
            string text,
            string voiceId,
            int? sampleRate,
            double? speed,
            double? consistency,
            double? similarity,
            double? enhancement,
            global::SmallestAI.Lightningv2RequestLanguage? language,
            global::SmallestAI.Lightningv2RequestOutputFormat? outputFormat,
            global::System.Collections.Generic.IList<string>? pronunciationDicts)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.SampleRate = sampleRate;
            this.Speed = speed;
            this.Consistency = consistency;
            this.Similarity = similarity;
            this.Enhancement = enhancement;
            this.Language = language;
            this.OutputFormat = outputFormat;
            this.PronunciationDicts = pronunciationDicts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Lightningv2Request" /> class.
        /// </summary>
        public Lightningv2Request()
        {
        }

    }
}