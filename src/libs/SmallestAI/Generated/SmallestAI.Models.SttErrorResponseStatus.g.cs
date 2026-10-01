
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Set to `error` on validation and transcription errors.
    /// </summary>
    public enum SttErrorResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SttErrorResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttErrorResponseStatus value)
        {
            return value switch
            {
                SttErrorResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttErrorResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => SttErrorResponseStatus.Error,
                _ => null,
            };
        }
    }
}