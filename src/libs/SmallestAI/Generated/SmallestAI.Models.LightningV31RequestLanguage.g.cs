
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Language code for synthesis. Influences pronunciation, number/date<br/>
    /// normalization, and phoneme selection.<br/>
    /// - **Indian:** `en`, `hi`, `mr` (Marathi), `kn` (Kannada), `ta` (Tamil),<br/>
    ///   `bn` (Bengali), `gu` (Gujarati), `te` (Telugu), `ml` (Malayalam),<br/>
    ///   `pa` (Punjabi), `or` (Odia)<br/>
    /// - **European:** `es` (Spanish)<br/>
    /// Default Value: en
    /// </summary>
    public enum LightningV31RequestLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Bn,
        /// <summary>
        /// ** `en`, `hi`, `mr` (Marathi), `kn` (Kannada), `ta` (Tamil),
        /// </summary>
        En,
        /// <summary>
        /// ** `es` (Spanish)
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Gu,
        /// <summary>
        /// ** `en`, `hi`, `mr` (Marathi), `kn` (Kannada), `ta` (Tamil),
        /// </summary>
        Hi,
        /// <summary>
        /// ** `en`, `hi`, `mr` (Marathi), `kn` (Kannada), `ta` (Tamil),
        /// </summary>
        Kn,
        /// <summary>
        /// 
        /// </summary>
        Ml,
        /// <summary>
        /// ** `en`, `hi`, `mr` (Marathi), `kn` (Kannada), `ta` (Tamil),
        /// </summary>
        Mr,
        /// <summary>
        /// 
        /// </summary>
        Or,
        /// <summary>
        /// ** `es` (Spanish)
        /// </summary>
        Pa,
        /// <summary>
        /// ** `en`, `hi`, `mr` (Marathi), `kn` (Kannada), `ta` (Tamil),
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
    public static class LightningV31RequestLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LightningV31RequestLanguage value)
        {
            return value switch
            {
                LightningV31RequestLanguage.Bn => "bn",
                LightningV31RequestLanguage.En => "en",
                LightningV31RequestLanguage.Es => "es",
                LightningV31RequestLanguage.Gu => "gu",
                LightningV31RequestLanguage.Hi => "hi",
                LightningV31RequestLanguage.Kn => "kn",
                LightningV31RequestLanguage.Ml => "ml",
                LightningV31RequestLanguage.Mr => "mr",
                LightningV31RequestLanguage.Or => "or",
                LightningV31RequestLanguage.Pa => "pa",
                LightningV31RequestLanguage.Ta => "ta",
                LightningV31RequestLanguage.Te => "te",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LightningV31RequestLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bn" => LightningV31RequestLanguage.Bn,
                "en" => LightningV31RequestLanguage.En,
                "es" => LightningV31RequestLanguage.Es,
                "gu" => LightningV31RequestLanguage.Gu,
                "hi" => LightningV31RequestLanguage.Hi,
                "kn" => LightningV31RequestLanguage.Kn,
                "ml" => LightningV31RequestLanguage.Ml,
                "mr" => LightningV31RequestLanguage.Mr,
                "or" => LightningV31RequestLanguage.Or,
                "pa" => LightningV31RequestLanguage.Pa,
                "ta" => LightningV31RequestLanguage.Ta,
                "te" => LightningV31RequestLanguage.Te,
                _ => null,
            };
        }
    }
}