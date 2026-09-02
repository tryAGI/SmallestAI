
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Frame kind. `complete` is terminal, except inside a `context_id`<br/>
    /// continuation where it ends one segment and the socket stays open.
    /// </summary>
    public enum TtsLiveEventStatus
    {
        /// <summary>
        ///
        /// </summary>
        Chunk,
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        WordTimestamp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsLiveEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsLiveEventStatus value)
        {
            return value switch
            {
                TtsLiveEventStatus.Chunk => "chunk",
                TtsLiveEventStatus.Complete => "complete",
                TtsLiveEventStatus.WordTimestamp => "word_timestamp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsLiveEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "chunk" => TtsLiveEventStatus.Chunk,
                "complete" => TtsLiveEventStatus.Complete,
                "word_timestamp" => TtsLiveEventStatus.WordTimestamp,
                _ => null,
            };
        }
    }
}