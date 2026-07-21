
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Optional. Sets the language used to read out numeric content —<br/>
    /// numbers, currency amounts, times, and the numeric parts of dates<br/>
    /// and years — independently of the synthesis voice. Ordinary words<br/>
    /// are not translated.<br/>
    /// - If you **omit `language`**, this value also becomes the<br/>
    ///   synthesis language: model selection and voice routing follow it.<br/>
    /// - If you **set `language` explicitly**, `language` always wins for<br/>
    ///   synthesis and `number_pronunciation_language` only changes how<br/>
    ///   numeric content is normalized. It works both ways — read numbers<br/>
    ///   in Hindi under an English voice, or in English under a Hindi<br/>
    ///   voice (tuned for Indian, often mixed-script, use cases).<br/>
    /// - Omit this field to keep the existing behaviour — normalization<br/>
    ///   follows `language`.<br/>
    /// Note: only numeric tokens are re-spoken; the words around them<br/>
    /// stay in the text language. On a cross-language request names may<br/>
    /// also render in the target script (e.g. "Smith" → "स्मिथ"), which<br/>
    /// is generally the desired reading for native-language voices.<br/>
    /// Accepts the same language codes as `language` (including `auto`,<br/>
    /// `nl`, `sv`).
    /// </summary>
    public enum TtsRequestNumberPronunciationLanguage
    {
        /// <summary>
        /// only numeric tokens are re-spoken; the words around them
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Bn,
        /// <summary>
        /// model selection and voice routing follow it.
        /// </summary>
        De,
        /// <summary>
        /// model selection and voice routing follow it.
        /// </summary>
        El,
        /// <summary>
        /// only numeric tokens are re-spoken; the words around them
        /// </summary>
        En,
        /// <summary>
        /// model selection and voice routing follow it.
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
        /// model selection and voice routing follow it.
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
        /// model selection and voice routing follow it.
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
        /// only numeric tokens are re-spoken; the words around them
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        No,
        /// <summary>
        /// only numeric tokens are re-spoken; the words around them
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
        /// only numeric tokens are re-spoken; the words around them
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
    public static class TtsRequestNumberPronunciationLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsRequestNumberPronunciationLanguage value)
        {
            return value switch
            {
                TtsRequestNumberPronunciationLanguage.Ar => "ar",
                TtsRequestNumberPronunciationLanguage.Auto => "auto",
                TtsRequestNumberPronunciationLanguage.Bn => "bn",
                TtsRequestNumberPronunciationLanguage.De => "de",
                TtsRequestNumberPronunciationLanguage.El => "el",
                TtsRequestNumberPronunciationLanguage.En => "en",
                TtsRequestNumberPronunciationLanguage.Es => "es",
                TtsRequestNumberPronunciationLanguage.Fi => "fi",
                TtsRequestNumberPronunciationLanguage.Fr => "fr",
                TtsRequestNumberPronunciationLanguage.Gu => "gu",
                TtsRequestNumberPronunciationLanguage.Hi => "hi",
                TtsRequestNumberPronunciationLanguage.Id => "id",
                TtsRequestNumberPronunciationLanguage.It => "it",
                TtsRequestNumberPronunciationLanguage.Ja => "ja",
                TtsRequestNumberPronunciationLanguage.Kn => "kn",
                TtsRequestNumberPronunciationLanguage.Ko => "ko",
                TtsRequestNumberPronunciationLanguage.Ml => "ml",
                TtsRequestNumberPronunciationLanguage.Mr => "mr",
                TtsRequestNumberPronunciationLanguage.Ms => "ms",
                TtsRequestNumberPronunciationLanguage.Nl => "nl",
                TtsRequestNumberPronunciationLanguage.No => "no",
                TtsRequestNumberPronunciationLanguage.Or => "or",
                TtsRequestNumberPronunciationLanguage.Pa => "pa",
                TtsRequestNumberPronunciationLanguage.Pl => "pl",
                TtsRequestNumberPronunciationLanguage.Pt => "pt",
                TtsRequestNumberPronunciationLanguage.Ru => "ru",
                TtsRequestNumberPronunciationLanguage.Sv => "sv",
                TtsRequestNumberPronunciationLanguage.Ta => "ta",
                TtsRequestNumberPronunciationLanguage.Te => "te",
                TtsRequestNumberPronunciationLanguage.Tr => "tr",
                TtsRequestNumberPronunciationLanguage.Vi => "vi",
                TtsRequestNumberPronunciationLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsRequestNumberPronunciationLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => TtsRequestNumberPronunciationLanguage.Ar,
                "auto" => TtsRequestNumberPronunciationLanguage.Auto,
                "bn" => TtsRequestNumberPronunciationLanguage.Bn,
                "de" => TtsRequestNumberPronunciationLanguage.De,
                "el" => TtsRequestNumberPronunciationLanguage.El,
                "en" => TtsRequestNumberPronunciationLanguage.En,
                "es" => TtsRequestNumberPronunciationLanguage.Es,
                "fi" => TtsRequestNumberPronunciationLanguage.Fi,
                "fr" => TtsRequestNumberPronunciationLanguage.Fr,
                "gu" => TtsRequestNumberPronunciationLanguage.Gu,
                "hi" => TtsRequestNumberPronunciationLanguage.Hi,
                "id" => TtsRequestNumberPronunciationLanguage.Id,
                "it" => TtsRequestNumberPronunciationLanguage.It,
                "ja" => TtsRequestNumberPronunciationLanguage.Ja,
                "kn" => TtsRequestNumberPronunciationLanguage.Kn,
                "ko" => TtsRequestNumberPronunciationLanguage.Ko,
                "ml" => TtsRequestNumberPronunciationLanguage.Ml,
                "mr" => TtsRequestNumberPronunciationLanguage.Mr,
                "ms" => TtsRequestNumberPronunciationLanguage.Ms,
                "nl" => TtsRequestNumberPronunciationLanguage.Nl,
                "no" => TtsRequestNumberPronunciationLanguage.No,
                "or" => TtsRequestNumberPronunciationLanguage.Or,
                "pa" => TtsRequestNumberPronunciationLanguage.Pa,
                "pl" => TtsRequestNumberPronunciationLanguage.Pl,
                "pt" => TtsRequestNumberPronunciationLanguage.Pt,
                "ru" => TtsRequestNumberPronunciationLanguage.Ru,
                "sv" => TtsRequestNumberPronunciationLanguage.Sv,
                "ta" => TtsRequestNumberPronunciationLanguage.Ta,
                "te" => TtsRequestNumberPronunciationLanguage.Te,
                "tr" => TtsRequestNumberPronunciationLanguage.Tr,
                "vi" => TtsRequestNumberPronunciationLanguage.Vi,
                "zh" => TtsRequestNumberPronunciationLanguage.Zh,
                _ => null,
            };
        }
    }
}