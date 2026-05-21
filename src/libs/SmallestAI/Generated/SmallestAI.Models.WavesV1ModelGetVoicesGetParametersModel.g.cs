
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: lightning-v3.1
    /// </summary>
    public enum WavesV1ModelGetVoicesGetParametersModel
    {
        /// <summary>
        /// 
        /// </summary>
        LightningV31,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1ModelGetVoicesGetParametersModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1ModelGetVoicesGetParametersModel value)
        {
            return value switch
            {
                WavesV1ModelGetVoicesGetParametersModel.LightningV31 => "lightning-v3.1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1ModelGetVoicesGetParametersModel? ToEnum(string value)
        {
            return value switch
            {
                "lightning-v3.1" => WavesV1ModelGetVoicesGetParametersModel.LightningV31,
                _ => null,
            };
        }
    }
}