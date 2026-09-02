
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Message type identifier.<br/>
    /// Default Value: finalize
    /// </summary>
    public enum SttFinalizeRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Finalize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SttFinalizeRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttFinalizeRequestType value)
        {
            return value switch
            {
                SttFinalizeRequestType.Finalize => "finalize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttFinalizeRequestType? ToEnum(string value)
        {
            return value switch
            {
                "finalize" => SttFinalizeRequestType.Finalize,
                _ => null,
            };
        }
    }
}