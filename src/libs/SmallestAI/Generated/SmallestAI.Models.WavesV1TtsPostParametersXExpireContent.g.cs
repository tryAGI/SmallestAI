
#nullable enable

namespace SmallestAI
{
    /// <summary>
    ///
    /// </summary>
    public enum WavesV1TtsPostParametersXExpireContent
    {
        /// <summary>
        ///
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1TtsPostParametersXExpireContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1TtsPostParametersXExpireContent value)
        {
            return value switch
            {
                WavesV1TtsPostParametersXExpireContent.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1TtsPostParametersXExpireContent? ToEnum(string value)
        {
            return value switch
            {
                "true" => WavesV1TtsPostParametersXExpireContent.True,
                _ => null,
            };
        }
    }
}