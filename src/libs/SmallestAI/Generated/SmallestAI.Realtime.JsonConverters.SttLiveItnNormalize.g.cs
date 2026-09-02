#nullable enable

namespace SmallestAI.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class SttLiveItnNormalizeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SmallestAI.Realtime.SttLiveItnNormalize>
    {
        /// <inheritdoc />
        public override global::SmallestAI.Realtime.SttLiveItnNormalize Read(
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
                        return global::SmallestAI.Realtime.SttLiveItnNormalizeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::SmallestAI.Realtime.SttLiveItnNormalize)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::SmallestAI.Realtime.SttLiveItnNormalize);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SmallestAI.Realtime.SttLiveItnNormalize value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::SmallestAI.Realtime.SttLiveItnNormalizeExtensions.ToValueString(value));
        }
    }
}
