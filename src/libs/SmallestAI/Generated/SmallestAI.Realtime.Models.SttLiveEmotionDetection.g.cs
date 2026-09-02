
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Emit emotion scores alongside transcripts.<br/>
    /// Default Value: false
    /// </summary>
    public enum SttLiveEmotionDetection
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
    public static class SttLiveEmotionDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveEmotionDetection value)
        {
            return value switch
            {
                SttLiveEmotionDetection.False => "false",
                SttLiveEmotionDetection.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveEmotionDetection? ToEnum(string value)
        {
            return value switch
            {
                "false" => SttLiveEmotionDetection.False,
                "true" => SttLiveEmotionDetection.True,
                _ => null,
            };
        }
    }
}