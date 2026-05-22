
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Most OpenAI Chat Completions request fields are accepted as<br/>
    /// passthrough. Explicitly rejected: `n &gt; 1`, `prompt_logprobs`.
    /// </summary>
    public sealed partial class ChatCompletionRequest
    {
        /// <summary>
        /// Model ID. Currently only `"electron"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Chat history. Standard OpenAI message array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::SmallestAI.ElectronMessage> Messages { get; set; }

        /// <summary>
        /// Sampling temperature.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Maximum output tokens. Combined input + output context ceiling<br/>
        /// is 32,768.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// When true, response is `text/event-stream`. See the<br/>
        /// [Streaming guide](/waves/documentation/llm-electron/streaming).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::SmallestAI.ChatCompletionRequestStreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// Tool / function calling definitions. Standard OpenAI shape.<br/>
        /// See [Tool Calling](/waves/documentation/llm-electron/tool-calling).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::SmallestAI.Tool>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.ChatCompletionRequestToolChoiceJsonConverter))]
        public global::SmallestAI.ChatCompletionRequestToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Output shape. `{type: "text"}` (default) or `{type: "json_object"}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::SmallestAI.ChatCompletionRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.ChatCompletionRequestStopJsonConverter))]
        public global::SmallestAI.ChatCompletionRequestStop? Stop { get; set; }

        /// <summary>
        /// Best-effort determinism.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, double>? LogitBias { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Opaque end-user identifier. Not interpreted by Electron.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Model ID. Currently only `"electron"`.
        /// </param>
        /// <param name="messages">
        /// Chat history. Standard OpenAI message array.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxTokens">
        /// Maximum output tokens. Combined input + output context ceiling<br/>
        /// is 32,768.
        /// </param>
        /// <param name="stream">
        /// When true, response is `text/event-stream`. See the<br/>
        /// [Streaming guide](/waves/documentation/llm-electron/streaming).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions"></param>
        /// <param name="tools">
        /// Tool / function calling definitions. Standard OpenAI shape.<br/>
        /// See [Tool Calling](/waves/documentation/llm-electron/tool-calling).
        /// </param>
        /// <param name="toolChoice"></param>
        /// <param name="responseFormat">
        /// Output shape. `{type: "text"}` (default) or `{type: "json_object"}`.
        /// </param>
        /// <param name="stop"></param>
        /// <param name="seed">
        /// Best-effort determinism.
        /// </param>
        /// <param name="logitBias"></param>
        /// <param name="logprobs">
        /// Default Value: false
        /// </param>
        /// <param name="topLogprobs"></param>
        /// <param name="presencePenalty">
        /// Default Value: 0
        /// </param>
        /// <param name="frequencyPenalty">
        /// Default Value: 0
        /// </param>
        /// <param name="user">
        /// Opaque end-user identifier. Not interpreted by Electron.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequest(
            string model,
            global::System.Collections.Generic.IList<global::SmallestAI.ElectronMessage> messages,
            double? temperature,
            double? topP,
            int? maxTokens,
            bool? stream,
            global::SmallestAI.ChatCompletionRequestStreamOptions? streamOptions,
            global::System.Collections.Generic.IList<global::SmallestAI.Tool>? tools,
            global::SmallestAI.ChatCompletionRequestToolChoice? toolChoice,
            global::SmallestAI.ChatCompletionRequestResponseFormat? responseFormat,
            global::SmallestAI.ChatCompletionRequestStop? stop,
            int? seed,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias,
            bool? logprobs,
            int? topLogprobs,
            double? presencePenalty,
            double? frequencyPenalty,
            string? user)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Temperature = temperature;
            this.TopP = topP;
            this.MaxTokens = maxTokens;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.ResponseFormat = responseFormat;
            this.Stop = stop;
            this.Seed = seed;
            this.LogitBias = logitBias;
            this.Logprobs = logprobs;
            this.TopLogprobs = topLogprobs;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        public ChatCompletionRequest()
        {
        }

    }
}