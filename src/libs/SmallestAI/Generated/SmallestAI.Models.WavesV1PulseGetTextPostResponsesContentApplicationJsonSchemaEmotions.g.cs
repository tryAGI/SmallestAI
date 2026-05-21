
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Predicted emotions of the speaker if requested
    /// </summary>
    public sealed partial class WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaEmotions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("happiness")]
        public double? Happiness { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sadness")]
        public double? Sadness { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disgust")]
        public double? Disgust { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fear")]
        public double? Fear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anger")]
        public double? Anger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaEmotions" /> class.
        /// </summary>
        /// <param name="happiness"></param>
        /// <param name="sadness"></param>
        /// <param name="disgust"></param>
        /// <param name="fear"></param>
        /// <param name="anger"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaEmotions(
            double? happiness,
            double? sadness,
            double? disgust,
            double? fear,
            double? anger)
        {
            this.Happiness = happiness;
            this.Sadness = sadness;
            this.Disgust = disgust;
            this.Fear = fear;
            this.Anger = anger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaEmotions" /> class.
        /// </summary>
        public WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaEmotions()
        {
        }

    }
}