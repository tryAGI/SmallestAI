
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestResponseFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestResponseFormatType value)
        {
            return value switch
            {
                ChatCompletionRequestResponseFormatType.JsonObject => "json_object",
                ChatCompletionRequestResponseFormatType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ChatCompletionRequestResponseFormatType.JsonObject,
                "text" => ChatCompletionRequestResponseFormatType.Text,
                _ => null,
            };
        }
    }
}