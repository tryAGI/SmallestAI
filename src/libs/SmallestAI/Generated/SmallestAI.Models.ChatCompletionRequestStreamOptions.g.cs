
#nullable enable

namespace SmallestAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionRequestStreamOptions
    {
        /// <summary>
        /// Append a final SSE chunk with the `usage` block. Strongly<br/>
        /// recommended for any caller that tracks token consumption.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_usage")]
        public bool? IncludeUsage { get; set; }

        /// <summary>
        /// With `include_usage: true`, adds a `usage` block with the token<br/>
        /// counts so far to every chunk, not just the last one. No effect<br/>
        /// without `include_usage`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continuous_usage_stats")]
        public bool? ContinuousUsageStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestStreamOptions" /> class.
        /// </summary>
        /// <param name="includeUsage">
        /// Append a final SSE chunk with the `usage` block. Strongly<br/>
        /// recommended for any caller that tracks token consumption.
        /// </param>
        /// <param name="continuousUsageStats">
        /// With `include_usage: true`, adds a `usage` block with the token<br/>
        /// counts so far to every chunk, not just the last one. No effect<br/>
        /// without `include_usage`.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestStreamOptions(
            bool? includeUsage,
            bool? continuousUsageStats)
        {
            this.IncludeUsage = includeUsage;
            this.ContinuousUsageStats = continuousUsageStats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestStreamOptions" /> class.
        /// </summary>
        public ChatCompletionRequestStreamOptions()
        {
        }

    }
}