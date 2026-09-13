
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1TtsPostParametersAccept), TypeInfoPropertyName = "WavesV1TtsPostParametersAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1TtsPostParametersXExpireContent), TypeInfoPropertyName = "WavesV1TtsPostParametersXExpireContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.TtsRequestModel), TypeInfoPropertyName = "TtsRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.TtsRequestSampleRate), TypeInfoPropertyName = "TtsRequestSampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.TtsRequestLanguage), TypeInfoPropertyName = "TtsRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.TtsRequestNumberPronunciationLanguage), TypeInfoPropertyName = "TtsRequestNumberPronunciationLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.TtsRequestOutputFormat), TypeInfoPropertyName = "TtsRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.TtsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.TtsError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1TtsLivePostParametersXExpireContent), TypeInfoPropertyName = "WavesV1TtsLivePostParametersXExpireContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1TtsPostParametersAccept?), TypeInfoPropertyName = "NullableWavesV1TtsPostParametersAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1TtsPostParametersXExpireContent?), TypeInfoPropertyName = "NullableWavesV1TtsPostParametersXExpireContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.TtsRequestModel?), TypeInfoPropertyName = "NullableTtsRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.TtsRequestSampleRate?), TypeInfoPropertyName = "NullableTtsRequestSampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.TtsRequestLanguage?), TypeInfoPropertyName = "NullableTtsRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.TtsRequestNumberPronunciationLanguage?), TypeInfoPropertyName = "NullableTtsRequestNumberPronunciationLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.TtsRequestOutputFormat?), TypeInfoPropertyName = "NullableTtsRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1TtsLivePostParametersXExpireContent?), TypeInfoPropertyName = "NullableWavesV1TtsLivePostParametersXExpireContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    internal sealed partial class TextToSpeechSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextToSpeechSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TextToSpeechSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TextToSpeechSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::SmallestAI.WavesV1TtsPostParametersAccept)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1TtsPostParametersAccept?)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1TtsPostParametersXExpireContent)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1TtsPostParametersXExpireContent?)

                    || typeToConvert == typeof(global::SmallestAI.TtsRequestModel)

                    || typeToConvert == typeof(global::SmallestAI.TtsRequestModel?)

                    || typeToConvert == typeof(global::SmallestAI.TtsRequestSampleRate)

                    || typeToConvert == typeof(global::SmallestAI.TtsRequestSampleRate?)

                    || typeToConvert == typeof(global::SmallestAI.TtsRequestLanguage)

                    || typeToConvert == typeof(global::SmallestAI.TtsRequestLanguage?)

                    || typeToConvert == typeof(global::SmallestAI.TtsRequestNumberPronunciationLanguage)

                    || typeToConvert == typeof(global::SmallestAI.TtsRequestNumberPronunciationLanguage?)

                    || typeToConvert == typeof(global::SmallestAI.TtsRequestOutputFormat)

                    || typeToConvert == typeof(global::SmallestAI.TtsRequestOutputFormat?)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1TtsLivePostParametersXExpireContent)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1TtsLivePostParametersXExpireContent?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::SmallestAI.WavesV1TtsPostParametersAccept))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1TtsPostParametersAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1TtsPostParametersAccept?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1TtsPostParametersAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1TtsPostParametersXExpireContent))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1TtsPostParametersXExpireContentJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1TtsPostParametersXExpireContent?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1TtsPostParametersXExpireContentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.TtsRequestModel))
                {
                    return new global::SmallestAI.JsonConverters.TtsRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.TtsRequestModel?))
                {
                    return new global::SmallestAI.JsonConverters.TtsRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.TtsRequestSampleRate))
                {
                    return new global::SmallestAI.JsonConverters.TtsRequestSampleRateJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.TtsRequestSampleRate?))
                {
                    return new global::SmallestAI.JsonConverters.TtsRequestSampleRateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.TtsRequestLanguage))
                {
                    return new global::SmallestAI.JsonConverters.TtsRequestLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.TtsRequestLanguage?))
                {
                    return new global::SmallestAI.JsonConverters.TtsRequestLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.TtsRequestNumberPronunciationLanguage))
                {
                    return new global::SmallestAI.JsonConverters.TtsRequestNumberPronunciationLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.TtsRequestNumberPronunciationLanguage?))
                {
                    return new global::SmallestAI.JsonConverters.TtsRequestNumberPronunciationLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.TtsRequestOutputFormat))
                {
                    return new global::SmallestAI.JsonConverters.TtsRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.TtsRequestOutputFormat?))
                {
                    return new global::SmallestAI.JsonConverters.TtsRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1TtsLivePostParametersXExpireContent))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1TtsLivePostParametersXExpireContentJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1TtsLivePostParametersXExpireContent?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1TtsLivePostParametersXExpireContentNullableJsonConverter();
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
                    0 => new TextToSpeechSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}