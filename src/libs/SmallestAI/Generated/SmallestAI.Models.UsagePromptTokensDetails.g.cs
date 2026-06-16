
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsagePromptTokensDetails
    {
        /// <summary>
        /// Subset of `prompt_tokens` served from prefix cache. Billed at<br/>
        /// the discounted rate ($0.10 / 1M vs $0.40 / 1M for fresh input).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsagePromptTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// Subset of `prompt_tokens` served from prefix cache. Billed at<br/>
        /// the discounted rate ($0.10 / 1M vs $0.40 / 1M for fresh input).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsagePromptTokensDetails(
            int? cachedTokens)
        {
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsagePromptTokensDetails" /> class.
        /// </summary>
        public UsagePromptTokensDetails()
        {
        }

    }
}