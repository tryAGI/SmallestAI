
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Language code for synthesis. Influences pronunciation, number/date<br/>
    /// normalization, and phoneme selection.<br/>
    /// **Default on `lightning_v3.1_pro`:** when `language` is omitted, the<br/>
    /// Pro pool defaults to **`en + hi`** (mixed Indian + Western English<br/>
    /// coverage, auto-detected from the input text).<br/>
    /// Each voice has its own `tags.language` set in the voice catalog —<br/>
    /// query `GET /waves/v1/lightning-v3.1/get_voices`. Pass a language<br/>
    /// the voice was trained on; passing other codes is accepted by the<br/>
    /// API but produces English-pronounced output.<br/>
    /// **`auto` (recommended for cross-language use cases):** routes internally<br/>
    /// based on the input text. Any English or Hindi voice can be used<br/>
    /// across all supported languages when `auto` is set; the platform<br/>
    /// handles language-appropriate routing without needing a code per<br/>
    /// call.<br/>
    /// **On `lightning_v3.1`** — 20 supported languages:<br/>
    /// - 10 European: English, Spanish, French, German, Italian, Dutch, Swedish, Portuguese, Polish, Russian<br/>
    /// - 10 Indic: Hindi, Marathi, Gujarati, Punjabi, Bengali, Odia, Tamil, Telugu, Kannada, Malayalam<br/>
    /// **On `lightning_v3.1_pro`** — 31 supported languages (adds 11 over base):<br/>
    /// - 13 European: base 10 plus Greek, Finnish, Norwegian<br/>
    /// - 8 Asian &amp; Middle Eastern: Chinese, Japanese, Korean, Indonesian, Malay, Vietnamese, Turkish, Arabic<br/>
    /// - 10 Indic: same as base<br/>
    /// - Pass `en` → UK + American accented English.<br/>
    /// - Pass `hi` → Indian accented English + Hindi (code-switching).<br/>
    /// - Omit `language` → defaults to `en + hi` (mixed Indian + Western English coverage, auto-detected from input text).
    /// </summary>
    public enum TtsRequestLanguage
    {
        /// <summary>
        /// Hindi, Marathi, Gujarati, Punjabi, Bengali, Odia, Tamil, Telugu, Kannada, Malayalam
        /// </summary>
        Ar,
        /// <summary>
        /// ** routes internally
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Bn,
        /// <summary>
        /// ** routes internally
        /// </summary>
        De,
        /// <summary>
        /// Hindi, Marathi, Gujarati, Punjabi, Bengali, Odia, Tamil, Telugu, Kannada, Malayalam
        /// </summary>
        El,
        /// <summary>
        /// ** when `language` is omitted, the
        /// </summary>
        En,
        /// <summary>
        /// ** routes internally
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
        /// ** when `language` is omitted, the
        /// </summary>
        Gu,
        /// <summary>
        /// Hindi, Marathi, Gujarati, Punjabi, Bengali, Odia, Tamil, Telugu, Kannada, Malayalam
        /// </summary>
        Hi,
        /// <summary>
        /// Chinese, Japanese, Korean, Indonesian, Malay, Vietnamese, Turkish, Arabic
        /// </summary>
        Id,
        /// <summary>
        /// ** when `language` is omitted, the
        /// </summary>
        It,
        /// <summary>
        /// Hindi, Marathi, Gujarati, Punjabi, Bengali, Odia, Tamil, Telugu, Kannada, Malayalam
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
        Nl,
        /// <summary>
        /// 
        /// </summary>
        No,
        /// <summary>
        /// ** routes internally
        /// </summary>
        Or,
        /// <summary>
        /// English, Spanish, French, German, Italian, Dutch, Swedish, Portuguese, Polish, Russian
        /// </summary>
        Pa,
        /// <summary>
        /// base 10 plus Greek, Finnish, Norwegian
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
        /// English, Spanish, French, German, Italian, Dutch, Swedish, Portuguese, Polish, Russian
        /// </summary>
        Ta,
        /// <summary>
        /// ** when `language` is omitted, the
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
                TtsRequestLanguage.Auto => "auto",
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
                TtsRequestLanguage.Nl => "nl",
                TtsRequestLanguage.No => "no",
                TtsRequestLanguage.Or => "or",
                TtsRequestLanguage.Pa => "pa",
                TtsRequestLanguage.Pl => "pl",
                TtsRequestLanguage.Pt => "pt",
                TtsRequestLanguage.Ru => "ru",
                TtsRequestLanguage.Sv => "sv",
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
                "auto" => TtsRequestLanguage.Auto,
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
                "nl" => TtsRequestLanguage.Nl,
                "no" => TtsRequestLanguage.No,
                "or" => TtsRequestLanguage.Or,
                "pa" => TtsRequestLanguage.Pa,
                "pl" => TtsRequestLanguage.Pl,
                "pt" => TtsRequestLanguage.Pt,
                "ru" => TtsRequestLanguage.Ru,
                "sv" => TtsRequestLanguage.Sv,
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