
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Primary language the clone will be used for. Optional, but<br/>
    /// **strongly recommended** — set it to the language of your<br/>
    /// reference audio. The TTS request's `language` should also<br/>
    /// match this code; setting it now avoids silent language<br/>
    /// mismatches at inference time.<br/>
    /// Must be one of the languages supported by `lightning-v3.1`.<br/>
    /// The server validates and rejects unsupported codes with a 400.
    /// </summary>
    public enum WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage
    {
        /// <summary>
        ///
        /// </summary>
        Ar,
        /// <summary>
        ///
        /// </summary>
        Bn,
        /// <summary>
        ///
        /// </summary>
        De,
        /// <summary>
        ///
        /// </summary>
        En,
        /// <summary>
        ///
        /// </summary>
        Es,
        /// <summary>
        ///
        /// </summary>
        Fr,
        /// <summary>
        ///
        /// </summary>
        Gu,
        /// <summary>
        ///
        /// </summary>
        He,
        /// <summary>
        ///
        /// </summary>
        Hi,
        /// <summary>
        ///
        /// </summary>
        It,
        /// <summary>
        ///
        /// </summary>
        Kn,
        /// <summary>
        ///
        /// </summary>
        Ml,
        /// <summary>
        ///
        /// </summary>
        Mr,
        /// <summary>
        ///
        /// </summary>
        Nl,
        /// <summary>
        ///
        /// </summary>
        Or,
        /// <summary>
        ///
        /// </summary>
        Pa,
        /// <summary>
        ///
        /// </summary>
        Pl,
        /// <summary>
        ///
        /// </summary>
        Pt,
        /// <summary>
        ///
        /// </summary>
        Ru,
        /// <summary>
        ///
        /// </summary>
        Sv,
        /// <summary>
        ///
        /// </summary>
        Ta,
        /// <summary>
        ///
        /// </summary>
        Te,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage value)
        {
            return value switch
            {
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ar => "ar",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Bn => "bn",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.De => "de",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.En => "en",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Es => "es",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Fr => "fr",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Gu => "gu",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.He => "he",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Hi => "hi",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.It => "it",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Kn => "kn",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ml => "ml",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Mr => "mr",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Nl => "nl",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Or => "or",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Pa => "pa",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Pl => "pl",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Pt => "pt",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ru => "ru",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Sv => "sv",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ta => "ta",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Te => "te",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ar,
                "bn" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Bn,
                "de" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.De,
                "en" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.En,
                "es" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Es,
                "fr" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Fr,
                "gu" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Gu,
                "he" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.He,
                "hi" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Hi,
                "it" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.It,
                "kn" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Kn,
                "ml" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ml,
                "mr" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Mr,
                "nl" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Nl,
                "or" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Or,
                "pa" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Pa,
                "pl" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Pl,
                "pt" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Pt,
                "ru" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ru,
                "sv" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Sv,
                "ta" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ta,
                "te" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Te,
                _ => null,
            };
        }
    }
}