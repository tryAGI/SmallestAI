
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Language code for synthesis. Influences pronunciation, number/date<br/>
    /// normalization, and phoneme selection.<br/>
    /// Each voice has its own `tags.language` set in the voice catalog —<br/>
    /// query `GET /waves/v1/lightning-v3.1/get_voices`. Pass a language<br/>
    /// the voice was trained on; passing other codes is accepted by the<br/>
    /// API but produces English-pronounced output.<br/>
    /// **On `lightning_v3.1`**, the full 12-language catalog applies.<br/>
    /// **On `lightning_v3.1_pro`**:<br/>
    /// - Pass `en` → UK + American accented English.<br/>
    /// - Pass `hi` → Indian accented English + Hindi (code-switching).<br/>
    /// - Pass the ISO 639-1 code of any other Pro language (e.g. `ta`, `de`, `ja`) with a matching Pro voice — 27 additional languages (9 Indian, 8 Asian &amp; Middle Eastern, 10 European) have dedicated Pro voices.<br/>
    /// - Omit `language` → defaults to `en + hi` (mixed Indian + Western English coverage).
    /// </summary>
    public enum TtsRequestLanguage
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
        El,
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
        Fi,
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
        Hi,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Kn,
        /// <summary>
        /// 
        /// </summary>
        Ko,
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
        Ms,
        /// <summary>
        /// 
        /// </summary>
        No,
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
        Ta,
        /// <summary>
        /// 
        /// </summary>
        Te,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Vi,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsRequestLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsRequestLanguage value)
        {
            return value switch
            {
                TtsRequestLanguage.Ar => "ar",
                TtsRequestLanguage.Bn => "bn",
                TtsRequestLanguage.De => "de",
                TtsRequestLanguage.El => "el",
                TtsRequestLanguage.En => "en",
                TtsRequestLanguage.Es => "es",
                TtsRequestLanguage.Fi => "fi",
                TtsRequestLanguage.Fr => "fr",
                TtsRequestLanguage.Gu => "gu",
                TtsRequestLanguage.Hi => "hi",
                TtsRequestLanguage.Id => "id",
                TtsRequestLanguage.It => "it",
                TtsRequestLanguage.Ja => "ja",
                TtsRequestLanguage.Kn => "kn",
                TtsRequestLanguage.Ko => "ko",
                TtsRequestLanguage.Ml => "ml",
                TtsRequestLanguage.Mr => "mr",
                TtsRequestLanguage.Ms => "ms",
                TtsRequestLanguage.No => "no",
                TtsRequestLanguage.Or => "or",
                TtsRequestLanguage.Pa => "pa",
                TtsRequestLanguage.Pl => "pl",
                TtsRequestLanguage.Pt => "pt",
                TtsRequestLanguage.Ru => "ru",
                TtsRequestLanguage.Ta => "ta",
                TtsRequestLanguage.Te => "te",
                TtsRequestLanguage.Tr => "tr",
                TtsRequestLanguage.Vi => "vi",
                TtsRequestLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsRequestLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => TtsRequestLanguage.Ar,
                "bn" => TtsRequestLanguage.Bn,
                "de" => TtsRequestLanguage.De,
                "el" => TtsRequestLanguage.El,
                "en" => TtsRequestLanguage.En,
                "es" => TtsRequestLanguage.Es,
                "fi" => TtsRequestLanguage.Fi,
                "fr" => TtsRequestLanguage.Fr,
                "gu" => TtsRequestLanguage.Gu,
                "hi" => TtsRequestLanguage.Hi,
                "id" => TtsRequestLanguage.Id,
                "it" => TtsRequestLanguage.It,
                "ja" => TtsRequestLanguage.Ja,
                "kn" => TtsRequestLanguage.Kn,
                "ko" => TtsRequestLanguage.Ko,
                "ml" => TtsRequestLanguage.Ml,
                "mr" => TtsRequestLanguage.Mr,
                "ms" => TtsRequestLanguage.Ms,
                "no" => TtsRequestLanguage.No,
                "or" => TtsRequestLanguage.Or,
                "pa" => TtsRequestLanguage.Pa,
                "pl" => TtsRequestLanguage.Pl,
                "pt" => TtsRequestLanguage.Pt,
                "ru" => TtsRequestLanguage.Ru,
                "ta" => TtsRequestLanguage.Ta,
                "te" => TtsRequestLanguage.Te,
                "tr" => TtsRequestLanguage.Tr,
                "vi" => TtsRequestLanguage.Vi,
                "zh" => TtsRequestLanguage.Zh,
                _ => null,
            };
        }
    }
}