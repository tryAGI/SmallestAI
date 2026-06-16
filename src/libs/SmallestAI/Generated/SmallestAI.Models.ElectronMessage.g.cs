
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ElectronMessage
    {
        /// <summary>
        /// Message role — one of `system`, `user`, `assistant`, or `tool`.<br/>
        /// `tool` is used to feed a function-call result back to the model on the next turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// Text content for the message. `null` is permitted on assistant messages that carry only `tool_calls`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::SmallestAI.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Required when `role` is `"tool"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// Message role — one of `system`, `user`, `assistant`, or `tool`.<br/>
        /// `tool` is used to feed a function-call result back to the model on the next turn.
        /// </param>
        /// <param name="content">
        /// Text content for the message. `null` is permitted on assistant messages that carry only `tool_calls`.
        /// </param>
        /// <param name="toolCalls"></param>
        /// <param name="toolCallId">
        /// Required when `role` is `"tool"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElectronMessage(
            string role,
            string? content,
            global::System.Collections.Generic.IList<global::SmallestAI.ToolCall>? toolCalls,
            string? toolCallId)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Content = content;
            this.ToolCalls = toolCalls;
            this.ToolCallId = toolCallId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronMessage" /> class.
        /// </summary>
        public ElectronMessage()
        {
        }

    }
}