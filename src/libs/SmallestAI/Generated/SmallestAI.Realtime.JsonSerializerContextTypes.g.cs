
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace SmallestAI.Realtime
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
        public global::SmallestAI.Realtime.SttLiveModel? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLiveEncoding? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLiveWordTimestamps? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLiveDiarize? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLiveSentenceTimestamps? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLiveFullTranscript? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLivePunctuate? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLiveCapitalize? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLiveFormat? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLiveItnNormalize? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLiveRedactPii? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLiveRedactPci? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLiveEmotionDetection? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLiveGenderDetection? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLiveNumerals? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLiveEndpointing? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttLiveFinalizeOnWords? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttTranscriptionEvent? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.Realtime.SttWord>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttWord? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.Realtime.SttUtterance>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttUtterance? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttFinalizeRequest? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttFinalizeRequestType? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttCloseStreamRequest? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.SttCloseStreamRequestType? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.TtsSynthesizeRequest? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.TtsLiveEvent? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.TtsLiveEventStatus? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SmallestAI.Realtime.TtsLiveEventData? Type34 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.Realtime.SttWord>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SmallestAI.Realtime.SttUtterance>? ListType2 { get; set; }
    }
}