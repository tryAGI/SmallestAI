
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
            typeof(global::SmallestAI.JsonConverters.WavesV1LightningV31GetSpeechPostParametersAcceptJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1LightningV31GetSpeechPostParametersAcceptNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.LightningV31RequestSampleRateJsonConverter),

            typeof(global::SmallestAI.JsonConverters.LightningV31RequestSampleRateNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.LightningV31RequestLanguageJsonConverter),

            typeof(global::SmallestAI.JsonConverters.LightningV31RequestLanguageNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.LightningV31RequestOutputFormatJsonConverter),

            typeof(global::SmallestAI.JsonConverters.LightningV31RequestOutputFormatNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.Lightningv2RequestLanguageJsonConverter),

            typeof(global::SmallestAI.JsonConverters.Lightningv2RequestLanguageNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.Lightningv2RequestOutputFormatJsonConverter),

            typeof(global::SmallestAI.JsonConverters.Lightningv2RequestOutputFormatNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostParametersLanguageJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostParametersLanguageNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostParametersEncodingJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostParametersEncodingNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostParametersGenderDetectionJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostParametersGenderDetectionNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostParametersEmotionDetectionJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostParametersEmotionDetectionNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostParametersFormatJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostParametersFormatNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostParametersPunctuateJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostParametersPunctuateNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostParametersCapitalizeJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostParametersCapitalizeNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaGenderJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaGenderNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.ErrorResponseStatusJsonConverter),

            typeof(global::SmallestAI.JsonConverters.ErrorResponseStatusNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1ModelGetVoicesGetParametersModelJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1ModelGetVoicesGetParametersModelNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModelJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModelNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatusJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatusNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCodeJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCodeNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatusJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatusNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningTypeJsonConverter),

            typeof(global::SmallestAI.JsonConverters.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningTypeNullableJsonConverter),

            typeof(global::SmallestAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept), TypeInfoPropertyName = "WavesV1LightningV31GetSpeechPostParametersAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.LightningV31RequestSampleRate), TypeInfoPropertyName = "LightningV31RequestSampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.LightningV31RequestLanguage), TypeInfoPropertyName = "LightningV31RequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.LightningV31RequestOutputFormat), TypeInfoPropertyName = "LightningV31RequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.LightningV31Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.SynthesizeLightningV31SpeechRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.SynthesizeLightningV31SpeechRequestUnauthorizedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.SynthesizeLightningV31SpeechRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.StreamLightningV31SpeechRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.StreamLightningV31SpeechRequestUnauthorizedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.StreamLightningV31SpeechRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Lightningv2RequestLanguage), TypeInfoPropertyName = "Lightningv2RequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Lightningv2RequestOutputFormat), TypeInfoPropertyName = "Lightningv2RequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.Lightningv2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.SynthesizeLightningv2SpeechRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.SynthesizeLightningv2SpeechRequestUnauthorizedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.SynthesizeLightningv2SpeechRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.StreamLightningv2SpeechRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.StreamLightningv2SpeechRequestUnauthorizedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.StreamLightningv2SpeechRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1PulseGetTextPostParametersLanguage), TypeInfoPropertyName = "WavesV1PulseGetTextPostParametersLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1PulseGetTextPostParametersEncoding), TypeInfoPropertyName = "WavesV1PulseGetTextPostParametersEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1PulseGetTextPostParametersGenderDetection), TypeInfoPropertyName = "WavesV1PulseGetTextPostParametersGenderDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1PulseGetTextPostParametersEmotionDetection), TypeInfoPropertyName = "WavesV1PulseGetTextPostParametersEmotionDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1PulseGetTextPostParametersFormat), TypeInfoPropertyName = "WavesV1PulseGetTextPostParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1PulseGetTextPostParametersPunctuate), TypeInfoPropertyName = "WavesV1PulseGetTextPostParametersPunctuate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1PulseGetTextPostParametersCapitalize), TypeInfoPropertyName = "WavesV1PulseGetTextPostParametersCapitalize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaWordsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaUtterancesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaGender), TypeInfoPropertyName = "WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaEmotions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.SpeechToTextPulseResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaUtterancesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ErrorResponseStatus), TypeInfoPropertyName = "ErrorResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1ModelGetVoicesGetParametersModel), TypeInfoPropertyName = "WavesV1ModelGetVoicesGetParametersModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItemsTags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.VoicesGetWavesVoicesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.GetWavesVoicesRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.GetWavesVoicesRequestUnauthorizedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.GetWavesVoicesRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel), TypeInfoPropertyName = "WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus), TypeInfoPropertyName = "WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.VoiceCloningDeleteVoiceCloneResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.DeleteVoiceCloneRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.DeleteVoiceCloneRequestUnauthorizedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.DeleteVoiceCloneRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1LightningLargeAddVoicePostResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.VoiceCloningAddVoiceToModelResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.AddVoiceToModelRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.AddVoiceToModelRequestUnauthorizedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.AddVoiceToModelRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.WavesV1LightningLargeGetClonedVoicesGetResponsesContentApplicationJsonSchemaVoicesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.VoiceCloningGetClonedVoicesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.WavesV1LightningLargeGetClonedVoicesGetResponsesContentApplicationJsonSchemaVoicesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.GetClonedVoicesRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.GetClonedVoicesRequestUnauthorizedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.GetClonedVoicesRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.PronunciationItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.PronunciationDict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.PronunciationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.CreatePronunciationDictRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.UpdatePronunciationDictRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.UpdatePronunciationDictResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.DeletePronunciationDictRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.DeletePronunciationDictResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.CreateVoiceCloneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.DeleteVoiceCloneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SmallestAI.AddVoiceToModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SmallestAI.PronunciationDict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaUtterancesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.WavesV1LightningLargeGetClonedVoicesGetResponsesContentApplicationJsonSchemaVoicesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.PronunciationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SmallestAI.PronunciationDict>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}