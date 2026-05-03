#nullable enable

namespace SmallestAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel>
    {
        /// <inheritdoc />
        public override global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel Read(
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
                        return global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModelExtensions.ToValueString(value));
        }
    }
}
