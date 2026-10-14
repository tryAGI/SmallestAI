
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Optional. Controls how all-numeric dates (e.g. `05/03/2024`) are<br/>
    /// read out, independent of the synthesis voice:<br/>
    /// - `EU` — day/month order (`DD/MM`): `05/03/2024` → "fifth March,<br/>
    ///   twenty twenty four".<br/>
    /// - `US` — month/day order (`MM/DD`): `05/03/2024` → "May third,<br/>
    ///   twenty twenty four".<br/>
    /// Omit this field to keep the existing behaviour: English dates<br/>
    /// default to `US` (`MM/DD`). Applies across all languages, so you can<br/>
    /// force day-first (`DD/MM`) reading — e.g. the Indian convention — on<br/>
    /// any voice.
    /// </summary>
    public enum TtsRequestDateFormat
    {
        /// <summary>
        /// `05/03/2024` → "fifth March,
        /// </summary>
        Eu,
        /// <summary>
        /// `05/03/2024` → "May third,
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsRequestDateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsRequestDateFormat value)
        {
            return value switch
            {
                TtsRequestDateFormat.Eu => "EU",
                TtsRequestDateFormat.Us => "US",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsRequestDateFormat? ToEnum(string value)
        {
            return value switch
            {
                "EU" => TtsRequestDateFormat.Eu,
                "US" => TtsRequestDateFormat.Us,
                _ => null,
            };
        }
    }
}