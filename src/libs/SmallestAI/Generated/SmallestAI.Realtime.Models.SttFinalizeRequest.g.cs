
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Control frame that flushes the current utterance.
    /// </summary>
    public sealed partial class SttFinalizeRequest
    {
        /// <summary>
        /// Message type identifier.<br/>
        /// Default Value: finalize
        /// </summary>
        /// <default>global::SmallestAI.Realtime.SttFinalizeRequestType.Finalize</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.Realtime.JsonConverters.SttFinalizeRequestTypeJsonConverter))]
        public global::SmallestAI.Realtime.SttFinalizeRequestType Type { get; set; } = global::SmallestAI.Realtime.SttFinalizeRequestType.Finalize;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttFinalizeRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier.<br/>
        /// Default Value: finalize
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttFinalizeRequest(
            global::SmallestAI.Realtime.SttFinalizeRequestType type = global::SmallestAI.Realtime.SttFinalizeRequestType.Finalize)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttFinalizeRequest" /> class.
        /// </summary>
        public SttFinalizeRequest()
        {
        }

    }
}