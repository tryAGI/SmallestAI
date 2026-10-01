
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: false
    /// </summary>
    public enum WavesV1SttPostParametersWordTimestamps
    {
        /// <summary>
        ///
        /// </summary>
        False,
        /// <summary>
        ///
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1SttPostParametersWordTimestampsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1SttPostParametersWordTimestamps value)
        {
            return value switch
            {
                WavesV1SttPostParametersWordTimestamps.False => "false",
                WavesV1SttPostParametersWordTimestamps.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1SttPostParametersWordTimestamps? ToEnum(string value)
        {
            return value switch
            {
                "false" => WavesV1SttPostParametersWordTimestamps.False,
                "true" => WavesV1SttPostParametersWordTimestamps.True,
                _ => null,
            };
        }
    }
}