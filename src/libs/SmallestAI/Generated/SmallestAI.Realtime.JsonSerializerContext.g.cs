
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace SmallestAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveModelJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveModelNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveEncodingJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveEncodingNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveWordTimestampsJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveWordTimestampsNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveDiarizeJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveDiarizeNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveSentenceTimestampsJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveSentenceTimestampsNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveFullTranscriptJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveFullTranscriptNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLivePunctuateJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLivePunctuateNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveCapitalizeJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveCapitalizeNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveFormatJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveFormatNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveItnNormalizeJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveItnNormalizeNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveRedactPiiJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveRedactPiiNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveRedactPciJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveRedactPciNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveEmotionDetectionJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveEmotionDetectionNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveGenderDetectionJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveGenderDetectionNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveNumeralsJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveNumeralsNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveEndpointingJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveEndpointingNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveFinalizeOnWordsJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttLiveFinalizeOnWordsNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttFinalizeRequestTypeJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttFinalizeRequestTypeNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttCloseStreamRequestTypeJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.SttCloseStreamRequestTypeNullableJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.TtsLiveEventStatusJsonConverter),

            typeof(global::SmallestAI.Realtime.JsonConverters.TtsLiveEventStatusNullableJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveModel), TypeInfoPropertyName = "SttLiveModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveEncoding), TypeInfoPropertyName = "SttLiveEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveWordTimestamps), TypeInfoPropertyName = "SttLiveWordTimestamps2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveDiarize), TypeInfoPropertyName = "SttLiveDiarize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveSentenceTimestamps), TypeInfoPropertyName = "SttLiveSentenceTimestamps2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveFullTranscript), TypeInfoPropertyName = "SttLiveFullTranscript2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLivePunctuate), TypeInfoPropertyName = "SttLivePunctuate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveCapitalize), TypeInfoPropertyName = "SttLiveCapitalize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveFormat), TypeInfoPropertyName = "SttLiveFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveItnNormalize), TypeInfoPropertyName = "SttLiveItnNormalize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveRedactPii), TypeInfoPropertyName = "SttLiveRedactPii2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveRedactPci), TypeInfoPropertyName = "SttLiveRedactPci2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveEmotionDetection), TypeInfoPropertyName = "SttLiveEmotionDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveGenderDetection), TypeInfoPropertyName = "SttLiveGenderDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveNumerals), TypeInfoPropertyName = "SttLiveNumerals2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveEndpointing), TypeInfoPropertyName = "SttLiveEndpointing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttLiveFinalizeOnWords), TypeInfoPropertyName = "SttLiveFinalizeOnWords2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttTranscriptionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.Realtime.SttWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.Realtime.SttUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttFinalizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttFinalizeRequestType), TypeInfoPropertyName = "SttFinalizeRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttCloseStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.SttCloseStreamRequestType), TypeInfoPropertyName = "SttCloseStreamRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.TtsSynthesizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.TtsLiveEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.TtsLiveEventStatus), TypeInfoPropertyName = "TtsLiveEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Realtime.TtsLiveEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.Realtime.SttWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.Realtime.SttUtterance>))]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}