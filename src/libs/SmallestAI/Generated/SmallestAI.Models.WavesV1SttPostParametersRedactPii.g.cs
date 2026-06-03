
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: false
    /// </summary>
    public enum WavesV1SttPostParametersRedactPii
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
    public static class WavesV1SttPostParametersRedactPiiExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1SttPostParametersRedactPii value)
        {
            return value switch
            {
                WavesV1SttPostParametersRedactPii.False => "false",
                WavesV1SttPostParametersRedactPii.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1SttPostParametersRedactPii? ToEnum(string value)
        {
            return value switch
            {
                "false" => WavesV1SttPostParametersRedactPii.False,
                "true" => WavesV1SttPostParametersRedactPii.True,
                _ => null,
            };
        }
    }
}