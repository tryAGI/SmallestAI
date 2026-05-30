#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SpeechToTextTranscribeResponse200 : global::System.IEquatable<SpeechToTextTranscribeResponse200>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::SmallestAI.TranscriptionResponse? TranscriptionResponse { get; init; }
#else
        public global::SmallestAI.TranscriptionResponse? TranscriptionResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptionResponse))]
#endif
        public bool IsTranscriptionResponse => TranscriptionResponse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTranscriptionResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::SmallestAI.TranscriptionResponse? value)
        {
            value = TranscriptionResponse;
            return IsTranscriptionResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::SmallestAI.TranscriptionResponse PickTranscriptionResponse() => IsTranscriptionResponse
            ? TranscriptionResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TranscriptionResponse' but the value was {ToString()}.");

        /// <summary>
        /// Returned by Pulse Pro when `webhook_url` is set. The transcription arrives on the webhook when ready.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::SmallestAI.AsyncAccepted? AsyncAccepted { get; init; }
#else
        public global::SmallestAI.AsyncAccepted? AsyncAccepted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsyncAccepted))]
#endif
        public bool IsAsyncAccepted => AsyncAccepted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAsyncAccepted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::SmallestAI.AsyncAccepted? value)
        {
            value = AsyncAccepted;
            return IsAsyncAccepted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::SmallestAI.AsyncAccepted PickAsyncAccepted() => IsAsyncAccepted
            ? AsyncAccepted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AsyncAccepted' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeechToTextTranscribeResponse200(global::SmallestAI.TranscriptionResponse value) => new SpeechToTextTranscribeResponse200((global::SmallestAI.TranscriptionResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::SmallestAI.TranscriptionResponse?(SpeechToTextTranscribeResponse200 @this) => @this.TranscriptionResponse;

        /// <summary>
        /// 
        /// </summary>
        public SpeechToTextTranscribeResponse200(global::SmallestAI.TranscriptionResponse? value)
        {
            TranscriptionResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SpeechToTextTranscribeResponse200 FromTranscriptionResponse(global::SmallestAI.TranscriptionResponse? value) => new SpeechToTextTranscribeResponse200(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeechToTextTranscribeResponse200(global::SmallestAI.AsyncAccepted value) => new SpeechToTextTranscribeResponse200((global::SmallestAI.AsyncAccepted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::SmallestAI.AsyncAccepted?(SpeechToTextTranscribeResponse200 @this) => @this.AsyncAccepted;

        /// <summary>
        /// 
        /// </summary>
        public SpeechToTextTranscribeResponse200(global::SmallestAI.AsyncAccepted? value)
        {
            AsyncAccepted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SpeechToTextTranscribeResponse200 FromAsyncAccepted(global::SmallestAI.AsyncAccepted? value) => new SpeechToTextTranscribeResponse200(value);

        /// <summary>
        /// 
        /// </summary>
        public SpeechToTextTranscribeResponse200(
            global::SmallestAI.TranscriptionResponse? transcriptionResponse,
            global::SmallestAI.AsyncAccepted? asyncAccepted
            )
        {
            TranscriptionResponse = transcriptionResponse;
            AsyncAccepted = asyncAccepted;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AsyncAccepted as object ??
            TranscriptionResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TranscriptionResponse?.ToString() ??
            AsyncAccepted?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTranscriptionResponse && !IsAsyncAccepted || !IsTranscriptionResponse && IsAsyncAccepted;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::SmallestAI.TranscriptionResponse, TResult>? transcriptionResponse = null,
            global::System.Func<global::SmallestAI.AsyncAccepted, TResult>? asyncAccepted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptionResponse && transcriptionResponse != null)
            {
                return transcriptionResponse(TranscriptionResponse!);
            }
            else if (IsAsyncAccepted && asyncAccepted != null)
            {
                return asyncAccepted(AsyncAccepted!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::SmallestAI.TranscriptionResponse>? transcriptionResponse = null,

            global::System.Action<global::SmallestAI.AsyncAccepted>? asyncAccepted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptionResponse)
            {
                transcriptionResponse?.Invoke(TranscriptionResponse!);
            }
            else if (IsAsyncAccepted)
            {
                asyncAccepted?.Invoke(AsyncAccepted!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::SmallestAI.TranscriptionResponse>? transcriptionResponse = null,
            global::System.Action<global::SmallestAI.AsyncAccepted>? asyncAccepted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptionResponse)
            {
                transcriptionResponse?.Invoke(TranscriptionResponse!);
            }
            else if (IsAsyncAccepted)
            {
                asyncAccepted?.Invoke(AsyncAccepted!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TranscriptionResponse,
                typeof(global::SmallestAI.TranscriptionResponse),
                AsyncAccepted,
                typeof(global::SmallestAI.AsyncAccepted),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(SpeechToTextTranscribeResponse200 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::SmallestAI.TranscriptionResponse?>.Default.Equals(TranscriptionResponse, other.TranscriptionResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::SmallestAI.AsyncAccepted?>.Default.Equals(AsyncAccepted, other.AsyncAccepted) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SpeechToTextTranscribeResponse200 obj1, SpeechToTextTranscribeResponse200 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SpeechToTextTranscribeResponse200>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SpeechToTextTranscribeResponse200 obj1, SpeechToTextTranscribeResponse200 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpeechToTextTranscribeResponse200 o && Equals(o);
        }
    }
}
