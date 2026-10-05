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
        public global::Baseten.RouteTargetConfigBasetenModelAPIV1? BasetenModelApi { get; init; }
#else
        public global::Baseten.RouteTargetConfigBasetenModelAPIV1? BasetenModelApi { get; }
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
            out global::Baseten.RouteTargetConfigBasetenModelAPIV1? value)
        {
            value = BasetenModelApi;
            return IsBasetenModelApi;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetConfigBasetenModelAPIV1 PickBasetenModelApi() => BasetenModelApi is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BasetenModelApi' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.RouteTargetConfigAnthropicV1? Anthropic { get; init; }
#else
        public global::Baseten.RouteTargetConfigAnthropicV1? Anthropic { get; }
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
            out global::Baseten.RouteTargetConfigAnthropicV1? value)
        {
            value = Anthropic;
            return IsAnthropic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetConfigAnthropicV1 PickAnthropic() => Anthropic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Anthropic' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.RouteTargetConfigOpenAIV1? Openai { get; init; }
#else
        public global::Baseten.RouteTargetConfigOpenAIV1? Openai { get; }
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
            out global::Baseten.RouteTargetConfigOpenAIV1? value)
        {
            value = Openai;
            return IsOpenai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetConfigOpenAIV1 PickOpenai() => Openai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openai' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.RouteTargetConfigXAIV1? Xai { get; init; }
#else
        public global::Baseten.RouteTargetConfigXAIV1? Xai { get; }
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
            out global::Baseten.RouteTargetConfigXAIV1? value)
        {
            value = Xai;
            return IsXai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetConfigXAIV1 PickXai() => Xai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Xai' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.RouteTargetConfigClassifierModelBasedV1? ClassifierModelBased { get; init; }
#else
        public global::Baseten.RouteTargetConfigClassifierModelBasedV1? ClassifierModelBased { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClassifierModelBased))]
