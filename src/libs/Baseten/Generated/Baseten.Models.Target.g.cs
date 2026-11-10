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
        public global::Baseten.GridRouteV1TargetDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.GridRouteTargetBasetenModelAPIV1? BasetenModelApi { get; init; }
#else
        public global::Baseten.GridRouteTargetBasetenModelAPIV1? BasetenModelApi { get; }
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
            out global::Baseten.GridRouteTargetBasetenModelAPIV1? value)
        {
            value = BasetenModelApi;
            return IsBasetenModelApi;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteTargetBasetenModelAPIV1 PickBasetenModelApi() => BasetenModelApi is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BasetenModelApi' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.GridRouteTargetConnectionV1? Connection { get; init; }
#else
        public global::Baseten.GridRouteTargetConnectionV1? Connection { get; }
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
            out global::Baseten.GridRouteTargetConnectionV1? value)
        {
            value = Connection;
            return IsConnection;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteTargetConnectionV1 PickConnection() => Connection is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Connection' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.GridRouteTargetIntelligentV1? Intelligent { get; init; }
#else
        public global::Baseten.GridRouteTargetIntelligentV1? Intelligent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Intelligent))]
#endif
        public bool IsIntelligent => Intelligent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickIntelligent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.GridRouteTargetIntelligentV1? value)
        {
            value = Intelligent;
            return IsIntelligent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteTargetIntelligentV1 PickIntelligent() => Intelligent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Intelligent' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Target(global::Baseten.GridRouteTargetBasetenModelAPIV1 value) => new Target((global::Baseten.GridRouteTargetBasetenModelAPIV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.GridRouteTargetBasetenModelAPIV1?(Target @this) => @this.BasetenModelApi;

        /// <summary>
        ///
        /// </summary>
        public Target(global::Baseten.GridRouteTargetBasetenModelAPIV1? value)
        {
            BasetenModelApi = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Target FromBasetenModelApi(global::Baseten.GridRouteTargetBasetenModelAPIV1? value) => new Target(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Target(global::Baseten.GridRouteTargetConnectionV1 value) => new Target((global::Baseten.GridRouteTargetConnectionV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.GridRouteTargetConnectionV1?(Target @this) => @this.Connection;

        /// <summary>
        ///
        /// </summary>
        public Target(global::Baseten.GridRouteTargetConnectionV1? value)
        {
            Connection = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Target FromConnection(global::Baseten.GridRouteTargetConnectionV1? value) => new Target(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Target(global::Baseten.GridRouteTargetIntelligentV1 value) => new Target((global::Baseten.GridRouteTargetIntelligentV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.GridRouteTargetIntelligentV1?(Target @this) => @this.Intelligent;

        /// <summary>
        ///
        /// </summary>
        public Target(global::Baseten.GridRouteTargetIntelligentV1? value)
        {
            Intelligent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Target FromIntelligent(global::Baseten.GridRouteTargetIntelligentV1? value) => new Target(value);

        /// <summary>
        ///
        /// </summary>
        public Target(
            global::Baseten.GridRouteV1TargetDiscriminatorType? type,
            global::Baseten.GridRouteTargetBasetenModelAPIV1? basetenModelApi,
            global::Baseten.GridRouteTargetConnectionV1? connection,
            global::Baseten.GridRouteTargetIntelligentV1? intelligent
            )
        {
            Type = type;

            BasetenModelApi = basetenModelApi;
            Connection = connection;
            Intelligent = intelligent;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Intelligent as object ??
            Connection as object ??
            BasetenModelApi as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BasetenModelApi?.ToString() ??
            Connection?.ToString() ??
            Intelligent?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBasetenModelApi && !IsConnection && !IsIntelligent || !IsBasetenModelApi && IsConnection && !IsIntelligent || !IsBasetenModelApi && !IsConnection && IsIntelligent;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.GridRouteTargetBasetenModelAPIV1, TResult>? basetenModelApi = null,
            global::System.Func<global::Baseten.GridRouteTargetConnectionV1, TResult>? connection = null,
            global::System.Func<global::Baseten.GridRouteTargetIntelligentV1, TResult>? intelligent = null,
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
            else if (Intelligent is { } __value2 && intelligent != null)
            {
                return intelligent(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.GridRouteTargetBasetenModelAPIV1>? basetenModelApi = null,

            global::System.Action<global::Baseten.GridRouteTargetConnectionV1>? connection = null,

            global::System.Action<global::Baseten.GridRouteTargetIntelligentV1>? intelligent = null,
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
            else if (Intelligent is { } __value2)
            {
                intelligent?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.GridRouteTargetBasetenModelAPIV1>? basetenModelApi = null,
            global::System.Action<global::Baseten.GridRouteTargetConnectionV1>? connection = null,
            global::System.Action<global::Baseten.GridRouteTargetIntelligentV1>? intelligent = null,
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
            else if (Intelligent is { } __value2)
            {
                intelligent?.Invoke(__value2);
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
                typeof(global::Baseten.GridRouteTargetBasetenModelAPIV1),
                Connection,
                typeof(global::Baseten.GridRouteTargetConnectionV1),
                Intelligent,
                typeof(global::Baseten.GridRouteTargetIntelligentV1),
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
                global::System.Collections.Generic.EqualityComparer<global::Baseten.GridRouteTargetBasetenModelAPIV1?>.Default.Equals(BasetenModelApi, other.BasetenModelApi) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.GridRouteTargetConnectionV1?>.Default.Equals(Connection, other.Connection) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.GridRouteTargetIntelligentV1?>.Default.Equals(Intelligent, other.Intelligent)
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
