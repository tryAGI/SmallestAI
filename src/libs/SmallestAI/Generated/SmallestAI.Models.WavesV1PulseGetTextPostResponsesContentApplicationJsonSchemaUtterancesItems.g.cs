
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaUtterancesItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

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
        /// Speaker if diarization is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaUtterancesItems" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="speaker">
        /// Speaker if diarization is enabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaUtterancesItems(
            string? text,
            double? start,
            double? end,
            string? speaker)
        {
            this.Text = text;
            this.Start = start;
            this.End = end;
            this.Speaker = speaker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaUtterancesItems" /> class.
        /// </summary>
        public WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaUtterancesItems()
        {
        }
    }
}