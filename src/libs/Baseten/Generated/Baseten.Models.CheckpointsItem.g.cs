#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CheckpointsItem : global::System.IEquatable<CheckpointsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp? Typ { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.BasetenLatestCheckpointConfig? BasetenLatestCheckpoint { get; init; }
#else
        public global::Baseten.BasetenLatestCheckpointConfig? BasetenLatestCheckpoint { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BasetenLatestCheckpoint))]
#endif
        public bool IsBasetenLatestCheckpoint => BasetenLatestCheckpoint != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.BasetenNamedCheckpointConfig? BasetenNamedCheckpoint { get; init; }
#else
        public global::Baseten.BasetenNamedCheckpointConfig? BasetenNamedCheckpoint { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BasetenNamedCheckpoint))]
#endif
        public bool IsBasetenNamedCheckpoint => BasetenNamedCheckpoint != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CheckpointsItem(global::Baseten.BasetenLatestCheckpointConfig value) => new CheckpointsItem((global::Baseten.BasetenLatestCheckpointConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.BasetenLatestCheckpointConfig?(CheckpointsItem @this) => @this.BasetenLatestCheckpoint;

        /// <summary>
        /// 
        /// </summary>
        public CheckpointsItem(global::Baseten.BasetenLatestCheckpointConfig? value)
        {
            BasetenLatestCheckpoint = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CheckpointsItem(global::Baseten.BasetenNamedCheckpointConfig value) => new CheckpointsItem((global::Baseten.BasetenNamedCheckpointConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.BasetenNamedCheckpointConfig?(CheckpointsItem @this) => @this.BasetenNamedCheckpoint;

        /// <summary>
        /// 
        /// </summary>
        public CheckpointsItem(global::Baseten.BasetenNamedCheckpointConfig? value)
        {
            BasetenNamedCheckpoint = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckpointsItem(
            global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp? typ,
            global::Baseten.BasetenLatestCheckpointConfig? basetenLatestCheckpoint,
            global::Baseten.BasetenNamedCheckpointConfig? basetenNamedCheckpoint
            )
        {
            Typ = typ;

            BasetenLatestCheckpoint = basetenLatestCheckpoint;
            BasetenNamedCheckpoint = basetenNamedCheckpoint;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BasetenNamedCheckpoint as object ??
            BasetenLatestCheckpoint as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BasetenLatestCheckpoint?.ToString() ??
            BasetenNamedCheckpoint?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBasetenLatestCheckpoint && !IsBasetenNamedCheckpoint || !IsBasetenLatestCheckpoint && IsBasetenNamedCheckpoint;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.BasetenLatestCheckpointConfig?, TResult>? basetenLatestCheckpoint = null,
            global::System.Func<global::Baseten.BasetenNamedCheckpointConfig?, TResult>? basetenNamedCheckpoint = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBasetenLatestCheckpoint && basetenLatestCheckpoint != null)
            {
                return basetenLatestCheckpoint(BasetenLatestCheckpoint!);
            }
            else if (IsBasetenNamedCheckpoint && basetenNamedCheckpoint != null)
            {
                return basetenNamedCheckpoint(BasetenNamedCheckpoint!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.BasetenLatestCheckpointConfig?>? basetenLatestCheckpoint = null,
            global::System.Action<global::Baseten.BasetenNamedCheckpointConfig?>? basetenNamedCheckpoint = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBasetenLatestCheckpoint)
            {
                basetenLatestCheckpoint?.Invoke(BasetenLatestCheckpoint!);
            }
            else if (IsBasetenNamedCheckpoint)
            {
                basetenNamedCheckpoint?.Invoke(BasetenNamedCheckpoint!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BasetenLatestCheckpoint,
                typeof(global::Baseten.BasetenLatestCheckpointConfig),
                BasetenNamedCheckpoint,
                typeof(global::Baseten.BasetenNamedCheckpointConfig),
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
        public bool Equals(CheckpointsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.BasetenLatestCheckpointConfig?>.Default.Equals(BasetenLatestCheckpoint, other.BasetenLatestCheckpoint) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.BasetenNamedCheckpointConfig?>.Default.Equals(BasetenNamedCheckpoint, other.BasetenNamedCheckpoint) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CheckpointsItem obj1, CheckpointsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CheckpointsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CheckpointsItem obj1, CheckpointsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CheckpointsItem o && Equals(o);
        }
    }
}
