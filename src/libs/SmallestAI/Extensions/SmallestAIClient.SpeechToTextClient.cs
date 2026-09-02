#nullable enable

using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Meai = Microsoft.Extensions.AI;

namespace SmallestAI;

/// <summary>
/// Implements <see cref="Meai.ISpeechToTextClient"/> on <see cref="SmallestAIClient"/>
/// over the Pulse speech-to-text API.
/// <para>
/// Non-streaming <c>GetTextAsync</c> posts the audio to <c>POST /waves/v1/stt/</c>.
/// Streaming <c>GetStreamingTextAsync</c> opens a WebSocket to
/// <c>wss://api.smallest.ai/waves/v1/stt/live</c>, uploads the audio as binary
/// frames, and yields interim and final transcription updates.
/// </para>
/// <para>
/// MEAI has no first-class notion of speaker diarization, so Pulse-specific
/// knobs are read from <c>SpeechToTextOptions.AdditionalProperties</c> and
/// Pulse-specific results — including <c>words[].speaker</c> and
/// <c>utterances[].speaker</c> — are written back to the response's
/// <c>AdditionalProperties</c>. Use <see cref="SmallestAISpeechToTextPropertyNames"/>
/// for the keys, or read <c>RawRepresentation</c> for the full typed payload.
/// </para>
/// <para>
/// The MEAI alias is required: the generated <see cref="ISpeechToTextClient"/>
/// sub-client interface collides by simple name with
/// <c>Microsoft.Extensions.AI.ISpeechToTextClient</c>.
/// </para>
/// </summary>
public sealed partial class SmallestAIClient : Meai.ISpeechToTextClient
{
    private Meai.SpeechToTextClientMetadata? _speechMetadata;

    /// <summary>
    /// Multilingual Pulse model. The only model served on the realtime
    /// WebSocket channel, and the only one that supports diarization.
    /// </summary>
    public const string PulseModelId = "pulse";

    /// <summary>
    /// English-only, leaderboard-ranked Pulse Pro model. Pre-recorded audio
    /// only — it has no streaming worker and does not support diarization.
    /// </summary>
    public const string PulseProModelId = "pulse-pro";

    /// <summary>
    /// Chunk size used when uploading audio over the realtime WebSocket.
    /// Smallest recommends roughly 4096-byte frames.
    /// </summary>
    private const int RealtimeAudioChunkSize = 4096;

    /// <inheritdoc />
    object? Meai.ISpeechToTextClient.GetService(Type serviceType, object? serviceKey) =>
        serviceType is null ? throw new ArgumentNullException(nameof(serviceType)) :
        serviceKey is not null ? null :
        serviceType == typeof(Meai.SpeechToTextClientMetadata)
            ? _speechMetadata ??= new Meai.SpeechToTextClientMetadata("smallestai", new Uri(DefaultBaseUrl))
            : serviceType.IsInstanceOfType(this) ? this
            : null;

    /// <inheritdoc />
    async Task<Meai.SpeechToTextResponse> Meai.ISpeechToTextClient.GetTextAsync(
        Stream audioSpeechStream,
        Meai.SpeechToTextOptions? options,
        CancellationToken cancellationToken)
    {
        _ = audioSpeechStream ?? throw new ArgumentNullException(nameof(audioSpeechStream));

        using var buffer = new MemoryStream();
        await audioSpeechStream.CopyToAsync(buffer, cancellationToken).ConfigureAwait(false);

        var properties = options?.AdditionalProperties;

        var result = await SpeechToText.TranscribeAsync(
            model: ResolveBatchModel(options?.ModelId),
            language: ResolveBatchLanguage(options?.SpeechLanguage),
            request: buffer.ToArray(),
            wordTimestamps: GetBoolean(properties, SmallestAISpeechToTextPropertyNames.WordTimestamps) ?? true,
            diarize: GetBoolean(properties, SmallestAISpeechToTextPropertyNames.Diarize),
            webhookUrl: GetString(properties, SmallestAISpeechToTextPropertyNames.WebhookUrl),
            redactPii: ToWireFlag<WavesV1SttPostParametersRedactPii>(
                GetBoolean(properties, SmallestAISpeechToTextPropertyNames.RedactPii)),
            redactPci: ToWireFlag<WavesV1SttPostParametersRedactPci>(
                GetBoolean(properties, SmallestAISpeechToTextPropertyNames.RedactPci)),
            emotionDetection: ToWireFlag<WavesV1SttPostParametersEmotionDetection>(
                GetBoolean(properties, SmallestAISpeechToTextPropertyNames.EmotionDetection)),
            genderDetection: ToWireFlag<WavesV1SttPostParametersGenderDetection>(
                GetBoolean(properties, SmallestAISpeechToTextPropertyNames.GenderDetection)),
            cancellationToken: cancellationToken).ConfigureAwait(false);

        if (result.AsyncAccepted is { } accepted)
        {
            throw new InvalidOperationException(
                $"Smallest accepted the audio for asynchronous processing (request {accepted.RequestId}). " +
                $"Remove the '{SmallestAISpeechToTextPropertyNames.WebhookUrl}' additional property to transcribe synchronously.");
        }

        var transcription = result.TranscriptionResponse
            ?? throw new InvalidOperationException("Smallest returned no transcription payload.");

        var response = new Meai.SpeechToTextResponse(transcription.Transcription)
        {
            RawRepresentation = transcription,
            ResponseId = transcription.RequestId,
            StartTime = TimeSpan.Zero,
            EndTime = transcription.Metadata?.Duration is { } duration and > 0
                ? TimeSpan.FromSeconds(duration)
                : null,
        };

        Add(response.AdditionalProperties ??= [], SmallestAISpeechToTextPropertyNames.Words, transcription.Words);
        Add(response.AdditionalProperties, SmallestAISpeechToTextPropertyNames.Utterances, transcription.Utterances);
        Add(response.AdditionalProperties, SmallestAISpeechToTextPropertyNames.Language, transcription.Language);
        Add(response.AdditionalProperties, SmallestAISpeechToTextPropertyNames.Emotions, transcription.Emotions);
        Add(response.AdditionalProperties, SmallestAISpeechToTextPropertyNames.Gender, transcription.Gender);

        return response;
    }

