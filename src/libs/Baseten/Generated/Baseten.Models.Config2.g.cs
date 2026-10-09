#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Provider the connection authenticates with, and the team secret holding its API key.
    /// </summary>
    public readonly partial struct Config2 : global::System.IEquatable<Config2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateRouteConnectionRequestV1ConfigDiscriminatorProvider? Provider { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpsertRouteConnectionConfigAnthropicV1? Anthropic { get; init; }
#else
        public global::Baseten.UpsertRouteConnectionConfigAnthropicV1? Anthropic { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anthropic))]
#endif
        public bool IsAnthropic => Anthropic != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnthropic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.UpsertRouteConnectionConfigAnthropicV1? value)
        {
            value = Anthropic;
            return IsAnthropic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertRouteConnectionConfigAnthropicV1 PickAnthropic() => Anthropic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Anthropic' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpsertRouteConnectionConfigOpenAIV1? Openai { get; init; }
#else
        public global::Baseten.UpsertRouteConnectionConfigOpenAIV1? Openai { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Openai))]
#endif
        public bool IsOpenai => Openai != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenai(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.UpsertRouteConnectionConfigOpenAIV1? value)
        {
            value = Openai;
            return IsOpenai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertRouteConnectionConfigOpenAIV1 PickOpenai() => Openai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openai' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpsertRouteConnectionConfigXAIV1? Xai { get; init; }
#else
        public global::Baseten.UpsertRouteConnectionConfigXAIV1? Xai { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Xai))]
#endif
        public bool IsXai => Xai != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickXai(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.UpsertRouteConnectionConfigXAIV1? value)
        {
            value = Xai;
            return IsXai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertRouteConnectionConfigXAIV1 PickXai() => Xai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Xai' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config2(global::Baseten.UpsertRouteConnectionConfigAnthropicV1 value) => new Config2((global::Baseten.UpsertRouteConnectionConfigAnthropicV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpsertRouteConnectionConfigAnthropicV1?(Config2 @this) => @this.Anthropic;

        /// <summary>
        ///
        /// </summary>
        public Config2(global::Baseten.UpsertRouteConnectionConfigAnthropicV1? value)
        {
            Anthropic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config2 FromAnthropic(global::Baseten.UpsertRouteConnectionConfigAnthropicV1? value) => new Config2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config2(global::Baseten.UpsertRouteConnectionConfigOpenAIV1 value) => new Config2((global::Baseten.UpsertRouteConnectionConfigOpenAIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpsertRouteConnectionConfigOpenAIV1?(Config2 @this) => @this.Openai;

        /// <summary>
        ///
        /// </summary>
        public Config2(global::Baseten.UpsertRouteConnectionConfigOpenAIV1? value)
        {
            Openai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config2 FromOpenai(global::Baseten.UpsertRouteConnectionConfigOpenAIV1? value) => new Config2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config2(global::Baseten.UpsertRouteConnectionConfigXAIV1 value) => new Config2((global::Baseten.UpsertRouteConnectionConfigXAIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpsertRouteConnectionConfigXAIV1?(Config2 @this) => @this.Xai;

        /// <summary>
        ///
        /// </summary>
        public Config2(global::Baseten.UpsertRouteConnectionConfigXAIV1? value)
        {
            Xai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config2 FromXai(global::Baseten.UpsertRouteConnectionConfigXAIV1? value) => new Config2(value);

        /// <summary>
        ///
        /// </summary>
        public Config2(
            global::Baseten.CreateRouteConnectionRequestV1ConfigDiscriminatorProvider? provider,
            global::Baseten.UpsertRouteConnectionConfigAnthropicV1? anthropic,
            global::Baseten.UpsertRouteConnectionConfigOpenAIV1? openai,
            global::Baseten.UpsertRouteConnectionConfigXAIV1? xai
            )
        {
            Provider = provider;

            Anthropic = anthropic;
            Openai = openai;
            Xai = xai;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Xai as object ??
            Openai as object ??
            Anthropic as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Anthropic?.ToString() ??
            Openai?.ToString() ??
            Xai?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAnthropic && !IsOpenai && !IsXai || !IsAnthropic && IsOpenai && !IsXai || !IsAnthropic && !IsOpenai && IsXai;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.UpsertRouteConnectionConfigAnthropicV1, TResult>? anthropic = null,
            global::System.Func<global::Baseten.UpsertRouteConnectionConfigOpenAIV1, TResult>? openai = null,
            global::System.Func<global::Baseten.UpsertRouteConnectionConfigXAIV1, TResult>? xai = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Anthropic is { } __value0 && anthropic != null)
            {
                return anthropic(__value0);
            }
            else if (Openai is { } __value1 && openai != null)
            {
                return openai(__value1);
            }
            else if (Xai is { } __value2 && xai != null)
            {
                return xai(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.UpsertRouteConnectionConfigAnthropicV1>? anthropic = null,

            global::System.Action<global::Baseten.UpsertRouteConnectionConfigOpenAIV1>? openai = null,

            global::System.Action<global::Baseten.UpsertRouteConnectionConfigXAIV1>? xai = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Anthropic is { } __value0)
            {
                anthropic?.Invoke(__value0);
            }
            else if (Openai is { } __value1)
            {
                openai?.Invoke(__value1);
            }
            else if (Xai is { } __value2)
            {
                xai?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.UpsertRouteConnectionConfigAnthropicV1>? anthropic = null,
            global::System.Action<global::Baseten.UpsertRouteConnectionConfigOpenAIV1>? openai = null,
            global::System.Action<global::Baseten.UpsertRouteConnectionConfigXAIV1>? xai = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Anthropic is { } __value0)
            {
                anthropic?.Invoke(__value0);
            }
            else if (Openai is { } __value1)
            {
                openai?.Invoke(__value1);
            }
            else if (Xai is { } __value2)
            {
                xai?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Anthropic,
                typeof(global::Baseten.UpsertRouteConnectionConfigAnthropicV1),
                Openai,
                typeof(global::Baseten.UpsertRouteConnectionConfigOpenAIV1),
                Xai,
                typeof(global::Baseten.UpsertRouteConnectionConfigXAIV1),
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
        public bool Equals(Config2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpsertRouteConnectionConfigAnthropicV1?>.Default.Equals(Anthropic, other.Anthropic) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpsertRouteConnectionConfigOpenAIV1?>.Default.Equals(Openai, other.Openai) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpsertRouteConnectionConfigXAIV1?>.Default.Equals(Xai, other.Xai)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Config2 obj1, Config2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Config2 obj1, Config2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config2 o && Equals(o);
        }
    }
}
