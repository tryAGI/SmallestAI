
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Include the cumulative session transcript on final frames.<br/>
    /// Default Value: false
    /// </summary>
    public enum SttLiveFullTranscript
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
    public static class SttLiveFullTranscriptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveFullTranscript value)
        {
            return value switch
            {
                SttLiveFullTranscript.False => "false",
                SttLiveFullTranscript.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveFullTranscript? ToEnum(string value)
        {
            return value switch
            {
                "false" => SttLiveFullTranscript.False,
                "true" => SttLiveFullTranscript.True,
                _ => null,
            };
        }
    }
}