    /// <inheritdoc />
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Reliability",
        "CA2025:Ensure tasks using 'IDisposable' instances complete before the instances are disposed",
        Justification = "The upload task is cancelled and drained in the finally block below, so it always settles before the WebSocket client is disposed. The analyzer cannot see through the iterator state machine.")]
    async IAsyncEnumerable<Meai.SpeechToTextResponseUpdate> Meai.ISpeechToTextClient.GetStreamingTextAsync(
        Stream audioSpeechStream,
        Meai.SpeechToTextOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        _ = audioSpeechStream ?? throw new ArgumentNullException(nameof(audioSpeechStream));

        if (options?.ModelId is { Length: > 0 } modelId &&
            !string.Equals(modelId, PulseModelId, StringComparison.OrdinalIgnoreCase))
        {
            throw new NotSupportedException(
                $"Smallest serves only '{PulseModelId}' on the realtime WebSocket channel; '{modelId}' was requested. " +
                $"'{PulseProModelId}' has no streaming worker and returns 400 before the WebSocket upgrade completes — " +
                "use GetTextAsync for pre-recorded audio instead.");
        }

        var apiKey = FindBearerApiKey()
            ?? throw new InvalidOperationException(
                "No API key found in SmallestAIClient.Authorizations. " +
                "Ensure the client was created with an API key or call AuthorizeUsingBearer.");

        var properties = options?.AdditionalProperties;

        var client = new Realtime.SmallestAISttLiveRealtimeClient(apiKey);
        await using (client.ConfigureAwait(false))
        {
            await client.ConnectAsync(
                model: Realtime.SttLiveModel.Pulse,
                language: options?.SpeechLanguage,
                encoding: Realtime.SttLiveEncodingExtensions.ToEnum(
                    GetString(properties, SmallestAISpeechToTextPropertyNames.Encoding) ?? "linear16"),
                sampleRate: GetInt32(properties, SmallestAISpeechToTextPropertyNames.SampleRate) ?? 16000,
                wordTimestamps: ToWireFlag<Realtime.SttLiveWordTimestamps>(
                    GetBoolean(properties, SmallestAISpeechToTextPropertyNames.WordTimestamps) ?? true),
                diarize: ToWireFlag<Realtime.SttLiveDiarize>(
                    GetBoolean(properties, SmallestAISpeechToTextPropertyNames.Diarize)),
                sentenceTimestamps: ToWireFlag<Realtime.SttLiveSentenceTimestamps>(
                    GetBoolean(properties, SmallestAISpeechToTextPropertyNames.SentenceTimestamps)),
                fullTranscript: ToWireFlag<Realtime.SttLiveFullTranscript>(
                    GetBoolean(properties, SmallestAISpeechToTextPropertyNames.FullTranscript)),
                punctuate: ToWireFlag<Realtime.SttLivePunctuate>(
                    GetBoolean(properties, SmallestAISpeechToTextPropertyNames.Punctuate)),
                capitalize: ToWireFlag<Realtime.SttLiveCapitalize>(
                    GetBoolean(properties, SmallestAISpeechToTextPropertyNames.Capitalize)),
                format: ToWireFlag<Realtime.SttLiveFormat>(
                    GetBoolean(properties, SmallestAISpeechToTextPropertyNames.Format)),
                itnNormalize: ToWireFlag<Realtime.SttLiveItnNormalize>(
                    GetBoolean(properties, SmallestAISpeechToTextPropertyNames.ItnNormalize)),
                redactPii: ToWireFlag<Realtime.SttLiveRedactPii>(
                    GetBoolean(properties, SmallestAISpeechToTextPropertyNames.RedactPii)),
                redactPci: ToWireFlag<Realtime.SttLiveRedactPci>(
                    GetBoolean(properties, SmallestAISpeechToTextPropertyNames.RedactPci)),
                emotionDetection: ToWireFlag<Realtime.SttLiveEmotionDetection>(
                    GetBoolean(properties, SmallestAISpeechToTextPropertyNames.EmotionDetection)),
                genderDetection: ToWireFlag<Realtime.SttLiveGenderDetection>(
                    GetBoolean(properties, SmallestAISpeechToTextPropertyNames.GenderDetection)),
                endpointing: ToWireFlag<Realtime.SttLiveEndpointing>(
                    GetBoolean(properties, SmallestAISpeechToTextPropertyNames.Endpointing)),
                finalizeOnWords: ToWireFlag<Realtime.SttLiveFinalizeOnWords>(
                    GetBoolean(properties, SmallestAISpeechToTextPropertyNames.FinalizeOnWords)),
                numerals: Realtime.SttLiveNumeralsExtensions.ToEnum(
                    GetString(properties, SmallestAISpeechToTextPropertyNames.Numerals) ?? string.Empty),
                // An empty keywords value registers a single empty keyword, so omit it entirely.
                keywords: GetString(properties, SmallestAISpeechToTextPropertyNames.Keywords) is { Length: > 0 } keywords
                    ? keywords
                    : null,
                eouTimeoutMs: GetInt32(properties, SmallestAISpeechToTextPropertyNames.EouTimeoutMs),
                maxWords: GetInt32(properties, SmallestAISpeechToTextPropertyNames.MaxWords),
                cancellationToken: cancellationToken).ConfigureAwait(false);

            // The upload runs concurrently with the receive loop, but must be
            // settled before `client` is disposed — hence the linked token and
            // the drain in `finally`.
            using var uploadCancellation = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            var uploadTask = UploadAudioAsync(client, audioSpeechStream, uploadCancellation.Token);
            try
            {

                string? responseId = null;
                var sessionOpened = false;

                await foreach (var @event in client.ReceiveUpdatesAsync(cancellationToken).ConfigureAwait(false))
                {
                    if (@event.Error is { Length: > 0 } error)
                    {
                        throw new InvalidOperationException($"Smallest realtime transcription failed: {error}");
                    }

                    responseId ??= @event.SessionId;

                    if (!sessionOpened)
                    {
                        sessionOpened = true;
                        yield return new Meai.SpeechToTextResponseUpdate
                        {
                            Kind = Meai.SpeechToTextResponseUpdateKind.SessionOpen,
                            ResponseId = responseId,
                            RawRepresentation = @event,
                        };
                    }

                    if (@event.Transcript is { Length: > 0 } transcript)
                    {
                        var update = new Meai.SpeechToTextResponseUpdate(transcript)
                        {
                            Kind = @event.IsFinal == true
                                ? Meai.SpeechToTextResponseUpdateKind.TextUpdated
                                : Meai.SpeechToTextResponseUpdateKind.TextUpdating,
                            ResponseId = responseId,
                            RawRepresentation = @event,
                        };

                        // Only final frames carry word-level data, so speaker labels
                        // are never surfaced from interim frames.
                        if (@event.IsFinal == true)
                        {
                            Add(update.AdditionalProperties ??= [], SmallestAISpeechToTextPropertyNames.Words, @event.Words);
                            Add(update.AdditionalProperties, SmallestAISpeechToTextPropertyNames.Utterances, @event.Utterances);
                            Add(update.AdditionalProperties, SmallestAISpeechToTextPropertyNames.Language, @event.Language);
                            Add(update.AdditionalProperties, SmallestAISpeechToTextPropertyNames.SessionId, @event.SessionId);
                        }

                        yield return update;
                    }

                    if (@event.IsLast == true)
                    {
                        break;
                    }
                }

                await uploadTask.ConfigureAwait(false);

                yield return new Meai.SpeechToTextResponseUpdate
                {
                    Kind = Meai.SpeechToTextResponseUpdateKind.SessionClose,
                    ResponseId = responseId,
                };
            }
            finally
            {
                await uploadCancellation.CancelAsync().ConfigureAwait(false);
                await DrainUploadAsync(uploadTask).ConfigureAwait(false);
            }
        }
    }

    /// <summary>
    /// Awaits the upload task so it can never outlive the WebSocket client.
    /// Failures are ignored here: the receive loop already surfaced whatever
    /// ended the session, and cancelling the upload is the normal shutdown path.
    /// </summary>
    private static async Task DrainUploadAsync(Task uploadTask)
    {
        try
        {
            await uploadTask.ConfigureAwait(false);
        }
        catch (OperationCanceledException)
        {
            // Expected when the receive loop finished first.
        }
        catch (System.Net.WebSockets.WebSocketException)
        {
            // Expected when the server closed the socket mid-upload.
        }
    }

    private static async Task UploadAudioAsync(
        Realtime.SmallestAISttLiveRealtimeClient client,
        Stream audioSpeechStream,
        CancellationToken cancellationToken)
    {
        // Yield first so the caller starts consuming ReceiveUpdatesAsync before
        // the upload saturates the socket.
        await Task.Yield();

        var buffer = new byte[RealtimeAudioChunkSize];
        int read;
        while ((read = await audioSpeechStream.ReadAsync(buffer, cancellationToken).ConfigureAwait(false)) > 0)
        {
            await client.SendAudioAsync(buffer.AsMemory(0, read), cancellationToken).ConfigureAwait(false);
        }

        await client.SendSttFinalizeAsync(cancellationToken).ConfigureAwait(false);
        await client.SendSttCloseStreamAsync(cancellationToken).ConfigureAwait(false);
    }

    private string? FindBearerApiKey()
    {
        foreach (var authorization in Authorizations)
        {
            if (authorization is { Type: "Http", Value.Length: > 0 })
            {
                return authorization.Value;
            }
        }

        return null;
    }

    private static WavesV1SttPostParametersModel ResolveBatchModel(string? modelId) =>
        modelId is { Length: > 0 }
            ? WavesV1SttPostParametersModelExtensions.ToEnum(modelId)
                ?? throw new NotSupportedException(
                    $"Unknown Smallest speech-to-text model '{modelId}'. Expected '{PulseModelId}' or '{PulseProModelId}'.")
            : WavesV1SttPostParametersModel.Pulse;

    private static WavesV1SttPostParametersLanguage ResolveBatchLanguage(string? language) =>
        language is { Length: > 0 }
            ? WavesV1SttPostParametersLanguageExtensions.ToEnum(language)
                ?? throw new NotSupportedException(
                    $"Unknown Smallest speech-to-text language '{language}'.")
            : WavesV1SttPostParametersLanguage.En;

    /// <summary>
    /// Maps a nullable <see cref="bool"/> onto one of the generated
    /// <c>"true"</c>/<c>"false"</c> wire enums — Pulse spells these flags as
    /// strings rather than JSON booleans.
    /// <para>
    /// Resolution is by member <em>name</em>, never by ordinal: AutoSDK emits
    /// the members alphabetically (<c>False</c> before <c>True</c>), so an
    /// ordinal mapping would silently invert every flag.
    /// </para>
    /// </summary>
    private static TEnum? ToWireFlag<TEnum>(bool? value)
        where TEnum : struct, Enum =>
        value is null ? null : Enum.Parse<TEnum>(value.Value ? "True" : "False");

    private static void Add(
        Meai.AdditionalPropertiesDictionary properties,
        string key,
        object? value)
    {
        if (value is not null)
        {
            properties[key] = value;
        }
    }

    private static bool? GetBoolean(Meai.AdditionalPropertiesDictionary? properties, string key) =>
        TryGet(properties, key) switch
        {
            bool value => value,
            string text when bool.TryParse(text, out var parsed) => parsed,
            JsonElement { ValueKind: JsonValueKind.True } => true,
            JsonElement { ValueKind: JsonValueKind.False } => false,
            JsonElement { ValueKind: JsonValueKind.String } element when bool.TryParse(element.GetString(), out var parsed) => parsed,
            _ => null,
        };

    private static int? GetInt32(Meai.AdditionalPropertiesDictionary? properties, string key) =>
        TryGet(properties, key) switch
        {
            int value => value,
            long value => (int)value,
            string text when int.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed) => parsed,
            JsonElement { ValueKind: JsonValueKind.Number } element when element.TryGetInt32(out var parsed) => parsed,
            JsonElement { ValueKind: JsonValueKind.String } element when int.TryParse(element.GetString(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed) => parsed,
            _ => null,
        };

    private static string? GetString(Meai.AdditionalPropertiesDictionary? properties, string key) =>
        TryGet(properties, key) switch
        {
            string value => value,
            JsonElement { ValueKind: JsonValueKind.String } element => element.GetString(),
            { } value => value.ToString(),
            _ => null,
        };

    private static object? TryGet(Meai.AdditionalPropertiesDictionary? properties, string key) =>
        properties is not null && properties.TryGetValue(key, out var value) ? value : null;
}
