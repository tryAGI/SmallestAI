
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: audio/wav
    /// </summary>
    public enum WavesV1LightningV31GetSpeechPostParametersAccept
    {
        /// <summary>
        /// 
        /// </summary>
        AudioWav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1LightningV31GetSpeechPostParametersAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1LightningV31GetSpeechPostParametersAccept value)
        {
            return value switch
            {
                WavesV1LightningV31GetSpeechPostParametersAccept.AudioWav => "audio/wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1LightningV31GetSpeechPostParametersAccept? ToEnum(string value)
        {
            return value switch
            {
                "audio/wav" => WavesV1LightningV31GetSpeechPostParametersAccept.AudioWav,
                _ => null,
            };
        }
    }
}