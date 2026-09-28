
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// What happens on a match. `reject` fails the request with HTTP 400; `flag` synthesizes normally and records the match.<br/>
    /// Default Value: reject
    /// </summary>
    public enum TtsRequestContentFilterAction
    {
        /// <summary>
        ///
        /// </summary>
        Flag,
        /// <summary>
        ///
        /// </summary>
        Reject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsRequestContentFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsRequestContentFilterAction value)
        {
            return value switch
            {
                TtsRequestContentFilterAction.Flag => "flag",
                TtsRequestContentFilterAction.Reject => "reject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsRequestContentFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "flag" => TtsRequestContentFilterAction.Flag,
                "reject" => TtsRequestContentFilterAction.Reject,
                _ => null,
            };
        }
    }
}