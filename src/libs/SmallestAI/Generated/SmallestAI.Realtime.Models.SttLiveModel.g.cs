
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Transcription model. Only `pulse` is served on this channel — Pulse Pro<br/>
    /// has no streaming worker and returns `400` before the upgrade completes.<br/>
    /// Default Value: pulse
    /// </summary>
    public enum SttLiveModel
    {
        /// <summary>
        ///
        /// </summary>
        Pulse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SttLiveModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveModel value)
        {
            return value switch
            {
                SttLiveModel.Pulse => "pulse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveModel? ToEnum(string value)
        {
            return value switch
            {
                "pulse" => SttLiveModel.Pulse,
                _ => null,
            };
        }
    }
}