
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: true
    /// </summary>
    public enum WavesV1PulseGetTextPostParametersFormat
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
    public static class WavesV1PulseGetTextPostParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1PulseGetTextPostParametersFormat value)
        {
            return value switch
            {
                WavesV1PulseGetTextPostParametersFormat.False => "false",
                WavesV1PulseGetTextPostParametersFormat.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1PulseGetTextPostParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "false" => WavesV1PulseGetTextPostParametersFormat.False,
                "true" => WavesV1PulseGetTextPostParametersFormat.True,
                _ => null,
            };
        }
    }
}