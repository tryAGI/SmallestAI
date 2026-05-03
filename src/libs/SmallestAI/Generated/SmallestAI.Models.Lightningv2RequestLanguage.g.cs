
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Determines how numbers are spelled out. If set to 'en', numbers will be read as individual digits in English. If set to 'hi', numbers will be read as individual digits in Hindi.<br/>
    /// Default Value: en
    /// </summary>
    public enum Lightningv2RequestLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Bn,
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
        Gu,
        /// <summary>
        /// 
        /// </summary>
        He,
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
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Pl,
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
        /// 
        /// </summary>
        Te,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Lightningv2RequestLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Lightningv2RequestLanguage value)
        {
            return value switch
            {
                Lightningv2RequestLanguage.Ar => "ar",
                Lightningv2RequestLanguage.Bn => "bn",
                Lightningv2RequestLanguage.De => "de",
                Lightningv2RequestLanguage.En => "en",
                Lightningv2RequestLanguage.Es => "es",
                Lightningv2RequestLanguage.Fr => "fr",
                Lightningv2RequestLanguage.Gu => "gu",
                Lightningv2RequestLanguage.He => "he",
                Lightningv2RequestLanguage.Hi => "hi",
                Lightningv2RequestLanguage.It => "it",
                Lightningv2RequestLanguage.Kn => "kn",
                Lightningv2RequestLanguage.Ml => "ml",
                Lightningv2RequestLanguage.Mr => "mr",
                Lightningv2RequestLanguage.Nl => "nl",
                Lightningv2RequestLanguage.Pl => "pl",
                Lightningv2RequestLanguage.Ru => "ru",
                Lightningv2RequestLanguage.Sv => "sv",
                Lightningv2RequestLanguage.Ta => "ta",
                Lightningv2RequestLanguage.Te => "te",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Lightningv2RequestLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => Lightningv2RequestLanguage.Ar,
                "bn" => Lightningv2RequestLanguage.Bn,
                "de" => Lightningv2RequestLanguage.De,
                "en" => Lightningv2RequestLanguage.En,
                "es" => Lightningv2RequestLanguage.Es,
                "fr" => Lightningv2RequestLanguage.Fr,
                "gu" => Lightningv2RequestLanguage.Gu,
                "he" => Lightningv2RequestLanguage.He,
                "hi" => Lightningv2RequestLanguage.Hi,
                "it" => Lightningv2RequestLanguage.It,
                "kn" => Lightningv2RequestLanguage.Kn,
                "ml" => Lightningv2RequestLanguage.Ml,
                "mr" => Lightningv2RequestLanguage.Mr,
                "nl" => Lightningv2RequestLanguage.Nl,
                "pl" => Lightningv2RequestLanguage.Pl,
                "ru" => Lightningv2RequestLanguage.Ru,
                "sv" => Lightningv2RequestLanguage.Sv,
                "ta" => Lightningv2RequestLanguage.Ta,
                "te" => Lightningv2RequestLanguage.Te,
                _ => null,
            };
        }
    }
}