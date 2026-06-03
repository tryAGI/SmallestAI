
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: false
    /// </summary>
    public enum WavesV1SttPostParametersRedactPci
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
    public static class WavesV1SttPostParametersRedactPciExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1SttPostParametersRedactPci value)
        {
            return value switch
            {
                WavesV1SttPostParametersRedactPci.False => "false",
                WavesV1SttPostParametersRedactPci.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1SttPostParametersRedactPci? ToEnum(string value)
        {
            return value switch
            {
                "false" => WavesV1SttPostParametersRedactPci.False,
                "true" => WavesV1SttPostParametersRedactPci.True,
                _ => null,
            };
        }
    }
}