#nullable enable

namespace SmallestAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class Lightningv2RequestOutputFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SmallestAI.Lightningv2RequestOutputFormat?>
    {
        /// <inheritdoc />
        public override global::SmallestAI.Lightningv2RequestOutputFormat? Read(
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
                        return global::SmallestAI.Lightningv2RequestOutputFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::SmallestAI.Lightningv2RequestOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::SmallestAI.Lightningv2RequestOutputFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SmallestAI.Lightningv2RequestOutputFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::SmallestAI.Lightningv2RequestOutputFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
