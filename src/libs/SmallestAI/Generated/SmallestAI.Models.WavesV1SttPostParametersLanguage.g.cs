
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WavesV1SttPostParametersLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Bg,
        /// <summary>
        /// 
        /// </summary>
        Bn,
        /// <summary>
        /// 
        /// </summary>
        Cs,
        /// <summary>
        /// 
        /// </summary>
        Da,
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
        Et,
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
        Hu,
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
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lv,
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
        Mt,
        /// <summary>
        /// 
        /// </summary>
        MultiEu,
        /// <summary>
        /// 
        /// </summary>
        MultiIndic,
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
        Ro,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Sk,
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
        /// <summary>
        /// 
        /// </summary>
        Tl,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        Yue,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1SttPostParametersLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1SttPostParametersLanguage value)
        {
            return value switch
            {
                WavesV1SttPostParametersLanguage.Bg => "bg",
                WavesV1SttPostParametersLanguage.Bn => "bn",
                WavesV1SttPostParametersLanguage.Cs => "cs",
                WavesV1SttPostParametersLanguage.Da => "da",
                WavesV1SttPostParametersLanguage.De => "de",
                WavesV1SttPostParametersLanguage.En => "en",
                WavesV1SttPostParametersLanguage.Es => "es",
                WavesV1SttPostParametersLanguage.Et => "et",
                WavesV1SttPostParametersLanguage.Fi => "fi",
                WavesV1SttPostParametersLanguage.Fr => "fr",
                WavesV1SttPostParametersLanguage.Gu => "gu",
                WavesV1SttPostParametersLanguage.Hi => "hi",
                WavesV1SttPostParametersLanguage.Hu => "hu",
                WavesV1SttPostParametersLanguage.Id => "id",
                WavesV1SttPostParametersLanguage.It => "it",
                WavesV1SttPostParametersLanguage.Ja => "ja",
                WavesV1SttPostParametersLanguage.Kn => "kn",
                WavesV1SttPostParametersLanguage.Ko => "ko",
                WavesV1SttPostParametersLanguage.Lt => "lt",
                WavesV1SttPostParametersLanguage.Lv => "lv",
                WavesV1SttPostParametersLanguage.Ml => "ml",
                WavesV1SttPostParametersLanguage.Mr => "mr",
                WavesV1SttPostParametersLanguage.Ms => "ms",
                WavesV1SttPostParametersLanguage.Mt => "mt",
                WavesV1SttPostParametersLanguage.MultiEu => "multi-eu",
                WavesV1SttPostParametersLanguage.MultiIndic => "multi-indic",
                WavesV1SttPostParametersLanguage.Nl => "nl",
                WavesV1SttPostParametersLanguage.Or => "or",
                WavesV1SttPostParametersLanguage.Pa => "pa",
                WavesV1SttPostParametersLanguage.Pl => "pl",
                WavesV1SttPostParametersLanguage.Pt => "pt",
                WavesV1SttPostParametersLanguage.Ro => "ro",
                WavesV1SttPostParametersLanguage.Ru => "ru",
                WavesV1SttPostParametersLanguage.Sk => "sk",
                WavesV1SttPostParametersLanguage.Sv => "sv",
                WavesV1SttPostParametersLanguage.Ta => "ta",
                WavesV1SttPostParametersLanguage.Te => "te",
                WavesV1SttPostParametersLanguage.Tl => "tl",
                WavesV1SttPostParametersLanguage.Uk => "uk",
                WavesV1SttPostParametersLanguage.Yue => "yue",
                WavesV1SttPostParametersLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1SttPostParametersLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => WavesV1SttPostParametersLanguage.Bg,
                "bn" => WavesV1SttPostParametersLanguage.Bn,
                "cs" => WavesV1SttPostParametersLanguage.Cs,
                "da" => WavesV1SttPostParametersLanguage.Da,
                "de" => WavesV1SttPostParametersLanguage.De,
                "en" => WavesV1SttPostParametersLanguage.En,
                "es" => WavesV1SttPostParametersLanguage.Es,
                "et" => WavesV1SttPostParametersLanguage.Et,
                "fi" => WavesV1SttPostParametersLanguage.Fi,
                "fr" => WavesV1SttPostParametersLanguage.Fr,
                "gu" => WavesV1SttPostParametersLanguage.Gu,
                "hi" => WavesV1SttPostParametersLanguage.Hi,
                "hu" => WavesV1SttPostParametersLanguage.Hu,
                "id" => WavesV1SttPostParametersLanguage.Id,
                "it" => WavesV1SttPostParametersLanguage.It,
                "ja" => WavesV1SttPostParametersLanguage.Ja,
                "kn" => WavesV1SttPostParametersLanguage.Kn,
                "ko" => WavesV1SttPostParametersLanguage.Ko,
                "lt" => WavesV1SttPostParametersLanguage.Lt,
                "lv" => WavesV1SttPostParametersLanguage.Lv,
                "ml" => WavesV1SttPostParametersLanguage.Ml,
                "mr" => WavesV1SttPostParametersLanguage.Mr,
                "ms" => WavesV1SttPostParametersLanguage.Ms,
                "mt" => WavesV1SttPostParametersLanguage.Mt,
                "multi-eu" => WavesV1SttPostParametersLanguage.MultiEu,
                "multi-indic" => WavesV1SttPostParametersLanguage.MultiIndic,
                "nl" => WavesV1SttPostParametersLanguage.Nl,
                "or" => WavesV1SttPostParametersLanguage.Or,
                "pa" => WavesV1SttPostParametersLanguage.Pa,
                "pl" => WavesV1SttPostParametersLanguage.Pl,
                "pt" => WavesV1SttPostParametersLanguage.Pt,
                "ro" => WavesV1SttPostParametersLanguage.Ro,
                "ru" => WavesV1SttPostParametersLanguage.Ru,
                "sk" => WavesV1SttPostParametersLanguage.Sk,
                "sv" => WavesV1SttPostParametersLanguage.Sv,
                "ta" => WavesV1SttPostParametersLanguage.Ta,
                "te" => WavesV1SttPostParametersLanguage.Te,
                "tl" => WavesV1SttPostParametersLanguage.Tl,
                "uk" => WavesV1SttPostParametersLanguage.Uk,
                "yue" => WavesV1SttPostParametersLanguage.Yue,
                "zh" => WavesV1SttPostParametersLanguage.Zh,
                _ => null,
            };
        }
    }
}