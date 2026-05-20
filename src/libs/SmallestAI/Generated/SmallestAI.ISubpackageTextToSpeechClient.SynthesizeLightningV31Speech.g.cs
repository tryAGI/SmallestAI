#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageTextToSpeechClient
    {
        /// <summary>
        /// Lightning v3.1 (Endpoint Deprecated)<br/>
        /// &lt;Warning&gt;**Endpoint scheduled for retirement.** This URL will stop accepting requests **60 days from the Lightning v3.1 Pro launch (2026-05-15)** — i.e. on **2026-07-14**. The Lightning v3.1 model itself is current and stays. Migrate to [`POST /waves/v1/tts`](/waves/api-reference/api-reference/text-to-speech/synthesize-speech) and select Lightning v3.1 via the `model` body field (default).&lt;/Warning&gt;<br/>
        /// Synthesize speech from text in a single request. The simplest way to get audio when you have the full text up front — pass `text` + `voice_id`, get back binary audio.<br/>
        /// ## When to use this<br/>
        /// - **Use this** for short utterances you can render before playback (notifications, prompts, batch jobs, audio file generation).<br/>
        /// - **Use the SSE streaming endpoint** when you want playback to start before the full audio is ready (long passages, latency-sensitive apps).<br/>
        /// - **Use the WebSocket endpoint** when text arrives incrementally (LLM token streams, live captioning).<br/>
        /// ## Key features<br/>
        /// - 44 kHz natural, expressive synthesis<br/>
        /// - Cloned voice IDs (`voice_*`) work — same param as catalog voices<br/>
        /// - 12 documented languages — see the model card for the full list<br/>
        /// - Output formats: `pcm`, `mp3`, `wav`, `ulaw`, `alaw`<br/>
        /// - Sample rates: 8 kHz – 44.1 kHz<br/>
        /// - Speed: 0.5× – 2×<br/>
        /// - Per-call pronunciation dictionaries via `pronunciation_dicts`<br/>
        /// ## Examples<br/>
        /// **cURL**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/lightning-v3.1/get_speech" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from Lightning v3.1.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **Python** (`pip install smallestai&gt;=4.4.0`)<br/>
        /// ```python<br/>
        /// from smallestai import SmallestAI<br/>
        /// client = SmallestAI(token="YOUR_API_KEY")<br/>
        /// with open("speech.wav", "wb") as f:<br/>
        ///     for chunk in client.waves.synthesize_lightning_v3_1(<br/>
        ///         text="Hello from Lightning v3.1.",<br/>
        ///         voice_id="magnus",<br/>
        ///         sample_rate=24000,<br/>
        ///         output_format="wav",<br/>
        ///         # Optional: cloned voice support<br/>
        ///         # voice_id="voice_FlPKRWI7DX",<br/>
        ///         # Optional: pin pronunciations for specific words<br/>
        ///         # pronunciation_dicts=["&lt;your dict id&gt;"],<br/>
        ///     ):<br/>
        ///         f.write(chunk)<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript** (using `fetch`)<br/>
        /// ```typescript<br/>
        /// const res = await fetch("https://api.smallest.ai/waves/v1/lightning-v3.1/get_speech", {<br/>
        ///   method: "POST",<br/>
        ///   headers: {<br/>
        ///     Authorization: `Bearer ${process.env.SMALLEST_API_KEY}`,<br/>
        ///     "Content-Type": "application/json",<br/>
        ///     Accept: "audio/wav",<br/>
        ///   },<br/>
        ///   body: JSON.stringify({<br/>
        ///     text: "Hello from Lightning v3.1.",<br/>
        ///     voice_id: "magnus",<br/>
        ///     sample_rate: 24000,<br/>
        ///     output_format: "wav",<br/>
        ///   }),<br/>
        /// });<br/>
        /// const audio = Buffer.from(await res.arrayBuffer());<br/>
        /// require("node:fs").writeFileSync("speech.wav", audio);<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Set `Accept: audio/wav`.** Omitting it can return an empty or unplayable response.<br/>
        /// - **Cloned voices** (`voice_*` from `add_voice`) work on this endpoint and support `pronunciation_dicts`.<br/>
        /// - **`pronunciation_dicts` validates IDs at request time.** Passing an unknown ID returns `Invalid input data` — create the dict first via the pronunciation-dicts endpoint and save the returned `id`.<br/>
        /// - **Pronunciation matching is case-sensitive.** Add both `Synopsis` and `synopsis` if your text uses both casings.<br/>
        /// - **44.1 kHz output** is supported but most playback environments are happy with 24 kHz — drop the sample rate if bandwidth matters.<br/>
        /// - **JavaScript / TypeScript**: the official `smallestai` npm package predates Lightning v3.1, so call this endpoint with `fetch` or `axios` as shown above.
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SynthesizeLightningV31SpeechAsync(

            global::SmallestAI.LightningV31Request request,
            global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept accept = global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept.AudioWav,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lightning v3.1 (Endpoint Deprecated)<br/>
        /// &lt;Warning&gt;**Endpoint scheduled for retirement.** This URL will stop accepting requests **60 days from the Lightning v3.1 Pro launch (2026-05-15)** — i.e. on **2026-07-14**. The Lightning v3.1 model itself is current and stays. Migrate to [`POST /waves/v1/tts`](/waves/api-reference/api-reference/text-to-speech/synthesize-speech) and select Lightning v3.1 via the `model` body field (default).&lt;/Warning&gt;<br/>
        /// Synthesize speech from text in a single request. The simplest way to get audio when you have the full text up front — pass `text` + `voice_id`, get back binary audio.<br/>
        /// ## When to use this<br/>
        /// - **Use this** for short utterances you can render before playback (notifications, prompts, batch jobs, audio file generation).<br/>
        /// - **Use the SSE streaming endpoint** when you want playback to start before the full audio is ready (long passages, latency-sensitive apps).<br/>
        /// - **Use the WebSocket endpoint** when text arrives incrementally (LLM token streams, live captioning).<br/>
        /// ## Key features<br/>
        /// - 44 kHz natural, expressive synthesis<br/>
        /// - Cloned voice IDs (`voice_*`) work — same param as catalog voices<br/>
        /// - 12 documented languages — see the model card for the full list<br/>
        /// - Output formats: `pcm`, `mp3`, `wav`, `ulaw`, `alaw`<br/>
        /// - Sample rates: 8 kHz – 44.1 kHz<br/>
        /// - Speed: 0.5× – 2×<br/>
        /// - Per-call pronunciation dictionaries via `pronunciation_dicts`<br/>
        /// ## Examples<br/>
        /// **cURL**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/lightning-v3.1/get_speech" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from Lightning v3.1.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **Python** (`pip install smallestai&gt;=4.4.0`)<br/>
        /// ```python<br/>
        /// from smallestai import SmallestAI<br/>
        /// client = SmallestAI(token="YOUR_API_KEY")<br/>
        /// with open("speech.wav", "wb") as f:<br/>
        ///     for chunk in client.waves.synthesize_lightning_v3_1(<br/>
        ///         text="Hello from Lightning v3.1.",<br/>
        ///         voice_id="magnus",<br/>
        ///         sample_rate=24000,<br/>
        ///         output_format="wav",<br/>
        ///         # Optional: cloned voice support<br/>
        ///         # voice_id="voice_FlPKRWI7DX",<br/>
        ///         # Optional: pin pronunciations for specific words<br/>
        ///         # pronunciation_dicts=["&lt;your dict id&gt;"],<br/>
        ///     ):<br/>
        ///         f.write(chunk)<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript** (using `fetch`)<br/>
        /// ```typescript<br/>
        /// const res = await fetch("https://api.smallest.ai/waves/v1/lightning-v3.1/get_speech", {<br/>
        ///   method: "POST",<br/>
        ///   headers: {<br/>
        ///     Authorization: `Bearer ${process.env.SMALLEST_API_KEY}`,<br/>
        ///     "Content-Type": "application/json",<br/>
        ///     Accept: "audio/wav",<br/>
        ///   },<br/>
        ///   body: JSON.stringify({<br/>
        ///     text: "Hello from Lightning v3.1.",<br/>
        ///     voice_id: "magnus",<br/>
        ///     sample_rate: 24000,<br/>
        ///     output_format: "wav",<br/>
        ///   }),<br/>
        /// });<br/>
        /// const audio = Buffer.from(await res.arrayBuffer());<br/>
        /// require("node:fs").writeFileSync("speech.wav", audio);<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Set `Accept: audio/wav`.** Omitting it can return an empty or unplayable response.<br/>
        /// - **Cloned voices** (`voice_*` from `add_voice`) work on this endpoint and support `pronunciation_dicts`.<br/>
        /// - **`pronunciation_dicts` validates IDs at request time.** Passing an unknown ID returns `Invalid input data` — create the dict first via the pronunciation-dicts endpoint and save the returned `id`.<br/>
        /// - **Pronunciation matching is case-sensitive.** Add both `Synopsis` and `synopsis` if your text uses both casings.<br/>
        /// - **44.1 kHz output** is supported but most playback environments are happy with 24 kHz — drop the sample rate if bandwidth matters.<br/>
        /// - **JavaScript / TypeScript**: the official `smallestai` npm package predates Lightning v3.1, so call this endpoint with `fetch` or `axios` as shown above.
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> SynthesizeLightningV31SpeechAsStreamAsync(

            global::SmallestAI.LightningV31Request request,
            global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept accept = global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept.AudioWav,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lightning v3.1 (Endpoint Deprecated)<br/>
        /// &lt;Warning&gt;**Endpoint scheduled for retirement.** This URL will stop accepting requests **60 days from the Lightning v3.1 Pro launch (2026-05-15)** — i.e. on **2026-07-14**. The Lightning v3.1 model itself is current and stays. Migrate to [`POST /waves/v1/tts`](/waves/api-reference/api-reference/text-to-speech/synthesize-speech) and select Lightning v3.1 via the `model` body field (default).&lt;/Warning&gt;<br/>
        /// Synthesize speech from text in a single request. The simplest way to get audio when you have the full text up front — pass `text` + `voice_id`, get back binary audio.<br/>
        /// ## When to use this<br/>
        /// - **Use this** for short utterances you can render before playback (notifications, prompts, batch jobs, audio file generation).<br/>
        /// - **Use the SSE streaming endpoint** when you want playback to start before the full audio is ready (long passages, latency-sensitive apps).<br/>
        /// - **Use the WebSocket endpoint** when text arrives incrementally (LLM token streams, live captioning).<br/>
        /// ## Key features<br/>
        /// - 44 kHz natural, expressive synthesis<br/>
        /// - Cloned voice IDs (`voice_*`) work — same param as catalog voices<br/>
        /// - 12 documented languages — see the model card for the full list<br/>
        /// - Output formats: `pcm`, `mp3`, `wav`, `ulaw`, `alaw`<br/>
        /// - Sample rates: 8 kHz – 44.1 kHz<br/>
        /// - Speed: 0.5× – 2×<br/>
        /// - Per-call pronunciation dictionaries via `pronunciation_dicts`<br/>
        /// ## Examples<br/>
        /// **cURL**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/lightning-v3.1/get_speech" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from Lightning v3.1.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **Python** (`pip install smallestai&gt;=4.4.0`)<br/>
        /// ```python<br/>
        /// from smallestai import SmallestAI<br/>
        /// client = SmallestAI(token="YOUR_API_KEY")<br/>
        /// with open("speech.wav", "wb") as f:<br/>
        ///     for chunk in client.waves.synthesize_lightning_v3_1(<br/>
        ///         text="Hello from Lightning v3.1.",<br/>
        ///         voice_id="magnus",<br/>
        ///         sample_rate=24000,<br/>
        ///         output_format="wav",<br/>
        ///         # Optional: cloned voice support<br/>
        ///         # voice_id="voice_FlPKRWI7DX",<br/>
        ///         # Optional: pin pronunciations for specific words<br/>
        ///         # pronunciation_dicts=["&lt;your dict id&gt;"],<br/>
        ///     ):<br/>
        ///         f.write(chunk)<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript** (using `fetch`)<br/>
        /// ```typescript<br/>
        /// const res = await fetch("https://api.smallest.ai/waves/v1/lightning-v3.1/get_speech", {<br/>
        ///   method: "POST",<br/>
        ///   headers: {<br/>
        ///     Authorization: `Bearer ${process.env.SMALLEST_API_KEY}`,<br/>
        ///     "Content-Type": "application/json",<br/>
        ///     Accept: "audio/wav",<br/>
        ///   },<br/>
        ///   body: JSON.stringify({<br/>
        ///     text: "Hello from Lightning v3.1.",<br/>
        ///     voice_id: "magnus",<br/>
        ///     sample_rate: 24000,<br/>
        ///     output_format: "wav",<br/>
        ///   }),<br/>
        /// });<br/>
        /// const audio = Buffer.from(await res.arrayBuffer());<br/>
        /// require("node:fs").writeFileSync("speech.wav", audio);<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Set `Accept: audio/wav`.** Omitting it can return an empty or unplayable response.<br/>
        /// - **Cloned voices** (`voice_*` from `add_voice`) work on this endpoint and support `pronunciation_dicts`.<br/>
        /// - **`pronunciation_dicts` validates IDs at request time.** Passing an unknown ID returns `Invalid input data` — create the dict first via the pronunciation-dicts endpoint and save the returned `id`.<br/>
        /// - **Pronunciation matching is case-sensitive.** Add both `Synopsis` and `synopsis` if your text uses both casings.<br/>
        /// - **44.1 kHz output** is supported but most playback environments are happy with 24 kHz — drop the sample rate if bandwidth matters.<br/>
        /// - **JavaScript / TypeScript**: the official `smallestai` npm package predates Lightning v3.1, so call this endpoint with `fetch` or `axios` as shown above.
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<byte[]>> SynthesizeLightningV31SpeechAsResponseAsync(

            global::SmallestAI.LightningV31Request request,
            global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept accept = global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept.AudioWav,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lightning v3.1 (Endpoint Deprecated)<br/>
        /// &lt;Warning&gt;**Endpoint scheduled for retirement.** This URL will stop accepting requests **60 days from the Lightning v3.1 Pro launch (2026-05-15)** — i.e. on **2026-07-14**. The Lightning v3.1 model itself is current and stays. Migrate to [`POST /waves/v1/tts`](/waves/api-reference/api-reference/text-to-speech/synthesize-speech) and select Lightning v3.1 via the `model` body field (default).&lt;/Warning&gt;<br/>
        /// Synthesize speech from text in a single request. The simplest way to get audio when you have the full text up front — pass `text` + `voice_id`, get back binary audio.<br/>
        /// ## When to use this<br/>
        /// - **Use this** for short utterances you can render before playback (notifications, prompts, batch jobs, audio file generation).<br/>
        /// - **Use the SSE streaming endpoint** when you want playback to start before the full audio is ready (long passages, latency-sensitive apps).<br/>
        /// - **Use the WebSocket endpoint** when text arrives incrementally (LLM token streams, live captioning).<br/>
        /// ## Key features<br/>
        /// - 44 kHz natural, expressive synthesis<br/>
        /// - Cloned voice IDs (`voice_*`) work — same param as catalog voices<br/>
        /// - 12 documented languages — see the model card for the full list<br/>
        /// - Output formats: `pcm`, `mp3`, `wav`, `ulaw`, `alaw`<br/>
        /// - Sample rates: 8 kHz – 44.1 kHz<br/>
        /// - Speed: 0.5× – 2×<br/>
        /// - Per-call pronunciation dictionaries via `pronunciation_dicts`<br/>
        /// ## Examples<br/>
        /// **cURL**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/lightning-v3.1/get_speech" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from Lightning v3.1.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **Python** (`pip install smallestai&gt;=4.4.0`)<br/>
        /// ```python<br/>
        /// from smallestai import SmallestAI<br/>
        /// client = SmallestAI(token="YOUR_API_KEY")<br/>
        /// with open("speech.wav", "wb") as f:<br/>
        ///     for chunk in client.waves.synthesize_lightning_v3_1(<br/>
        ///         text="Hello from Lightning v3.1.",<br/>
        ///         voice_id="magnus",<br/>
        ///         sample_rate=24000,<br/>
        ///         output_format="wav",<br/>
        ///         # Optional: cloned voice support<br/>
        ///         # voice_id="voice_FlPKRWI7DX",<br/>
        ///         # Optional: pin pronunciations for specific words<br/>
        ///         # pronunciation_dicts=["&lt;your dict id&gt;"],<br/>
        ///     ):<br/>
        ///         f.write(chunk)<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript** (using `fetch`)<br/>
        /// ```typescript<br/>
        /// const res = await fetch("https://api.smallest.ai/waves/v1/lightning-v3.1/get_speech", {<br/>
        ///   method: "POST",<br/>
        ///   headers: {<br/>
        ///     Authorization: `Bearer ${process.env.SMALLEST_API_KEY}`,<br/>
        ///     "Content-Type": "application/json",<br/>
        ///     Accept: "audio/wav",<br/>
        ///   },<br/>
        ///   body: JSON.stringify({<br/>
        ///     text: "Hello from Lightning v3.1.",<br/>
        ///     voice_id: "magnus",<br/>
        ///     sample_rate: 24000,<br/>
        ///     output_format: "wav",<br/>
        ///   }),<br/>
        /// });<br/>
        /// const audio = Buffer.from(await res.arrayBuffer());<br/>
        /// require("node:fs").writeFileSync("speech.wav", audio);<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Set `Accept: audio/wav`.** Omitting it can return an empty or unplayable response.<br/>
        /// - **Cloned voices** (`voice_*` from `add_voice`) work on this endpoint and support `pronunciation_dicts`.<br/>
        /// - **`pronunciation_dicts` validates IDs at request time.** Passing an unknown ID returns `Invalid input data` — create the dict first via the pronunciation-dicts endpoint and save the returned `id`.<br/>
        /// - **Pronunciation matching is case-sensitive.** Add both `Synopsis` and `synopsis` if your text uses both casings.<br/>
        /// - **44.1 kHz output** is supported but most playback environments are happy with 24 kHz — drop the sample rate if bandwidth matters.<br/>
        /// - **JavaScript / TypeScript**: the official `smallestai` npm package predates Lightning v3.1, so call this endpoint with `fetch` or `axios` as shown above.
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="text">
        /// The text to convert to speech.<br/>
        /// Default Value: Hey i am your a text to speech model
        /// </param>
        /// <param name="voiceId">
        /// The voice identifier to use for speech generation.<br/>
        /// Default Value: daniel
        /// </param>
        /// <param name="model">
        /// TTS model to route the request to.<br/>
        /// - `lightning_v3.1` (default) — standard Lightning v3.1 pool.<br/>
        /// - `lightning_v3.1_pro` — Lightning v3.1 Pro pool with a curated<br/>
        ///   voice catalog. See the<br/>
        ///   [Pro model card](/waves/model-cards/text-to-speech/lightning-v-3-1-pro).<br/>
        /// New integrations should use the unified<br/>
        /// `/waves/v1/tts` route instead of this endpoint, but the `model`<br/>
        /// field is supported here for backwards-compatible Pro opt-in.<br/>
        /// Default Value: lightning_v3.1
        /// </param>
        /// <param name="sampleRate">
        /// The sample rate for the generated audio.<br/>
        /// Default Value: 44100
        /// </param>
        /// <param name="speed">
        /// The speed of the generated speech.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="language">
        /// Language code for synthesis. Influences pronunciation, number/date<br/>
        /// normalization, and phoneme selection.<br/>
        /// - **Indian:** `en`, `hi`, `mr` (Marathi), `kn` (Kannada), `ta` (Tamil),<br/>
        ///   `bn` (Bengali), `gu` (Gujarati), `te` (Telugu), `ml` (Malayalam),<br/>
        ///   `pa` (Punjabi), `or` (Odia)<br/>
        /// - **European:** `es` (Spanish)<br/>
        /// - `auto` — auto-detect from input text (recommended for code-switching)<br/>
        /// Default Value: en
        /// </param>
        /// <param name="outputFormat">
        /// Format of the returned audio. `pcm` is the lowest-latency option<br/>
        /// but requires a decoder to play; `mp3` and `wav` are directly<br/>
        /// playable in browsers and most media players. The server default<br/>
        /// is `pcm` when the field is omitted — the API playground uses<br/>
        /// `mp3` so the generated audio is directly playable.<br/>
        /// Default Value: pcm
        /// </param>
        /// <param name="pronunciationDicts">
        /// The IDs of the pronunciation dictionaries to use for speech generation.
        /// </param>
        /// <param name="sessionId">
        /// Optional client-provided session identifier for correlation. Only alphanumeric characters, hyphens, underscores, and dots are allowed. Max 128 characters. Echoed back in response headers as `X-External-Session-Id`.
        /// </param>
        /// <param name="requestId">
        /// Optional client-provided request identifier for correlation. Only alphanumeric characters, hyphens, underscores, and dots are allowed. Max 128 characters. Echoed back in response headers as `X-External-Request-Id`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SynthesizeLightningV31SpeechAsync(
            global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept accept = global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept.AudioWav,
            string text = "Hey i am your a text to speech model",
            string voiceId = "daniel",
            global::SmallestAI.LightningV31RequestModel? model = default,
            global::SmallestAI.LightningV31RequestSampleRate? sampleRate = default,
            double? speed = default,
            global::SmallestAI.LightningV31RequestLanguage? language = default,
            global::SmallestAI.LightningV31RequestOutputFormat? outputFormat = default,
            global::System.Collections.Generic.IList<string>? pronunciationDicts = default,
            string? sessionId = default,
            string? requestId = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}