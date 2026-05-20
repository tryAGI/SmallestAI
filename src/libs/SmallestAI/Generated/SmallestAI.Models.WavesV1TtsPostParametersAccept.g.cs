
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: audio/wav
    /// </summary>
    public enum WavesV1TtsPostParametersAccept
    {
        /// <summary>
        /// 
        /// </summary>
        AudioWav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1TtsPostParametersAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1TtsPostParametersAccept value)
        {
            return value switch
            {
                WavesV1TtsPostParametersAccept.AudioWav => "audio/wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1TtsPostParametersAccept? ToEnum(string value)
        {
            return value switch
            {
                "audio/wav" => WavesV1TtsPostParametersAccept.AudioWav,
                _ => null,
            };
        }
    }
}