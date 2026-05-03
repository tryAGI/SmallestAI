
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: true
    /// </summary>
    public enum WavesV1PulseGetTextPostParametersCapitalize
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
    public static class WavesV1PulseGetTextPostParametersCapitalizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1PulseGetTextPostParametersCapitalize value)
        {
            return value switch
            {
                WavesV1PulseGetTextPostParametersCapitalize.False => "false",
                WavesV1PulseGetTextPostParametersCapitalize.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1PulseGetTextPostParametersCapitalize? ToEnum(string value)
        {
            return value switch
            {
                "false" => WavesV1PulseGetTextPostParametersCapitalize.False,
                "true" => WavesV1PulseGetTextPostParametersCapitalize.True,
                _ => null,
            };
        }
    }
}