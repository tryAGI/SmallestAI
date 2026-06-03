
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: false
    /// </summary>
    public enum WavesV1SttPostParametersGenderDetection
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
    public static class WavesV1SttPostParametersGenderDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1SttPostParametersGenderDetection value)
        {
            return value switch
            {
                WavesV1SttPostParametersGenderDetection.False => "false",
                WavesV1SttPostParametersGenderDetection.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1SttPostParametersGenderDetection? ToEnum(string value)
        {
            return value switch
            {
                "false" => WavesV1SttPostParametersGenderDetection.False,
                "true" => WavesV1SttPostParametersGenderDetection.True,
                _ => null,
            };
        }
    }
}