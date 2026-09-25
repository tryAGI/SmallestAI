
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage), TypeInfoPropertyName = "WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel), TypeInfoPropertyName = "WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus), TypeInfoPropertyName = "WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.VoiceCloningCreateVoiceCloneResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.CreateVoiceCloneRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.CreateVoiceCloneRequestUnauthorizedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode), TypeInfoPropertyName = "WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.CreateVoiceCloneRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus), TypeInfoPropertyName = "WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType), TypeInfoPropertyName = "WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.VoiceCloningListVoiceClonesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.CreateVoiceCloneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage?), TypeInfoPropertyName = "NullableWavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel?), TypeInfoPropertyName = "NullableWavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus?), TypeInfoPropertyName = "NullableWavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode?), TypeInfoPropertyName = "NullableWavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus?), TypeInfoPropertyName = "NullableWavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType?), TypeInfoPropertyName = "NullableWavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItems>))]
    internal sealed partial class VoiceCloningSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceCloningSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VoiceCloningSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VoiceCloningSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage?)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel?)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus?)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode?)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus?)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType)

                    || typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModelJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType?))
                {
                    return new global::SmallestAI.JsonConverters.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningTypeNullableJsonConverter();
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
                    0 => new VoiceCloningSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}