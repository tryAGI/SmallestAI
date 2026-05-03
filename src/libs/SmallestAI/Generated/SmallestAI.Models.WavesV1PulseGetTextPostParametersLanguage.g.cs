
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Default Value: multi-eu
    /// </summary>
    public enum WavesV1PulseGetTextPostParametersLanguage
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
        It,
        /// <summary>
        /// 
        /// </summary>
        Kn,
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
        Mt,
        /// <summary>
        /// 
        /// </summary>
        Multi,
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
        Uk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WavesV1PulseGetTextPostParametersLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WavesV1PulseGetTextPostParametersLanguage value)
        {
            return value switch
            {
                WavesV1PulseGetTextPostParametersLanguage.Bg => "bg",
                WavesV1PulseGetTextPostParametersLanguage.Bn => "bn",
                WavesV1PulseGetTextPostParametersLanguage.Cs => "cs",
                WavesV1PulseGetTextPostParametersLanguage.Da => "da",
                WavesV1PulseGetTextPostParametersLanguage.De => "de",
                WavesV1PulseGetTextPostParametersLanguage.En => "en",
                WavesV1PulseGetTextPostParametersLanguage.Es => "es",
                WavesV1PulseGetTextPostParametersLanguage.Et => "et",
                WavesV1PulseGetTextPostParametersLanguage.Fi => "fi",
                WavesV1PulseGetTextPostParametersLanguage.Fr => "fr",
                WavesV1PulseGetTextPostParametersLanguage.Gu => "gu",
                WavesV1PulseGetTextPostParametersLanguage.Hi => "hi",
                WavesV1PulseGetTextPostParametersLanguage.Hu => "hu",
                WavesV1PulseGetTextPostParametersLanguage.It => "it",
                WavesV1PulseGetTextPostParametersLanguage.Kn => "kn",
                WavesV1PulseGetTextPostParametersLanguage.Lt => "lt",
                WavesV1PulseGetTextPostParametersLanguage.Lv => "lv",
                WavesV1PulseGetTextPostParametersLanguage.Ml => "ml",
                WavesV1PulseGetTextPostParametersLanguage.Mr => "mr",
                WavesV1PulseGetTextPostParametersLanguage.Mt => "mt",
                WavesV1PulseGetTextPostParametersLanguage.Multi => "multi",
                WavesV1PulseGetTextPostParametersLanguage.MultiAsian => "multi-asian",
                WavesV1PulseGetTextPostParametersLanguage.MultiEu => "multi-eu",
                WavesV1PulseGetTextPostParametersLanguage.MultiIndic => "multi-indic",
                WavesV1PulseGetTextPostParametersLanguage.Nl => "nl",
                WavesV1PulseGetTextPostParametersLanguage.Or => "or",
                WavesV1PulseGetTextPostParametersLanguage.Pa => "pa",
                WavesV1PulseGetTextPostParametersLanguage.Pl => "pl",
                WavesV1PulseGetTextPostParametersLanguage.Pt => "pt",
                WavesV1PulseGetTextPostParametersLanguage.Ro => "ro",
                WavesV1PulseGetTextPostParametersLanguage.Ru => "ru",
                WavesV1PulseGetTextPostParametersLanguage.Sk => "sk",
                WavesV1PulseGetTextPostParametersLanguage.Sv => "sv",
                WavesV1PulseGetTextPostParametersLanguage.Ta => "ta",
                WavesV1PulseGetTextPostParametersLanguage.Te => "te",
                WavesV1PulseGetTextPostParametersLanguage.Uk => "uk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WavesV1PulseGetTextPostParametersLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg" => WavesV1PulseGetTextPostParametersLanguage.Bg,
                "bn" => WavesV1PulseGetTextPostParametersLanguage.Bn,
                "cs" => WavesV1PulseGetTextPostParametersLanguage.Cs,
                "da" => WavesV1PulseGetTextPostParametersLanguage.Da,
                "de" => WavesV1PulseGetTextPostParametersLanguage.De,
                "en" => WavesV1PulseGetTextPostParametersLanguage.En,
                "es" => WavesV1PulseGetTextPostParametersLanguage.Es,
                "et" => WavesV1PulseGetTextPostParametersLanguage.Et,
                "fi" => WavesV1PulseGetTextPostParametersLanguage.Fi,
                "fr" => WavesV1PulseGetTextPostParametersLanguage.Fr,
                "gu" => WavesV1PulseGetTextPostParametersLanguage.Gu,
                "hi" => WavesV1PulseGetTextPostParametersLanguage.Hi,
                "hu" => WavesV1PulseGetTextPostParametersLanguage.Hu,
                "it" => WavesV1PulseGetTextPostParametersLanguage.It,
                "kn" => WavesV1PulseGetTextPostParametersLanguage.Kn,
                "lt" => WavesV1PulseGetTextPostParametersLanguage.Lt,
                "lv" => WavesV1PulseGetTextPostParametersLanguage.Lv,
                "ml" => WavesV1PulseGetTextPostParametersLanguage.Ml,
                "mr" => WavesV1PulseGetTextPostParametersLanguage.Mr,
                "mt" => WavesV1PulseGetTextPostParametersLanguage.Mt,
                "multi" => WavesV1PulseGetTextPostParametersLanguage.Multi,
                "multi-asian" => WavesV1PulseGetTextPostParametersLanguage.MultiAsian,
                "multi-eu" => WavesV1PulseGetTextPostParametersLanguage.MultiEu,
                "multi-indic" => WavesV1PulseGetTextPostParametersLanguage.MultiIndic,
                "nl" => WavesV1PulseGetTextPostParametersLanguage.Nl,
                "or" => WavesV1PulseGetTextPostParametersLanguage.Or,
                "pa" => WavesV1PulseGetTextPostParametersLanguage.Pa,
                "pl" => WavesV1PulseGetTextPostParametersLanguage.Pl,
                "pt" => WavesV1PulseGetTextPostParametersLanguage.Pt,
                "ro" => WavesV1PulseGetTextPostParametersLanguage.Ro,
                "ru" => WavesV1PulseGetTextPostParametersLanguage.Ru,
                "sk" => WavesV1PulseGetTextPostParametersLanguage.Sk,
                "sv" => WavesV1PulseGetTextPostParametersLanguage.Sv,
                "ta" => WavesV1PulseGetTextPostParametersLanguage.Ta,
                "te" => WavesV1PulseGetTextPostParametersLanguage.Te,
                "uk" => WavesV1PulseGetTextPostParametersLanguage.Uk,
                _ => null,
            };
        }
    }
}