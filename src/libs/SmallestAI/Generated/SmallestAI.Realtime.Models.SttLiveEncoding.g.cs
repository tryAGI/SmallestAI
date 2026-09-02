
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Encoding of the binary audio frames.<br/>
    /// Default Value: linear16
    /// </summary>
    public enum SttLiveEncoding
    {
        /// <summary>
        ///
        /// </summary>
        Alaw,
        /// <summary>
        ///
        /// </summary>
        Linear16,
        /// <summary>
        ///
        /// </summary>
        Linear32,
        /// <summary>
        ///
        /// </summary>
        Mulaw,
        /// <summary>
        ///
        /// </summary>
        OggOpus,
        /// <summary>
        ///
        /// </summary>
        Opus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SttLiveEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveEncoding value)
        {
            return value switch
            {
                SttLiveEncoding.Alaw => "alaw",
                SttLiveEncoding.Linear16 => "linear16",
                SttLiveEncoding.Linear32 => "linear32",
                SttLiveEncoding.Mulaw => "mulaw",
                SttLiveEncoding.OggOpus => "ogg_opus",
                SttLiveEncoding.Opus => "opus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveEncoding? ToEnum(string value)
        {
            return value switch
            {
                "alaw" => SttLiveEncoding.Alaw,
                "linear16" => SttLiveEncoding.Linear16,
                "linear32" => SttLiveEncoding.Linear32,
                "mulaw" => SttLiveEncoding.Mulaw,
                "ogg_opus" => SttLiveEncoding.OggOpus,
                "opus" => SttLiveEncoding.Opus,
                _ => null,
            };
        }
    }
}