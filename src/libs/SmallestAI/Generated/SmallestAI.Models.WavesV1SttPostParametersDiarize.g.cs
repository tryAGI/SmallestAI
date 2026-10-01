
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: false
    /// </summary>
    public enum WavesV1SttPostParametersDiarize
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
    public static class WavesV1SttPostParametersDiarizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1SttPostParametersDiarize value)
        {
            return value switch
            {
                WavesV1SttPostParametersDiarize.False => "false",
                WavesV1SttPostParametersDiarize.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1SttPostParametersDiarize? ToEnum(string value)
        {
            return value switch
            {
                "false" => WavesV1SttPostParametersDiarize.False,
                "true" => WavesV1SttPostParametersDiarize.True,
                _ => null,
            };
        }
    }
}