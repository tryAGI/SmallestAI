
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Always `Bearer`.
    /// </summary>
    public enum AccessTokenResponseTokenType
    {
        /// <summary>
        ///
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessTokenResponseTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessTokenResponseTokenType value)
        {
            return value switch
            {
                AccessTokenResponseTokenType.Bearer => "Bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessTokenResponseTokenType? ToEnum(string value)
        {
            return value switch
            {
                "Bearer" => AccessTokenResponseTokenType.Bearer,
                _ => null,
            };
        }
    }
}