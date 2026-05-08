
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WavesV1PulseGetTextPostParametersEncoding
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
    public static class WavesV1PulseGetTextPostParametersEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1PulseGetTextPostParametersEncoding value)
        {
            return value switch
            {
                WavesV1PulseGetTextPostParametersEncoding.Alaw => "alaw",
                WavesV1PulseGetTextPostParametersEncoding.Linear16 => "linear16",
                WavesV1PulseGetTextPostParametersEncoding.Linear32 => "linear32",
                WavesV1PulseGetTextPostParametersEncoding.Mulaw => "mulaw",
                WavesV1PulseGetTextPostParametersEncoding.OggOpus => "ogg_opus",
                WavesV1PulseGetTextPostParametersEncoding.Opus => "opus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1PulseGetTextPostParametersEncoding? ToEnum(string value)
        {
            return value switch
            {
                "alaw" => WavesV1PulseGetTextPostParametersEncoding.Alaw,
                "linear16" => WavesV1PulseGetTextPostParametersEncoding.Linear16,
                "linear32" => WavesV1PulseGetTextPostParametersEncoding.Linear32,
                "mulaw" => WavesV1PulseGetTextPostParametersEncoding.Mulaw,
                "ogg_opus" => WavesV1PulseGetTextPostParametersEncoding.OggOpus,
                "opus" => WavesV1PulseGetTextPostParametersEncoding.Opus,
                _ => null,
            };
        }
    }
}