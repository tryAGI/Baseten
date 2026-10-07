#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Provider the connection authenticates with, and the team secret holding its API key.
    /// </summary>
    public readonly partial struct Config : global::System.IEquatable<Config>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteConnectionV1ConfigDiscriminatorProvider? Provider { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.RouteConnectionAnthropicV1? Anthropic { get; init; }
#else
        public global::Baseten.RouteConnectionAnthropicV1? Anthropic { get; }
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
            out global::Baseten.RouteConnectionAnthropicV1? value)
        {
            value = Anthropic;
            return IsAnthropic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteConnectionAnthropicV1 PickAnthropic() => Anthropic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Anthropic' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.RouteConnectionOpenAIV1? Openai { get; init; }
#else
        public global::Baseten.RouteConnectionOpenAIV1? Openai { get; }
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
            out global::Baseten.RouteConnectionOpenAIV1? value)
        {
            value = Openai;
            return IsOpenai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteConnectionOpenAIV1 PickOpenai() => Openai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openai' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.RouteConnectionXAIV1? Xai { get; init; }
#else
        public global::Baseten.RouteConnectionXAIV1? Xai { get; }
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
            out global::Baseten.RouteConnectionXAIV1? value)
        {
            value = Xai;
            return IsXai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteConnectionXAIV1 PickXai() => Xai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Xai' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config(global::Baseten.RouteConnectionAnthropicV1 value) => new Config((global::Baseten.RouteConnectionAnthropicV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteConnectionAnthropicV1?(Config @this) => @this.Anthropic;

        /// <summary>
        ///
        /// </summary>
        public Config(global::Baseten.RouteConnectionAnthropicV1? value)
        {
            Anthropic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config FromAnthropic(global::Baseten.RouteConnectionAnthropicV1? value) => new Config(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config(global::Baseten.RouteConnectionOpenAIV1 value) => new Config((global::Baseten.RouteConnectionOpenAIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteConnectionOpenAIV1?(Config @this) => @this.Openai;

        /// <summary>
        ///
        /// </summary>
        public Config(global::Baseten.RouteConnectionOpenAIV1? value)
        {
            Openai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config FromOpenai(global::Baseten.RouteConnectionOpenAIV1? value) => new Config(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config(global::Baseten.RouteConnectionXAIV1 value) => new Config((global::Baseten.RouteConnectionXAIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteConnectionXAIV1?(Config @this) => @this.Xai;

        /// <summary>
        ///
        /// </summary>
        public Config(global::Baseten.RouteConnectionXAIV1? value)
        {
            Xai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config FromXai(global::Baseten.RouteConnectionXAIV1? value) => new Config(value);

        /// <summary>
        ///
        /// </summary>
        public Config(
            global::Baseten.RouteConnectionV1ConfigDiscriminatorProvider? provider,
            global::Baseten.RouteConnectionAnthropicV1? anthropic,
            global::Baseten.RouteConnectionOpenAIV1? openai,
            global::Baseten.RouteConnectionXAIV1? xai
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
            global::System.Func<global::Baseten.RouteConnectionAnthropicV1, TResult>? anthropic = null,
            global::System.Func<global::Baseten.RouteConnectionOpenAIV1, TResult>? openai = null,
            global::System.Func<global::Baseten.RouteConnectionXAIV1, TResult>? xai = null,
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
            global::System.Action<global::Baseten.RouteConnectionAnthropicV1>? anthropic = null,

            global::System.Action<global::Baseten.RouteConnectionOpenAIV1>? openai = null,

            global::System.Action<global::Baseten.RouteConnectionXAIV1>? xai = null,
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
            global::System.Action<global::Baseten.RouteConnectionAnthropicV1>? anthropic = null,
            global::System.Action<global::Baseten.RouteConnectionOpenAIV1>? openai = null,
            global::System.Action<global::Baseten.RouteConnectionXAIV1>? xai = null,
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
                typeof(global::Baseten.RouteConnectionAnthropicV1),
                Openai,
                typeof(global::Baseten.RouteConnectionOpenAIV1),
                Xai,
                typeof(global::Baseten.RouteConnectionXAIV1),
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
        public bool Equals(Config other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteConnectionAnthropicV1?>.Default.Equals(Anthropic, other.Anthropic) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteConnectionOpenAIV1?>.Default.Equals(Openai, other.Openai) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteConnectionXAIV1?>.Default.Equals(Xai, other.Xai)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Config obj1, Config obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Config obj1, Config obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config o && Equals(o);
        }
    }
}
