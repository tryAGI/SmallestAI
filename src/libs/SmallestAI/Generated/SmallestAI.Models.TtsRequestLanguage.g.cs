
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
    /// - Omit `language` → defaults to `en + hi` (mixed Indian + Western English coverage).
    /// </summary>
    public enum TtsRequestLanguage
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
        /// 
        /// </summary>
        Es,
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
    public static class TtsRequestLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsRequestLanguage value)
        {
            return value switch
            {
                TtsRequestLanguage.Bn => "bn",
                TtsRequestLanguage.En => "en",
                TtsRequestLanguage.Es => "es",
                TtsRequestLanguage.Gu => "gu",
                TtsRequestLanguage.Hi => "hi",
                TtsRequestLanguage.Kn => "kn",
                TtsRequestLanguage.Ml => "ml",
                TtsRequestLanguage.Mr => "mr",
                TtsRequestLanguage.Or => "or",
                TtsRequestLanguage.Pa => "pa",
                TtsRequestLanguage.Ta => "ta",
                TtsRequestLanguage.Te => "te",
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
                "bn" => TtsRequestLanguage.Bn,
                "en" => TtsRequestLanguage.En,
                "es" => TtsRequestLanguage.Es,
                "gu" => TtsRequestLanguage.Gu,
                "hi" => TtsRequestLanguage.Hi,
                "kn" => TtsRequestLanguage.Kn,
                "ml" => TtsRequestLanguage.Ml,
                "mr" => TtsRequestLanguage.Mr,
                "or" => TtsRequestLanguage.Or,
                "pa" => TtsRequestLanguage.Pa,
                "ta" => TtsRequestLanguage.Ta,
                "te" => TtsRequestLanguage.Te,
                _ => null,
            };
        }
    }
}