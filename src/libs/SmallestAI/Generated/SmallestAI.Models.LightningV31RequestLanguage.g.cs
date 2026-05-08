
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Language code for synthesis. Influences pronunciation, number/date<br/>
    /// normalization, and phoneme selection.<br/>
    /// - **Indian:** `en`, `hi`, `mr` (Marathi), `kn` (Kannada), `ta` (Tamil),<br/>
    ///   `bn` (Bengali), `gu` (Gujarati), `te` (Telugu), `ml` (Malayalam),<br/>
    ///   `pa` (Punjabi), `or` (Odia)<br/>
    /// - **European:** `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `sv` (Swedish),<br/>
    ///   `pt` (Portuguese)<br/>
    /// - **MENA:** `ar` (Arabic), `he` (Hebrew)<br/>
    /// - `auto` — auto-detect from input text (recommended for code-switching)<br/>
    /// Default Value: en
    /// </summary>
    public enum LightningV31RequestLanguage
    {
        /// <summary>
        /// ** `en`, `hi`, `mr` (Marathi), `kn` (Kannada), `ta` (Tamil),
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
        /// ** `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `sv` (Swedish),
        /// </summary>
        De,
        /// <summary>
        /// ** `en`, `hi`, `mr` (Marathi), `kn` (Kannada), `ta` (Tamil),
        /// </summary>
        En,
        /// <summary>
        /// ** `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `sv` (Swedish),
        /// </summary>
        Es,
        /// <summary>
        /// ** `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `sv` (Swedish),
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Gu,
        /// <summary>
        /// ** `ar` (Arabic), `he` (Hebrew)
        /// </summary>
        He,
        /// <summary>
        /// ** `en`, `hi`, `mr` (Marathi), `kn` (Kannada), `ta` (Tamil),
        /// </summary>
        Hi,
        /// <summary>
        /// ** `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `sv` (Swedish),
        /// </summary>
        It,
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
        /// ** `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `sv` (Swedish),
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
        /// ** `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `sv` (Swedish),
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// ** `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `sv` (Swedish),
        /// </summary>
        Ru,
        /// <summary>
        /// ** `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `sv` (Swedish),
        /// </summary>
        Sv,
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
                LightningV31RequestLanguage.Ar => "ar",
                LightningV31RequestLanguage.Auto => "auto",
                LightningV31RequestLanguage.Bn => "bn",
                LightningV31RequestLanguage.De => "de",
                LightningV31RequestLanguage.En => "en",
                LightningV31RequestLanguage.Es => "es",
                LightningV31RequestLanguage.Fr => "fr",
                LightningV31RequestLanguage.Gu => "gu",
                LightningV31RequestLanguage.He => "he",
                LightningV31RequestLanguage.Hi => "hi",
                LightningV31RequestLanguage.It => "it",
                LightningV31RequestLanguage.Kn => "kn",
                LightningV31RequestLanguage.Ml => "ml",
                LightningV31RequestLanguage.Mr => "mr",
                LightningV31RequestLanguage.Nl => "nl",
                LightningV31RequestLanguage.Or => "or",
                LightningV31RequestLanguage.Pa => "pa",
                LightningV31RequestLanguage.Pl => "pl",
                LightningV31RequestLanguage.Pt => "pt",
                LightningV31RequestLanguage.Ru => "ru",
                LightningV31RequestLanguage.Sv => "sv",
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
                "ar" => LightningV31RequestLanguage.Ar,
                "auto" => LightningV31RequestLanguage.Auto,
                "bn" => LightningV31RequestLanguage.Bn,
                "de" => LightningV31RequestLanguage.De,
                "en" => LightningV31RequestLanguage.En,
                "es" => LightningV31RequestLanguage.Es,
                "fr" => LightningV31RequestLanguage.Fr,
                "gu" => LightningV31RequestLanguage.Gu,
                "he" => LightningV31RequestLanguage.He,
                "hi" => LightningV31RequestLanguage.Hi,
                "it" => LightningV31RequestLanguage.It,
                "kn" => LightningV31RequestLanguage.Kn,
                "ml" => LightningV31RequestLanguage.Ml,
                "mr" => LightningV31RequestLanguage.Mr,
                "nl" => LightningV31RequestLanguage.Nl,
                "or" => LightningV31RequestLanguage.Or,
                "pa" => LightningV31RequestLanguage.Pa,
                "pl" => LightningV31RequestLanguage.Pl,
                "pt" => LightningV31RequestLanguage.Pt,
                "ru" => LightningV31RequestLanguage.Ru,
                "sv" => LightningV31RequestLanguage.Sv,
                "ta" => LightningV31RequestLanguage.Ta,
                "te" => LightningV31RequestLanguage.Te,
                _ => null,
            };
        }
    }
}