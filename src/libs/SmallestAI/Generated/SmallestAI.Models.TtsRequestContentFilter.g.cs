
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Opt-in profanity filter for the submitted text. Off by default;<br/>
    /// passing this object is the only way to turn it on. The filter<br/>
    /// never rewrites your text — it either lets the request through or<br/>
    /// rejects it before synthesis.<br/>
    /// `action: "reject"` returns HTTP 400 with `error_code:<br/>
    /// "CONTENT_FILTER_BLOCKED"`, the `language` checked and a<br/>
    /// `match_count`; the matched terms are never returned or logged.<br/>
    /// `action: "flag"` synthesizes normally and records the match.<br/>
    /// Matching is whole-word, not substring. If no verdict is returned<br/>
    /// the request fails open and the audio is synthesized unfiltered.<br/>
    /// See [Content filter](/models/text-to-speech/content-filter).
    /// </summary>
    public sealed partial class TtsRequestContentFilter
    {
        /// <summary>
        /// Must be the literal `true` to enable the filter. Any other value leaves it off.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// What happens on a match. `reject` fails the request with HTTP 400; `flag` synthesizes normally and records the match.<br/>
        /// Default Value: reject
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.TtsRequestContentFilterActionJsonConverter))]
        public global::SmallestAI.TtsRequestContentFilterAction? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRequestContentFilter" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Must be the literal `true` to enable the filter. Any other value leaves it off.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="action">
        /// What happens on a match. `reject` fails the request with HTTP 400; `flag` synthesizes normally and records the match.<br/>
        /// Default Value: reject
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsRequestContentFilter(
            bool? enabled,
            global::SmallestAI.TtsRequestContentFilterAction? action)
        {
            this.Enabled = enabled;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRequestContentFilter" /> class.
        /// </summary>
        public TtsRequestContentFilter()
        {
        }

    }
}