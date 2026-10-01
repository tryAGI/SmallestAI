
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
        Fr,
        /// <summary>
        ///
        /// </summary>
        Hi,
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
        Pt,
        /// <summary>
        ///
        /// </summary>
        Ru,
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
                WavesV1SttPostParametersLanguage.De => "de",
                WavesV1SttPostParametersLanguage.En => "en",
                WavesV1SttPostParametersLanguage.Es => "es",
                WavesV1SttPostParametersLanguage.Fr => "fr",
                WavesV1SttPostParametersLanguage.Hi => "hi",
                WavesV1SttPostParametersLanguage.It => "it",
                WavesV1SttPostParametersLanguage.Ja => "ja",
                WavesV1SttPostParametersLanguage.Ko => "ko",
                WavesV1SttPostParametersLanguage.MultiAsian => "multi-asian",
                WavesV1SttPostParametersLanguage.MultiEu => "multi-eu",
                WavesV1SttPostParametersLanguage.MultiIndic => "multi-indic",
                WavesV1SttPostParametersLanguage.Nl => "nl",
                WavesV1SttPostParametersLanguage.Pt => "pt",
                WavesV1SttPostParametersLanguage.Ru => "ru",
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
                "de" => WavesV1SttPostParametersLanguage.De,
                "en" => WavesV1SttPostParametersLanguage.En,
                "es" => WavesV1SttPostParametersLanguage.Es,
                "fr" => WavesV1SttPostParametersLanguage.Fr,
                "hi" => WavesV1SttPostParametersLanguage.Hi,
                "it" => WavesV1SttPostParametersLanguage.It,
                "ja" => WavesV1SttPostParametersLanguage.Ja,
                "ko" => WavesV1SttPostParametersLanguage.Ko,
                "multi-asian" => WavesV1SttPostParametersLanguage.MultiAsian,
                "multi-eu" => WavesV1SttPostParametersLanguage.MultiEu,
                "multi-indic" => WavesV1SttPostParametersLanguage.MultiIndic,
                "nl" => WavesV1SttPostParametersLanguage.Nl,
                "pt" => WavesV1SttPostParametersLanguage.Pt,
                "ru" => WavesV1SttPostParametersLanguage.Ru,
                "zh" => WavesV1SttPostParametersLanguage.Zh,
                _ => null,
            };
        }
    }
}