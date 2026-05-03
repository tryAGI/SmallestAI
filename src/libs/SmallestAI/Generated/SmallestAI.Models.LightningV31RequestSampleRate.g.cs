
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// The sample rate for the generated audio.
    /// </summary>
    public enum LightningV31RequestSampleRate
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
        x8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LightningV31RequestSampleRateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LightningV31RequestSampleRate value)
        {
            return value switch
            {
                LightningV31RequestSampleRate.x16000 => "16000",
                LightningV31RequestSampleRate.x24000 => "24000",
                LightningV31RequestSampleRate.x8000 => "8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LightningV31RequestSampleRate? ToEnum(string value)
        {
            return value switch
            {
                "16000" => LightningV31RequestSampleRate.x16000,
                "24000" => LightningV31RequestSampleRate.x24000,
                "8000" => LightningV31RequestSampleRate.x8000,
                _ => null,
            };
        }
    }
}