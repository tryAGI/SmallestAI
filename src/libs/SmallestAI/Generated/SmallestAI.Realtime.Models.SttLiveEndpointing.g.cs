
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Finalize promptly on trailing silence.<br/>
    /// Default Value: true
    /// </summary>
    public enum SttLiveEndpointing
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
    public static class SttLiveEndpointingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttLiveEndpointing value)
        {
            return value switch
            {
                SttLiveEndpointing.False => "false",
                SttLiveEndpointing.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttLiveEndpointing? ToEnum(string value)
        {
            return value switch
            {
                "false" => SttLiveEndpointing.False,
                "true" => SttLiveEndpointing.True,
                _ => null,
            };
        }
    }
}