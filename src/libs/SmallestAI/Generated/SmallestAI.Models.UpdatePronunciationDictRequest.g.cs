
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePronunciationDictRequest
    {
        /// <summary>
        /// ID of the pronunciation dictionary to update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Updated list of word-pronunciation pairs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::SmallestAI.PronunciationItem> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePronunciationDictRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the pronunciation dictionary to update
        /// </param>
        /// <param name="items">
        /// Updated list of word-pronunciation pairs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePronunciationDictRequest(
            string id,
            global::System.Collections.Generic.IList<global::SmallestAI.PronunciationItem> items)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePronunciationDictRequest" /> class.
        /// </summary>
        public UpdatePronunciationDictRequest()
        {
        }

    }
}