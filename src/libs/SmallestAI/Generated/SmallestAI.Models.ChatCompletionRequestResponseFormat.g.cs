
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Output shape. `{type: "text"}` (default) or `{type: "json_object"}`.
    /// </summary>
    public sealed partial class ChatCompletionRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.ChatCompletionRequestResponseFormatTypeJsonConverter))]
        public global::SmallestAI.ChatCompletionRequestResponseFormatType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestResponseFormat" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestResponseFormat(
            global::SmallestAI.ChatCompletionRequestResponseFormatType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestResponseFormat" /> class.
        /// </summary>
        public ChatCompletionRequestResponseFormat()
        {
        }

    }
}