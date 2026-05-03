
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Voice cloning model. Defaults to `lightning-v3.1`.<br/>
    /// `lightning-v2` is accepted by the schema for historical<br/>
    /// reasons but is deprecated — the server returns 400 with<br/>
    /// `"Voice cloning for lightning-v2 is deprecated. Please use lightning-v3.1"`.<br/>
    /// Default Value: lightning-v3.1
    /// </summary>
    public enum WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel
    {
        /// <summary>
        /// 
        /// </summary>
        LightningV31,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel value)
        {
            return value switch
            {
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel.LightningV31 => "lightning-v3.1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel? ToEnum(string value)
        {
            return value switch
            {
                "lightning-v3.1" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel.LightningV31,
                _ => null,
            };
        }
    }
}