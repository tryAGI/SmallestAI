
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Convert spoken numerals to digits.<br/>
    /// Default Value: auto
    /// </summary>
    public enum SttLiveNumerals
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
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
    public static class SttLiveNumeralsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveNumerals value)
        {
            return value switch
            {
                SttLiveNumerals.Auto => "auto",
                SttLiveNumerals.False => "false",
                SttLiveNumerals.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveNumerals? ToEnum(string value)
        {
            return value switch
            {
                "auto" => SttLiveNumerals.Auto,
                "false" => SttLiveNumerals.False,
                "true" => SttLiveNumerals.True,
                _ => null,
            };
        }
    }
}