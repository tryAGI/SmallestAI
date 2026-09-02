
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Redact personally identifiable information from transcripts.<br/>
    /// Default Value: false
    /// </summary>
    public enum SttLiveRedactPii
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
    public static class SttLiveRedactPiiExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveRedactPii value)
        {
            return value switch
            {
                SttLiveRedactPii.False => "false",
                SttLiveRedactPii.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveRedactPii? ToEnum(string value)
        {
            return value switch
            {
                "false" => SttLiveRedactPii.False,
                "true" => SttLiveRedactPii.True,
                _ => null,
            };
        }
    }
}