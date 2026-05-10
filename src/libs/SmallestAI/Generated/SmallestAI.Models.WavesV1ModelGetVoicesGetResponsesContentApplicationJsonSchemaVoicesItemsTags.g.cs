
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// List of tags associated with the voice.
    /// </summary>
    public sealed partial class WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItemsTags
    {
        /// <summary>
        /// Language of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public global::System.Collections.Generic.IList<string>? Language { get; set; }

        /// <summary>
        /// Accent of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// Gender of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItemsTags" /> class.
        /// </summary>
        /// <param name="language">
        /// Language of the voice.
        /// </param>
        /// <param name="accent">
        /// Accent of the voice.
        /// </param>
        /// <param name="gender">
        /// Gender of the voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItemsTags(
            global::System.Collections.Generic.IList<string>? language,
            string? accent,
            string? gender)
        {
            this.Language = language;
            this.Accent = accent;
            this.Gender = gender;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItemsTags" /> class.
        /// </summary>
        public WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItemsTags()
        {
        }

    }
}