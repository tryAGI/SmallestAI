
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Control frame that ends the session.
    /// </summary>
    public sealed partial class SttCloseStreamRequest
    {
        /// <summary>
        /// Message type identifier.<br/>
        /// Default Value: close_stream
        /// </summary>
        /// <default>global::SmallestAI.Realtime.SttCloseStreamRequestType.CloseStream</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.Realtime.JsonConverters.SttCloseStreamRequestTypeJsonConverter))]
        public global::SmallestAI.Realtime.SttCloseStreamRequestType Type { get; set; } = global::SmallestAI.Realtime.SttCloseStreamRequestType.CloseStream;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttCloseStreamRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier.<br/>
        /// Default Value: close_stream
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttCloseStreamRequest(
            global::SmallestAI.Realtime.SttCloseStreamRequestType type = global::SmallestAI.Realtime.SttCloseStreamRequestType.CloseStream)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttCloseStreamRequest" /> class.
        /// </summary>
        public SttCloseStreamRequest()
        {
        }

    }
}