#endif
        public bool IsClassifierModelBased => ClassifierModelBased != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClassifierModelBased(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.RouteTargetConfigClassifierModelBasedV1? value)
        {
            value = ClassifierModelBased;
            return IsClassifierModelBased;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetConfigClassifierModelBasedV1 PickClassifierModelBased() => ClassifierModelBased is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClassifierModelBased' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.RouteTargetConfigBasetenModelAPIV1 value) => new TargetVariant1((global::Baseten.RouteTargetConfigBasetenModelAPIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteTargetConfigBasetenModelAPIV1?(TargetVariant1 @this) => @this.BasetenModelApi;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.RouteTargetConfigBasetenModelAPIV1? value)
        {
            BasetenModelApi = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromBasetenModelApi(global::Baseten.RouteTargetConfigBasetenModelAPIV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.RouteTargetConfigAnthropicV1 value) => new TargetVariant1((global::Baseten.RouteTargetConfigAnthropicV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteTargetConfigAnthropicV1?(TargetVariant1 @this) => @this.Anthropic;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.RouteTargetConfigAnthropicV1? value)
        {
            Anthropic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromAnthropic(global::Baseten.RouteTargetConfigAnthropicV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.RouteTargetConfigOpenAIV1 value) => new TargetVariant1((global::Baseten.RouteTargetConfigOpenAIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteTargetConfigOpenAIV1?(TargetVariant1 @this) => @this.Openai;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.RouteTargetConfigOpenAIV1? value)
        {
            Openai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromOpenai(global::Baseten.RouteTargetConfigOpenAIV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.RouteTargetConfigXAIV1 value) => new TargetVariant1((global::Baseten.RouteTargetConfigXAIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteTargetConfigXAIV1?(TargetVariant1 @this) => @this.Xai;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.RouteTargetConfigXAIV1? value)
        {
            Xai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromXai(global::Baseten.RouteTargetConfigXAIV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.RouteTargetConfigClassifierModelBasedV1 value) => new TargetVariant1((global::Baseten.RouteTargetConfigClassifierModelBasedV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteTargetConfigClassifierModelBasedV1?(TargetVariant1 @this) => @this.ClassifierModelBased;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.RouteTargetConfigClassifierModelBasedV1? value)
        {
            ClassifierModelBased = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromClassifierModelBased(global::Baseten.RouteTargetConfigClassifierModelBasedV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(
            global::Baseten.UpdateRouteRequestV1TargetVariant1DiscriminatorType? type,
            global::Baseten.RouteTargetConfigBasetenModelAPIV1? basetenModelApi,
            global::Baseten.RouteTargetConfigAnthropicV1? anthropic,
            global::Baseten.RouteTargetConfigOpenAIV1? openai,
            global::Baseten.RouteTargetConfigXAIV1? xai,
            global::Baseten.RouteTargetConfigClassifierModelBasedV1? classifierModelBased
            )
        {
            Type = type;

            BasetenModelApi = basetenModelApi;
            Anthropic = anthropic;
            Openai = openai;
            Xai = xai;
            ClassifierModelBased = classifierModelBased;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ClassifierModelBased as object ??
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
            ClassifierModelBased?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBasetenModelApi && !IsAnthropic && !IsOpenai && !IsXai && !IsClassifierModelBased || !IsBasetenModelApi && IsAnthropic && !IsOpenai && !IsXai && !IsClassifierModelBased || !IsBasetenModelApi && !IsAnthropic && IsOpenai && !IsXai && !IsClassifierModelBased || !IsBasetenModelApi && !IsAnthropic && !IsOpenai && IsXai && !IsClassifierModelBased || !IsBasetenModelApi && !IsAnthropic && !IsOpenai && !IsXai && IsClassifierModelBased;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.RouteTargetConfigBasetenModelAPIV1, TResult>? basetenModelApi = null,
            global::System.Func<global::Baseten.RouteTargetConfigAnthropicV1, TResult>? anthropic = null,
            global::System.Func<global::Baseten.RouteTargetConfigOpenAIV1, TResult>? openai = null,
            global::System.Func<global::Baseten.RouteTargetConfigXAIV1, TResult>? xai = null,
            global::System.Func<global::Baseten.RouteTargetConfigClassifierModelBasedV1, TResult>? classifierModelBased = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BasetenModelApi is { } __value0 && basetenModelApi != null)
            {
                return basetenModelApi(__value0);
            }
            else if (Anthropic is { } __value1 && anthropic != null)
            {
                return anthropic(__value1);
            }
            else if (Openai is { } __value2 && openai != null)
            {
                return openai(__value2);
            }
            else if (Xai is { } __value3 && xai != null)
            {
                return xai(__value3);
            }
            else if (ClassifierModelBased is { } __value4 && classifierModelBased != null)
            {
                return classifierModelBased(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.RouteTargetConfigBasetenModelAPIV1>? basetenModelApi = null,

            global::System.Action<global::Baseten.RouteTargetConfigAnthropicV1>? anthropic = null,

            global::System.Action<global::Baseten.RouteTargetConfigOpenAIV1>? openai = null,

            global::System.Action<global::Baseten.RouteTargetConfigXAIV1>? xai = null,

            global::System.Action<global::Baseten.RouteTargetConfigClassifierModelBasedV1>? classifierModelBased = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BasetenModelApi is { } __value0)
            {
                basetenModelApi?.Invoke(__value0);
            }
            else if (Anthropic is { } __value1)
            {
                anthropic?.Invoke(__value1);
            }
            else if (Openai is { } __value2)
            {
                openai?.Invoke(__value2);
            }
            else if (Xai is { } __value3)
            {
                xai?.Invoke(__value3);
            }
            else if (ClassifierModelBased is { } __value4)
            {
                classifierModelBased?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.RouteTargetConfigBasetenModelAPIV1>? basetenModelApi = null,
            global::System.Action<global::Baseten.RouteTargetConfigAnthropicV1>? anthropic = null,
            global::System.Action<global::Baseten.RouteTargetConfigOpenAIV1>? openai = null,
            global::System.Action<global::Baseten.RouteTargetConfigXAIV1>? xai = null,
            global::System.Action<global::Baseten.RouteTargetConfigClassifierModelBasedV1>? classifierModelBased = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BasetenModelApi is { } __value0)
            {
                basetenModelApi?.Invoke(__value0);
            }
            else if (Anthropic is { } __value1)
            {
                anthropic?.Invoke(__value1);
            }
            else if (Openai is { } __value2)
            {
                openai?.Invoke(__value2);
            }
            else if (Xai is { } __value3)
            {
                xai?.Invoke(__value3);
            }
            else if (ClassifierModelBased is { } __value4)
            {
                classifierModelBased?.Invoke(__value4);
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
                typeof(global::Baseten.RouteTargetConfigBasetenModelAPIV1),
                Anthropic,
                typeof(global::Baseten.RouteTargetConfigAnthropicV1),
                Openai,
                typeof(global::Baseten.RouteTargetConfigOpenAIV1),
                Xai,
                typeof(global::Baseten.RouteTargetConfigXAIV1),
                ClassifierModelBased,
                typeof(global::Baseten.RouteTargetConfigClassifierModelBasedV1),
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
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteTargetConfigBasetenModelAPIV1?>.Default.Equals(BasetenModelApi, other.BasetenModelApi) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteTargetConfigAnthropicV1?>.Default.Equals(Anthropic, other.Anthropic) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteTargetConfigOpenAIV1?>.Default.Equals(Openai, other.Openai) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteTargetConfigXAIV1?>.Default.Equals(Xai, other.Xai) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteTargetConfigClassifierModelBasedV1?>.Default.Equals(ClassifierModelBased, other.ClassifierModelBased)
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
