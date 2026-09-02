
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Emit speaker labels. Pair with `word_timestamps` for per-word attribution.<br/>
    /// Default Value: false
    /// </summary>
    public enum SttLiveDiarize
    {
        /// <summary>
        ///
        /// </summary>
        False,
        /// <summary>
        ///
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SttLiveDiarizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveDiarize value)
        {
            return value switch
            {
                SttLiveDiarize.False => "false",
                SttLiveDiarize.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveDiarize? ToEnum(string value)
        {
            return value switch
            {
                "false" => SttLiveDiarize.False,
                "true" => SttLiveDiarize.True,
                _ => null,
            };
        }
    }
}