#nullable enable

namespace SmallestAI.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class SttLiveFullTranscriptNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SmallestAI.Realtime.SttLiveFullTranscript?>
    {
        /// <inheritdoc />
        public override global::SmallestAI.Realtime.SttLiveFullTranscript? Read(
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
                        return global::SmallestAI.Realtime.SttLiveFullTranscriptExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::SmallestAI.Realtime.SttLiveFullTranscript)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::SmallestAI.Realtime.SttLiveFullTranscript?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SmallestAI.Realtime.SttLiveFullTranscript? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::SmallestAI.Realtime.SttLiveFullTranscriptExtensions.ToValueString(value.Value));
            }
        }
    }
}
