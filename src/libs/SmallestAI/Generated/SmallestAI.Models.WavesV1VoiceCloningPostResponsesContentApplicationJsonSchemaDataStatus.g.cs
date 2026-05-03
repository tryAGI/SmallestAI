
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus value)
        {
            return value switch
            {
                WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus.Completed => "completed",
                WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus.Failed => "failed",
                WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus.Pending => "pending",
                WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus.Completed,
                "failed" => WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus.Failed,
                "pending" => WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus.Pending,
                "processing" => WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus.Processing,
                _ => null,
            };
        }
    }
}