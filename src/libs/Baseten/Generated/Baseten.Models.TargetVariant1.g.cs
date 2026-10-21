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
        public global::Baseten.UpdateGridRouteRequestV1TargetVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1? BasetenModelApi { get; init; }
#else
        public global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1? BasetenModelApi { get; }
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
            out global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1? value)
        {
            value = BasetenModelApi;
            return IsBasetenModelApi;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1 PickBasetenModelApi() => BasetenModelApi is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BasetenModelApi' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpsertGridRouteTargetConnectionV1? Connection { get; init; }
#else
        public global::Baseten.UpsertGridRouteTargetConnectionV1? Connection { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Connection))]
#endif
        public bool IsConnection => Connection != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConnection(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.UpsertGridRouteTargetConnectionV1? value)
        {
            value = Connection;
            return IsConnection;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridRouteTargetConnectionV1 PickConnection() => Connection is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Connection' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpsertGridRouteTargetClassifierV1? Classifier { get; init; }
#else
        public global::Baseten.UpsertGridRouteTargetClassifierV1? Classifier { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Classifier))]
#endif
        public bool IsClassifier => Classifier != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClassifier(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.UpsertGridRouteTargetClassifierV1? value)
        {
            value = Classifier;
            return IsClassifier;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridRouteTargetClassifierV1 PickClassifier() => Classifier is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Classifier' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1 value) => new TargetVariant1((global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1?(TargetVariant1 @this) => @this.BasetenModelApi;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1? value)
        {
            BasetenModelApi = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromBasetenModelApi(global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.UpsertGridRouteTargetConnectionV1 value) => new TargetVariant1((global::Baseten.UpsertGridRouteTargetConnectionV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpsertGridRouteTargetConnectionV1?(TargetVariant1 @this) => @this.Connection;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.UpsertGridRouteTargetConnectionV1? value)
        {
            Connection = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromConnection(global::Baseten.UpsertGridRouteTargetConnectionV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.UpsertGridRouteTargetClassifierV1 value) => new TargetVariant1((global::Baseten.UpsertGridRouteTargetClassifierV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpsertGridRouteTargetClassifierV1?(TargetVariant1 @this) => @this.Classifier;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.UpsertGridRouteTargetClassifierV1? value)
        {
            Classifier = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromClassifier(global::Baseten.UpsertGridRouteTargetClassifierV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(
            global::Baseten.UpdateGridRouteRequestV1TargetVariant1DiscriminatorType? type,
            global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1? basetenModelApi,
            global::Baseten.UpsertGridRouteTargetConnectionV1? connection,
            global::Baseten.UpsertGridRouteTargetClassifierV1? classifier
            )
        {
            Type = type;

            BasetenModelApi = basetenModelApi;
            Connection = connection;
            Classifier = classifier;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Classifier as object ??
            Connection as object ??
            BasetenModelApi as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BasetenModelApi?.ToString() ??
            Connection?.ToString() ??
            Classifier?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBasetenModelApi && !IsConnection && !IsClassifier || !IsBasetenModelApi && IsConnection && !IsClassifier || !IsBasetenModelApi && !IsConnection && IsClassifier;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1, TResult>? basetenModelApi = null,
            global::System.Func<global::Baseten.UpsertGridRouteTargetConnectionV1, TResult>? connection = null,
            global::System.Func<global::Baseten.UpsertGridRouteTargetClassifierV1, TResult>? classifier = null,
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
            else if (Connection is { } __value1 && connection != null)
            {
                return connection(__value1);
            }
            else if (Classifier is { } __value2 && classifier != null)
            {
                return classifier(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1>? basetenModelApi = null,

            global::System.Action<global::Baseten.UpsertGridRouteTargetConnectionV1>? connection = null,

            global::System.Action<global::Baseten.UpsertGridRouteTargetClassifierV1>? classifier = null,
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
            else if (Connection is { } __value1)
            {
                connection?.Invoke(__value1);
            }
            else if (Classifier is { } __value2)
            {
                classifier?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1>? basetenModelApi = null,
            global::System.Action<global::Baseten.UpsertGridRouteTargetConnectionV1>? connection = null,
            global::System.Action<global::Baseten.UpsertGridRouteTargetClassifierV1>? classifier = null,
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
            else if (Connection is { } __value1)
            {
                connection?.Invoke(__value1);
            }
            else if (Classifier is { } __value2)
            {
                classifier?.Invoke(__value2);
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
                typeof(global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1),
                Connection,
                typeof(global::Baseten.UpsertGridRouteTargetConnectionV1),
                Classifier,
                typeof(global::Baseten.UpsertGridRouteTargetClassifierV1),
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
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1?>.Default.Equals(BasetenModelApi, other.BasetenModelApi) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpsertGridRouteTargetConnectionV1?>.Default.Equals(Connection, other.Connection) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpsertGridRouteTargetClassifierV1?>.Default.Equals(Classifier, other.Classifier)
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
