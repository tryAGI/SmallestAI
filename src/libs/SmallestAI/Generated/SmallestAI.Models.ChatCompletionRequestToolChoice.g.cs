#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestToolChoice : global::System.IEquatable<ChatCompletionRequestToolChoice>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::SmallestAI.ChatCompletionRequestToolChoice0? ChatCompletionRequestToolChoice0 { get; init; }
#else
        public global::SmallestAI.ChatCompletionRequestToolChoice0? ChatCompletionRequestToolChoice0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatCompletionRequestToolChoice0))]
#endif
        public bool IsChatCompletionRequestToolChoice0 => ChatCompletionRequestToolChoice0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatCompletionRequestToolChoice0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::SmallestAI.ChatCompletionRequestToolChoice0? value)
        {
            value = ChatCompletionRequestToolChoice0;
            return IsChatCompletionRequestToolChoice0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestToolChoice0 PickChatCompletionRequestToolChoice0() => IsChatCompletionRequestToolChoice0
            ? ChatCompletionRequestToolChoice0!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatCompletionRequestToolChoice0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::SmallestAI.ChatCompletionRequestToolChoice1? ChatCompletionRequestToolChoice1 { get; init; }
#else
        public global::SmallestAI.ChatCompletionRequestToolChoice1? ChatCompletionRequestToolChoice1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatCompletionRequestToolChoice1))]
#endif
        public bool IsChatCompletionRequestToolChoice1 => ChatCompletionRequestToolChoice1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatCompletionRequestToolChoice1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::SmallestAI.ChatCompletionRequestToolChoice1? value)
        {
            value = ChatCompletionRequestToolChoice1;
            return IsChatCompletionRequestToolChoice1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::SmallestAI.ChatCompletionRequestToolChoice1 PickChatCompletionRequestToolChoice1() => IsChatCompletionRequestToolChoice1
            ? ChatCompletionRequestToolChoice1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatCompletionRequestToolChoice1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestToolChoice(global::SmallestAI.ChatCompletionRequestToolChoice0 value) => new ChatCompletionRequestToolChoice((global::SmallestAI.ChatCompletionRequestToolChoice0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::SmallestAI.ChatCompletionRequestToolChoice0?(ChatCompletionRequestToolChoice @this) => @this.ChatCompletionRequestToolChoice0;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestToolChoice(global::SmallestAI.ChatCompletionRequestToolChoice0? value)
        {
            ChatCompletionRequestToolChoice0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatCompletionRequestToolChoice FromChatCompletionRequestToolChoice0(global::SmallestAI.ChatCompletionRequestToolChoice0? value) => new ChatCompletionRequestToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestToolChoice(global::SmallestAI.ChatCompletionRequestToolChoice1 value) => new ChatCompletionRequestToolChoice((global::SmallestAI.ChatCompletionRequestToolChoice1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::SmallestAI.ChatCompletionRequestToolChoice1?(ChatCompletionRequestToolChoice @this) => @this.ChatCompletionRequestToolChoice1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestToolChoice(global::SmallestAI.ChatCompletionRequestToolChoice1? value)
        {
            ChatCompletionRequestToolChoice1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatCompletionRequestToolChoice FromChatCompletionRequestToolChoice1(global::SmallestAI.ChatCompletionRequestToolChoice1? value) => new ChatCompletionRequestToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestToolChoice(
            global::SmallestAI.ChatCompletionRequestToolChoice0? chatCompletionRequestToolChoice0,
            global::SmallestAI.ChatCompletionRequestToolChoice1? chatCompletionRequestToolChoice1
            )
        {
            ChatCompletionRequestToolChoice0 = chatCompletionRequestToolChoice0;
            ChatCompletionRequestToolChoice1 = chatCompletionRequestToolChoice1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatCompletionRequestToolChoice1 as object ??
            ChatCompletionRequestToolChoice0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatCompletionRequestToolChoice0?.ToValueString() ??
            ChatCompletionRequestToolChoice1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatCompletionRequestToolChoice0 && !IsChatCompletionRequestToolChoice1 || !IsChatCompletionRequestToolChoice0 && IsChatCompletionRequestToolChoice1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::SmallestAI.ChatCompletionRequestToolChoice0?, TResult>? chatCompletionRequestToolChoice0 = null,
            global::System.Func<global::SmallestAI.ChatCompletionRequestToolChoice1, TResult>? chatCompletionRequestToolChoice1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionRequestToolChoice0 && chatCompletionRequestToolChoice0 != null)
            {
                return chatCompletionRequestToolChoice0(ChatCompletionRequestToolChoice0!);
            }
            else if (IsChatCompletionRequestToolChoice1 && chatCompletionRequestToolChoice1 != null)
            {
                return chatCompletionRequestToolChoice1(ChatCompletionRequestToolChoice1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::SmallestAI.ChatCompletionRequestToolChoice0?>? chatCompletionRequestToolChoice0 = null,

            global::System.Action<global::SmallestAI.ChatCompletionRequestToolChoice1>? chatCompletionRequestToolChoice1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionRequestToolChoice0)
            {
                chatCompletionRequestToolChoice0?.Invoke(ChatCompletionRequestToolChoice0!);
            }
            else if (IsChatCompletionRequestToolChoice1)
            {
                chatCompletionRequestToolChoice1?.Invoke(ChatCompletionRequestToolChoice1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::SmallestAI.ChatCompletionRequestToolChoice0?>? chatCompletionRequestToolChoice0 = null,
            global::System.Action<global::SmallestAI.ChatCompletionRequestToolChoice1>? chatCompletionRequestToolChoice1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionRequestToolChoice0)
            {
                chatCompletionRequestToolChoice0?.Invoke(ChatCompletionRequestToolChoice0!);
            }
            else if (IsChatCompletionRequestToolChoice1)
            {
                chatCompletionRequestToolChoice1?.Invoke(ChatCompletionRequestToolChoice1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatCompletionRequestToolChoice0,
                typeof(global::SmallestAI.ChatCompletionRequestToolChoice0),
                ChatCompletionRequestToolChoice1,
                typeof(global::SmallestAI.ChatCompletionRequestToolChoice1),
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
        public bool Equals(ChatCompletionRequestToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::SmallestAI.ChatCompletionRequestToolChoice0?>.Default.Equals(ChatCompletionRequestToolChoice0, other.ChatCompletionRequestToolChoice0) &&
                global::System.Collections.Generic.EqualityComparer<global::SmallestAI.ChatCompletionRequestToolChoice1?>.Default.Equals(ChatCompletionRequestToolChoice1, other.ChatCompletionRequestToolChoice1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestToolChoice obj1, ChatCompletionRequestToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestToolChoice obj1, ChatCompletionRequestToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestToolChoice o && Equals(o);
        }
    }
}
