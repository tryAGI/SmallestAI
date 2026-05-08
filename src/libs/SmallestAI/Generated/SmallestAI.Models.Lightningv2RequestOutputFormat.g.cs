
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// The format of the output audio.<br/>
    /// Default Value: pcm
    /// </summary>
    public enum Lightningv2RequestOutputFormat
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
    public static class Lightningv2RequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Lightningv2RequestOutputFormat value)
        {
            return value switch
            {
                Lightningv2RequestOutputFormat.Alaw => "alaw",
                Lightningv2RequestOutputFormat.Mp3 => "mp3",
                Lightningv2RequestOutputFormat.Pcm => "pcm",
                Lightningv2RequestOutputFormat.Ulaw => "ulaw",
                Lightningv2RequestOutputFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Lightningv2RequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "alaw" => Lightningv2RequestOutputFormat.Alaw,
                "mp3" => Lightningv2RequestOutputFormat.Mp3,
                "pcm" => Lightningv2RequestOutputFormat.Pcm,
                "ulaw" => Lightningv2RequestOutputFormat.Ulaw,
                "wav" => Lightningv2RequestOutputFormat.Wav,
                _ => null,
            };
        }
    }
}