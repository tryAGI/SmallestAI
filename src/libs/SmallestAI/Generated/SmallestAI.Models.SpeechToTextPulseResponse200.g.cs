
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechToTextPulseResponse200
    {
        /// <summary>
        /// Status of the transcription request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The transcribed text from the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public string? Transcription { get; set; }

        /// <summary>
        /// Duration of the audio file in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_length")]
        public double? AudioLength { get; set; }

        /// <summary>
        /// Word-level timestamps in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaWordsItems>? Words { get; set; }

        /// <summary>
        /// List of utterances with start and end times
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        public global::System.Collections.Generic.IList<global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaUtterancesItems>? Utterances { get; set; }

        /// <summary>
        /// Predicted gender of the speaker if requested
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaGenderJsonConverter))]
        public global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaGender? Gender { get; set; }

        /// <summary>
        /// Predicted emotions of the speaker if requested
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotions")]
        public global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaEmotions? Emotions { get; set; }

        /// <summary>
        /// Metadata about the transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextPulseResponse200" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the transcription request
        /// </param>
        /// <param name="transcription">
        /// The transcribed text from the audio file
        /// </param>
        /// <param name="audioLength">
        /// Duration of the audio file in seconds
        /// </param>
        /// <param name="words">
        /// Word-level timestamps in seconds.
        /// </param>
        /// <param name="utterances">
        /// List of utterances with start and end times
        /// </param>
        /// <param name="gender">
        /// Predicted gender of the speaker if requested
        /// </param>
        /// <param name="emotions">
        /// Predicted emotions of the speaker if requested
        /// </param>
        /// <param name="metadata">
        /// Metadata about the transcription
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechToTextPulseResponse200(
            string? status,
            string? transcription,
            double? audioLength,
            global::System.Collections.Generic.IList<global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaWordsItems>? words,
            global::System.Collections.Generic.IList<global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaUtterancesItems>? utterances,
            global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaGender? gender,
            global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaEmotions? emotions,
            global::SmallestAI.WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaMetadata? metadata)
        {
            this.Status = status;
            this.Transcription = transcription;
            this.AudioLength = audioLength;
            this.Words = words;
            this.Utterances = utterances;
            this.Gender = gender;
            this.Emotions = emotions;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextPulseResponse200" /> class.
        /// </summary>
        public SpeechToTextPulseResponse200()
        {
        }

    }
}