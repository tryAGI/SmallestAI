
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Tag metadata used to identify the voice's characteristics. Filter on these fields to find voices for a target language, accent, or use case. Fields may be empty on some voices.
    /// </summary>
    public sealed partial class WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItemsTags
    {
        /// <summary>
        /// Languages the voice was trained on (e.g., `["english"]`, `["english", "hindi"]`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public global::System.Collections.Generic.IList<string>? Language { get; set; }

        /// <summary>
        /// Accent of the voice (e.g., `american`, `british`, `indian`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// Gender of the voice (`male` or `female`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// Age range of the voice (e.g., `young`, `middle aged`, `senior`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        public string? Age { get; set; }

        /// <summary>
        /// Emotional ranges the voice supports. May be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotions")]
        public global::System.Collections.Generic.IList<string>? Emotions { get; set; }

        /// <summary>
        /// Recommended use cases for the voice (e.g., `conversational`, `narration`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usecases")]
        public global::System.Collections.Generic.IList<string>? Usecases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItemsTags" /> class.
        /// </summary>
        /// <param name="language">
        /// Languages the voice was trained on (e.g., `["english"]`, `["english", "hindi"]`).
        /// </param>
        /// <param name="accent">
        /// Accent of the voice (e.g., `american`, `british`, `indian`).
        /// </param>
        /// <param name="gender">
        /// Gender of the voice (`male` or `female`).
        /// </param>
        /// <param name="age">
        /// Age range of the voice (e.g., `young`, `middle aged`, `senior`).
        /// </param>
        /// <param name="emotions">
        /// Emotional ranges the voice supports. May be empty.
        /// </param>
        /// <param name="usecases">
        /// Recommended use cases for the voice (e.g., `conversational`, `narration`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItemsTags(
            global::System.Collections.Generic.IList<string>? language,
            string? accent,
            string? gender,
            string? age,
            global::System.Collections.Generic.IList<string>? emotions,
            global::System.Collections.Generic.IList<string>? usecases)
        {
            this.Language = language;
            this.Accent = accent;
            this.Gender = gender;
            this.Age = age;
            this.Emotions = emotions;
            this.Usecases = usecases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItemsTags" /> class.
        /// </summary>
        public WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItemsTags()
        {
        }

    }
}