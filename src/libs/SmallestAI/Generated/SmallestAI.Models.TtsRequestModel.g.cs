
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// TTS model to route the request to. Controls which model pool serves<br/>
    /// this synthesis.<br/>
    /// - `lightning_v3.1` (default) — standard Lightning v3.1.<br/>
    /// - `lightning_v3.1_pro` — Lightning v3.1 Pro pool. Improved audio<br/>
    ///   quality and naturalness, with a curated voice catalog. See the<br/>
    ///   [Lightning v3.1 Pro model card](/waves/model-cards/text-to-speech/lightning-v-3-1-pro)<br/>
    ///   for supported voice IDs.<br/>
    /// Same concurrency and latency profile across both. Other request<br/>
    /// parameters behave identically.<br/>
    /// Default Value: lightning_v3.1
    /// </summary>
    public enum TtsRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        LightningV31,
        /// <summary>
        /// 
        /// </summary>
        LightningV31Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsRequestModel value)
        {
            return value switch
            {
                TtsRequestModel.LightningV31 => "lightning_v3.1",
                TtsRequestModel.LightningV31Pro => "lightning_v3.1_pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "lightning_v3.1" => TtsRequestModel.LightningV31,
                "lightning_v3.1_pro" => TtsRequestModel.LightningV31Pro,
                _ => null,
            };
        }
    }
}