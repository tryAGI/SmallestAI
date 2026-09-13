
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace SmallestAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ElectronToolCallType), TypeInfoPropertyName = "ElectronToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ElectronToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ElectronToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ElectronMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.ElectronToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionRequestStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionRequestToolChoice0), TypeInfoPropertyName = "ChatCompletionRequestToolChoice02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionRequestToolChoiceOneOf1Type), TypeInfoPropertyName = "ChatCompletionRequestToolChoiceOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionRequestToolChoiceOneOf1Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionRequestToolChoice1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionRequestToolChoice), TypeInfoPropertyName = "ChatCompletionRequestToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionRequestResponseFormatType), TypeInfoPropertyName = "ChatCompletionRequestResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionRequestResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionRequestStop), TypeInfoPropertyName = "ChatCompletionRequestStop2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.ElectronMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionObject), TypeInfoPropertyName = "ChatCompletionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionChoicesItemsFinishReason), TypeInfoPropertyName = "ChatCompletionChoicesItemsFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionChoicesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.UsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.ChatCompletionChoicesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ErrorErrorDetailsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.ErrorErrorDetailsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ElectronToolCallType?), TypeInfoPropertyName = "NullableElectronToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionRequestToolChoice0?), TypeInfoPropertyName = "NullableChatCompletionRequestToolChoice02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionRequestToolChoiceOneOf1Type?), TypeInfoPropertyName = "NullableChatCompletionRequestToolChoiceOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionRequestToolChoice?), TypeInfoPropertyName = "NullableChatCompletionRequestToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionRequestResponseFormatType?), TypeInfoPropertyName = "NullableChatCompletionRequestResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionRequestStop?), TypeInfoPropertyName = "NullableChatCompletionRequestStop2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionObject?), TypeInfoPropertyName = "NullableChatCompletionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ChatCompletionChoicesItemsFinishReason?), TypeInfoPropertyName = "NullableChatCompletionChoicesItemsFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.ElectronToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.ElectronMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.ChatCompletionChoicesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.ErrorErrorDetailsItems>))]
    internal sealed partial class ElectronSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ElectronSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ElectronSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ElectronSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::SmallestAI.JsonConverters.ChatCompletionRequestToolChoiceJsonConverter());
            options.Converters.Add(new global::SmallestAI.JsonConverters.ChatCompletionRequestStopJsonConverter());
            options.Converters.Add(new global::SmallestAI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::SmallestAI.ElectronToolCallType)

                    || typeToConvert == typeof(global::SmallestAI.ElectronToolCallType?)

                    || typeToConvert == typeof(global::SmallestAI.ChatCompletionRequestToolChoice0)

                    || typeToConvert == typeof(global::SmallestAI.ChatCompletionRequestToolChoice0?)

                    || typeToConvert == typeof(global::SmallestAI.ChatCompletionRequestToolChoiceOneOf1Type)

                    || typeToConvert == typeof(global::SmallestAI.ChatCompletionRequestToolChoiceOneOf1Type?)

                    || typeToConvert == typeof(global::SmallestAI.ChatCompletionRequestResponseFormatType)

                    || typeToConvert == typeof(global::SmallestAI.ChatCompletionRequestResponseFormatType?)

                    || typeToConvert == typeof(global::SmallestAI.ChatCompletionObject)

                    || typeToConvert == typeof(global::SmallestAI.ChatCompletionObject?)

                    || typeToConvert == typeof(global::SmallestAI.ChatCompletionChoicesItemsFinishReason)

                    || typeToConvert == typeof(global::SmallestAI.ChatCompletionChoicesItemsFinishReason?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::SmallestAI.ElectronToolCallType))
                {
                    return new global::SmallestAI.JsonConverters.ElectronToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.ElectronToolCallType?))
                {
                    return new global::SmallestAI.JsonConverters.ElectronToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.ChatCompletionRequestToolChoice0))
                {
                    return new global::SmallestAI.JsonConverters.ChatCompletionRequestToolChoice0JsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.ChatCompletionRequestToolChoice0?))
                {
                    return new global::SmallestAI.JsonConverters.ChatCompletionRequestToolChoice0NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.ChatCompletionRequestToolChoiceOneOf1Type))
                {
                    return new global::SmallestAI.JsonConverters.ChatCompletionRequestToolChoiceOneOf1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.ChatCompletionRequestToolChoiceOneOf1Type?))
                {
                    return new global::SmallestAI.JsonConverters.ChatCompletionRequestToolChoiceOneOf1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.ChatCompletionRequestResponseFormatType))
                {
                    return new global::SmallestAI.JsonConverters.ChatCompletionRequestResponseFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.ChatCompletionRequestResponseFormatType?))
                {
                    return new global::SmallestAI.JsonConverters.ChatCompletionRequestResponseFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.ChatCompletionObject))
                {
                    return new global::SmallestAI.JsonConverters.ChatCompletionObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.ChatCompletionObject?))
                {
                    return new global::SmallestAI.JsonConverters.ChatCompletionObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.ChatCompletionChoicesItemsFinishReason))
                {
                    return new global::SmallestAI.JsonConverters.ChatCompletionChoicesItemsFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.ChatCompletionChoicesItemsFinishReason?))
                {
                    return new global::SmallestAI.JsonConverters.ChatCompletionChoicesItemsFinishReasonNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ElectronSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}