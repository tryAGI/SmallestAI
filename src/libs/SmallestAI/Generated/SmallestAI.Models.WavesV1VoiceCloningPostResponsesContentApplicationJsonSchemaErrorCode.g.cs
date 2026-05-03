
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Present when a known failure mode occurred.
    /// </summary>
    public enum WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        VoiceCloneError,
        /// <summary>
        /// 
        /// </summary>
        VoiceCloneTimeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode value)
        {
            return value switch
            {
                WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode.VoiceCloneError => "voice_clone_error",
                WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode.VoiceCloneTimeout => "voice_clone_timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "voice_clone_error" => WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode.VoiceCloneError,
                "voice_clone_timeout" => WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode.VoiceCloneTimeout,
                _ => null,
            };
        }
    }
}