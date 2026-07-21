#nullable enable

namespace SmallestAI
{
    public partial interface ITextToSpeechClient
    {
        /// <summary>
        /// Synthesize speech<br/>
        /// Synthesize speech from text in a single request. Pass `text` + `voice_id`, get back binary audio.<br/>
        /// Pick the model with the `model` body parameter: default `lightning_v3.1`, or `lightning_v3.1_pro` for the Pro pool. Other request parameters are identical across models.<br/>
        /// **Language behaviour on `lightning_v3.1_pro`:** pass `language: en` for UK + American accented English, pass `language: hi` for Indian accented English + Hindi (code-switching), or omit `language` to default to `en + hi` (mixed Indian + Western English coverage). Pro supports 31 languages total (10 Indic, 8 Asian &amp; Middle Eastern, 13 European including Dutch and Swedish). Pass the matching ISO 639-1 code (e.g. `ta`, `de`, `ja`) with a Pro voice from that language, or use `auto` to route across all supported languages with any English or Hindi voice. See the [Lightning v3.1 Pro model card](/models/model-cards/text-to-speech/lightning-v-3-1-pro#supported-languages) for the full list. On `lightning_v3.1` the model accepts 20 language codes (10 European + 10 Indic) plus `auto`; the trained voice catalog covers 12 of those directly.<br/>
        /// ## When to use this<br/>
        /// - **Use this** for short utterances you can render before playback (notifications, prompts, batch jobs, audio file generation).<br/>
        /// - **Use `/waves/v1/tts/live`** when you want playback to start before the full audio is ready (long passages, latency-sensitive apps).<br/>
        /// - **Use `/waves/v1/tts/live`** (WebSocket) when text arrives incrementally (LLM token streams, live captioning).<br/>
        /// ## Key features<br/>
        /// - 44 kHz natural, expressive synthesis<br/>
        /// - Model selectable per request via `model` body parameter<br/>
        /// - Cloned voice IDs (`voice_*`) work on `lightning_v3.1` — same param as catalog voices<br/>
        /// - 20 accepted language codes on `lightning_v3.1` (12 with trained voices, 8 additional routed via English/Hindi voices). On `lightning_v3.1_pro`: 31 languages with dedicated voices (10 Indic, 8 Asian &amp; Middle Eastern, 13 European); `language: en` → UK + American accented English; `language: hi` → Indian accented English + Hindi; omit `language` → defaults to `en + hi`. Both models accept `language: auto` for cross-language routing.<br/>
        /// - Output formats: `pcm`, `mp3`, `wav`, `ulaw`, `alaw`<br/>
        /// - Sample rates: 8 kHz – 44.1 kHz<br/>
        /// - Speed: 0.5× – 2×<br/>
        /// - Per-call pronunciation dictionaries via `pronunciation_dicts`<br/>
        /// ## Examples<br/>
        /// **cURL — Lightning v3.1 (default)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from Waves TTS.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro (omit `language` → defaults to `en + hi`)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from the Lightning v3.1 Pro pool.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: en` (UK + American accented English)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Good morning, this is a Pro voice speaking.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "en",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: hi` (Indian accented English + Hindi)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Namaste, this is an Indian-accented Pro voice.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "hi",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Set `Accept: audio/wav`.** Omitting it can return an empty or unplayable response.<br/>
        /// - **Pair voice IDs with the right model.** Voice catalogs differ between `lightning_v3.1` and `lightning_v3.1_pro`. The API does not reject mismatched pairings, but using a Pro-only `voice_id` with `model=lightning_v3.1` (or omitting `model`) can return wrong or hallucinated audio. Pair Pro voices with `model=lightning_v3.1_pro`; standard catalog voices with `model=lightning_v3.1` (the default).<br/>
        /// - **Cloned voices** (`voice_*` from `add_voice`) work with `lightning_v3.1` only; voice cloning is not available on `lightning_v3.1_pro`.<br/>
        /// - **44.1 kHz output** is supported but most playback environments are happy with 24 kHz — drop the sample rate if bandwidth matters.
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SynthesizeSpeechAsync(

            global::SmallestAI.TtsRequest request,
            global::SmallestAI.WavesV1TtsPostParametersAccept accept = global::SmallestAI.WavesV1TtsPostParametersAccept.AudioWav,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech<br/>
        /// Synthesize speech from text in a single request. Pass `text` + `voice_id`, get back binary audio.<br/>
        /// Pick the model with the `model` body parameter: default `lightning_v3.1`, or `lightning_v3.1_pro` for the Pro pool. Other request parameters are identical across models.<br/>
        /// **Language behaviour on `lightning_v3.1_pro`:** pass `language: en` for UK + American accented English, pass `language: hi` for Indian accented English + Hindi (code-switching), or omit `language` to default to `en + hi` (mixed Indian + Western English coverage). Pro supports 31 languages total (10 Indic, 8 Asian &amp; Middle Eastern, 13 European including Dutch and Swedish). Pass the matching ISO 639-1 code (e.g. `ta`, `de`, `ja`) with a Pro voice from that language, or use `auto` to route across all supported languages with any English or Hindi voice. See the [Lightning v3.1 Pro model card](/models/model-cards/text-to-speech/lightning-v-3-1-pro#supported-languages) for the full list. On `lightning_v3.1` the model accepts 20 language codes (10 European + 10 Indic) plus `auto`; the trained voice catalog covers 12 of those directly.<br/>
        /// ## When to use this<br/>
        /// - **Use this** for short utterances you can render before playback (notifications, prompts, batch jobs, audio file generation).<br/>
        /// - **Use `/waves/v1/tts/live`** when you want playback to start before the full audio is ready (long passages, latency-sensitive apps).<br/>
        /// - **Use `/waves/v1/tts/live`** (WebSocket) when text arrives incrementally (LLM token streams, live captioning).<br/>
        /// ## Key features<br/>
        /// - 44 kHz natural, expressive synthesis<br/>
        /// - Model selectable per request via `model` body parameter<br/>
        /// - Cloned voice IDs (`voice_*`) work on `lightning_v3.1` — same param as catalog voices<br/>
        /// - 20 accepted language codes on `lightning_v3.1` (12 with trained voices, 8 additional routed via English/Hindi voices). On `lightning_v3.1_pro`: 31 languages with dedicated voices (10 Indic, 8 Asian &amp; Middle Eastern, 13 European); `language: en` → UK + American accented English; `language: hi` → Indian accented English + Hindi; omit `language` → defaults to `en + hi`. Both models accept `language: auto` for cross-language routing.<br/>
        /// - Output formats: `pcm`, `mp3`, `wav`, `ulaw`, `alaw`<br/>
        /// - Sample rates: 8 kHz – 44.1 kHz<br/>
        /// - Speed: 0.5× – 2×<br/>
        /// - Per-call pronunciation dictionaries via `pronunciation_dicts`<br/>
        /// ## Examples<br/>
        /// **cURL — Lightning v3.1 (default)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from Waves TTS.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro (omit `language` → defaults to `en + hi`)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from the Lightning v3.1 Pro pool.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: en` (UK + American accented English)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Good morning, this is a Pro voice speaking.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "en",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: hi` (Indian accented English + Hindi)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Namaste, this is an Indian-accented Pro voice.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "hi",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Set `Accept: audio/wav`.** Omitting it can return an empty or unplayable response.<br/>
        /// - **Pair voice IDs with the right model.** Voice catalogs differ between `lightning_v3.1` and `lightning_v3.1_pro`. The API does not reject mismatched pairings, but using a Pro-only `voice_id` with `model=lightning_v3.1` (or omitting `model`) can return wrong or hallucinated audio. Pair Pro voices with `model=lightning_v3.1_pro`; standard catalog voices with `model=lightning_v3.1` (the default).<br/>
        /// - **Cloned voices** (`voice_*` from `add_voice`) work with `lightning_v3.1` only; voice cloning is not available on `lightning_v3.1_pro`.<br/>
        /// - **44.1 kHz output** is supported but most playback environments are happy with 24 kHz — drop the sample rate if bandwidth matters.
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> SynthesizeSpeechAsStreamAsync(

            global::SmallestAI.TtsRequest request,
            global::SmallestAI.WavesV1TtsPostParametersAccept accept = global::SmallestAI.WavesV1TtsPostParametersAccept.AudioWav,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech<br/>
        /// Synthesize speech from text in a single request. Pass `text` + `voice_id`, get back binary audio.<br/>
        /// Pick the model with the `model` body parameter: default `lightning_v3.1`, or `lightning_v3.1_pro` for the Pro pool. Other request parameters are identical across models.<br/>
        /// **Language behaviour on `lightning_v3.1_pro`:** pass `language: en` for UK + American accented English, pass `language: hi` for Indian accented English + Hindi (code-switching), or omit `language` to default to `en + hi` (mixed Indian + Western English coverage). Pro supports 31 languages total (10 Indic, 8 Asian &amp; Middle Eastern, 13 European including Dutch and Swedish). Pass the matching ISO 639-1 code (e.g. `ta`, `de`, `ja`) with a Pro voice from that language, or use `auto` to route across all supported languages with any English or Hindi voice. See the [Lightning v3.1 Pro model card](/models/model-cards/text-to-speech/lightning-v-3-1-pro#supported-languages) for the full list. On `lightning_v3.1` the model accepts 20 language codes (10 European + 10 Indic) plus `auto`; the trained voice catalog covers 12 of those directly.<br/>
        /// ## When to use this<br/>
        /// - **Use this** for short utterances you can render before playback (notifications, prompts, batch jobs, audio file generation).<br/>
        /// - **Use `/waves/v1/tts/live`** when you want playback to start before the full audio is ready (long passages, latency-sensitive apps).<br/>
        /// - **Use `/waves/v1/tts/live`** (WebSocket) when text arrives incrementally (LLM token streams, live captioning).<br/>
        /// ## Key features<br/>
        /// - 44 kHz natural, expressive synthesis<br/>
        /// - Model selectable per request via `model` body parameter<br/>
        /// - Cloned voice IDs (`voice_*`) work on `lightning_v3.1` — same param as catalog voices<br/>
        /// - 20 accepted language codes on `lightning_v3.1` (12 with trained voices, 8 additional routed via English/Hindi voices). On `lightning_v3.1_pro`: 31 languages with dedicated voices (10 Indic, 8 Asian &amp; Middle Eastern, 13 European); `language: en` → UK + American accented English; `language: hi` → Indian accented English + Hindi; omit `language` → defaults to `en + hi`. Both models accept `language: auto` for cross-language routing.<br/>
        /// - Output formats: `pcm`, `mp3`, `wav`, `ulaw`, `alaw`<br/>
        /// - Sample rates: 8 kHz – 44.1 kHz<br/>
        /// - Speed: 0.5× – 2×<br/>
        /// - Per-call pronunciation dictionaries via `pronunciation_dicts`<br/>
        /// ## Examples<br/>
        /// **cURL — Lightning v3.1 (default)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from Waves TTS.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro (omit `language` → defaults to `en + hi`)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from the Lightning v3.1 Pro pool.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: en` (UK + American accented English)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Good morning, this is a Pro voice speaking.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "en",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: hi` (Indian accented English + Hindi)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Namaste, this is an Indian-accented Pro voice.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "hi",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Set `Accept: audio/wav`.** Omitting it can return an empty or unplayable response.<br/>
        /// - **Pair voice IDs with the right model.** Voice catalogs differ between `lightning_v3.1` and `lightning_v3.1_pro`. The API does not reject mismatched pairings, but using a Pro-only `voice_id` with `model=lightning_v3.1` (or omitting `model`) can return wrong or hallucinated audio. Pair Pro voices with `model=lightning_v3.1_pro`; standard catalog voices with `model=lightning_v3.1` (the default).<br/>
        /// - **Cloned voices** (`voice_*` from `add_voice`) work with `lightning_v3.1` only; voice cloning is not available on `lightning_v3.1_pro`.<br/>
        /// - **44.1 kHz output** is supported but most playback environments are happy with 24 kHz — drop the sample rate if bandwidth matters.
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<byte[]>> SynthesizeSpeechAsResponseAsync(

            global::SmallestAI.TtsRequest request,
            global::SmallestAI.WavesV1TtsPostParametersAccept accept = global::SmallestAI.WavesV1TtsPostParametersAccept.AudioWav,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech<br/>
        /// Synthesize speech from text in a single request. Pass `text` + `voice_id`, get back binary audio.<br/>
        /// Pick the model with the `model` body parameter: default `lightning_v3.1`, or `lightning_v3.1_pro` for the Pro pool. Other request parameters are identical across models.<br/>
        /// **Language behaviour on `lightning_v3.1_pro`:** pass `language: en` for UK + American accented English, pass `language: hi` for Indian accented English + Hindi (code-switching), or omit `language` to default to `en + hi` (mixed Indian + Western English coverage). Pro supports 31 languages total (10 Indic, 8 Asian &amp; Middle Eastern, 13 European including Dutch and Swedish). Pass the matching ISO 639-1 code (e.g. `ta`, `de`, `ja`) with a Pro voice from that language, or use `auto` to route across all supported languages with any English or Hindi voice. See the [Lightning v3.1 Pro model card](/models/model-cards/text-to-speech/lightning-v-3-1-pro#supported-languages) for the full list. On `lightning_v3.1` the model accepts 20 language codes (10 European + 10 Indic) plus `auto`; the trained voice catalog covers 12 of those directly.<br/>
        /// ## When to use this<br/>
        /// - **Use this** for short utterances you can render before playback (notifications, prompts, batch jobs, audio file generation).<br/>
        /// - **Use `/waves/v1/tts/live`** when you want playback to start before the full audio is ready (long passages, latency-sensitive apps).<br/>
        /// - **Use `/waves/v1/tts/live`** (WebSocket) when text arrives incrementally (LLM token streams, live captioning).<br/>
        /// ## Key features<br/>
        /// - 44 kHz natural, expressive synthesis<br/>
        /// - Model selectable per request via `model` body parameter<br/>
        /// - Cloned voice IDs (`voice_*`) work on `lightning_v3.1` — same param as catalog voices<br/>
        /// - 20 accepted language codes on `lightning_v3.1` (12 with trained voices, 8 additional routed via English/Hindi voices). On `lightning_v3.1_pro`: 31 languages with dedicated voices (10 Indic, 8 Asian &amp; Middle Eastern, 13 European); `language: en` → UK + American accented English; `language: hi` → Indian accented English + Hindi; omit `language` → defaults to `en + hi`. Both models accept `language: auto` for cross-language routing.<br/>
        /// - Output formats: `pcm`, `mp3`, `wav`, `ulaw`, `alaw`<br/>
        /// - Sample rates: 8 kHz – 44.1 kHz<br/>
        /// - Speed: 0.5× – 2×<br/>
        /// - Per-call pronunciation dictionaries via `pronunciation_dicts`<br/>
        /// ## Examples<br/>
        /// **cURL — Lightning v3.1 (default)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from Waves TTS.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro (omit `language` → defaults to `en + hi`)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from the Lightning v3.1 Pro pool.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: en` (UK + American accented English)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Good morning, this is a Pro voice speaking.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "en",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: hi` (Indian accented English + Hindi)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Namaste, this is an Indian-accented Pro voice.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "hi",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Set `Accept: audio/wav`.** Omitting it can return an empty or unplayable response.<br/>
        /// - **Pair voice IDs with the right model.** Voice catalogs differ between `lightning_v3.1` and `lightning_v3.1_pro`. The API does not reject mismatched pairings, but using a Pro-only `voice_id` with `model=lightning_v3.1` (or omitting `model`) can return wrong or hallucinated audio. Pair Pro voices with `model=lightning_v3.1_pro`; standard catalog voices with `model=lightning_v3.1` (the default).<br/>
        /// - **Cloned voices** (`voice_*` from `add_voice`) work with `lightning_v3.1` only; voice cloning is not available on `lightning_v3.1_pro`.<br/>
        /// - **44.1 kHz output** is supported but most playback environments are happy with 24 kHz — drop the sample rate if bandwidth matters.
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="text">
        /// The text to convert to speech.<br/>
        /// Default Value: Hello from Waves TTS.
        /// </param>
        /// <param name="voiceId">
        /// The voice identifier to use for speech generation. See the model card for available voices per model.<br/>
        /// Default Value: magnus
        /// </param>
        /// <param name="model">
        /// TTS model to route the request to. Controls which model pool serves<br/>
        /// this synthesis.<br/>
        /// - `lightning_v3.1` (default) — standard Lightning v3.1.<br/>
        /// - `lightning_v3.1_pro` — Lightning v3.1 Pro pool. Improved audio<br/>
        ///   quality and naturalness, with a curated voice catalog. See the<br/>
        ///   [Lightning v3.1 Pro model card](/models/model-cards/text-to-speech/lightning-v-3-1-pro)<br/>
        ///   for supported voice IDs.<br/>
        /// Same concurrency and latency profile across both. Other request<br/>
        /// parameters behave identically.<br/>
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
        /// **Default on `lightning_v3.1_pro`:** when `language` is omitted, the<br/>
        /// Pro pool defaults to **`en + hi`** (mixed Indian + Western English<br/>
        /// coverage, auto-detected from the input text).<br/>
        /// Each voice has its own `tags.language` set in the voice catalog —<br/>
        /// query `GET /waves/v1/lightning-v3.1/get_voices`. Pass a language<br/>
        /// the voice was trained on; passing other codes is accepted by the<br/>
        /// API but produces English-pronounced output.<br/>
        /// **`auto` (recommended for cross-language use cases):** routes internally<br/>
        /// based on the input text. Any English or Hindi voice can be used<br/>
        /// across all supported languages when `auto` is set; the platform<br/>
        /// handles language-appropriate routing without needing a code per<br/>
        /// call.<br/>
        /// **On `lightning_v3.1`** — 20 supported languages:<br/>
        /// - 10 European: English, Spanish, French, German, Italian, Dutch, Swedish, Portuguese, Polish, Russian<br/>
        /// - 10 Indic: Hindi, Marathi, Gujarati, Punjabi, Bengali, Odia, Tamil, Telugu, Kannada, Malayalam<br/>
        /// **On `lightning_v3.1_pro`** — 31 supported languages (adds 11 over base):<br/>
        /// - 13 European: base 10 plus Greek, Finnish, Norwegian<br/>
        /// - 8 Asian &amp; Middle Eastern: Chinese, Japanese, Korean, Indonesian, Malay, Vietnamese, Turkish, Arabic<br/>
        /// - 10 Indic: same as base<br/>
        /// - Pass `en` → UK + American accented English.<br/>
        /// - Pass `hi` → Indian accented English + Hindi (code-switching).<br/>
        /// - Omit `language` → defaults to `en + hi` (mixed Indian + Western English coverage, auto-detected from input text).
        /// </param>
        /// <param name="numberPronunciationLanguage">
        /// Optional. Sets the language used to read out numeric content —<br/>
        /// numbers, currency amounts, times, and the numeric parts of dates<br/>
        /// and years — independently of the synthesis voice. Ordinary words<br/>
        /// are not translated.<br/>
        /// - If you **omit `language`**, this value also becomes the<br/>
        ///   synthesis language: model selection and voice routing follow it.<br/>
        /// - If you **set `language` explicitly**, `language` always wins for<br/>
        ///   synthesis and `number_pronunciation_language` only changes how<br/>
        ///   numeric content is normalized. It works both ways — read numbers<br/>
        ///   in Hindi under an English voice, or in English under a Hindi<br/>
        ///   voice (tuned for Indian, often mixed-script, use cases).<br/>
        /// - Omit this field to keep the existing behaviour — normalization<br/>
        ///   follows `language`.<br/>
        /// Note: only numeric tokens are re-spoken; the words around them<br/>
        /// stay in the text language. On a cross-language request names may<br/>
        /// also render in the target script (e.g. "Smith" → "स्मिथ"), which<br/>
        /// is generally the desired reading for native-language voices.<br/>
        /// Accepts the same language codes as `language` (including `auto`,<br/>
        /// `nl`, `sv`).
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
        /// The IDs of the pronunciation dictionaries to use for speech generation. Available on both `lightning_v3.1` and `lightning_v3.1_pro`.
        /// </param>
        /// <param name="wordTimestamps">
        /// **WebSocket-only feature.** Accepted on this endpoint but ignored — no per-word timing information is returned in the sync HTTP or SSE response shape. To receive `status: "word_timestamp"` frames with per-word `{ id, word, start, end }` data, use the WebSocket endpoint `wss://api.smallest.ai/waves/v1/tts/live`. See [Word-level timestamps](/models/documentation/text-to-speech-lightning/word-timestamps).<br/>
        /// Default Value: false
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
        global::System.Threading.Tasks.Task<byte[]> SynthesizeSpeechAsync(
            global::SmallestAI.WavesV1TtsPostParametersAccept accept = global::SmallestAI.WavesV1TtsPostParametersAccept.AudioWav,
            string text = "Hello from Waves TTS.",
            string voiceId = "magnus",
            global::SmallestAI.TtsRequestModel? model = default,
            global::SmallestAI.TtsRequestSampleRate? sampleRate = default,
            double? speed = default,
            global::SmallestAI.TtsRequestLanguage? language = default,
            global::SmallestAI.TtsRequestNumberPronunciationLanguage? numberPronunciationLanguage = default,
            global::SmallestAI.TtsRequestOutputFormat? outputFormat = default,
            global::System.Collections.Generic.IList<string>? pronunciationDicts = default,
            bool? wordTimestamps = default,
            string? sessionId = default,
            string? requestId = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}