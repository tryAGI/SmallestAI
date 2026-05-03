
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType
    {
        /// <summary>
        /// 
        /// </summary>
        Instant,
        /// <summary>
        /// 
        /// </summary>
        Professional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType value)
        {
            return value switch
            {
                WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType.Instant => "instant",
                WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType.Professional => "professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType? ToEnum(string value)
        {
            return value switch
            {
                "instant" => WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType.Instant,
                "professional" => WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType.Professional,
                _ => null,
            };
        }
    }
}