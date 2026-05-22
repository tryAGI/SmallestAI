
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestToolChoiceOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestToolChoiceOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestToolChoiceOneOf1Type value)
        {
            return value switch
            {
                ChatCompletionRequestToolChoiceOneOf1Type.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestToolChoiceOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatCompletionRequestToolChoiceOneOf1Type.Function,
                _ => null,
            };
        }
    }
}