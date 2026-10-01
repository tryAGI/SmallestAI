#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Validation detail. On query-parameter failures, an array of entries with the parameter `path` and a `message`. On request-body failures, a string.
    /// </summary>
    public readonly partial struct SttErrorResponseErrors : global::System.IEquatable<SttErrorResponseErrors>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::SmallestAI.SttErrorResponseErrorsOneOf0Items>? SttErrorResponseErrors0 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::SmallestAI.SttErrorResponseErrorsOneOf0Items>? SttErrorResponseErrors0 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SttErrorResponseErrors0))]
#endif
        public bool IsSttErrorResponseErrors0 => SttErrorResponseErrors0 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSttErrorResponseErrors0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::SmallestAI.SttErrorResponseErrorsOneOf0Items>? value)
        {
            value = SttErrorResponseErrors0;
            return IsSttErrorResponseErrors0;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SmallestAI.SttErrorResponseErrorsOneOf0Items> PickSttErrorResponseErrors0() => SttErrorResponseErrors0 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SttErrorResponseErrors0' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? SttErrorResponseErrorsVariant2 { get; init; }
#else
        public string? SttErrorResponseErrorsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SttErrorResponseErrorsVariant2))]
#endif
        public bool IsSttErrorResponseErrorsVariant2 => SttErrorResponseErrorsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSttErrorResponseErrorsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = SttErrorResponseErrorsVariant2;
            return IsSttErrorResponseErrorsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickSttErrorResponseErrorsVariant2() => SttErrorResponseErrorsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SttErrorResponseErrorsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SttErrorResponseErrors(string value) => new SttErrorResponseErrors((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(SttErrorResponseErrors @this) => @this.SttErrorResponseErrorsVariant2;

        /// <summary>
        ///
        /// </summary>
        public SttErrorResponseErrors(string? value)
        {
            SttErrorResponseErrorsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SttErrorResponseErrors FromSttErrorResponseErrorsVariant2(string? value) => new SttErrorResponseErrors(value);

        /// <summary>
        ///
        /// </summary>
        public SttErrorResponseErrors(
            global::System.Collections.Generic.IList<global::SmallestAI.SttErrorResponseErrorsOneOf0Items>? sttErrorResponseErrors0,
            string? sttErrorResponseErrorsVariant2
            )
        {
            SttErrorResponseErrors0 = sttErrorResponseErrors0;
            SttErrorResponseErrorsVariant2 = sttErrorResponseErrorsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SttErrorResponseErrorsVariant2 as object ??
            SttErrorResponseErrors0 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SttErrorResponseErrors0?.ToString() ??
            SttErrorResponseErrorsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSttErrorResponseErrors0 && !IsSttErrorResponseErrorsVariant2 || !IsSttErrorResponseErrors0 && IsSttErrorResponseErrorsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::SmallestAI.SttErrorResponseErrorsOneOf0Items>, TResult>? sttErrorResponseErrors0 = null,
            global::System.Func<string, TResult>? sttErrorResponseErrorsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SttErrorResponseErrors0 is { } __value0 && sttErrorResponseErrors0 != null)
            {
                return sttErrorResponseErrors0(__value0);
            }
            else if (SttErrorResponseErrorsVariant2 is { } __value1 && sttErrorResponseErrorsVariant2 != null)
            {
                return sttErrorResponseErrorsVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::SmallestAI.SttErrorResponseErrorsOneOf0Items>>? sttErrorResponseErrors0 = null,

            global::System.Action<string>? sttErrorResponseErrorsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SttErrorResponseErrors0 is { } __value0)
            {
                sttErrorResponseErrors0?.Invoke(__value0);
            }
            else if (SttErrorResponseErrorsVariant2 is { } __value1)
            {
                sttErrorResponseErrorsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::SmallestAI.SttErrorResponseErrorsOneOf0Items>>? sttErrorResponseErrors0 = null,
            global::System.Action<string>? sttErrorResponseErrorsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SttErrorResponseErrors0 is { } __value0)
            {
                sttErrorResponseErrors0?.Invoke(__value0);
            }
            else if (SttErrorResponseErrorsVariant2 is { } __value1)
            {
                sttErrorResponseErrorsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SttErrorResponseErrors0,
                typeof(global::System.Collections.Generic.IList<global::SmallestAI.SttErrorResponseErrorsOneOf0Items>),
                SttErrorResponseErrorsVariant2,
                typeof(string),
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
        public bool Equals(SttErrorResponseErrors other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::SmallestAI.SttErrorResponseErrorsOneOf0Items>?>.Default.Equals(SttErrorResponseErrors0, other.SttErrorResponseErrors0) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(SttErrorResponseErrorsVariant2, other.SttErrorResponseErrorsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SttErrorResponseErrors obj1, SttErrorResponseErrors obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SttErrorResponseErrors>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SttErrorResponseErrors obj1, SttErrorResponseErrors obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SttErrorResponseErrors o && Equals(o);
        }
    }
}
