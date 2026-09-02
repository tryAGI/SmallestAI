
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Emit a speaker gender label alongside transcripts.<br/>
    /// Default Value: false
    /// </summary>
    public enum SttLiveGenderDetection
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
    public static class SttLiveGenderDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveGenderDetection value)
        {
            return value switch
            {
                SttLiveGenderDetection.False => "false",
                SttLiveGenderDetection.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveGenderDetection? ToEnum(string value)
        {
            return value switch
            {
                "false" => SttLiveGenderDetection.False,
                "true" => SttLiveGenderDetection.True,
                _ => null,
            };
        }
    }
}