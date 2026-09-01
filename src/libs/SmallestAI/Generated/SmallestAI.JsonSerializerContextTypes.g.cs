
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
        public global::SmallestAI.WavesV1TtsPostParametersAccept? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1TtsPostParametersXExpireContent? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TtsRequestModel? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TtsRequestSampleRate? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TtsRequestLanguage? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TtsRequestNumberPronunciationLanguage? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TtsRequestOutputFormat? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TtsRequest? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TtsError? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1TtsLivePostParametersXExpireContent? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1ModelGetVoicesGetParametersModel? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItemsTags? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItems? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.VoicesGetWavesVoicesResponse200? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItems>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.GetWavesVoicesRequestBadRequestError? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.GetWavesVoicesRequestUnauthorizedError? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.GetWavesVoicesRequestInternalServerError? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaLanguage? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaData? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.VoiceCloningCreateVoiceCloneResponse200? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.CreateVoiceCloneRequestBadRequestError? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.CreateVoiceCloneRequestUnauthorizedError? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.CreateVoiceCloneRequestInternalServerError? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItems? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.VoiceCloningListVoiceClonesResponse200? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItems>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.PronunciationItem? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.PronunciationDict? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.PronunciationItem>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ErrorResponseDetailsItems? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ErrorResponse? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.ErrorResponseDetailsItems>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.CreatePronunciationDictRequest? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.UpdatePronunciationDictRequest? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.UpdatePronunciationDictResponse? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.DeletePronunciationDictRequest? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.DeletePronunciationDictResponse? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersModel? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersLanguage? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersWebhookMethod? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersRedactPii? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersRedactPci? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersEmotionDetection? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersGenderDetection? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.WavesV1SttPostParametersXExpireContent? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Word? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Utterance? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TranscriptionResponseMetadata? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.TranscriptionResponse? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.Word>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.Utterance>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.AsyncAccepted? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.SpeechToTextTranscribeResponse200? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.SttErrorResponseDetailsItems? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.SttErrorResponse? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.SttErrorResponseDetailsItems>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ElectronToolCallType? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ElectronToolCallFunction? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ElectronToolCall? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ElectronMessage? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.ElectronToolCall>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestStreamOptions? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestToolChoice0? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestToolChoiceOneOf1Type? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestToolChoiceOneOf1Function? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestToolChoice1? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestToolChoice? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestResponseFormatType? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestResponseFormat? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestStop? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionRequest? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.ElectronMessage>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionObject? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionChoicesItemsFinishReason? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletionChoicesItems? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.UsagePromptTokensDetails? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Usage? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ChatCompletion? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.ChatCompletionChoicesItems>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ErrorErrorDetailsItems? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.ErrorError? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.ErrorErrorDetailsItems>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Error? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.CreateVoiceCloneRequest? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.PronunciationDict>? Type102 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItems>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItems>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.PronunciationItem>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.ErrorResponseDetailsItems>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.Word>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.Utterance>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.SttErrorResponseDetailsItems>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.ElectronToolCall>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.ElectronMessage>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.ChatCompletionChoicesItems>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.ErrorErrorDetailsItems>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.PronunciationDict>? ListType14 { get; set; }
    }
}