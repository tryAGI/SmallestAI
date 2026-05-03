
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: false
    /// </summary>
    public enum WavesV1PulseGetTextPostParametersAgeDetection
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
    public static class WavesV1PulseGetTextPostParametersAgeDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1PulseGetTextPostParametersAgeDetection value)
        {
            return value switch
            {
                WavesV1PulseGetTextPostParametersAgeDetection.False => "false",
                WavesV1PulseGetTextPostParametersAgeDetection.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1PulseGetTextPostParametersAgeDetection? ToEnum(string value)
        {
            return value switch
            {
                "false" => WavesV1PulseGetTextPostParametersAgeDetection.False,
                "true" => WavesV1PulseGetTextPostParametersAgeDetection.True,
                _ => null,
            };
        }
    }
}