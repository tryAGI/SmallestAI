#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace SmallestAI.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionRequestToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SmallestAI.ChatCompletionRequestToolChoice>
    {
        /// <inheritdoc />
        public override global::SmallestAI.ChatCompletionRequestToolChoice Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            var __score1 = 0;
            if (__jsonProps.Contains("function")) __score1++;
            if (__jsonProps.Contains("function.name")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::SmallestAI.ChatCompletionRequestToolChoice0? chatCompletionRequestToolChoice0 = default;
            global::SmallestAI.ChatCompletionRequestToolChoice1? chatCompletionRequestToolChoice1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SmallestAI.ChatCompletionRequestToolChoice0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SmallestAI.ChatCompletionRequestToolChoice0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SmallestAI.ChatCompletionRequestToolChoice0).Name}");
                        chatCompletionRequestToolChoice0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SmallestAI.ChatCompletionRequestToolChoice1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SmallestAI.ChatCompletionRequestToolChoice1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SmallestAI.ChatCompletionRequestToolChoice1).Name}");
                        chatCompletionRequestToolChoice1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatCompletionRequestToolChoice0 == null && chatCompletionRequestToolChoice1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SmallestAI.ChatCompletionRequestToolChoice0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SmallestAI.ChatCompletionRequestToolChoice0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SmallestAI.ChatCompletionRequestToolChoice0).Name}");
                    chatCompletionRequestToolChoice0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chatCompletionRequestToolChoice0 == null && chatCompletionRequestToolChoice1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SmallestAI.ChatCompletionRequestToolChoice1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SmallestAI.ChatCompletionRequestToolChoice1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SmallestAI.ChatCompletionRequestToolChoice1).Name}");
                    chatCompletionRequestToolChoice1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::SmallestAI.ChatCompletionRequestToolChoice(
                chatCompletionRequestToolChoice0,

                chatCompletionRequestToolChoice1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SmallestAI.ChatCompletionRequestToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChatCompletionRequestToolChoice0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SmallestAI.ChatCompletionRequestToolChoice0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SmallestAI.ChatCompletionRequestToolChoice0> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SmallestAI.ChatCompletionRequestToolChoice0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatCompletionRequestToolChoice0!.Value, typeInfo);
            }
            else if (value.IsChatCompletionRequestToolChoice1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SmallestAI.ChatCompletionRequestToolChoice1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SmallestAI.ChatCompletionRequestToolChoice1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SmallestAI.ChatCompletionRequestToolChoice1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatCompletionRequestToolChoice1!, typeInfo);
            }
        }
    }
}