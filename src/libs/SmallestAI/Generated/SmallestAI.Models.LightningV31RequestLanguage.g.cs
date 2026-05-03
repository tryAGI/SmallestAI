
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Determines how numbers are spelled out. If set to 'en', numbers will be read in English. If set to 'hi', numbers will be read in Hindi.<br/>
    /// Default Value: en
    /// </summary>
    public enum LightningV31RequestLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Hi,
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
                LightningV31RequestLanguage.En => "en",
                LightningV31RequestLanguage.Hi => "hi",
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
                "en" => LightningV31RequestLanguage.En,
                "hi" => LightningV31RequestLanguage.Hi,
                _ => null,
            };
        }
    }
}