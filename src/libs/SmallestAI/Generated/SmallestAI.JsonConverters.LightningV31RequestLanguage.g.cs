#nullable enable

namespace SmallestAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class LightningV31RequestLanguageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SmallestAI.LightningV31RequestLanguage>
    {
        /// <inheritdoc />
        public override global::SmallestAI.LightningV31RequestLanguage Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::SmallestAI.LightningV31RequestLanguageExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::SmallestAI.LightningV31RequestLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::SmallestAI.LightningV31RequestLanguage);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SmallestAI.LightningV31RequestLanguage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::SmallestAI.LightningV31RequestLanguageExtensions.ToValueString(value));
        }
    }
}
