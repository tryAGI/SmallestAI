#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestStop : global::System.IEquatable<ChatCompletionRequestStop>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChatCompletionRequestStopVariant1 { get; init; }
#else
        public string? ChatCompletionRequestStopVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatCompletionRequestStopVariant1))]
#endif
        public bool IsChatCompletionRequestStopVariant1 => ChatCompletionRequestStopVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatCompletionRequestStopVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ChatCompletionRequestStopVariant1;
            return IsChatCompletionRequestStopVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickChatCompletionRequestStopVariant1() => IsChatCompletionRequestStopVariant1
            ? ChatCompletionRequestStopVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatCompletionRequestStopVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? ChatCompletionRequestStopVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? ChatCompletionRequestStopVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatCompletionRequestStopVariant2))]
#endif
        public bool IsChatCompletionRequestStopVariant2 => ChatCompletionRequestStopVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatCompletionRequestStopVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = ChatCompletionRequestStopVariant2;
            return IsChatCompletionRequestStopVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickChatCompletionRequestStopVariant2() => IsChatCompletionRequestStopVariant2
            ? ChatCompletionRequestStopVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatCompletionRequestStopVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestStop(string value) => new ChatCompletionRequestStop((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatCompletionRequestStop @this) => @this.ChatCompletionRequestStopVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestStop(string? value)
        {
            ChatCompletionRequestStopVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatCompletionRequestStop FromChatCompletionRequestStopVariant1(string? value) => new ChatCompletionRequestStop(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestStop(
            string? chatCompletionRequestStopVariant1,
            global::System.Collections.Generic.IList<string>? chatCompletionRequestStopVariant2
            )
        {
            ChatCompletionRequestStopVariant1 = chatCompletionRequestStopVariant1;
            ChatCompletionRequestStopVariant2 = chatCompletionRequestStopVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatCompletionRequestStopVariant2 as object ??
            ChatCompletionRequestStopVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatCompletionRequestStopVariant1?.ToString() ??
            ChatCompletionRequestStopVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatCompletionRequestStopVariant1 && !IsChatCompletionRequestStopVariant2 || !IsChatCompletionRequestStopVariant1 && IsChatCompletionRequestStopVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? chatCompletionRequestStopVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? chatCompletionRequestStopVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionRequestStopVariant1 && chatCompletionRequestStopVariant1 != null)
            {
                return chatCompletionRequestStopVariant1(ChatCompletionRequestStopVariant1!);
            }
            else if (IsChatCompletionRequestStopVariant2 && chatCompletionRequestStopVariant2 != null)
            {
                return chatCompletionRequestStopVariant2(ChatCompletionRequestStopVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? chatCompletionRequestStopVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? chatCompletionRequestStopVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionRequestStopVariant1)
            {
                chatCompletionRequestStopVariant1?.Invoke(ChatCompletionRequestStopVariant1!);
            }
            else if (IsChatCompletionRequestStopVariant2)
            {
                chatCompletionRequestStopVariant2?.Invoke(ChatCompletionRequestStopVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? chatCompletionRequestStopVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? chatCompletionRequestStopVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionRequestStopVariant1)
            {
                chatCompletionRequestStopVariant1?.Invoke(ChatCompletionRequestStopVariant1!);
            }
            else if (IsChatCompletionRequestStopVariant2)
            {
                chatCompletionRequestStopVariant2?.Invoke(ChatCompletionRequestStopVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatCompletionRequestStopVariant1,
                typeof(string),
                ChatCompletionRequestStopVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
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
        public bool Equals(ChatCompletionRequestStop other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChatCompletionRequestStopVariant1, other.ChatCompletionRequestStopVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(ChatCompletionRequestStopVariant2, other.ChatCompletionRequestStopVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestStop obj1, ChatCompletionRequestStop obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestStop>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestStop obj1, ChatCompletionRequestStop obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestStop o && Equals(o);
        }
    }
}
