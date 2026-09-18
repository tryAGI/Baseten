#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TargetVariant1 : global::System.IEquatable<TargetVariant1>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateRouteRequestV1TargetVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.RouteTargetBasetenModelAPIV1? BasetenModelApi { get; init; }
#else
        public global::Baseten.RouteTargetBasetenModelAPIV1? BasetenModelApi { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BasetenModelApi))]
#endif
        public bool IsBasetenModelApi => BasetenModelApi != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBasetenModelApi(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.RouteTargetBasetenModelAPIV1? value)
        {
            value = BasetenModelApi;
            return IsBasetenModelApi;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetBasetenModelAPIV1 PickBasetenModelApi() => IsBasetenModelApi
            ? BasetenModelApi!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BasetenModelApi' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.RouteTargetAnthropicV1? Anthropic { get; init; }
#else
        public global::Baseten.RouteTargetAnthropicV1? Anthropic { get; }
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
            out global::Baseten.RouteTargetAnthropicV1? value)
        {
            value = Anthropic;
            return IsAnthropic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetAnthropicV1 PickAnthropic() => IsAnthropic
            ? Anthropic!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Anthropic' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.RouteTargetOpenAIV1? Openai { get; init; }
#else
        public global::Baseten.RouteTargetOpenAIV1? Openai { get; }
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
            out global::Baseten.RouteTargetOpenAIV1? value)
        {
            value = Openai;
            return IsOpenai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetOpenAIV1 PickOpenai() => IsOpenai
            ? Openai!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openai' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.RouteTargetXAIV1? Xai { get; init; }
#else
        public global::Baseten.RouteTargetXAIV1? Xai { get; }
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
            out global::Baseten.RouteTargetXAIV1? value)
        {
            value = Xai;
            return IsXai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetXAIV1 PickXai() => IsXai
            ? Xai!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Xai' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.RouteTargetVertexV1? Vertex { get; init; }
#else
        public global::Baseten.RouteTargetVertexV1? Vertex { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Vertex))]
#endif
        public bool IsVertex => Vertex != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVertex(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.RouteTargetVertexV1? value)
        {
            value = Vertex;
            return IsVertex;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetVertexV1 PickVertex() => IsVertex
            ? Vertex!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Vertex' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.RouteTargetOpenAICompatibleV1? OpenaiCompatible { get; init; }
#else
        public global::Baseten.RouteTargetOpenAICompatibleV1? OpenaiCompatible { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenaiCompatible))]
