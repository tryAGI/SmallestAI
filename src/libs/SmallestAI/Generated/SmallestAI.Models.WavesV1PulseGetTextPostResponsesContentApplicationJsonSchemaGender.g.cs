
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Predicted gender of the speaker if requested
    /// </summary>
    public enum WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaGender
    {
        /// <summary>
        /// 
        /// </summary>
        Female,
        /// <summary>
        /// 
        /// </summary>
        Male,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaGender value)
        {
            return value switch
            {
                WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaGender.Female => "female",
                WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaGender.Male => "male",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaGender.Female,
                "male" => WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaGender.Male,
                _ => null,
            };
        }
    }
}