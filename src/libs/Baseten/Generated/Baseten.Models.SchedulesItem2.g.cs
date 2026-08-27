#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SchedulesItem2 : global::System.IEquatable<SchedulesItem2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence? Cadence { get; }

        /// <summary>
        /// A complete recurring schedule submitted for create or replacement.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AutoscalingScheduleUpsertV1? Daily { get; init; }
#else
        public global::Baseten.AutoscalingScheduleUpsertV1? Daily { get; }
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
            out global::Baseten.AutoscalingScheduleUpsertV1? value)
        {
            value = Daily;
            return IsDaily;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleUpsertV1 PickDaily() => IsDaily
            ? Daily!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Daily' but the value was {ToString()}.");

        /// <summary>
        /// A complete one-time schedule submitted for create or replacement.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.OneTimeAutoscalingScheduleUpsertV1? OneTime { get; init; }
#else
        public global::Baseten.OneTimeAutoscalingScheduleUpsertV1? OneTime { get; }
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
            out global::Baseten.OneTimeAutoscalingScheduleUpsertV1? value)
        {
            value = OneTime;
            return IsOneTime;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.OneTimeAutoscalingScheduleUpsertV1 PickOneTime() => IsOneTime
            ? OneTime!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OneTime' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SchedulesItem2(global::Baseten.AutoscalingScheduleUpsertV1 value) => new SchedulesItem2((global::Baseten.AutoscalingScheduleUpsertV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.AutoscalingScheduleUpsertV1?(SchedulesItem2 @this) => @this.Daily;

        /// <summary>
        ///
        /// </summary>
        public SchedulesItem2(global::Baseten.AutoscalingScheduleUpsertV1? value)
        {
            Daily = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SchedulesItem2 FromDaily(global::Baseten.AutoscalingScheduleUpsertV1? value) => new SchedulesItem2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SchedulesItem2(global::Baseten.OneTimeAutoscalingScheduleUpsertV1 value) => new SchedulesItem2((global::Baseten.OneTimeAutoscalingScheduleUpsertV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.OneTimeAutoscalingScheduleUpsertV1?(SchedulesItem2 @this) => @this.OneTime;

        /// <summary>
        ///
        /// </summary>
        public SchedulesItem2(global::Baseten.OneTimeAutoscalingScheduleUpsertV1? value)
        {
            OneTime = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SchedulesItem2 FromOneTime(global::Baseten.OneTimeAutoscalingScheduleUpsertV1? value) => new SchedulesItem2(value);

        /// <summary>
        ///
        /// </summary>
        public SchedulesItem2(
            global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence? cadence,
            global::Baseten.AutoscalingScheduleUpsertV1? daily,
            global::Baseten.OneTimeAutoscalingScheduleUpsertV1? oneTime
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
            global::System.Func<global::Baseten.AutoscalingScheduleUpsertV1, TResult>? daily = null,
            global::System.Func<global::Baseten.OneTimeAutoscalingScheduleUpsertV1, TResult>? oneTime = null,
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
            global::System.Action<global::Baseten.AutoscalingScheduleUpsertV1>? daily = null,

            global::System.Action<global::Baseten.OneTimeAutoscalingScheduleUpsertV1>? oneTime = null,
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
            global::System.Action<global::Baseten.AutoscalingScheduleUpsertV1>? daily = null,
            global::System.Action<global::Baseten.OneTimeAutoscalingScheduleUpsertV1>? oneTime = null,
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
                typeof(global::Baseten.AutoscalingScheduleUpsertV1),
                OneTime,
                typeof(global::Baseten.OneTimeAutoscalingScheduleUpsertV1),
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
        public bool Equals(SchedulesItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AutoscalingScheduleUpsertV1?>.Default.Equals(Daily, other.Daily) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.OneTimeAutoscalingScheduleUpsertV1?>.Default.Equals(OneTime, other.OneTime)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SchedulesItem2 obj1, SchedulesItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SchedulesItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SchedulesItem2 obj1, SchedulesItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SchedulesItem2 o && Equals(o);
        }
    }
}
