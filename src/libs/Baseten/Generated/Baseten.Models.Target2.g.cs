#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Upstream target for the route. CONNECTION targets use the provider and credentials of a connection owned by the route's team.
    /// </summary>
    public readonly partial struct Target2 : global::System.IEquatable<Target2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateRouteRequestV1TargetDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpsertRouteTargetBasetenModelAPIV1? BasetenModelApi { get; init; }
#else
        public global::Baseten.UpsertRouteTargetBasetenModelAPIV1? BasetenModelApi { get; }
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
            out global::Baseten.UpsertRouteTargetBasetenModelAPIV1? value)
        {
            value = BasetenModelApi;
            return IsBasetenModelApi;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertRouteTargetBasetenModelAPIV1 PickBasetenModelApi() => BasetenModelApi is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BasetenModelApi' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpsertRouteTargetConnectionV1? Connection { get; init; }
#else
        public global::Baseten.UpsertRouteTargetConnectionV1? Connection { get; }
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
            out global::Baseten.UpsertRouteTargetConnectionV1? value)
        {
            value = Connection;
            return IsConnection;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertRouteTargetConnectionV1 PickConnection() => Connection is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Connection' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpsertRouteTargetClassifierV1? Classifier { get; init; }
#else
        public global::Baseten.UpsertRouteTargetClassifierV1? Classifier { get; }
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
            out global::Baseten.UpsertRouteTargetClassifierV1? value)
        {
            value = Classifier;
            return IsClassifier;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertRouteTargetClassifierV1 PickClassifier() => Classifier is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Classifier' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Target2(global::Baseten.UpsertRouteTargetBasetenModelAPIV1 value) => new Target2((global::Baseten.UpsertRouteTargetBasetenModelAPIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpsertRouteTargetBasetenModelAPIV1?(Target2 @this) => @this.BasetenModelApi;

        /// <summary>
        ///
        /// </summary>
        public Target2(global::Baseten.UpsertRouteTargetBasetenModelAPIV1? value)
        {
            BasetenModelApi = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Target2 FromBasetenModelApi(global::Baseten.UpsertRouteTargetBasetenModelAPIV1? value) => new Target2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Target2(global::Baseten.UpsertRouteTargetConnectionV1 value) => new Target2((global::Baseten.UpsertRouteTargetConnectionV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpsertRouteTargetConnectionV1?(Target2 @this) => @this.Connection;

        /// <summary>
        ///
        /// </summary>
        public Target2(global::Baseten.UpsertRouteTargetConnectionV1? value)
        {
            Connection = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Target2 FromConnection(global::Baseten.UpsertRouteTargetConnectionV1? value) => new Target2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Target2(global::Baseten.UpsertRouteTargetClassifierV1 value) => new Target2((global::Baseten.UpsertRouteTargetClassifierV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpsertRouteTargetClassifierV1?(Target2 @this) => @this.Classifier;

        /// <summary>
        ///
        /// </summary>
        public Target2(global::Baseten.UpsertRouteTargetClassifierV1? value)
        {
            Classifier = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Target2 FromClassifier(global::Baseten.UpsertRouteTargetClassifierV1? value) => new Target2(value);

        /// <summary>
        ///
        /// </summary>
        public Target2(
            global::Baseten.CreateRouteRequestV1TargetDiscriminatorType? type,
            global::Baseten.UpsertRouteTargetBasetenModelAPIV1? basetenModelApi,
            global::Baseten.UpsertRouteTargetConnectionV1? connection,
            global::Baseten.UpsertRouteTargetClassifierV1? classifier
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
            global::System.Func<global::Baseten.UpsertRouteTargetBasetenModelAPIV1, TResult>? basetenModelApi = null,
            global::System.Func<global::Baseten.UpsertRouteTargetConnectionV1, TResult>? connection = null,
            global::System.Func<global::Baseten.UpsertRouteTargetClassifierV1, TResult>? classifier = null,
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
            global::System.Action<global::Baseten.UpsertRouteTargetBasetenModelAPIV1>? basetenModelApi = null,

            global::System.Action<global::Baseten.UpsertRouteTargetConnectionV1>? connection = null,

            global::System.Action<global::Baseten.UpsertRouteTargetClassifierV1>? classifier = null,
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
            global::System.Action<global::Baseten.UpsertRouteTargetBasetenModelAPIV1>? basetenModelApi = null,
            global::System.Action<global::Baseten.UpsertRouteTargetConnectionV1>? connection = null,
            global::System.Action<global::Baseten.UpsertRouteTargetClassifierV1>? classifier = null,
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
                typeof(global::Baseten.UpsertRouteTargetBasetenModelAPIV1),
                Connection,
                typeof(global::Baseten.UpsertRouteTargetConnectionV1),
                Classifier,
                typeof(global::Baseten.UpsertRouteTargetClassifierV1),
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
        public bool Equals(Target2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpsertRouteTargetBasetenModelAPIV1?>.Default.Equals(BasetenModelApi, other.BasetenModelApi) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpsertRouteTargetConnectionV1?>.Default.Equals(Connection, other.Connection) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpsertRouteTargetClassifierV1?>.Default.Equals(Classifier, other.Classifier)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Target2 obj1, Target2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Target2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Target2 obj1, Target2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Target2 o && Equals(o);
        }
    }
}
