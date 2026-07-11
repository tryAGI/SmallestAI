
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
    /// Accepts the same language codes as `language`.
    /// </summary>
    public enum LightningV31RequestNumberPronunciationLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Bn,
        /// <summary>
        /// only numeric tokens are re-spoken; the words around them
        /// </summary>
        En,
        /// <summary>
        /// model selection and voice routing follow it.
        /// </summary>
        Es,
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
        Ta,
        /// <summary>
        /// only numeric tokens are re-spoken; the words around them
        /// </summary>
        Te,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LightningV31RequestNumberPronunciationLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LightningV31RequestNumberPronunciationLanguage value)
        {
            return value switch
            {
                LightningV31RequestNumberPronunciationLanguage.Bn => "bn",
                LightningV31RequestNumberPronunciationLanguage.En => "en",
                LightningV31RequestNumberPronunciationLanguage.Es => "es",
                LightningV31RequestNumberPronunciationLanguage.Gu => "gu",
                LightningV31RequestNumberPronunciationLanguage.Hi => "hi",
                LightningV31RequestNumberPronunciationLanguage.Kn => "kn",
                LightningV31RequestNumberPronunciationLanguage.Ml => "ml",
                LightningV31RequestNumberPronunciationLanguage.Mr => "mr",
                LightningV31RequestNumberPronunciationLanguage.Or => "or",
                LightningV31RequestNumberPronunciationLanguage.Pa => "pa",
                LightningV31RequestNumberPronunciationLanguage.Ta => "ta",
                LightningV31RequestNumberPronunciationLanguage.Te => "te",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LightningV31RequestNumberPronunciationLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bn" => LightningV31RequestNumberPronunciationLanguage.Bn,
                "en" => LightningV31RequestNumberPronunciationLanguage.En,
                "es" => LightningV31RequestNumberPronunciationLanguage.Es,
                "gu" => LightningV31RequestNumberPronunciationLanguage.Gu,
                "hi" => LightningV31RequestNumberPronunciationLanguage.Hi,
                "kn" => LightningV31RequestNumberPronunciationLanguage.Kn,
                "ml" => LightningV31RequestNumberPronunciationLanguage.Ml,
                "mr" => LightningV31RequestNumberPronunciationLanguage.Mr,
                "or" => LightningV31RequestNumberPronunciationLanguage.Or,
                "pa" => LightningV31RequestNumberPronunciationLanguage.Pa,
                "ta" => LightningV31RequestNumberPronunciationLanguage.Ta,
                "te" => LightningV31RequestNumberPronunciationLanguage.Te,
                _ => null,
            };
        }
    }
}