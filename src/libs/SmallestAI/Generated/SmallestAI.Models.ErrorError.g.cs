
#nullable enable

namespace SmallestAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ErrorError
    {
        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Validation issues, when applicable. Each entry includes the JSON<br/>
        /// path to the offending field plus a short reason. Present on<br/>
        /// schema-validation failures (e.g. `n &gt; 1`, `prompt_logprobs`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::System.Collections.Generic.IList<global::SmallestAI.ErrorErrorDetailsItems>? Details { get; set; }

        /// <summary>
        /// Echo in support tickets so the request can be traced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// The request field at fault, such as `model`, when there is one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// `rate_limit_exceeded` on rate-limit errors, `insufficient_quota`<br/>
        /// when credits run out. Otherwise `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error message.
        /// </param>
        /// <param name="type"></param>
        /// <param name="details">
        /// Validation issues, when applicable. Each entry includes the JSON<br/>
        /// path to the offending field plus a short reason. Present on<br/>
        /// schema-validation failures (e.g. `n &gt; 1`, `prompt_logprobs`).
        /// </param>
        /// <param name="requestId">
        /// Echo in support tickets so the request can be traced.
        /// </param>
        /// <param name="param">
        /// The request field at fault, such as `model`, when there is one.
        /// </param>
        /// <param name="code">
        /// `rate_limit_exceeded` on rate-limit errors, `insufficient_quota`<br/>
        /// when credits run out. Otherwise `null`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorError(
            string? message,
            string? type,
            global::System.Collections.Generic.IList<global::SmallestAI.ErrorErrorDetailsItems>? details,
            string? requestId,
            string? param,
            string? code)
        {
            this.Message = message;
            this.Type = type;
            this.Details = details;
            this.RequestId = requestId;
            this.Param = param;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorError" /> class.
        /// </summary>
        public ErrorError()
        {
        }

    }
}