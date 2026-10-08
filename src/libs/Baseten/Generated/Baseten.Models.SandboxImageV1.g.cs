#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Sandbox image repository. Get operations return a summary with an empty tags array.<br/>
    /// Example: {"name":"base-image","status":"BUILT","created_at":"2026-09-15T21:20:00Z","updated_at":"2026-09-16T21:25:00Z","last_deployed_at":"2026-09-16T21:26:58.545765901Z","size":260046848,"tag_count":2,"tags":[]}
    /// </summary>
    public readonly partial struct SandboxImageV1 : global::System.IEquatable<SandboxImageV1>
    {
        /// <summary>
        /// Sandbox image repository summary. Fetch tags through GET /sandboxes/images/{image_name}/tags.<br/>
        /// Example: {"name":"base-image","status":"BUILT","created_at":"2026-09-15T21:20:00Z","updated_at":"2026-09-16T21:25:00Z","last_deployed_at":"2026-09-16T21:26:58.545765901Z","size":260046848,"tag_count":2}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.SandboxImageSummaryV1? Summary { get; init; }
#else
        public global::Baseten.SandboxImageSummaryV1? Summary { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Summary))]
#endif
        public bool IsSummary => Summary != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSummary(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.SandboxImageSummaryV1? value)
        {
            value = Summary;
            return IsSummary;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxImageSummaryV1 PickSummary() => Summary is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Summary' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.SandboxImageV1Variant2? SandboxImageV1Variant2 { get; init; }
#else
        public global::Baseten.SandboxImageV1Variant2? SandboxImageV1Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SandboxImageV1Variant2))]
#endif
        public bool IsSandboxImageV1Variant2 => SandboxImageV1Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSandboxImageV1Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.SandboxImageV1Variant2? value)
        {
            value = SandboxImageV1Variant2;
            return IsSandboxImageV1Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxImageV1Variant2 PickSandboxImageV1Variant2() => SandboxImageV1Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SandboxImageV1Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxImageV1(global::Baseten.SandboxImageSummaryV1 value) => new SandboxImageV1((global::Baseten.SandboxImageSummaryV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.SandboxImageSummaryV1?(SandboxImageV1 @this) => @this.Summary;

        /// <summary>
        ///
        /// </summary>
        public SandboxImageV1(global::Baseten.SandboxImageSummaryV1? value)
        {
            Summary = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxImageV1 FromSummary(global::Baseten.SandboxImageSummaryV1? value) => new SandboxImageV1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxImageV1(global::Baseten.SandboxImageV1Variant2 value) => new SandboxImageV1((global::Baseten.SandboxImageV1Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.SandboxImageV1Variant2?(SandboxImageV1 @this) => @this.SandboxImageV1Variant2;

        /// <summary>
        ///
        /// </summary>
        public SandboxImageV1(global::Baseten.SandboxImageV1Variant2? value)
        {
            SandboxImageV1Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxImageV1 FromSandboxImageV1Variant2(global::Baseten.SandboxImageV1Variant2? value) => new SandboxImageV1(value);

        /// <summary>
        ///
        /// </summary>
        public SandboxImageV1(
            global::Baseten.SandboxImageSummaryV1? summary,
            global::Baseten.SandboxImageV1Variant2? sandboxImageV1Variant2
            )
        {
            Summary = summary;
            SandboxImageV1Variant2 = sandboxImageV1Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SandboxImageV1Variant2 as object ??
            Summary as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Summary?.ToString() ??
            SandboxImageV1Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSummary && IsSandboxImageV1Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.SandboxImageSummaryV1, TResult>? summary = null,
            global::System.Func<global::Baseten.SandboxImageV1Variant2, TResult>? sandboxImageV1Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Summary is { } __value0 && summary != null)
            {
                return summary(__value0);
            }
            else if (SandboxImageV1Variant2 is { } __value1 && sandboxImageV1Variant2 != null)
            {
                return sandboxImageV1Variant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.SandboxImageSummaryV1>? summary = null,

            global::System.Action<global::Baseten.SandboxImageV1Variant2>? sandboxImageV1Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Summary is { } __value0)
            {
                summary?.Invoke(__value0);
            }
            else if (SandboxImageV1Variant2 is { } __value1)
            {
                sandboxImageV1Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.SandboxImageSummaryV1>? summary = null,
            global::System.Action<global::Baseten.SandboxImageV1Variant2>? sandboxImageV1Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Summary is { } __value0)
            {
                summary?.Invoke(__value0);
            }
            else if (SandboxImageV1Variant2 is { } __value1)
            {
                sandboxImageV1Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Summary,
                typeof(global::Baseten.SandboxImageSummaryV1),
                SandboxImageV1Variant2,
                typeof(global::Baseten.SandboxImageV1Variant2),
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
        public bool Equals(SandboxImageV1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.SandboxImageSummaryV1?>.Default.Equals(Summary, other.Summary) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.SandboxImageV1Variant2?>.Default.Equals(SandboxImageV1Variant2, other.SandboxImageV1Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SandboxImageV1 obj1, SandboxImageV1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SandboxImageV1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SandboxImageV1 obj1, SandboxImageV1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SandboxImageV1 o && Equals(o);
        }
    }
}
