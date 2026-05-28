
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionChoicesItemsFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionChoicesItemsFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionChoicesItemsFinishReason value)
        {
            return value switch
            {
                ChatCompletionChoicesItemsFinishReason.ContentFilter => "content_filter",
                ChatCompletionChoicesItemsFinishReason.Length => "length",
                ChatCompletionChoicesItemsFinishReason.Stop => "stop",
                ChatCompletionChoicesItemsFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionChoicesItemsFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => ChatCompletionChoicesItemsFinishReason.ContentFilter,
                "length" => ChatCompletionChoicesItemsFinishReason.Length,
                "stop" => ChatCompletionChoicesItemsFinishReason.Stop,
                "tool_calls" => ChatCompletionChoicesItemsFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}