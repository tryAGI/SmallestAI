#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageLlmClient
    {
        /// <summary>
        /// Chat Completions (Electron)<br/>
        /// Generate a chat completion with Electron. OpenAI-compatible<br/>
        /// request/response shape — point any OpenAI SDK at<br/>
        /// `https://api.smallest.ai/waves/v1` and it just works.<br/>
        /// Set `stream: true` to receive tokens via Server-Sent Events. With<br/>
        /// `stream_options: { include_usage: true }`, the final SSE chunk<br/>
        /// carries the `usage` block so token accounting is exact even on<br/>
        /// client disconnects.<br/>
        /// Tool calling follows OpenAI's `tools` array convention. When you<br/>
        /// provide a voice-agent-style system prompt, Electron emits a short<br/>
        /// filler phrase in the assistant message `content` field alongside<br/>
        /// `tool_calls` — see the [Tool Calling guide](/waves/documentation/llm-electron/tool-function-calling)<br/>
        /// for the voice-agent pattern.<br/>
        /// ## Examples<br/>
        /// **cURL**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/chat/completions" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "model": "electron",<br/>
        ///     "messages": [<br/>
        ///       {"role": "user", "content": "Write one sentence about why the sky is blue."}<br/>
        ///     ]<br/>
        ///   }'<br/>
        /// ```<br/>
        /// **Python** (`pip install openai`)<br/>
        /// ```python<br/>
        /// import os<br/>
        /// from openai import OpenAI<br/>
        /// client = OpenAI(<br/>
        ///     base_url="https://api.smallest.ai/waves/v1",<br/>
        ///     api_key=os.environ["SMALLEST_API_KEY"],<br/>
        /// )<br/>
        /// response = client.chat.completions.create(<br/>
        ///     model="electron",<br/>
        ///     messages=[<br/>
        ///         {"role": "user", "content": "Write one sentence about why the sky is blue."}<br/>
        ///     ],<br/>
        /// )<br/>
        /// print(response.choices[0].message.content)<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript** (`npm install openai`)<br/>
        /// ```typescript<br/>
        /// import OpenAI from "openai";<br/>
        /// const client = new OpenAI({<br/>
        ///   baseURL: "https://api.smallest.ai/waves/v1",<br/>
        ///   apiKey: process.env.SMALLEST_API_KEY,<br/>
        /// });<br/>
        /// const response = await client.chat.completions.create({<br/>
        ///   model: "electron",<br/>
        ///   messages: [<br/>
        ///     { role: "user", content: "Write one sentence about why the sky is blue." },<br/>
        ///   ],<br/>
        /// });<br/>
        /// console.log(response.choices[0].message.content);<br/>
        /// ```<br/>
        /// **Streaming with usage** (Python)<br/>
        /// ```python<br/>
        /// stream = client.chat.completions.create(<br/>
        ///     model="electron",<br/>
        ///     messages=[{"role": "user", "content": "Tell me a one-sentence fun fact."}],<br/>
        ///     stream=True,<br/>
        ///     stream_options={"include_usage": True},<br/>
        /// )<br/>
        /// for chunk in stream:<br/>
        ///     if chunk.choices and chunk.choices[0].delta.content:<br/>
        ///         print(chunk.choices[0].delta.content, end="", flush=True)<br/>
        ///     if chunk.usage:<br/>
        ///         print(f"\n\nTokens: {chunk.usage.total_tokens}")<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Base URL is `/waves/v1`**, not `/v1`. The OpenAI SDK appends `/chat/completions` for you.<br/>
        /// - **`stream_options.include_usage: true`** is required for exact token accounting on streaming calls — the final SSE chunk carries the `usage` block.<br/>
        /// - **`n &gt; 1` and `prompt_logprobs` are rejected.** Use multiple requests if you need parallel completions.<br/>
        /// - **Auth header is `Authorization: Bearer $SMALLEST_API_KEY`** — get the key from the [Smallest AI Console](https://app.smallest.ai/dashboard/api-keys).
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
        /// request/response shape — point any OpenAI SDK at<br/>
        /// `https://api.smallest.ai/waves/v1` and it just works.<br/>
        /// Set `stream: true` to receive tokens via Server-Sent Events. With<br/>
        /// `stream_options: { include_usage: true }`, the final SSE chunk<br/>
        /// carries the `usage` block so token accounting is exact even on<br/>
        /// client disconnects.<br/>
        /// Tool calling follows OpenAI's `tools` array convention. When you<br/>
        /// provide a voice-agent-style system prompt, Electron emits a short<br/>
        /// filler phrase in the assistant message `content` field alongside<br/>
        /// `tool_calls` — see the [Tool Calling guide](/waves/documentation/llm-electron/tool-function-calling)<br/>
        /// for the voice-agent pattern.<br/>
        /// ## Examples<br/>
        /// **cURL**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/chat/completions" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "model": "electron",<br/>
        ///     "messages": [<br/>
        ///       {"role": "user", "content": "Write one sentence about why the sky is blue."}<br/>
        ///     ]<br/>
        ///   }'<br/>
        /// ```<br/>
        /// **Python** (`pip install openai`)<br/>
        /// ```python<br/>
        /// import os<br/>
        /// from openai import OpenAI<br/>
        /// client = OpenAI(<br/>
        ///     base_url="https://api.smallest.ai/waves/v1",<br/>
        ///     api_key=os.environ["SMALLEST_API_KEY"],<br/>
        /// )<br/>
        /// response = client.chat.completions.create(<br/>
        ///     model="electron",<br/>
        ///     messages=[<br/>
        ///         {"role": "user", "content": "Write one sentence about why the sky is blue."}<br/>
        ///     ],<br/>
        /// )<br/>
        /// print(response.choices[0].message.content)<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript** (`npm install openai`)<br/>
        /// ```typescript<br/>
        /// import OpenAI from "openai";<br/>
        /// const client = new OpenAI({<br/>
        ///   baseURL: "https://api.smallest.ai/waves/v1",<br/>
        ///   apiKey: process.env.SMALLEST_API_KEY,<br/>
        /// });<br/>
        /// const response = await client.chat.completions.create({<br/>
        ///   model: "electron",<br/>
        ///   messages: [<br/>
        ///     { role: "user", content: "Write one sentence about why the sky is blue." },<br/>
        ///   ],<br/>
        /// });<br/>
        /// console.log(response.choices[0].message.content);<br/>
        /// ```<br/>
        /// **Streaming with usage** (Python)<br/>
        /// ```python<br/>
        /// stream = client.chat.completions.create(<br/>
        ///     model="electron",<br/>
        ///     messages=[{"role": "user", "content": "Tell me a one-sentence fun fact."}],<br/>
        ///     stream=True,<br/>
        ///     stream_options={"include_usage": True},<br/>
        /// )<br/>
        /// for chunk in stream:<br/>
        ///     if chunk.choices and chunk.choices[0].delta.content:<br/>
        ///         print(chunk.choices[0].delta.content, end="", flush=True)<br/>
        ///     if chunk.usage:<br/>
        ///         print(f"\n\nTokens: {chunk.usage.total_tokens}")<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Base URL is `/waves/v1`**, not `/v1`. The OpenAI SDK appends `/chat/completions` for you.<br/>
        /// - **`stream_options.include_usage: true`** is required for exact token accounting on streaming calls — the final SSE chunk carries the `usage` block.<br/>
        /// - **`n &gt; 1` and `prompt_logprobs` are rejected.** Use multiple requests if you need parallel completions.<br/>
        /// - **Auth header is `Authorization: Bearer $SMALLEST_API_KEY`** — get the key from the [Smallest AI Console](https://app.smallest.ai/dashboard/api-keys).
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
        /// request/response shape — point any OpenAI SDK at<br/>
        /// `https://api.smallest.ai/waves/v1` and it just works.<br/>
        /// Set `stream: true` to receive tokens via Server-Sent Events. With<br/>
        /// `stream_options: { include_usage: true }`, the final SSE chunk<br/>
        /// carries the `usage` block so token accounting is exact even on<br/>
        /// client disconnects.<br/>
        /// Tool calling follows OpenAI's `tools` array convention. When you<br/>
        /// provide a voice-agent-style system prompt, Electron emits a short<br/>
        /// filler phrase in the assistant message `content` field alongside<br/>
        /// `tool_calls` — see the [Tool Calling guide](/waves/documentation/llm-electron/tool-function-calling)<br/>
        /// for the voice-agent pattern.<br/>
        /// ## Examples<br/>
        /// **cURL**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/chat/completions" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "model": "electron",<br/>
        ///     "messages": [<br/>
        ///       {"role": "user", "content": "Write one sentence about why the sky is blue."}<br/>
        ///     ]<br/>
        ///   }'<br/>
        /// ```<br/>
        /// **Python** (`pip install openai`)<br/>
        /// ```python<br/>
        /// import os<br/>
        /// from openai import OpenAI<br/>
        /// client = OpenAI(<br/>
        ///     base_url="https://api.smallest.ai/waves/v1",<br/>
        ///     api_key=os.environ["SMALLEST_API_KEY"],<br/>
        /// )<br/>
        /// response = client.chat.completions.create(<br/>
        ///     model="electron",<br/>
        ///     messages=[<br/>
        ///         {"role": "user", "content": "Write one sentence about why the sky is blue."}<br/>
        ///     ],<br/>
        /// )<br/>
        /// print(response.choices[0].message.content)<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript** (`npm install openai`)<br/>
        /// ```typescript<br/>
        /// import OpenAI from "openai";<br/>
        /// const client = new OpenAI({<br/>
        ///   baseURL: "https://api.smallest.ai/waves/v1",<br/>
        ///   apiKey: process.env.SMALLEST_API_KEY,<br/>
        /// });<br/>
        /// const response = await client.chat.completions.create({<br/>
        ///   model: "electron",<br/>
        ///   messages: [<br/>
        ///     { role: "user", content: "Write one sentence about why the sky is blue." },<br/>
        ///   ],<br/>
        /// });<br/>
        /// console.log(response.choices[0].message.content);<br/>
        /// ```<br/>
        /// **Streaming with usage** (Python)<br/>
        /// ```python<br/>
        /// stream = client.chat.completions.create(<br/>
        ///     model="electron",<br/>
        ///     messages=[{"role": "user", "content": "Tell me a one-sentence fun fact."}],<br/>
        ///     stream=True,<br/>
        ///     stream_options={"include_usage": True},<br/>
        /// )<br/>
        /// for chunk in stream:<br/>
        ///     if chunk.choices and chunk.choices[0].delta.content:<br/>
        ///         print(chunk.choices[0].delta.content, end="", flush=True)<br/>
        ///     if chunk.usage:<br/>
        ///         print(f"\n\nTokens: {chunk.usage.total_tokens}")<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Base URL is `/waves/v1`**, not `/v1`. The OpenAI SDK appends `/chat/completions` for you.<br/>
        /// - **`stream_options.include_usage: true`** is required for exact token accounting on streaming calls — the final SSE chunk carries the `usage` block.<br/>
        /// - **`n &gt; 1` and `prompt_logprobs` are rejected.** Use multiple requests if you need parallel completions.<br/>
        /// - **Auth header is `Authorization: Bearer $SMALLEST_API_KEY`** — get the key from the [Smallest AI Console](https://app.smallest.ai/dashboard/api-keys).
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
        /// See [Tool Calling](/waves/documentation/llm-electron/tool-function-calling).
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