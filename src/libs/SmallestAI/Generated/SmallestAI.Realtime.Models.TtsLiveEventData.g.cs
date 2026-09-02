
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Frame payload. `audio` is populated on `chunk` frames; `id`, `word`,<br/>
    /// `start` and `end` on `word_timestamp` frames.
    /// </summary>
    public sealed partial class TtsLiveEventData
    {
        /// <summary>
        /// Base64-encoded audio chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// Zero-indexed position of the word in the input text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The word, verbatim and un-normalized, as it appeared in the input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        public string? Word { get; set; }

        /// <summary>
        /// Start offset in seconds within the synthesized audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// End offset in seconds within the synthesized audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsLiveEventData" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded audio chunk.
        /// </param>
        /// <param name="id">
        /// Zero-indexed position of the word in the input text.
        /// </param>
        /// <param name="word">
        /// The word, verbatim and un-normalized, as it appeared in the input.
        /// </param>
        /// <param name="start">
        /// Start offset in seconds within the synthesized audio.
        /// </param>
        /// <param name="end">
        /// End offset in seconds within the synthesized audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsLiveEventData(
            string? audio,
            int? id,
            string? word,
            double? start,
            double? end)
        {
            this.Audio = audio;
            this.Id = id;
            this.Word = word;
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsLiveEventData" /> class.
        /// </summary>
        public TtsLiveEventData()
        {
        }

    }
}