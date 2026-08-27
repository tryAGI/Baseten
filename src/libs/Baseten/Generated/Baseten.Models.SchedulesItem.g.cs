#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SchedulesItem : global::System.IEquatable<SchedulesItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence? Cadence { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AutoscalingScheduleV1? Daily { get; init; }
#else
        public global::Baseten.AutoscalingScheduleV1? Daily { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Daily))]
#endif
        public bool IsDaily => Daily != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDaily(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AutoscalingScheduleV1? value)
        {
            value = Daily;
            return IsDaily;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleV1 PickDaily() => IsDaily
            ? Daily!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Daily' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.OneTimeAutoscalingScheduleV1? OneTime { get; init; }
#else
        public global::Baseten.OneTimeAutoscalingScheduleV1? OneTime { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OneTime))]
#endif
        public bool IsOneTime => OneTime != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOneTime(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.OneTimeAutoscalingScheduleV1? value)
        {
            value = OneTime;
            return IsOneTime;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.OneTimeAutoscalingScheduleV1 PickOneTime() => IsOneTime
            ? OneTime!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OneTime' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SchedulesItem(global::Baseten.AutoscalingScheduleV1 value) => new SchedulesItem((global::Baseten.AutoscalingScheduleV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.AutoscalingScheduleV1?(SchedulesItem @this) => @this.Daily;

        /// <summary>
        ///
        /// </summary>
        public SchedulesItem(global::Baseten.AutoscalingScheduleV1? value)
        {
            Daily = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SchedulesItem FromDaily(global::Baseten.AutoscalingScheduleV1? value) => new SchedulesItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SchedulesItem(global::Baseten.OneTimeAutoscalingScheduleV1 value) => new SchedulesItem((global::Baseten.OneTimeAutoscalingScheduleV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.OneTimeAutoscalingScheduleV1?(SchedulesItem @this) => @this.OneTime;

        /// <summary>
        ///
        /// </summary>
        public SchedulesItem(global::Baseten.OneTimeAutoscalingScheduleV1? value)
        {
            OneTime = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SchedulesItem FromOneTime(global::Baseten.OneTimeAutoscalingScheduleV1? value) => new SchedulesItem(value);

        /// <summary>
        ///
        /// </summary>
        public SchedulesItem(
            global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence? cadence,
            global::Baseten.AutoscalingScheduleV1? daily,
            global::Baseten.OneTimeAutoscalingScheduleV1? oneTime
            )
        {
            Cadence = cadence;

            Daily = daily;
            OneTime = oneTime;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OneTime as object ??
            Daily as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Daily?.ToString() ??
            OneTime?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDaily && !IsOneTime || !IsDaily && IsOneTime;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.AutoscalingScheduleV1, TResult>? daily = null,
            global::System.Func<global::Baseten.OneTimeAutoscalingScheduleV1, TResult>? oneTime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDaily && daily != null)
            {
                return daily(Daily!);
            }
            else if (IsOneTime && oneTime != null)
            {
                return oneTime(OneTime!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.AutoscalingScheduleV1>? daily = null,

            global::System.Action<global::Baseten.OneTimeAutoscalingScheduleV1>? oneTime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDaily)
            {
                daily?.Invoke(Daily!);
            }
            else if (IsOneTime)
            {
                oneTime?.Invoke(OneTime!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.AutoscalingScheduleV1>? daily = null,
            global::System.Action<global::Baseten.OneTimeAutoscalingScheduleV1>? oneTime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDaily)
            {
                daily?.Invoke(Daily!);
            }
            else if (IsOneTime)
            {
                oneTime?.Invoke(OneTime!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Daily,
                typeof(global::Baseten.AutoscalingScheduleV1),
                OneTime,
                typeof(global::Baseten.OneTimeAutoscalingScheduleV1),
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
        public bool Equals(SchedulesItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AutoscalingScheduleV1?>.Default.Equals(Daily, other.Daily) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.OneTimeAutoscalingScheduleV1?>.Default.Equals(OneTime, other.OneTime)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SchedulesItem obj1, SchedulesItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SchedulesItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SchedulesItem obj1, SchedulesItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SchedulesItem o && Equals(o);
        }
    }
}
