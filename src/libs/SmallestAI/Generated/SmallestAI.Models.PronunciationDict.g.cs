
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PronunciationDict
    {
        /// <summary>
        /// Unique identifier for the pronunciation dictionary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// List of word-pronunciation pairs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::SmallestAI.PronunciationItem> Items { get; set; }

        /// <summary>
        /// Timestamp when the dictionary was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDict" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the pronunciation dictionary
        /// </param>
        /// <param name="items">
        /// List of word-pronunciation pairs
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the dictionary was created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDict(
            string id,
            global::System.Collections.Generic.IList<global::SmallestAI.PronunciationItem> items,
            global::System.DateTime createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDict" /> class.
        /// </summary>
        public PronunciationDict()
        {
        }

    }
}