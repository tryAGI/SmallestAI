
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Emit per-word timings on final frames. Required for per-word speaker labels.<br/>
    /// Default Value: false
    /// </summary>
    public enum SttLiveWordTimestamps
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
    public static class SttLiveWordTimestampsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveWordTimestamps value)
        {
            return value switch
            {
                SttLiveWordTimestamps.False => "false",
                SttLiveWordTimestamps.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveWordTimestamps? ToEnum(string value)
        {
            return value switch
            {
                "false" => SttLiveWordTimestamps.False,
                "true" => SttLiveWordTimestamps.True,
                _ => null,
            };
        }
    }
}