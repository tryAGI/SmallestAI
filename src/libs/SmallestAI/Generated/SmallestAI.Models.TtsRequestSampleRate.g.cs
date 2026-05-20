
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// The sample rate for the generated audio.
    /// </summary>
    public enum TtsRequestSampleRate
    {
        /// <summary>
        /// 
        /// </summary>
        x16000,
        /// <summary>
        /// 
        /// </summary>
        x24000,
        /// <summary>
        /// 
        /// </summary>
        x44100,
        /// <summary>
        /// 
        /// </summary>
        x8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsRequestSampleRateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsRequestSampleRate value)
        {
            return value switch
            {
                TtsRequestSampleRate.x16000 => "16000",
                TtsRequestSampleRate.x24000 => "24000",
                TtsRequestSampleRate.x44100 => "44100",
                TtsRequestSampleRate.x8000 => "8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsRequestSampleRate? ToEnum(string value)
        {
            return value switch
            {
                "16000" => TtsRequestSampleRate.x16000,
                "24000" => TtsRequestSampleRate.x24000,
                "44100" => TtsRequestSampleRate.x44100,
                "8000" => TtsRequestSampleRate.x8000,
                _ => null,
            };
        }
    }
}