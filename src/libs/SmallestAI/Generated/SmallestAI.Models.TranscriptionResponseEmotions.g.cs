
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Detected emotion labels mapped to confidence scores. Present when `emotion_detection=true` was set on the request.
    /// </summary>
    public sealed partial class TranscriptionResponseEmotions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}