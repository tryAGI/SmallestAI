
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
        Hi,
        /// <summary>
        /// 
        /// </summary>
        Hu,
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
        Mt,
        /// <summary>
        /// 
        /// </summary>
        MultiAsian,
        /// <summary>
        /// 
        /// </summary>
        MultiEu,
        /// <summary>
        /// 
        /// </summary>
        Nl,
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
        Uk,
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
                WavesV1SttPostParametersLanguage.Cs => "cs",
                WavesV1SttPostParametersLanguage.Da => "da",
                WavesV1SttPostParametersLanguage.De => "de",
                WavesV1SttPostParametersLanguage.En => "en",
                WavesV1SttPostParametersLanguage.Es => "es",
                WavesV1SttPostParametersLanguage.Et => "et",
                WavesV1SttPostParametersLanguage.Fi => "fi",
                WavesV1SttPostParametersLanguage.Fr => "fr",
                WavesV1SttPostParametersLanguage.Hi => "hi",
                WavesV1SttPostParametersLanguage.Hu => "hu",
                WavesV1SttPostParametersLanguage.It => "it",
                WavesV1SttPostParametersLanguage.Ja => "ja",
                WavesV1SttPostParametersLanguage.Ko => "ko",
                WavesV1SttPostParametersLanguage.Lt => "lt",
                WavesV1SttPostParametersLanguage.Lv => "lv",
                WavesV1SttPostParametersLanguage.Mt => "mt",
                WavesV1SttPostParametersLanguage.MultiAsian => "multi-asian",
                WavesV1SttPostParametersLanguage.MultiEu => "multi-eu",
                WavesV1SttPostParametersLanguage.Nl => "nl",
                WavesV1SttPostParametersLanguage.Pl => "pl",
                WavesV1SttPostParametersLanguage.Pt => "pt",
                WavesV1SttPostParametersLanguage.Ro => "ro",
                WavesV1SttPostParametersLanguage.Ru => "ru",
                WavesV1SttPostParametersLanguage.Sk => "sk",
                WavesV1SttPostParametersLanguage.Sv => "sv",
                WavesV1SttPostParametersLanguage.Uk => "uk",
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
                "cs" => WavesV1SttPostParametersLanguage.Cs,
                "da" => WavesV1SttPostParametersLanguage.Da,
                "de" => WavesV1SttPostParametersLanguage.De,
                "en" => WavesV1SttPostParametersLanguage.En,
                "es" => WavesV1SttPostParametersLanguage.Es,
                "et" => WavesV1SttPostParametersLanguage.Et,
                "fi" => WavesV1SttPostParametersLanguage.Fi,
                "fr" => WavesV1SttPostParametersLanguage.Fr,
                "hi" => WavesV1SttPostParametersLanguage.Hi,
                "hu" => WavesV1SttPostParametersLanguage.Hu,
                "it" => WavesV1SttPostParametersLanguage.It,
                "ja" => WavesV1SttPostParametersLanguage.Ja,
                "ko" => WavesV1SttPostParametersLanguage.Ko,
                "lt" => WavesV1SttPostParametersLanguage.Lt,
                "lv" => WavesV1SttPostParametersLanguage.Lv,
                "mt" => WavesV1SttPostParametersLanguage.Mt,
                "multi-asian" => WavesV1SttPostParametersLanguage.MultiAsian,
                "multi-eu" => WavesV1SttPostParametersLanguage.MultiEu,
                "nl" => WavesV1SttPostParametersLanguage.Nl,
                "pl" => WavesV1SttPostParametersLanguage.Pl,
                "pt" => WavesV1SttPostParametersLanguage.Pt,
                "ro" => WavesV1SttPostParametersLanguage.Ro,
                "ru" => WavesV1SttPostParametersLanguage.Ru,
                "sk" => WavesV1SttPostParametersLanguage.Sk,
                "sv" => WavesV1SttPostParametersLanguage.Sv,
                "uk" => WavesV1SttPostParametersLanguage.Uk,
                "zh" => WavesV1SttPostParametersLanguage.Zh,
                _ => null,
            };
        }
    }
}