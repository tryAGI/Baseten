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
        public bool TryPickBasetenLatestCheckpoint(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.BasetenLatestCheckpointConfig? value)
        {
            value = BasetenLatestCheckpoint;
            return IsBasetenLatestCheckpoint;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.BasetenLatestCheckpointConfig PickBasetenLatestCheckpoint() => IsBasetenLatestCheckpoint
            ? BasetenLatestCheckpoint!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BasetenLatestCheckpoint' but the value was {ToString()}.");

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
        public bool TryPickBasetenNamedCheckpoint(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.BasetenNamedCheckpointConfig? value)
        {
            value = BasetenNamedCheckpoint;
            return IsBasetenNamedCheckpoint;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.BasetenNamedCheckpointConfig PickBasetenNamedCheckpoint() => IsBasetenNamedCheckpoint
            ? BasetenNamedCheckpoint!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BasetenNamedCheckpoint' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.LoopsCheckpointConfig? LoopsCheckpoint { get; init; }
#else
        public global::Baseten.LoopsCheckpointConfig? LoopsCheckpoint { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LoopsCheckpoint))]
#endif
        public bool IsLoopsCheckpoint => LoopsCheckpoint != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLoopsCheckpoint(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.LoopsCheckpointConfig? value)
        {
            value = LoopsCheckpoint;
            return IsLoopsCheckpoint;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.LoopsCheckpointConfig PickLoopsCheckpoint() => IsLoopsCheckpoint
            ? LoopsCheckpoint!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LoopsCheckpoint' but the value was {ToString()}.");
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
        public static CheckpointsItem FromBasetenLatestCheckpoint(global::Baseten.BasetenLatestCheckpointConfig? value) => new CheckpointsItem(value);

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
        public static CheckpointsItem FromBasetenNamedCheckpoint(global::Baseten.BasetenNamedCheckpointConfig? value) => new CheckpointsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CheckpointsItem(global::Baseten.LoopsCheckpointConfig value) => new CheckpointsItem((global::Baseten.LoopsCheckpointConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.LoopsCheckpointConfig?(CheckpointsItem @this) => @this.LoopsCheckpoint;

        /// <summary>
        /// 
        /// </summary>
        public CheckpointsItem(global::Baseten.LoopsCheckpointConfig? value)
        {
            LoopsCheckpoint = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CheckpointsItem FromLoopsCheckpoint(global::Baseten.LoopsCheckpointConfig? value) => new CheckpointsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public CheckpointsItem(
            global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp? typ,
            global::Baseten.BasetenLatestCheckpointConfig? basetenLatestCheckpoint,
            global::Baseten.BasetenNamedCheckpointConfig? basetenNamedCheckpoint,
            global::Baseten.LoopsCheckpointConfig? loopsCheckpoint
            )
        {
            Typ = typ;

            BasetenLatestCheckpoint = basetenLatestCheckpoint;
            BasetenNamedCheckpoint = basetenNamedCheckpoint;
            LoopsCheckpoint = loopsCheckpoint;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LoopsCheckpoint as object ??
            BasetenNamedCheckpoint as object ??
            BasetenLatestCheckpoint as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BasetenLatestCheckpoint?.ToString() ??
            BasetenNamedCheckpoint?.ToString() ??
            LoopsCheckpoint?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBasetenLatestCheckpoint && !IsBasetenNamedCheckpoint && !IsLoopsCheckpoint || !IsBasetenLatestCheckpoint && IsBasetenNamedCheckpoint && !IsLoopsCheckpoint || !IsBasetenLatestCheckpoint && !IsBasetenNamedCheckpoint && IsLoopsCheckpoint;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.BasetenLatestCheckpointConfig, TResult>? basetenLatestCheckpoint = null,
            global::System.Func<global::Baseten.BasetenNamedCheckpointConfig, TResult>? basetenNamedCheckpoint = null,
            global::System.Func<global::Baseten.LoopsCheckpointConfig, TResult>? loopsCheckpoint = null,
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
            else if (IsLoopsCheckpoint && loopsCheckpoint != null)
            {
                return loopsCheckpoint(LoopsCheckpoint!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.BasetenLatestCheckpointConfig>? basetenLatestCheckpoint = null,

            global::System.Action<global::Baseten.BasetenNamedCheckpointConfig>? basetenNamedCheckpoint = null,

            global::System.Action<global::Baseten.LoopsCheckpointConfig>? loopsCheckpoint = null,
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
            else if (IsLoopsCheckpoint)
            {
                loopsCheckpoint?.Invoke(LoopsCheckpoint!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.BasetenLatestCheckpointConfig>? basetenLatestCheckpoint = null,
            global::System.Action<global::Baseten.BasetenNamedCheckpointConfig>? basetenNamedCheckpoint = null,
            global::System.Action<global::Baseten.LoopsCheckpointConfig>? loopsCheckpoint = null,
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
            else if (IsLoopsCheckpoint)
            {
                loopsCheckpoint?.Invoke(LoopsCheckpoint!);
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
                LoopsCheckpoint,
                typeof(global::Baseten.LoopsCheckpointConfig),
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
                global::System.Collections.Generic.EqualityComparer<global::Baseten.BasetenNamedCheckpointConfig?>.Default.Equals(BasetenNamedCheckpoint, other.BasetenNamedCheckpoint) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.LoopsCheckpointConfig?>.Default.Equals(LoopsCheckpoint, other.LoopsCheckpoint) 
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
