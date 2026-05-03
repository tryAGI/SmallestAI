
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Format of the returned audio. `pcm` is the lowest-latency option<br/>
    /// but requires a decoder to play; `mp3` and `wav` are directly<br/>
    /// playable in browsers and most media players. The server default<br/>
    /// is `pcm` when the field is omitted — the API playground uses<br/>
    /// `mp3` so the generated audio is directly playable.<br/>
    /// Default Value: pcm
    /// </summary>
    public enum LightningV31RequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Alaw,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
        /// <summary>
        /// 
        /// </summary>
        Ulaw,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LightningV31RequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LightningV31RequestOutputFormat value)
        {
            return value switch
            {
                LightningV31RequestOutputFormat.Alaw => "alaw",
                LightningV31RequestOutputFormat.Mp3 => "mp3",
                LightningV31RequestOutputFormat.Pcm => "pcm",
                LightningV31RequestOutputFormat.Ulaw => "ulaw",
                LightningV31RequestOutputFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LightningV31RequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "alaw" => LightningV31RequestOutputFormat.Alaw,
                "mp3" => LightningV31RequestOutputFormat.Mp3,
                "pcm" => LightningV31RequestOutputFormat.Pcm,
                "ulaw" => LightningV31RequestOutputFormat.Ulaw,
                "wav" => LightningV31RequestOutputFormat.Wav,
                _ => null,
            };
        }
    }
}