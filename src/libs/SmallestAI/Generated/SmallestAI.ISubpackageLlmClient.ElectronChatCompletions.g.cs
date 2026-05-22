#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageLlmClient
    {
        /// <summary>
        /// Chat Completions (Electron)<br/>
        /// Generate a chat completion with Electron. OpenAI-compatible<br/>
        /// request/response shape.<br/>
        /// Set `stream: true` to receive tokens via Server-Sent Events. With<br/>
        /// `stream_options: { include_usage: true }`, the final SSE chunk<br/>
        /// carries the `usage` block so token accounting is exact even on<br/>
        /// client disconnects.<br/>
        /// Tool calling follows OpenAI's `tools` array convention. When you<br/>
        /// provide a voice-agent-style system prompt, Electron emits a short<br/>
        /// filler phrase in the assistant message `content` field alongside<br/>
        /// `tool_calls` — see the [Tool Calling guide](/waves/documentation/llm-electron/tool-calling)<br/>
        /// for the voice-agent pattern.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.ChatCompletion> ElectronChatCompletionsAsync(

            global::SmallestAI.ChatCompletionRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat Completions (Electron)<br/>
        /// Generate a chat completion with Electron. OpenAI-compatible<br/>
        /// request/response shape.<br/>
        /// Set `stream: true` to receive tokens via Server-Sent Events. With<br/>
        /// `stream_options: { include_usage: true }`, the final SSE chunk<br/>
        /// carries the `usage` block so token accounting is exact even on<br/>
        /// client disconnects.<br/>
        /// Tool calling follows OpenAI's `tools` array convention. When you<br/>
        /// provide a voice-agent-style system prompt, Electron emits a short<br/>
        /// filler phrase in the assistant message `content` field alongside<br/>
        /// `tool_calls` — see the [Tool Calling guide](/waves/documentation/llm-electron/tool-calling)<br/>
        /// for the voice-agent pattern.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.ChatCompletion>> ElectronChatCompletionsAsResponseAsync(

            global::SmallestAI.ChatCompletionRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat Completions (Electron)<br/>
        /// Generate a chat completion with Electron. OpenAI-compatible<br/>
        /// request/response shape.<br/>
        /// Set `stream: true` to receive tokens via Server-Sent Events. With<br/>
        /// `stream_options: { include_usage: true }`, the final SSE chunk<br/>
        /// carries the `usage` block so token accounting is exact even on<br/>
        /// client disconnects.<br/>
        /// Tool calling follows OpenAI's `tools` array convention. When you<br/>
        /// provide a voice-agent-style system prompt, Electron emits a short<br/>
        /// filler phrase in the assistant message `content` field alongside<br/>
        /// `tool_calls` — see the [Tool Calling guide](/waves/documentation/llm-electron/tool-calling)<br/>
        /// for the voice-agent pattern.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.ChatCompletion> ElectronChatCompletionsAsync(
            string model,
            global::System.Collections.Generic.IList<global::SmallestAI.ElectronMessage> messages,
            double? temperature = default,
            double? topP = default,
            int? maxTokens = default,
            bool? stream = default,
            global::SmallestAI.ChatCompletionRequestStreamOptions? streamOptions = default,
            global::System.Collections.Generic.IList<global::SmallestAI.Tool>? tools = default,
            global::SmallestAI.ChatCompletionRequestToolChoice? toolChoice = default,
            global::SmallestAI.ChatCompletionRequestResponseFormat? responseFormat = default,
            global::SmallestAI.ChatCompletionRequestStop? stop = default,
            int? seed = default,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias = default,
            bool? logprobs = default,
            int? topLogprobs = default,
            double? presencePenalty = default,
            double? frequencyPenalty = default,
            string? user = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}