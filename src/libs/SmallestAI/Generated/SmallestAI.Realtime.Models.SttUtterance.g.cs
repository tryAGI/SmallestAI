
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// One sentence-level segment with its speaker attribution.
    /// </summary>
    public sealed partial class SttUtterance
    {
        /// <summary>
        /// Text of the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

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
        /// Zero-indexed speaker id, stable within this session only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public int? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttUtterance" /> class.
        /// </summary>
        /// <param name="text">
        /// Text of the segment.
        /// </param>
        /// <param name="start">
        /// Start offset in seconds from the beginning of the stream.
        /// </param>
        /// <param name="end">
        /// End offset in seconds from the beginning of the stream.
        /// </param>
        /// <param name="speaker">
        /// Zero-indexed speaker id, stable within this session only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttUtterance(
            string? text,
            double? start,
            double? end,
            int? speaker)
        {
            this.Text = text;
            this.Start = start;
            this.End = end;
            this.Speaker = speaker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttUtterance" /> class.
        /// </summary>
        public SttUtterance()
        {
        }

    }
}