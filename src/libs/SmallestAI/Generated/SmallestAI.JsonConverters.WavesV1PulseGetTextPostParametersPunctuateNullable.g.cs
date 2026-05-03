#nullable enable

namespace SmallestAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class WavesV1PulseGetTextPostParametersPunctuateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SmallestAI.WavesV1PulseGetTextPostParametersPunctuate?>
    {
        /// <inheritdoc />
        public override global::SmallestAI.WavesV1PulseGetTextPostParametersPunctuate? Read(
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
                        return global::SmallestAI.WavesV1PulseGetTextPostParametersPunctuateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::SmallestAI.WavesV1PulseGetTextPostParametersPunctuate)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::SmallestAI.WavesV1PulseGetTextPostParametersPunctuate?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SmallestAI.WavesV1PulseGetTextPostParametersPunctuate? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::SmallestAI.WavesV1PulseGetTextPostParametersPunctuateExtensions.ToValueString(value.Value));
            }
        }
    }
}
