
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
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
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
                Lightningv2RequestOutputFormat.Mp3 => "mp3",
                Lightningv2RequestOutputFormat.Mulaw => "mulaw",
                Lightningv2RequestOutputFormat.Pcm => "pcm",
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
                "mp3" => Lightningv2RequestOutputFormat.Mp3,
                "mulaw" => Lightningv2RequestOutputFormat.Mulaw,
                "pcm" => Lightningv2RequestOutputFormat.Pcm,
                "wav" => Lightningv2RequestOutputFormat.Wav,
                _ => null,
            };
        }
    }
}