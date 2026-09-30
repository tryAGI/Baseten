#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct UpdateRouteHarnessConfigRequestV1 : global::System.IEquatable<UpdateRouteHarnessConfigRequestV1>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateRouteHarnessConfigRequestV1DiscriminatorHarness? Harness { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpdateClaudeCodeHarnessConfigV1? ClaudeCode { get; init; }
#else
        public global::Baseten.UpdateClaudeCodeHarnessConfigV1? ClaudeCode { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClaudeCode))]
#endif
        public bool IsClaudeCode => ClaudeCode != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClaudeCode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.UpdateClaudeCodeHarnessConfigV1? value)
        {
            value = ClaudeCode;
            return IsClaudeCode;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateClaudeCodeHarnessConfigV1 PickClaudeCode() => ClaudeCode is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClaudeCode' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpdateOpenCodeHarnessConfigV1? Opencode { get; init; }
#else
        public global::Baseten.UpdateOpenCodeHarnessConfigV1? Opencode { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Opencode))]
#endif
        public bool IsOpencode => Opencode != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpencode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.UpdateOpenCodeHarnessConfigV1? value)
        {
            value = Opencode;
            return IsOpencode;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateOpenCodeHarnessConfigV1 PickOpencode() => Opencode is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Opencode' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpdateCodexHarnessConfigV1? Codex { get; init; }
#else
        public global::Baseten.UpdateCodexHarnessConfigV1? Codex { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Codex))]
#endif
        public bool IsCodex => Codex != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodex(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.UpdateCodexHarnessConfigV1? value)
        {
            value = Codex;
            return IsCodex;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateCodexHarnessConfigV1 PickCodex() => Codex is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Codex' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateRouteHarnessConfigRequestV1(global::Baseten.UpdateClaudeCodeHarnessConfigV1 value) => new UpdateRouteHarnessConfigRequestV1((global::Baseten.UpdateClaudeCodeHarnessConfigV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpdateClaudeCodeHarnessConfigV1?(UpdateRouteHarnessConfigRequestV1 @this) => @this.ClaudeCode;

        /// <summary>
        ///
        /// </summary>
        public UpdateRouteHarnessConfigRequestV1(global::Baseten.UpdateClaudeCodeHarnessConfigV1? value)
        {
            ClaudeCode = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateRouteHarnessConfigRequestV1 FromClaudeCode(global::Baseten.UpdateClaudeCodeHarnessConfigV1? value) => new UpdateRouteHarnessConfigRequestV1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateRouteHarnessConfigRequestV1(global::Baseten.UpdateOpenCodeHarnessConfigV1 value) => new UpdateRouteHarnessConfigRequestV1((global::Baseten.UpdateOpenCodeHarnessConfigV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpdateOpenCodeHarnessConfigV1?(UpdateRouteHarnessConfigRequestV1 @this) => @this.Opencode;

        /// <summary>
        ///
        /// </summary>
        public UpdateRouteHarnessConfigRequestV1(global::Baseten.UpdateOpenCodeHarnessConfigV1? value)
        {
            Opencode = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateRouteHarnessConfigRequestV1 FromOpencode(global::Baseten.UpdateOpenCodeHarnessConfigV1? value) => new UpdateRouteHarnessConfigRequestV1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateRouteHarnessConfigRequestV1(global::Baseten.UpdateCodexHarnessConfigV1 value) => new UpdateRouteHarnessConfigRequestV1((global::Baseten.UpdateCodexHarnessConfigV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpdateCodexHarnessConfigV1?(UpdateRouteHarnessConfigRequestV1 @this) => @this.Codex;

        /// <summary>
        ///
        /// </summary>
        public UpdateRouteHarnessConfigRequestV1(global::Baseten.UpdateCodexHarnessConfigV1? value)
        {
            Codex = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateRouteHarnessConfigRequestV1 FromCodex(global::Baseten.UpdateCodexHarnessConfigV1? value) => new UpdateRouteHarnessConfigRequestV1(value);

        /// <summary>
        ///
        /// </summary>
        public UpdateRouteHarnessConfigRequestV1(
            global::Baseten.UpdateRouteHarnessConfigRequestV1DiscriminatorHarness? harness,
            global::Baseten.UpdateClaudeCodeHarnessConfigV1? claudeCode,
            global::Baseten.UpdateOpenCodeHarnessConfigV1? opencode,
            global::Baseten.UpdateCodexHarnessConfigV1? codex
            )
        {
            Harness = harness;

            ClaudeCode = claudeCode;
            Opencode = opencode;
            Codex = codex;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Codex as object ??
            Opencode as object ??
            ClaudeCode as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ClaudeCode?.ToString() ??
            Opencode?.ToString() ??
            Codex?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsClaudeCode && !IsOpencode && !IsCodex || !IsClaudeCode && IsOpencode && !IsCodex || !IsClaudeCode && !IsOpencode && IsCodex;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.UpdateClaudeCodeHarnessConfigV1, TResult>? claudeCode = null,
            global::System.Func<global::Baseten.UpdateOpenCodeHarnessConfigV1, TResult>? opencode = null,
            global::System.Func<global::Baseten.UpdateCodexHarnessConfigV1, TResult>? codex = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ClaudeCode is { } __value0 && claudeCode != null)
            {
                return claudeCode(__value0);
            }
            else if (Opencode is { } __value1 && opencode != null)
            {
                return opencode(__value1);
            }
            else if (Codex is { } __value2 && codex != null)
            {
                return codex(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.UpdateClaudeCodeHarnessConfigV1>? claudeCode = null,

            global::System.Action<global::Baseten.UpdateOpenCodeHarnessConfigV1>? opencode = null,

            global::System.Action<global::Baseten.UpdateCodexHarnessConfigV1>? codex = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ClaudeCode is { } __value0)
            {
                claudeCode?.Invoke(__value0);
            }
            else if (Opencode is { } __value1)
            {
                opencode?.Invoke(__value1);
            }
            else if (Codex is { } __value2)
            {
                codex?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.UpdateClaudeCodeHarnessConfigV1>? claudeCode = null,
            global::System.Action<global::Baseten.UpdateOpenCodeHarnessConfigV1>? opencode = null,
            global::System.Action<global::Baseten.UpdateCodexHarnessConfigV1>? codex = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ClaudeCode is { } __value0)
            {
                claudeCode?.Invoke(__value0);
            }
            else if (Opencode is { } __value1)
            {
                opencode?.Invoke(__value1);
            }
            else if (Codex is { } __value2)
            {
                codex?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ClaudeCode,
                typeof(global::Baseten.UpdateClaudeCodeHarnessConfigV1),
                Opencode,
                typeof(global::Baseten.UpdateOpenCodeHarnessConfigV1),
                Codex,
                typeof(global::Baseten.UpdateCodexHarnessConfigV1),
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
        public bool Equals(UpdateRouteHarnessConfigRequestV1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpdateClaudeCodeHarnessConfigV1?>.Default.Equals(ClaudeCode, other.ClaudeCode) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpdateOpenCodeHarnessConfigV1?>.Default.Equals(Opencode, other.Opencode) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpdateCodexHarnessConfigV1?>.Default.Equals(Codex, other.Codex)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UpdateRouteHarnessConfigRequestV1 obj1, UpdateRouteHarnessConfigRequestV1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateRouteHarnessConfigRequestV1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdateRouteHarnessConfigRequestV1 obj1, UpdateRouteHarnessConfigRequestV1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateRouteHarnessConfigRequestV1 o && Equals(o);
        }
    }
}
