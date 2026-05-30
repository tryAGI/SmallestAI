#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace SmallestAI.JsonConverters
{
    /// <inheritdoc />
    public class SpeechToTextTranscribeResponse200JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SmallestAI.SpeechToTextTranscribeResponse200>
    {
        /// <inheritdoc />
        public override global::SmallestAI.SpeechToTextTranscribeResponse200 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("language")) __score0++;
            if (__jsonProps.Contains("metadata")) __score0++;
            if (__jsonProps.Contains("request_id")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("transcription")) __score0++;
            if (__jsonProps.Contains("utterances")) __score0++;
            if (__jsonProps.Contains("words")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("request_id")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::SmallestAI.TranscriptionResponse? transcriptionResponse = default;
            global::SmallestAI.AsyncAccepted? asyncAccepted = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SmallestAI.TranscriptionResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SmallestAI.TranscriptionResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SmallestAI.TranscriptionResponse).Name}");
                        transcriptionResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SmallestAI.AsyncAccepted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SmallestAI.AsyncAccepted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SmallestAI.AsyncAccepted).Name}");
                        asyncAccepted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (transcriptionResponse == null && asyncAccepted == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SmallestAI.TranscriptionResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SmallestAI.TranscriptionResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SmallestAI.TranscriptionResponse).Name}");
                    transcriptionResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (transcriptionResponse == null && asyncAccepted == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SmallestAI.AsyncAccepted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SmallestAI.AsyncAccepted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SmallestAI.AsyncAccepted).Name}");
                    asyncAccepted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::SmallestAI.SpeechToTextTranscribeResponse200(
                transcriptionResponse,

                asyncAccepted
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SmallestAI.SpeechToTextTranscribeResponse200 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTranscriptionResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SmallestAI.TranscriptionResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SmallestAI.TranscriptionResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SmallestAI.TranscriptionResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionResponse!, typeInfo);
            }
            else if (value.IsAsyncAccepted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SmallestAI.AsyncAccepted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SmallestAI.AsyncAccepted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SmallestAI.AsyncAccepted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AsyncAccepted!, typeInfo);
            }
        }
    }
}