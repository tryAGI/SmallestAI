
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersModel), TypeInfoPropertyName = "WavesV1SttPostParametersModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersLanguage), TypeInfoPropertyName = "WavesV1SttPostParametersLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersWebhookMethod), TypeInfoPropertyName = "WavesV1SttPostParametersWebhookMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersRedactPii), TypeInfoPropertyName = "WavesV1SttPostParametersRedactPii2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersRedactPci), TypeInfoPropertyName = "WavesV1SttPostParametersRedactPci2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersEmotionDetection), TypeInfoPropertyName = "WavesV1SttPostParametersEmotionDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersGenderDetection), TypeInfoPropertyName = "WavesV1SttPostParametersGenderDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersXExpireContent), TypeInfoPropertyName = "WavesV1SttPostParametersXExpireContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Word))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Utterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.TranscriptionResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.TranscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.Word>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.Utterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.AsyncAccepted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.SpeechToTextTranscribeResponse200), TypeInfoPropertyName = "SpeechToTextTranscribeResponse2002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.SttErrorResponseDetailsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.SttErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.SttErrorResponseDetailsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.TranscriptionUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersModel?), TypeInfoPropertyName = "NullableWavesV1SttPostParametersModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersLanguage?), TypeInfoPropertyName = "NullableWavesV1SttPostParametersLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersWebhookMethod?), TypeInfoPropertyName = "NullableWavesV1SttPostParametersWebhookMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersRedactPii?), TypeInfoPropertyName = "NullableWavesV1SttPostParametersRedactPii2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersRedactPci?), TypeInfoPropertyName = "NullableWavesV1SttPostParametersRedactPci2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersEmotionDetection?), TypeInfoPropertyName = "NullableWavesV1SttPostParametersEmotionDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersGenderDetection?), TypeInfoPropertyName = "NullableWavesV1SttPostParametersGenderDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1SttPostParametersXExpireContent?), TypeInfoPropertyName = "NullableWavesV1SttPostParametersXExpireContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.SpeechToTextTranscribeResponse200?), TypeInfoPropertyName = "NullableSpeechToTextTranscribeResponse2002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.Word>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.Utterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.SttErrorResponseDetailsItems>))]
    internal sealed partial class SpeechToTextSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeechToTextSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SpeechToTextSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SpeechToTextSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::SmallestAI.JsonConverters.SpeechToTextTranscribeResponse200JsonConverter());
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
                    typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersModel)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersModel?)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersLanguage)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersLanguage?)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersWebhookMethod)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersWebhookMethod?)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersRedactPii)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersRedactPii?)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersRedactPci)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersRedactPci?)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersEmotionDetection)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersEmotionDetection?)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersGenderDetection)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersGenderDetection?)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersXExpireContent)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersXExpireContent?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersModel))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersModelJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersModel?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersLanguage))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersLanguage?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersWebhookMethod))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersWebhookMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersWebhookMethod?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersWebhookMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersRedactPii))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersRedactPiiJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersRedactPii?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersRedactPiiNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersRedactPci))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersRedactPciJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersRedactPci?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersRedactPciNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersEmotionDetection))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersEmotionDetectionJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersEmotionDetection?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersEmotionDetectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersGenderDetection))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersGenderDetectionJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersGenderDetection?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersGenderDetectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersXExpireContent))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersXExpireContentJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1SttPostParametersXExpireContent?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1SttPostParametersXExpireContentNullableJsonConverter();
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
                    0 => new SpeechToTextSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}