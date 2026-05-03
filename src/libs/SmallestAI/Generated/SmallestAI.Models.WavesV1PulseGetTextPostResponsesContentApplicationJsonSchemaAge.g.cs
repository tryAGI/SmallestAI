
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Predicted age group of the speaker (e.g., infant, teenager, adult, old)
    /// </summary>
    public enum WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaAge
    {
        /// <summary>
        /// 
        /// </summary>
        Adult,
        /// <summary>
        /// 
        /// </summary>
        Infant,
        /// <summary>
        /// 
        /// </summary>
        Old,
        /// <summary>
        /// 
        /// </summary>
        Teenager,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaAgeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaAge value)
        {
            return value switch
            {
                WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaAge.Adult => "adult",
                WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaAge.Infant => "infant",
                WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaAge.Old => "old",
                WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaAge.Teenager => "teenager",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaAge? ToEnum(string value)
        {
            return value switch
            {
                "adult" => WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaAge.Adult,
                "infant" => WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaAge.Infant,
                "old" => WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaAge.Old,
                "teenager" => WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaAge.Teenager,
                _ => null,
            };
        }
    }
}