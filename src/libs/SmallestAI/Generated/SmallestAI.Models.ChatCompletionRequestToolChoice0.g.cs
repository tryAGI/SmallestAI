
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestToolChoice0
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestToolChoice0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestToolChoice0 value)
        {
            return value switch
            {
                ChatCompletionRequestToolChoice0.Auto => "auto",
                ChatCompletionRequestToolChoice0.None => "none",
                ChatCompletionRequestToolChoice0.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestToolChoice0? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatCompletionRequestToolChoice0.Auto,
                "none" => ChatCompletionRequestToolChoice0.None,
                "required" => ChatCompletionRequestToolChoice0.Required,
                _ => null,
            };
        }
    }
}