
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Optional. Sets the language used to read out numbers, dates, and<br/>
    /// other text — the text-normalization language — independently of<br/>
    /// the synthesis voice.<br/>
    /// - If you **omit `language`**, this value also becomes the<br/>
    ///   synthesis language: model selection and voice routing follow it.<br/>
    /// - If you **set `language` explicitly**, `language` always wins for<br/>
    ///   synthesis and `number_pronunciation_language` only changes how<br/>
    ///   numbers and text are normalized (for example, read digits in<br/>
    ///   Hindi while an English voice speaks the surrounding words).<br/>
    /// - Omit this field to keep the existing behaviour — normalization<br/>
    ///   follows `language`.<br/>
    /// Accepts the same language codes as `language`.
    /// </summary>
    public enum LightningV31RequestNumberPronunciationLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Bn,
        /// <summary>
        /// 
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
        Ta,
        /// <summary>
        /// 
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