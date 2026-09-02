
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Insert punctuation.<br/>
    /// Default Value: true
    /// </summary>
    public enum SttLivePunctuate
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
    public static class SttLivePunctuateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLivePunctuate value)
        {
            return value switch
            {
                SttLivePunctuate.False => "false",
                SttLivePunctuate.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLivePunctuate? ToEnum(string value)
        {
            return value switch
            {
                "false" => SttLivePunctuate.False,
                "true" => SttLivePunctuate.True,
                _ => null,
            };
        }
    }
}