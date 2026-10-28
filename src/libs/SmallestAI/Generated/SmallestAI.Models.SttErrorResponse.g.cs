
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Error body returned by `POST /waves/v1/stt/`. The shape depends on where the request fails:<br/>
    /// - A request with no `Authorization` header returns `{ "message": "Unauthorized: No tokens provided" }`.<br/>
    /// - Other authentication errors, and plan, credit, and rate-limit errors, return `{ "error": "&lt;message&gt;" }`.<br/>
    /// - Request validation and transcription errors return `{ "status": "error", "message": "&lt;message&gt;" }`, with optional `errors`, `error_code`, `code`, `language`, `region`, and `request_id` fields.<br/>
    /// Read `error` first and fall back to `message`. Branch on the HTTP status and on `error_code` / `code` when present, not on the message text.
    /// </summary>
    public sealed partial class SttErrorResponse
    {
        /// <summary>
        /// Human-readable error message on authentication, plan, credit, and rate-limit errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Set to `error` on validation and transcription errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.SttErrorResponseStatusJsonConverter))]
        public global::SmallestAI.SttErrorResponseStatus? Status { get; set; }

        /// <summary>
        /// Human-readable error message on validation and transcription errors, and on a missing `Authorization` header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Machine-readable error code. Known values: `LANGUAGE_NOT_ENABLED_IN_REGION`, `NO_SPEECH_DETECTED`, `LANGUAGE_DETECTION_LOW_CONFIDENCE`, `DETECTED_LANGUAGE_NOT_SUPPORTED`, `LID_UNAVAILABLE`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// Machine-readable error code on some transcription failures. Known values: `AudioDecodeError`, `NoAudio`, `AudioTooLong`; with `language=auto` also `EmptyBody` and `AudioTooLarge` (400/413, from language detection).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Language code echoed on `LANGUAGE_NOT_ENABLED_IN_REGION` responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Language detected from the audio, on `language=auto` errors that have one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detected_language")]
        public string? DetectedLanguage { get; set; }

        /// <summary>
        /// Confidence of `detected_language`, on `language=auto` errors that have one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_confidence")]
        public double? LanguageConfidence { get; set; }

        /// <summary>
        /// Region that served the request on `LANGUAGE_NOT_ENABLED_IN_REGION` responses (for example `ap-south-1` or `us-west-2`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Correlation ID for support
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Validation detail. On query-parameter failures, an array of entries with the parameter `path` and a `message`. On request-body failures, a string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.SttErrorResponseErrorsJsonConverter))]
        public global::SmallestAI.SttErrorResponseErrors? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttErrorResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Human-readable error message on authentication, plan, credit, and rate-limit errors.
        /// </param>
        /// <param name="status">
        /// Set to `error` on validation and transcription errors.
        /// </param>
        /// <param name="message">
        /// Human-readable error message on validation and transcription errors, and on a missing `Authorization` header.
        /// </param>
        /// <param name="errorCode">
        /// Machine-readable error code. Known values: `LANGUAGE_NOT_ENABLED_IN_REGION`, `NO_SPEECH_DETECTED`, `LANGUAGE_DETECTION_LOW_CONFIDENCE`, `DETECTED_LANGUAGE_NOT_SUPPORTED`, `LID_UNAVAILABLE`.
        /// </param>
        /// <param name="code">
        /// Machine-readable error code on some transcription failures. Known values: `AudioDecodeError`, `NoAudio`, `AudioTooLong`; with `language=auto` also `EmptyBody` and `AudioTooLarge` (400/413, from language detection).
        /// </param>
        /// <param name="language">
        /// Language code echoed on `LANGUAGE_NOT_ENABLED_IN_REGION` responses.
        /// </param>
        /// <param name="detectedLanguage">
        /// Language detected from the audio, on `language=auto` errors that have one.
        /// </param>
        /// <param name="languageConfidence">
        /// Confidence of `detected_language`, on `language=auto` errors that have one.
        /// </param>
        /// <param name="region">
        /// Region that served the request on `LANGUAGE_NOT_ENABLED_IN_REGION` responses (for example `ap-south-1` or `us-west-2`).
        /// </param>
        /// <param name="requestId">
        /// Correlation ID for support
        /// </param>
        /// <param name="errors">
        /// Validation detail. On query-parameter failures, an array of entries with the parameter `path` and a `message`. On request-body failures, a string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttErrorResponse(
            string? error,
            global::SmallestAI.SttErrorResponseStatus? status,
            string? message,
            string? errorCode,
            string? code,
            string? language,
            string? detectedLanguage,
            double? languageConfidence,
            string? region,
            string? requestId,
            global::SmallestAI.SttErrorResponseErrors? errors)
        {
            this.Error = error;
            this.Status = status;
            this.Message = message;
            this.ErrorCode = errorCode;
            this.Code = code;
            this.Language = language;
            this.DetectedLanguage = detectedLanguage;
            this.LanguageConfidence = languageConfidence;
            this.Region = region;
            this.RequestId = requestId;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttErrorResponse" /> class.
        /// </summary>
        public SttErrorResponse()
        {
        }

    }
}