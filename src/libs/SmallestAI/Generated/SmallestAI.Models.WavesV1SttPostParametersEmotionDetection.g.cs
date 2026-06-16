
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: false
    /// </summary>
    public enum WavesV1SttPostParametersEmotionDetection
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
    public static class WavesV1SttPostParametersEmotionDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1SttPostParametersEmotionDetection value)
        {
            return value switch
            {
                WavesV1SttPostParametersEmotionDetection.False => "false",
                WavesV1SttPostParametersEmotionDetection.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1SttPostParametersEmotionDetection? ToEnum(string value)
        {
            return value switch
            {
                "false" => WavesV1SttPostParametersEmotionDetection.False,
                "true" => WavesV1SttPostParametersEmotionDetection.True,
                _ => null,
            };
        }
    }
}