#nullable enable

namespace SmallestAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode>
    {
        /// <inheritdoc />
        public override global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode Read(
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
                        return global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCodeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCodeExtensions.ToValueString(value));
        }
    }
}
