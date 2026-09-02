
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Apply punctuation and capitalization formatting to transcripts.<br/>
    /// Default Value: true
    /// </summary>
    public enum SttLiveFormat
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
    public static class SttLiveFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveFormat value)
        {
            return value switch
            {
                SttLiveFormat.False => "false",
                SttLiveFormat.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveFormat? ToEnum(string value)
        {
            return value switch
            {
                "false" => SttLiveFormat.False,
                "true" => SttLiveFormat.True,
                _ => null,
            };
        }
    }
}