#endif
        public bool IsOpenaiCompatible => OpenaiCompatible != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenaiCompatible(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.RouteTargetOpenAICompatibleV1? value)
        {
            value = OpenaiCompatible;
            return IsOpenaiCompatible;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetOpenAICompatibleV1 PickOpenaiCompatible() => IsOpenaiCompatible
            ? OpenaiCompatible!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenaiCompatible' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.RouteTargetBasetenModelAPIV1 value) => new TargetVariant1((global::Baseten.RouteTargetBasetenModelAPIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteTargetBasetenModelAPIV1?(TargetVariant1 @this) => @this.BasetenModelApi;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.RouteTargetBasetenModelAPIV1? value)
        {
            BasetenModelApi = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromBasetenModelApi(global::Baseten.RouteTargetBasetenModelAPIV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.RouteTargetAnthropicV1 value) => new TargetVariant1((global::Baseten.RouteTargetAnthropicV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteTargetAnthropicV1?(TargetVariant1 @this) => @this.Anthropic;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.RouteTargetAnthropicV1? value)
        {
            Anthropic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromAnthropic(global::Baseten.RouteTargetAnthropicV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.RouteTargetOpenAIV1 value) => new TargetVariant1((global::Baseten.RouteTargetOpenAIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteTargetOpenAIV1?(TargetVariant1 @this) => @this.Openai;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.RouteTargetOpenAIV1? value)
        {
            Openai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromOpenai(global::Baseten.RouteTargetOpenAIV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.RouteTargetXAIV1 value) => new TargetVariant1((global::Baseten.RouteTargetXAIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteTargetXAIV1?(TargetVariant1 @this) => @this.Xai;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.RouteTargetXAIV1? value)
        {
            Xai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromXai(global::Baseten.RouteTargetXAIV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.RouteTargetVertexV1 value) => new TargetVariant1((global::Baseten.RouteTargetVertexV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteTargetVertexV1?(TargetVariant1 @this) => @this.Vertex;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.RouteTargetVertexV1? value)
        {
            Vertex = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromVertex(global::Baseten.RouteTargetVertexV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.RouteTargetOpenAICompatibleV1 value) => new TargetVariant1((global::Baseten.RouteTargetOpenAICompatibleV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteTargetOpenAICompatibleV1?(TargetVariant1 @this) => @this.OpenaiCompatible;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.RouteTargetOpenAICompatibleV1? value)
        {
            OpenaiCompatible = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromOpenaiCompatible(global::Baseten.RouteTargetOpenAICompatibleV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(
            global::Baseten.UpdateRouteRequestV1TargetVariant1DiscriminatorType? type,
            global::Baseten.RouteTargetBasetenModelAPIV1? basetenModelApi,
            global::Baseten.RouteTargetAnthropicV1? anthropic,
            global::Baseten.RouteTargetOpenAIV1? openai,
            global::Baseten.RouteTargetXAIV1? xai,
            global::Baseten.RouteTargetVertexV1? vertex,
            global::Baseten.RouteTargetOpenAICompatibleV1? openaiCompatible
            )
        {
            Type = type;

            BasetenModelApi = basetenModelApi;
            Anthropic = anthropic;
            Openai = openai;
            Xai = xai;
            Vertex = vertex;
            OpenaiCompatible = openaiCompatible;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OpenaiCompatible as object ??
            Vertex as object ??
            Xai as object ??
            Openai as object ??
            Anthropic as object ??
            BasetenModelApi as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BasetenModelApi?.ToString() ??
            Anthropic?.ToString() ??
            Openai?.ToString() ??
            Xai?.ToString() ??
            Vertex?.ToString() ??
            OpenaiCompatible?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBasetenModelApi && !IsAnthropic && !IsOpenai && !IsXai && !IsVertex && !IsOpenaiCompatible || !IsBasetenModelApi && IsAnthropic && !IsOpenai && !IsXai && !IsVertex && !IsOpenaiCompatible || !IsBasetenModelApi && !IsAnthropic && IsOpenai && !IsXai && !IsVertex && !IsOpenaiCompatible || !IsBasetenModelApi && !IsAnthropic && !IsOpenai && IsXai && !IsVertex && !IsOpenaiCompatible || !IsBasetenModelApi && !IsAnthropic && !IsOpenai && !IsXai && IsVertex && !IsOpenaiCompatible || !IsBasetenModelApi && !IsAnthropic && !IsOpenai && !IsXai && !IsVertex && IsOpenaiCompatible;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.RouteTargetBasetenModelAPIV1, TResult>? basetenModelApi = null,
            global::System.Func<global::Baseten.RouteTargetAnthropicV1, TResult>? anthropic = null,
            global::System.Func<global::Baseten.RouteTargetOpenAIV1, TResult>? openai = null,
            global::System.Func<global::Baseten.RouteTargetXAIV1, TResult>? xai = null,
            global::System.Func<global::Baseten.RouteTargetVertexV1, TResult>? vertex = null,
            global::System.Func<global::Baseten.RouteTargetOpenAICompatibleV1, TResult>? openaiCompatible = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBasetenModelApi && basetenModelApi != null)
            {
                return basetenModelApi(BasetenModelApi!);
            }
            else if (IsAnthropic && anthropic != null)
            {
                return anthropic(Anthropic!);
            }
            else if (IsOpenai && openai != null)
            {
                return openai(Openai!);
            }
            else if (IsXai && xai != null)
            {
                return xai(Xai!);
            }
            else if (IsVertex && vertex != null)
            {
                return vertex(Vertex!);
            }
            else if (IsOpenaiCompatible && openaiCompatible != null)
            {
                return openaiCompatible(OpenaiCompatible!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.RouteTargetBasetenModelAPIV1>? basetenModelApi = null,

            global::System.Action<global::Baseten.RouteTargetAnthropicV1>? anthropic = null,

            global::System.Action<global::Baseten.RouteTargetOpenAIV1>? openai = null,

            global::System.Action<global::Baseten.RouteTargetXAIV1>? xai = null,

            global::System.Action<global::Baseten.RouteTargetVertexV1>? vertex = null,

            global::System.Action<global::Baseten.RouteTargetOpenAICompatibleV1>? openaiCompatible = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBasetenModelApi)
            {
                basetenModelApi?.Invoke(BasetenModelApi!);
            }
            else if (IsAnthropic)
            {
                anthropic?.Invoke(Anthropic!);
            }
            else if (IsOpenai)
            {
                openai?.Invoke(Openai!);
            }
            else if (IsXai)
            {
                xai?.Invoke(Xai!);
            }
            else if (IsVertex)
            {
                vertex?.Invoke(Vertex!);
            }
            else if (IsOpenaiCompatible)
            {
                openaiCompatible?.Invoke(OpenaiCompatible!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.RouteTargetBasetenModelAPIV1>? basetenModelApi = null,
            global::System.Action<global::Baseten.RouteTargetAnthropicV1>? anthropic = null,
            global::System.Action<global::Baseten.RouteTargetOpenAIV1>? openai = null,
            global::System.Action<global::Baseten.RouteTargetXAIV1>? xai = null,
            global::System.Action<global::Baseten.RouteTargetVertexV1>? vertex = null,
            global::System.Action<global::Baseten.RouteTargetOpenAICompatibleV1>? openaiCompatible = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBasetenModelApi)
            {
                basetenModelApi?.Invoke(BasetenModelApi!);
            }
            else if (IsAnthropic)
            {
                anthropic?.Invoke(Anthropic!);
            }
            else if (IsOpenai)
            {
                openai?.Invoke(Openai!);
            }
            else if (IsXai)
            {
                xai?.Invoke(Xai!);
            }
            else if (IsVertex)
            {
                vertex?.Invoke(Vertex!);
            }
            else if (IsOpenaiCompatible)
            {
                openaiCompatible?.Invoke(OpenaiCompatible!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BasetenModelApi,
                typeof(global::Baseten.RouteTargetBasetenModelAPIV1),
                Anthropic,
                typeof(global::Baseten.RouteTargetAnthropicV1),
                Openai,
                typeof(global::Baseten.RouteTargetOpenAIV1),
                Xai,
                typeof(global::Baseten.RouteTargetXAIV1),
                Vertex,
                typeof(global::Baseten.RouteTargetVertexV1),
                OpenaiCompatible,
                typeof(global::Baseten.RouteTargetOpenAICompatibleV1),
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
        public bool Equals(TargetVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteTargetBasetenModelAPIV1?>.Default.Equals(BasetenModelApi, other.BasetenModelApi) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteTargetAnthropicV1?>.Default.Equals(Anthropic, other.Anthropic) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteTargetOpenAIV1?>.Default.Equals(Openai, other.Openai) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteTargetXAIV1?>.Default.Equals(Xai, other.Xai) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteTargetVertexV1?>.Default.Equals(Vertex, other.Vertex) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteTargetOpenAICompatibleV1?>.Default.Equals(OpenaiCompatible, other.OpenaiCompatible)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TargetVariant1 obj1, TargetVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TargetVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TargetVariant1 obj1, TargetVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TargetVariant1 o && Equals(o);
        }
    }
}
