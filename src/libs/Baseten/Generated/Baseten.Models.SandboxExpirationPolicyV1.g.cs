#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Expiration policy. The type determines whether value is a duration or an absolute timestamp.
    /// </summary>
    public readonly partial struct SandboxExpirationPolicyV1 : global::System.IEquatable<SandboxExpirationPolicyV1>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxExpirationPolicyV1DiscriminatorType? Type { get; }

        /// <summary>
        /// Delete after the specified period of inactivity.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.SandboxTTLIdleExpirationPolicyV1? TtlIdle { get; init; }
#else
        public global::Baseten.SandboxTTLIdleExpirationPolicyV1? TtlIdle { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TtlIdle))]
#endif
        public bool IsTtlIdle => TtlIdle != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTtlIdle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.SandboxTTLIdleExpirationPolicyV1? value)
        {
            value = TtlIdle;
            return IsTtlIdle;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxTTLIdleExpirationPolicyV1 PickTtlIdle() => TtlIdle is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TtlIdle' but the value was {ToString()}.");

        /// <summary>
        /// Delete after the specified total lifetime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1? TtlMaxAge { get; init; }
#else
        public global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1? TtlMaxAge { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TtlMaxAge))]
#endif
        public bool IsTtlMaxAge => TtlMaxAge != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTtlMaxAge(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1? value)
        {
            value = TtlMaxAge;
            return IsTtlMaxAge;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1 PickTtlMaxAge() => TtlMaxAge is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TtlMaxAge' but the value was {ToString()}.");

        /// <summary>
        /// Delete at the specified absolute timestamp.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.SandboxDateExpirationPolicyV1? Date { get; init; }
#else
        public global::Baseten.SandboxDateExpirationPolicyV1? Date { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Date))]
#endif
        public bool IsDate => Date != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.SandboxDateExpirationPolicyV1? value)
        {
            value = Date;
            return IsDate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxDateExpirationPolicyV1 PickDate() => Date is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Date' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxExpirationPolicyV1(global::Baseten.SandboxTTLIdleExpirationPolicyV1 value) => new SandboxExpirationPolicyV1((global::Baseten.SandboxTTLIdleExpirationPolicyV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.SandboxTTLIdleExpirationPolicyV1?(SandboxExpirationPolicyV1 @this) => @this.TtlIdle;

        /// <summary>
        ///
        /// </summary>
        public SandboxExpirationPolicyV1(global::Baseten.SandboxTTLIdleExpirationPolicyV1? value)
        {
            TtlIdle = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxExpirationPolicyV1 FromTtlIdle(global::Baseten.SandboxTTLIdleExpirationPolicyV1? value) => new SandboxExpirationPolicyV1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxExpirationPolicyV1(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1 value) => new SandboxExpirationPolicyV1((global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1?(SandboxExpirationPolicyV1 @this) => @this.TtlMaxAge;

        /// <summary>
        ///
        /// </summary>
        public SandboxExpirationPolicyV1(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1? value)
        {
            TtlMaxAge = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxExpirationPolicyV1 FromTtlMaxAge(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1? value) => new SandboxExpirationPolicyV1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxExpirationPolicyV1(global::Baseten.SandboxDateExpirationPolicyV1 value) => new SandboxExpirationPolicyV1((global::Baseten.SandboxDateExpirationPolicyV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.SandboxDateExpirationPolicyV1?(SandboxExpirationPolicyV1 @this) => @this.Date;

        /// <summary>
        ///
        /// </summary>
        public SandboxExpirationPolicyV1(global::Baseten.SandboxDateExpirationPolicyV1? value)
        {
            Date = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxExpirationPolicyV1 FromDate(global::Baseten.SandboxDateExpirationPolicyV1? value) => new SandboxExpirationPolicyV1(value);

        /// <summary>
        ///
        /// </summary>
        public SandboxExpirationPolicyV1(
            global::Baseten.SandboxExpirationPolicyV1DiscriminatorType? type,
            global::Baseten.SandboxTTLIdleExpirationPolicyV1? ttlIdle,
            global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1? ttlMaxAge,
            global::Baseten.SandboxDateExpirationPolicyV1? date
            )
        {
            Type = type;

            TtlIdle = ttlIdle;
            TtlMaxAge = ttlMaxAge;
            Date = date;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Date as object ??
            TtlMaxAge as object ??
            TtlIdle as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TtlIdle?.ToString() ??
            TtlMaxAge?.ToString() ??
            Date?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTtlIdle && !IsTtlMaxAge && !IsDate || !IsTtlIdle && IsTtlMaxAge && !IsDate || !IsTtlIdle && !IsTtlMaxAge && IsDate;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.SandboxTTLIdleExpirationPolicyV1, TResult>? ttlIdle = null,
            global::System.Func<global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1, TResult>? ttlMaxAge = null,
            global::System.Func<global::Baseten.SandboxDateExpirationPolicyV1, TResult>? date = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TtlIdle is { } __value0 && ttlIdle != null)
            {
                return ttlIdle(__value0);
            }
            else if (TtlMaxAge is { } __value1 && ttlMaxAge != null)
            {
                return ttlMaxAge(__value1);
            }
            else if (Date is { } __value2 && date != null)
            {
                return date(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.SandboxTTLIdleExpirationPolicyV1>? ttlIdle = null,

            global::System.Action<global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1>? ttlMaxAge = null,

            global::System.Action<global::Baseten.SandboxDateExpirationPolicyV1>? date = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TtlIdle is { } __value0)
            {
                ttlIdle?.Invoke(__value0);
            }
            else if (TtlMaxAge is { } __value1)
            {
                ttlMaxAge?.Invoke(__value1);
            }
            else if (Date is { } __value2)
            {
                date?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.SandboxTTLIdleExpirationPolicyV1>? ttlIdle = null,
            global::System.Action<global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1>? ttlMaxAge = null,
            global::System.Action<global::Baseten.SandboxDateExpirationPolicyV1>? date = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TtlIdle is { } __value0)
            {
                ttlIdle?.Invoke(__value0);
            }
            else if (TtlMaxAge is { } __value1)
            {
                ttlMaxAge?.Invoke(__value1);
            }
            else if (Date is { } __value2)
            {
                date?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TtlIdle,
                typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1),
                TtlMaxAge,
                typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1),
                Date,
                typeof(global::Baseten.SandboxDateExpirationPolicyV1),
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
        public bool Equals(SandboxExpirationPolicyV1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.SandboxTTLIdleExpirationPolicyV1?>.Default.Equals(TtlIdle, other.TtlIdle) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1?>.Default.Equals(TtlMaxAge, other.TtlMaxAge) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.SandboxDateExpirationPolicyV1?>.Default.Equals(Date, other.Date)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SandboxExpirationPolicyV1 obj1, SandboxExpirationPolicyV1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SandboxExpirationPolicyV1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SandboxExpirationPolicyV1 obj1, SandboxExpirationPolicyV1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SandboxExpirationPolicyV1 o && Equals(o);
        }
    }
}
