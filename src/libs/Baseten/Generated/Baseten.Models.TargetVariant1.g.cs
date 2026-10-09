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
        public global::Baseten.UpsertRouteTargetClassifierModelBasedV1? ClassifierModelBased { get; init; }
#else
        public global::Baseten.UpsertRouteTargetClassifierModelBasedV1? ClassifierModelBased { get; }
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
            out global::Baseten.UpsertRouteTargetClassifierModelBasedV1? value)
        {
            value = ClassifierModelBased;
            return IsClassifierModelBased;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertRouteTargetClassifierModelBasedV1 PickClassifierModelBased() => ClassifierModelBased is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClassifierModelBased' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.UpsertRouteTargetBasetenModelAPIV1 value) => new TargetVariant1((global::Baseten.UpsertRouteTargetBasetenModelAPIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpsertRouteTargetBasetenModelAPIV1?(TargetVariant1 @this) => @this.BasetenModelApi;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.UpsertRouteTargetBasetenModelAPIV1? value)
        {
            BasetenModelApi = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromBasetenModelApi(global::Baseten.UpsertRouteTargetBasetenModelAPIV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.UpsertRouteTargetConnectionV1 value) => new TargetVariant1((global::Baseten.UpsertRouteTargetConnectionV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpsertRouteTargetConnectionV1?(TargetVariant1 @this) => @this.Connection;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.UpsertRouteTargetConnectionV1? value)
        {
            Connection = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromConnection(global::Baseten.UpsertRouteTargetConnectionV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TargetVariant1(global::Baseten.UpsertRouteTargetClassifierModelBasedV1 value) => new TargetVariant1((global::Baseten.UpsertRouteTargetClassifierModelBasedV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpsertRouteTargetClassifierModelBasedV1?(TargetVariant1 @this) => @this.ClassifierModelBased;

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(global::Baseten.UpsertRouteTargetClassifierModelBasedV1? value)
        {
            ClassifierModelBased = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TargetVariant1 FromClassifierModelBased(global::Baseten.UpsertRouteTargetClassifierModelBasedV1? value) => new TargetVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public TargetVariant1(
            global::Baseten.UpdateRouteRequestV1TargetVariant1DiscriminatorType? type,
            global::Baseten.UpsertRouteTargetBasetenModelAPIV1? basetenModelApi,
            global::Baseten.UpsertRouteTargetConnectionV1? connection,
            global::Baseten.UpsertRouteTargetClassifierModelBasedV1? classifierModelBased
            )
        {
            Type = type;

            BasetenModelApi = basetenModelApi;
            Connection = connection;
            ClassifierModelBased = classifierModelBased;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ClassifierModelBased as object ??
            Connection as object ??
            BasetenModelApi as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BasetenModelApi?.ToString() ??
            Connection?.ToString() ??
            ClassifierModelBased?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBasetenModelApi && !IsConnection && !IsClassifierModelBased || !IsBasetenModelApi && IsConnection && !IsClassifierModelBased || !IsBasetenModelApi && !IsConnection && IsClassifierModelBased;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.UpsertRouteTargetBasetenModelAPIV1, TResult>? basetenModelApi = null,
            global::System.Func<global::Baseten.UpsertRouteTargetConnectionV1, TResult>? connection = null,
            global::System.Func<global::Baseten.UpsertRouteTargetClassifierModelBasedV1, TResult>? classifierModelBased = null,
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
            else if (ClassifierModelBased is { } __value2 && classifierModelBased != null)
            {
                return classifierModelBased(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.UpsertRouteTargetBasetenModelAPIV1>? basetenModelApi = null,

            global::System.Action<global::Baseten.UpsertRouteTargetConnectionV1>? connection = null,

            global::System.Action<global::Baseten.UpsertRouteTargetClassifierModelBasedV1>? classifierModelBased = null,
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
            else if (ClassifierModelBased is { } __value2)
            {
                classifierModelBased?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.UpsertRouteTargetBasetenModelAPIV1>? basetenModelApi = null,
            global::System.Action<global::Baseten.UpsertRouteTargetConnectionV1>? connection = null,
            global::System.Action<global::Baseten.UpsertRouteTargetClassifierModelBasedV1>? classifierModelBased = null,
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
            else if (ClassifierModelBased is { } __value2)
            {
                classifierModelBased?.Invoke(__value2);
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
                ClassifierModelBased,
                typeof(global::Baseten.UpsertRouteTargetClassifierModelBasedV1),
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
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpsertRouteTargetBasetenModelAPIV1?>.Default.Equals(BasetenModelApi, other.BasetenModelApi) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpsertRouteTargetConnectionV1?>.Default.Equals(Connection, other.Connection) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpsertRouteTargetClassifierModelBasedV1?>.Default.Equals(ClassifierModelBased, other.ClassifierModelBased)
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
