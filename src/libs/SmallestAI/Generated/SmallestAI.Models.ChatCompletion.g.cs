
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.ChatCompletionObjectJsonConverter))]
        public global::SmallestAI.ChatCompletionObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::SmallestAI.ChatCompletionChoicesItems>? Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::SmallestAI.Usage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletion" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="created"></param>
        /// <param name="model"></param>
        /// <param name="choices"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletion(
            string? id,
            global::SmallestAI.ChatCompletionObject? @object,
            int? created,
            string? model,
            global::System.Collections.Generic.IList<global::SmallestAI.ChatCompletionChoicesItems>? choices,
            global::SmallestAI.Usage? usage)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Choices = choices;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletion" /> class.
        /// </summary>
        public ChatCompletion()
        {
        }

    }
}