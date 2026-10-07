#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Connection fields to change. The provider must match the connection and is immutable.
    /// </summary>
    public readonly partial struct Config3 : global::System.IEquatable<Config3>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateRouteConnectionRequestV1ConfigDiscriminatorProvider? Provider { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpdateRouteConnectionConfigAnthropicV1? Anthropic { get; init; }
#else
        public global::Baseten.UpdateRouteConnectionConfigAnthropicV1? Anthropic { get; }
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
            out global::Baseten.UpdateRouteConnectionConfigAnthropicV1? value)
        {
            value = Anthropic;
            return IsAnthropic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateRouteConnectionConfigAnthropicV1 PickAnthropic() => Anthropic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Anthropic' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpdateRouteConnectionConfigOpenAIV1? Openai { get; init; }
#else
        public global::Baseten.UpdateRouteConnectionConfigOpenAIV1? Openai { get; }
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
            out global::Baseten.UpdateRouteConnectionConfigOpenAIV1? value)
        {
            value = Openai;
            return IsOpenai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateRouteConnectionConfigOpenAIV1 PickOpenai() => Openai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openai' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpdateRouteConnectionConfigXAIV1? Xai { get; init; }
#else
        public global::Baseten.UpdateRouteConnectionConfigXAIV1? Xai { get; }
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
            out global::Baseten.UpdateRouteConnectionConfigXAIV1? value)
        {
            value = Xai;
            return IsXai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateRouteConnectionConfigXAIV1 PickXai() => Xai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Xai' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config3(global::Baseten.UpdateRouteConnectionConfigAnthropicV1 value) => new Config3((global::Baseten.UpdateRouteConnectionConfigAnthropicV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpdateRouteConnectionConfigAnthropicV1?(Config3 @this) => @this.Anthropic;

        /// <summary>
        ///
        /// </summary>
        public Config3(global::Baseten.UpdateRouteConnectionConfigAnthropicV1? value)
        {
            Anthropic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config3 FromAnthropic(global::Baseten.UpdateRouteConnectionConfigAnthropicV1? value) => new Config3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config3(global::Baseten.UpdateRouteConnectionConfigOpenAIV1 value) => new Config3((global::Baseten.UpdateRouteConnectionConfigOpenAIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpdateRouteConnectionConfigOpenAIV1?(Config3 @this) => @this.Openai;

        /// <summary>
        ///
        /// </summary>
        public Config3(global::Baseten.UpdateRouteConnectionConfigOpenAIV1? value)
        {
            Openai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config3 FromOpenai(global::Baseten.UpdateRouteConnectionConfigOpenAIV1? value) => new Config3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config3(global::Baseten.UpdateRouteConnectionConfigXAIV1 value) => new Config3((global::Baseten.UpdateRouteConnectionConfigXAIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpdateRouteConnectionConfigXAIV1?(Config3 @this) => @this.Xai;

        /// <summary>
        ///
        /// </summary>
        public Config3(global::Baseten.UpdateRouteConnectionConfigXAIV1? value)
        {
            Xai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config3 FromXai(global::Baseten.UpdateRouteConnectionConfigXAIV1? value) => new Config3(value);

        /// <summary>
        ///
        /// </summary>
        public Config3(
            global::Baseten.UpdateRouteConnectionRequestV1ConfigDiscriminatorProvider? provider,
            global::Baseten.UpdateRouteConnectionConfigAnthropicV1? anthropic,
            global::Baseten.UpdateRouteConnectionConfigOpenAIV1? openai,
            global::Baseten.UpdateRouteConnectionConfigXAIV1? xai
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
            global::System.Func<global::Baseten.UpdateRouteConnectionConfigAnthropicV1, TResult>? anthropic = null,
            global::System.Func<global::Baseten.UpdateRouteConnectionConfigOpenAIV1, TResult>? openai = null,
            global::System.Func<global::Baseten.UpdateRouteConnectionConfigXAIV1, TResult>? xai = null,
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
            global::System.Action<global::Baseten.UpdateRouteConnectionConfigAnthropicV1>? anthropic = null,

            global::System.Action<global::Baseten.UpdateRouteConnectionConfigOpenAIV1>? openai = null,

            global::System.Action<global::Baseten.UpdateRouteConnectionConfigXAIV1>? xai = null,
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
            global::System.Action<global::Baseten.UpdateRouteConnectionConfigAnthropicV1>? anthropic = null,
            global::System.Action<global::Baseten.UpdateRouteConnectionConfigOpenAIV1>? openai = null,
            global::System.Action<global::Baseten.UpdateRouteConnectionConfigXAIV1>? xai = null,
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
                typeof(global::Baseten.UpdateRouteConnectionConfigAnthropicV1),
                Openai,
                typeof(global::Baseten.UpdateRouteConnectionConfigOpenAIV1),
                Xai,
                typeof(global::Baseten.UpdateRouteConnectionConfigXAIV1),
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
        public bool Equals(Config3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpdateRouteConnectionConfigAnthropicV1?>.Default.Equals(Anthropic, other.Anthropic) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpdateRouteConnectionConfigOpenAIV1?>.Default.Equals(Openai, other.Openai) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpdateRouteConnectionConfigXAIV1?>.Default.Equals(Xai, other.Xai)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Config3 obj1, Config3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Config3 obj1, Config3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config3 o && Equals(o);
        }
    }
}
