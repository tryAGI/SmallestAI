
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// One recognized word with its timing and speaker attribution.
    /// </summary>
    public sealed partial class SttWord
    {
        /// <summary>
        /// The recognized word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        public string? Word { get; set; }

        /// <summary>
        /// Start offset in seconds from the beginning of the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// End offset in seconds from the beginning of the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        /// Recognition confidence between 0 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Zero-indexed speaker id, stable within this session only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public int? Speaker { get; set; }

        /// <summary>
        /// Speaker attribution confidence between 0 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_confidence")]
        public double? SpeakerConfidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttWord" /> class.
        /// </summary>
        /// <param name="word">
        /// The recognized word.
        /// </param>
        /// <param name="start">
        /// Start offset in seconds from the beginning of the stream.
        /// </param>
        /// <param name="end">
        /// End offset in seconds from the beginning of the stream.
        /// </param>
        /// <param name="confidence">
        /// Recognition confidence between 0 and 1.
        /// </param>
        /// <param name="speaker">
        /// Zero-indexed speaker id, stable within this session only.
        /// </param>
        /// <param name="speakerConfidence">
        /// Speaker attribution confidence between 0 and 1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttWord(
            string? word,
            double? start,
            double? end,
            double? confidence,
            int? speaker,
            double? speakerConfidence)
        {
            this.Word = word;
            this.Start = start;
            this.End = end;
            this.Confidence = confidence;
            this.Speaker = speaker;
            this.SpeakerConfidence = speakerConfidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttWord" /> class.
        /// </summary>
        public SttWord()
        {
        }

    }
}