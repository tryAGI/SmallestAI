
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Message type identifier.<br/>
    /// Default Value: close_stream
    /// </summary>
    public enum SttCloseStreamRequestType
    {
        /// <summary>
        ///
        /// </summary>
        CloseStream,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SttCloseStreamRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttCloseStreamRequestType value)
        {
            return value switch
            {
                SttCloseStreamRequestType.CloseStream => "close_stream",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttCloseStreamRequestType? ToEnum(string value)
        {
            return value switch
            {
                "close_stream" => SttCloseStreamRequestType.CloseStream,
                _ => null,
            };
        }
    }
}