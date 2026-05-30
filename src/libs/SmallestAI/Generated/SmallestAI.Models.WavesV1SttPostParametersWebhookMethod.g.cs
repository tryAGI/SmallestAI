
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: POST
    /// </summary>
    public enum WavesV1SttPostParametersWebhookMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Post,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1SttPostParametersWebhookMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1SttPostParametersWebhookMethod value)
        {
            return value switch
            {
                WavesV1SttPostParametersWebhookMethod.Get => "GET",
                WavesV1SttPostParametersWebhookMethod.Post => "POST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1SttPostParametersWebhookMethod? ToEnum(string value)
        {
            return value switch
            {
                "GET" => WavesV1SttPostParametersWebhookMethod.Get,
                "POST" => WavesV1SttPostParametersWebhookMethod.Post,
                _ => null,
            };
        }
    }
}