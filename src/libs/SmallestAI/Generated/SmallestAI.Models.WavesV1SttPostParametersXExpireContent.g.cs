
#nullable enable

namespace SmallestAI
{
    /// <summary>
    ///
    /// </summary>
    public enum WavesV1SttPostParametersXExpireContent
    {
        /// <summary>
        ///
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1SttPostParametersXExpireContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1SttPostParametersXExpireContent value)
        {
            return value switch
            {
                WavesV1SttPostParametersXExpireContent.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1SttPostParametersXExpireContent? ToEnum(string value)
        {
            return value switch
            {
                "true" => WavesV1SttPostParametersXExpireContent.True,
                _ => null,
            };
        }
    }
}