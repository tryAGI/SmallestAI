
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace SmallestAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.CreateAccessTokenRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.AccessTokenResponseTokenType? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.AccessTokenResponse? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ValidationErrorResponseStatus? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ValidationErrorResponseErrorsItems? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ValidationErrorResponse? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.ValidationErrorResponseErrorsItems>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.SimpleErrorResponse? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1TtsPostParametersAccept? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1TtsPostParametersXExpireContent? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TtsRequestModel? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TtsRequestSampleRate? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TtsRequestLanguage? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TtsRequestNumberPronunciationLanguage? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TtsRequestOutputFormat? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TtsRequest? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TtsError? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1TtsLivePostParametersXExpireContent? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1ModelGetVoicesGetParametersModel? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItemsTags? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItems? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.VoicesGetWavesVoicesResponse200? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItems>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.GetWavesVoicesRequestBadRequestError? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.GetWavesVoicesRequestUnauthorizedError? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.GetWavesVoicesRequestInternalServerError? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaData? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.VoiceCloningCreateVoiceCloneResponse200? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.CreateVoiceCloneRequestBadRequestError? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.CreateVoiceCloneRequestUnauthorizedError? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.CreateVoiceCloneRequestInternalServerError? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItems? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.VoiceCloningListVoiceClonesResponse200? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItems>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.PronunciationItem? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.PronunciationDict? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.PronunciationItem>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ErrorResponseDetailsItems? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ErrorResponse? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.ErrorResponseDetailsItems>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.CreatePronunciationDictRequest? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.UpdatePronunciationDictRequest? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.UpdatePronunciationDictResponse? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.DeletePronunciationDictRequest? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.DeletePronunciationDictResponse? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersModel? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersLanguage? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersWebhookMethod? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersRedactPii? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersRedactPci? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersEmotionDetection? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersGenderDetection? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersXExpireContent? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Word? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Utterance? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TranscriptionResponseMetadata? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TranscriptionResponse? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.Word>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.Utterance>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.AsyncAccepted? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.SpeechToTextTranscribeResponse200? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.SttErrorResponseDetailsItems? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.SttErrorResponse? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.SttErrorResponseDetailsItems>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ElectronToolCallType? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ElectronToolCallFunction? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ElectronToolCall? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ElectronMessage? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.ElectronToolCall>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestStreamOptions? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestToolChoice0? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestToolChoiceOneOf1Type? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestToolChoiceOneOf1Function? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestToolChoice1? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestToolChoice? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestResponseFormatType? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestResponseFormat? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestStop? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.ElectronMessage>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionObject? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionChoicesItemsFinishReason? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionChoicesItems? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.UsagePromptTokensDetails? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Usage? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletion? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.ChatCompletionChoicesItems>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ErrorErrorDetailsItems? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ErrorError? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.ErrorErrorDetailsItems>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Error? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TranscriptionUrlRequest? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.CreateVoiceCloneRequest? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.PronunciationDict>? Type111 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.ValidationErrorResponseErrorsItems>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItems>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItems>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.PronunciationItem>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.ErrorResponseDetailsItems>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.Word>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.Utterance>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.SttErrorResponseDetailsItems>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.ElectronToolCall>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.ElectronMessage>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.ChatCompletionChoicesItems>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.ErrorErrorDetailsItems>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.PronunciationDict>? ListType15 { get; set; }
    }
}