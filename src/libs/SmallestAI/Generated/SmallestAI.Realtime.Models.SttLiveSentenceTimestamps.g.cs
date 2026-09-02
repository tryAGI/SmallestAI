
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Emit sentence-level `utterances` on final frames.<br/>
    /// Default Value: false
    /// </summary>
    public enum SttLiveSentenceTimestamps
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
    public static class SttLiveSentenceTimestampsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveSentenceTimestamps value)
        {
            return value switch
            {
                SttLiveSentenceTimestamps.False => "false",
                SttLiveSentenceTimestamps.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveSentenceTimestamps? ToEnum(string value)
        {
            return value switch
            {
                "false" => SttLiveSentenceTimestamps.False,
                "true" => SttLiveSentenceTimestamps.True,
                _ => null,
            };
        }
    }
}