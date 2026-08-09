
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Word
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        public string? Word1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        /// Per-word confidence score, from 0.0 to 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Zero-indexed speaker label. Present on Pulse when `diarize=true`. Pulse Pro does not diarize, so this field is absent on Pro responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public int? Speaker { get; set; }

        /// <summary>
        /// Speaker-attribution confidence for this word, from 0.0 to 1.0. Present on Pulse alongside `speaker`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_confidence")]
        public double? SpeakerConfidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Word" /> class.
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="confidence">
        /// Per-word confidence score, from 0.0 to 1.0.
        /// </param>
        /// <param name="speaker">
        /// Zero-indexed speaker label. Present on Pulse when `diarize=true`. Pulse Pro does not diarize, so this field is absent on Pro responses.
        /// </param>
        /// <param name="speakerConfidence">
        /// Speaker-attribution confidence for this word, from 0.0 to 1.0. Present on Pulse alongside `speaker`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Word(
            string? word1,
            double? start,
            double? end,
            double? confidence,
            int? speaker,
            double? speakerConfidence)
        {
            this.Word1 = word1;
            this.Start = start;
            this.End = end;
            this.Confidence = confidence;
            this.Speaker = speaker;
            this.SpeakerConfidence = speakerConfidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Word" /> class.
        /// </summary>
        public Word()
        {
        }

    }
}