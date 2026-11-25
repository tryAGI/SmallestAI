
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Primary language the clone will be used for. Optional, but<br/>
    /// **strongly recommended**: set it to the language of your<br/>
    /// reference audio. The TTS request's `language` should also<br/>
    /// match this code; setting it now avoids silent language<br/>
    /// mismatches at inference time.<br/>
    /// Accepted codes depend on `model`:<br/>
    /// - `lightning-v3.1`: `en`, `hi`, `mr`, `kn`, `ta`, `bn`, `gu`, `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `ar`, `he`, `sv`, `ml`, `te`, `pt`, `pa`, `or`.<br/>
    /// - `lightning-v3.1-pro`: the same codes except `he`, plus `el`, `fi`, `no`, `zh`, `id`, `ja`, `ko`, `ms`, `tr`, `vi`.<br/>
    /// A code the model doesn't support returns 400 `Invalid language. Supported: ...` with that model's list.
    /// </summary>
    public enum WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage
    {
        /// <summary>
        /// `en`, `hi`, `mr`, `kn`, `ta`, `bn`, `gu`, `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `ar`, `he`, `sv`, `ml`, `te`, `pt`, `pa`, `or`.
        /// </summary>
        Ar,
        /// <summary>
        /// `en`, `hi`, `mr`, `kn`, `ta`, `bn`, `gu`, `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `ar`, `he`, `sv`, `ml`, `te`, `pt`, `pa`, `or`.
        /// </summary>
        Bn,
        /// <summary>
        /// set it to the language of your
        /// </summary>
        De,
        /// <summary>
        ///
        /// </summary>
        El,
        /// <summary>
        /// set it to the language of your
        /// </summary>
        En,
        /// <summary>
        ///
        /// </summary>
        Es,
        /// <summary>
        /// the same codes except `he`, plus `el`, `fi`, `no`, `zh`, `id`, `ja`, `ko`, `ms`, `tr`, `vi`.
        /// </summary>
        Fi,
        /// <summary>
        /// `en`, `hi`, `mr`, `kn`, `ta`, `bn`, `gu`, `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `ar`, `he`, `sv`, `ml`, `te`, `pt`, `pa`, `or`.
        /// </summary>
        Fr,
        /// <summary>
        /// set it to the language of your
        /// </summary>
        Gu,
        /// <summary>
        /// set it to the language of your
        /// </summary>
        He,
        /// <summary>
        /// `en`, `hi`, `mr`, `kn`, `ta`, `bn`, `gu`, `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `ar`, `he`, `sv`, `ml`, `te`, `pt`, `pa`, `or`.
        /// </summary>
        Hi,
        /// <summary>
        /// the same codes except `he`, plus `el`, `fi`, `no`, `zh`, `id`, `ja`, `ko`, `ms`, `tr`, `vi`.
        /// </summary>
        Id,
        /// <summary>
        /// set it to the language of your
        /// </summary>
        It,
        /// <summary>
        /// the same codes except `he`, plus `el`, `fi`, `no`, `zh`, `id`, `ja`, `ko`, `ms`, `tr`, `vi`.
        /// </summary>
        Ja,
        /// <summary>
        /// `en`, `hi`, `mr`, `kn`, `ta`, `bn`, `gu`, `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `ar`, `he`, `sv`, `ml`, `te`, `pt`, `pa`, `or`.
        /// </summary>
        Kn,
        /// <summary>
        /// the same codes except `he`, plus `el`, `fi`, `no`, `zh`, `id`, `ja`, `ko`, `ms`, `tr`, `vi`.
        /// </summary>
        Ko,
        /// <summary>
        /// `en`, `hi`, `mr`, `kn`, `ta`, `bn`, `gu`, `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `ar`, `he`, `sv`, `ml`, `te`, `pt`, `pa`, `or`.
        /// </summary>
        Ml,
        /// <summary>
        /// `en`, `hi`, `mr`, `kn`, `ta`, `bn`, `gu`, `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `ar`, `he`, `sv`, `ml`, `te`, `pt`, `pa`, `or`.
        /// </summary>
        Mr,
        /// <summary>
        /// the same codes except `he`, plus `el`, `fi`, `no`, `zh`, `id`, `ja`, `ko`, `ms`, `tr`, `vi`.
        /// </summary>
        Ms,
        /// <summary>
        /// `en`, `hi`, `mr`, `kn`, `ta`, `bn`, `gu`, `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `ar`, `he`, `sv`, `ml`, `te`, `pt`, `pa`, `or`.
        /// </summary>
        Nl,
        /// <summary>
        /// the same codes except `he`, plus `el`, `fi`, `no`, `zh`, `id`, `ja`, `ko`, `ms`, `tr`, `vi`.
        /// </summary>
        No,
        /// <summary>
        /// `en`, `hi`, `mr`, `kn`, `ta`, `bn`, `gu`, `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `ar`, `he`, `sv`, `ml`, `te`, `pt`, `pa`, `or`.
        /// </summary>
        Or,
        /// <summary>
        /// `en`, `hi`, `mr`, `kn`, `ta`, `bn`, `gu`, `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `ar`, `he`, `sv`, `ml`, `te`, `pt`, `pa`, `or`.
        /// </summary>
        Pa,
        /// <summary>
        /// `en`, `hi`, `mr`, `kn`, `ta`, `bn`, `gu`, `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `ar`, `he`, `sv`, `ml`, `te`, `pt`, `pa`, `or`.
        /// </summary>
        Pl,
        /// <summary>
        ///
        /// </summary>
        Pt,
        /// <summary>
        /// `en`, `hi`, `mr`, `kn`, `ta`, `bn`, `gu`, `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `ar`, `he`, `sv`, `ml`, `te`, `pt`, `pa`, `or`.
        /// </summary>
        Ru,
        /// <summary>
        /// `en`, `hi`, `mr`, `kn`, `ta`, `bn`, `gu`, `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `ar`, `he`, `sv`, `ml`, `te`, `pt`, `pa`, `or`.
        /// </summary>
        Sv,
        /// <summary>
        /// `en`, `hi`, `mr`, `kn`, `ta`, `bn`, `gu`, `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `ar`, `he`, `sv`, `ml`, `te`, `pt`, `pa`, `or`.
        /// </summary>
        Ta,
        /// <summary>
        ///
        /// </summary>
        Te,
        /// <summary>
        /// set it to the language of your
        /// </summary>
        Tr,
        /// <summary>
        /// the same codes except `he`, plus `el`, `fi`, `no`, `zh`, `id`, `ja`, `ko`, `ms`, `tr`, `vi`.
        /// </summary>
        Vi,
        /// <summary>
        /// the same codes except `he`, plus `el`, `fi`, `no`, `zh`, `id`, `ja`, `ko`, `ms`, `tr`, `vi`.
        /// </summary>
        Zh,
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
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.El => "el",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.En => "en",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Es => "es",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Fi => "fi",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Fr => "fr",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Gu => "gu",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.He => "he",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Hi => "hi",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Id => "id",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.It => "it",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ja => "ja",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Kn => "kn",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ko => "ko",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ml => "ml",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Mr => "mr",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ms => "ms",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Nl => "nl",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.No => "no",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Or => "or",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Pa => "pa",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Pl => "pl",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Pt => "pt",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ru => "ru",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Sv => "sv",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ta => "ta",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Te => "te",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Tr => "tr",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Vi => "vi",
                WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Zh => "zh",
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
                "el" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.El,
                "en" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.En,
                "es" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Es,
                "fi" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Fi,
                "fr" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Fr,
                "gu" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Gu,
                "he" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.He,
                "hi" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Hi,
                "id" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Id,
                "it" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.It,
                "ja" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ja,
                "kn" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Kn,
                "ko" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ko,
                "ml" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ml,
                "mr" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Mr,
                "ms" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ms,
                "nl" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Nl,
                "no" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.No,
                "or" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Or,
                "pa" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Pa,
                "pl" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Pl,
                "pt" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Pt,
                "ru" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ru,
                "sv" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Sv,
                "ta" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Ta,
                "te" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Te,
                "tr" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Tr,
                "vi" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Vi,
                "zh" => WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage.Zh,
                _ => null,
            };
        }
    }
}