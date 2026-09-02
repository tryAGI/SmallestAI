
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Apply capitalization.<br/>
    /// Default Value: true
    /// </summary>
    public enum SttLiveCapitalize
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
    public static class SttLiveCapitalizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveCapitalize value)
        {
            return value switch
            {
                SttLiveCapitalize.False => "false",
                SttLiveCapitalize.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveCapitalize? ToEnum(string value)
        {
            return value switch
            {
                "false" => SttLiveCapitalize.False,
                "true" => SttLiveCapitalize.True,
                _ => null,
            };
        }
    }
}