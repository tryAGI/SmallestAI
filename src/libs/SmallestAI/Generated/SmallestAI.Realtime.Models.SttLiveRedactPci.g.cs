
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Redact payment card information from transcripts.<br/>
    /// Default Value: false
    /// </summary>
    public enum SttLiveRedactPci
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
    public static class SttLiveRedactPciExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveRedactPci value)
        {
            return value switch
            {
                SttLiveRedactPci.False => "false",
                SttLiveRedactPci.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveRedactPci? ToEnum(string value)
        {
            return value switch
            {
                "false" => SttLiveRedactPci.False,
                "true" => SttLiveRedactPci.True,
                _ => null,
            };
        }
    }
}