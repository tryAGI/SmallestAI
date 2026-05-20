
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// TTS model to route the request to.<br/>
    /// - `lightning_v3.1` (default) — standard Lightning v3.1 pool.<br/>
    /// - `lightning_v3.1_pro` — Lightning v3.1 Pro pool with a curated<br/>
    ///   voice catalog. See the<br/>
    ///   [Pro model card](/waves/model-cards/text-to-speech/lightning-v-3-1-pro).<br/>
    /// New integrations should use the unified<br/>
    /// `/waves/v1/tts` route instead of this endpoint, but the `model`<br/>
    /// field is supported here for backwards-compatible Pro opt-in.<br/>
    /// Default Value: lightning_v3.1
    /// </summary>
    public enum LightningV31RequestModel
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
    public static class LightningV31RequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LightningV31RequestModel value)
        {
            return value switch
            {
                LightningV31RequestModel.LightningV31 => "lightning_v3.1",
                LightningV31RequestModel.LightningV31Pro => "lightning_v3.1_pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LightningV31RequestModel? ToEnum(string value)
        {
            return value switch
            {
                "lightning_v3.1" => LightningV31RequestModel.LightningV31,
                "lightning_v3.1_pro" => LightningV31RequestModel.LightningV31Pro,
                _ => null,
            };
        }
    }
}