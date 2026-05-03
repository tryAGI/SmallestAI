
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: true
    /// </summary>
    public enum WavesV1PulseGetTextPostParametersPunctuate
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
    public static class WavesV1PulseGetTextPostParametersPunctuateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1PulseGetTextPostParametersPunctuate value)
        {
            return value switch
            {
                WavesV1PulseGetTextPostParametersPunctuate.False => "false",
                WavesV1PulseGetTextPostParametersPunctuate.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1PulseGetTextPostParametersPunctuate? ToEnum(string value)
        {
            return value switch
            {
                "false" => WavesV1PulseGetTextPostParametersPunctuate.False,
                "true" => WavesV1PulseGetTextPostParametersPunctuate.True,
                _ => null,
            };
        }
    }
}