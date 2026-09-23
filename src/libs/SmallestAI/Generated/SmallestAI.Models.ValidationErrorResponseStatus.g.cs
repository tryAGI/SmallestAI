
#nullable enable

namespace SmallestAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ValidationErrorResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ValidationErrorResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValidationErrorResponseStatus value)
        {
            return value switch
            {
                ValidationErrorResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValidationErrorResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ValidationErrorResponseStatus.Error,
                _ => null,
            };
        }
    }
}