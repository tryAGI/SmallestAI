
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WavesV1TtsLivePostParametersXExpireContent
    {
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1TtsLivePostParametersXExpireContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1TtsLivePostParametersXExpireContent value)
        {
            return value switch
            {
                WavesV1TtsLivePostParametersXExpireContent.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1TtsLivePostParametersXExpireContent? ToEnum(string value)
        {
            return value switch
            {
                "true" => WavesV1TtsLivePostParametersXExpireContent.True,
                _ => null,
            };
        }
    }
}