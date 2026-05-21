
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
    public enum TtsRequestOutputFormat
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
    public static class TtsRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsRequestOutputFormat value)
        {
            return value switch
            {
                TtsRequestOutputFormat.Alaw => "alaw",
                TtsRequestOutputFormat.Mp3 => "mp3",
                TtsRequestOutputFormat.Pcm => "pcm",
                TtsRequestOutputFormat.Ulaw => "ulaw",
                TtsRequestOutputFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "alaw" => TtsRequestOutputFormat.Alaw,
                "mp3" => TtsRequestOutputFormat.Mp3,
                "pcm" => TtsRequestOutputFormat.Pcm,
                "ulaw" => TtsRequestOutputFormat.Ulaw,
                "wav" => TtsRequestOutputFormat.Wav,
                _ => null,
            };
        }
    }
}