
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems
    {
        /// <summary>
        /// Text that was synthesized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Signed URL to the generated sample audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioUrl")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems" /> class.
        /// </summary>
        /// <param name="text">
        /// Text that was synthesized.
        /// </param>
        /// <param name="audioUrl">
        /// Signed URL to the generated sample audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems(
            string? text,
            string? audioUrl)
        {
            this.Text = text;
            this.AudioUrl = audioUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems" /> class.
        /// </summary>
        public WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems()
        {
        }

    }
}