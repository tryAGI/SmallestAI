
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: false
    /// </summary>
    public enum WavesV1PulseGetTextPostParametersGenderDetection
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
    public static class WavesV1PulseGetTextPostParametersGenderDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1PulseGetTextPostParametersGenderDetection value)
        {
            return value switch
            {
                WavesV1PulseGetTextPostParametersGenderDetection.False => "false",
                WavesV1PulseGetTextPostParametersGenderDetection.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1PulseGetTextPostParametersGenderDetection? ToEnum(string value)
        {
            return value switch
            {
                "false" => WavesV1PulseGetTextPostParametersGenderDetection.False,
                "true" => WavesV1PulseGetTextPostParametersGenderDetection.True,
                _ => null,
            };
        }
    }
}