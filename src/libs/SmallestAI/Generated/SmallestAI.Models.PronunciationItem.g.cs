
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PronunciationItem
    {
        /// <summary>
        /// The word to be pronounced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word { get; set; }

        /// <summary>
        /// The phonetic pronunciation of the word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pronunciation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationItem" /> class.
        /// </summary>
        /// <param name="word">
        /// The word to be pronounced
        /// </param>
        /// <param name="pronunciation">
        /// The phonetic pronunciation of the word
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationItem(
            string word,
            string pronunciation)
        {
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
            this.Pronunciation = pronunciation ?? throw new global::System.ArgumentNullException(nameof(pronunciation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationItem" /> class.
        /// </summary>
        public PronunciationItem()
        {
        }

    }
}