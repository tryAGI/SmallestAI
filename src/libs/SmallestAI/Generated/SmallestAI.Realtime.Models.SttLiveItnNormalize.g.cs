
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Inverse text normalization, for example "twenty five" to "25".<br/>
    /// Default Value: false
    /// </summary>
    public enum SttLiveItnNormalize
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
    public static class SttLiveItnNormalizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveItnNormalize value)
        {
            return value switch
            {
                SttLiveItnNormalize.False => "false",
                SttLiveItnNormalize.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveItnNormalize? ToEnum(string value)
        {
            return value switch
            {
                "false" => SttLiveItnNormalize.False,
                "true" => SttLiveItnNormalize.True,
                _ => null,
            };
        }
    }
}