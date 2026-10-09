#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Configured upstream target.
    /// </summary>
    public readonly partial struct Target : global::System.IEquatable<Target>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteV1TargetDiscriminatorType? Type { get; }

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
        public global::Baseten.RouteTargetBasetenModelAPIV1 PickBasetenModelApi() => BasetenModelApi is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BasetenModelApi' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.RouteTargetConnectionV1? Connection { get; init; }
#else
        public global::Baseten.RouteTargetConnectionV1? Connection { get; }
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
            out global::Baseten.RouteTargetConnectionV1? value)
        {
            value = Connection;
            return IsConnection;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetConnectionV1 PickConnection() => Connection is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Connection' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.RouteTargetClassifierModelBasedV1? ClassifierModelBased { get; init; }
#else
        public global::Baseten.RouteTargetClassifierModelBasedV1? ClassifierModelBased { get; }
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
            out global::Baseten.RouteTargetClassifierModelBasedV1? value)
        {
            value = ClassifierModelBased;
            return IsClassifierModelBased;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetClassifierModelBasedV1 PickClassifierModelBased() => ClassifierModelBased is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClassifierModelBased' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Target(global::Baseten.RouteTargetBasetenModelAPIV1 value) => new Target((global::Baseten.RouteTargetBasetenModelAPIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteTargetBasetenModelAPIV1?(Target @this) => @this.BasetenModelApi;

        /// <summary>
        ///
        /// </summary>
        public Target(global::Baseten.RouteTargetBasetenModelAPIV1? value)
        {
            BasetenModelApi = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Target FromBasetenModelApi(global::Baseten.RouteTargetBasetenModelAPIV1? value) => new Target(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Target(global::Baseten.RouteTargetConnectionV1 value) => new Target((global::Baseten.RouteTargetConnectionV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteTargetConnectionV1?(Target @this) => @this.Connection;

        /// <summary>
        ///
        /// </summary>
        public Target(global::Baseten.RouteTargetConnectionV1? value)
        {
            Connection = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Target FromConnection(global::Baseten.RouteTargetConnectionV1? value) => new Target(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Target(global::Baseten.RouteTargetClassifierModelBasedV1 value) => new Target((global::Baseten.RouteTargetClassifierModelBasedV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.RouteTargetClassifierModelBasedV1?(Target @this) => @this.ClassifierModelBased;

        /// <summary>
        ///
        /// </summary>
        public Target(global::Baseten.RouteTargetClassifierModelBasedV1? value)
        {
            ClassifierModelBased = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Target FromClassifierModelBased(global::Baseten.RouteTargetClassifierModelBasedV1? value) => new Target(value);

        /// <summary>
        ///
        /// </summary>
        public Target(
            global::Baseten.RouteV1TargetDiscriminatorType? type,
            global::Baseten.RouteTargetBasetenModelAPIV1? basetenModelApi,
            global::Baseten.RouteTargetConnectionV1? connection,
            global::Baseten.RouteTargetClassifierModelBasedV1? classifierModelBased
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
            global::System.Func<global::Baseten.RouteTargetBasetenModelAPIV1, TResult>? basetenModelApi = null,
            global::System.Func<global::Baseten.RouteTargetConnectionV1, TResult>? connection = null,
            global::System.Func<global::Baseten.RouteTargetClassifierModelBasedV1, TResult>? classifierModelBased = null,
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
            global::System.Action<global::Baseten.RouteTargetBasetenModelAPIV1>? basetenModelApi = null,

            global::System.Action<global::Baseten.RouteTargetConnectionV1>? connection = null,

            global::System.Action<global::Baseten.RouteTargetClassifierModelBasedV1>? classifierModelBased = null,
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
            global::System.Action<global::Baseten.RouteTargetBasetenModelAPIV1>? basetenModelApi = null,
            global::System.Action<global::Baseten.RouteTargetConnectionV1>? connection = null,
            global::System.Action<global::Baseten.RouteTargetClassifierModelBasedV1>? classifierModelBased = null,
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
                typeof(global::Baseten.RouteTargetBasetenModelAPIV1),
                Connection,
                typeof(global::Baseten.RouteTargetConnectionV1),
                ClassifierModelBased,
                typeof(global::Baseten.RouteTargetClassifierModelBasedV1),
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
        public bool Equals(Target other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteTargetBasetenModelAPIV1?>.Default.Equals(BasetenModelApi, other.BasetenModelApi) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteTargetConnectionV1?>.Default.Equals(Connection, other.Connection) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.RouteTargetClassifierModelBasedV1?>.Default.Equals(ClassifierModelBased, other.ClassifierModelBased)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Target obj1, Target obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Target>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Target obj1, Target obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Target o && Equals(o);
        }
    }
}
