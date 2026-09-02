
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Whether `max_words` forces finalization.<br/>
    /// Default Value: true
    /// </summary>
    public enum SttLiveFinalizeOnWords
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
    public static class SttLiveFinalizeOnWordsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveFinalizeOnWords value)
        {
            return value switch
            {
                SttLiveFinalizeOnWords.False => "false",
                SttLiveFinalizeOnWords.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveFinalizeOnWords? ToEnum(string value)
        {
            return value switch
            {
                "false" => SttLiveFinalizeOnWords.False,
                "true" => SttLiveFinalizeOnWords.True,
                _ => null,
            };
        }
    }
}