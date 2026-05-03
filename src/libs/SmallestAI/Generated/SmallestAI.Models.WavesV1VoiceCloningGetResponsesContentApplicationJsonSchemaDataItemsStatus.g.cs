
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus
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
    public static class WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus value)
        {
            return value switch
            {
                WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus.Completed => "completed",
                WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus.Failed => "failed",
                WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus.Pending => "pending",
                WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus.Completed,
                "failed" => WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus.Failed,
                "pending" => WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus.Pending,
                "processing" => WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus.Processing,
                _ => null,
            };
        }
    }
}