
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WavesV1SttPostParametersModel
    {
        /// <summary>
        /// 
        /// </summary>
        Pulse,
        /// <summary>
        /// 
        /// </summary>
        PulsePro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1SttPostParametersModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1SttPostParametersModel value)
        {
            return value switch
            {
                WavesV1SttPostParametersModel.Pulse => "pulse",
                WavesV1SttPostParametersModel.PulsePro => "pulse-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1SttPostParametersModel? ToEnum(string value)
        {
            return value switch
            {
                "pulse" => WavesV1SttPostParametersModel.Pulse,
                "pulse-pro" => WavesV1SttPostParametersModel.PulsePro,
                _ => null,
            };
        }
    }
}