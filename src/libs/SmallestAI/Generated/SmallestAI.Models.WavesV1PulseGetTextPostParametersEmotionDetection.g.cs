
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: false
    /// </summary>
    public enum WavesV1PulseGetTextPostParametersEmotionDetection
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
    public static class WavesV1PulseGetTextPostParametersEmotionDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1PulseGetTextPostParametersEmotionDetection value)
        {
            return value switch
            {
                WavesV1PulseGetTextPostParametersEmotionDetection.False => "false",
                WavesV1PulseGetTextPostParametersEmotionDetection.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1PulseGetTextPostParametersEmotionDetection? ToEnum(string value)
        {
            return value switch
            {
                "false" => WavesV1PulseGetTextPostParametersEmotionDetection.False,
                "true" => WavesV1PulseGetTextPostParametersEmotionDetection.True,
                _ => null,
            };
        }
    }
}