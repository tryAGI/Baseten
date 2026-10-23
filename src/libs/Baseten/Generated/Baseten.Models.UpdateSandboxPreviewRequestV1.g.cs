#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Preview fields to change. name and port cannot be changed. ttl and expires_at are mutually exclusive; supplying both returns 400.
    /// </summary>
    public readonly partial struct UpdateSandboxPreviewRequestV1 : global::System.IEquatable<UpdateSandboxPreviewRequestV1>
    {
        /// <summary>
        /// Mutable preview configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.SandboxPreviewConfigurationV1? Configuration { get; init; }
#else
        public global::Baseten.SandboxPreviewConfigurationV1? Configuration { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Configuration))]
#endif
        public bool IsConfiguration => Configuration != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConfiguration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.SandboxPreviewConfigurationV1? value)
        {
            value = Configuration;
            return IsConfiguration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxPreviewConfigurationV1 PickConfiguration() => Configuration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Configuration' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpdateSandboxPreviewRequestV1Variant2? UpdateSandboxPreviewRequestV1Variant2 { get; init; }
#else
        public global::Baseten.UpdateSandboxPreviewRequestV1Variant2? UpdateSandboxPreviewRequestV1Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateSandboxPreviewRequestV1Variant2))]
#endif
        public bool IsUpdateSandboxPreviewRequestV1Variant2 => UpdateSandboxPreviewRequestV1Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUpdateSandboxPreviewRequestV1Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.UpdateSandboxPreviewRequestV1Variant2? value)
        {
            value = UpdateSandboxPreviewRequestV1Variant2;
            return IsUpdateSandboxPreviewRequestV1Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateSandboxPreviewRequestV1Variant2 PickUpdateSandboxPreviewRequestV1Variant2() => UpdateSandboxPreviewRequestV1Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateSandboxPreviewRequestV1Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateSandboxPreviewRequestV1(global::Baseten.SandboxPreviewConfigurationV1 value) => new UpdateSandboxPreviewRequestV1((global::Baseten.SandboxPreviewConfigurationV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.SandboxPreviewConfigurationV1?(UpdateSandboxPreviewRequestV1 @this) => @this.Configuration;

        /// <summary>
        ///
        /// </summary>
        public UpdateSandboxPreviewRequestV1(global::Baseten.SandboxPreviewConfigurationV1? value)
        {
            Configuration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateSandboxPreviewRequestV1 FromConfiguration(global::Baseten.SandboxPreviewConfigurationV1? value) => new UpdateSandboxPreviewRequestV1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateSandboxPreviewRequestV1(global::Baseten.UpdateSandboxPreviewRequestV1Variant2 value) => new UpdateSandboxPreviewRequestV1((global::Baseten.UpdateSandboxPreviewRequestV1Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpdateSandboxPreviewRequestV1Variant2?(UpdateSandboxPreviewRequestV1 @this) => @this.UpdateSandboxPreviewRequestV1Variant2;

        /// <summary>
        ///
        /// </summary>
        public UpdateSandboxPreviewRequestV1(global::Baseten.UpdateSandboxPreviewRequestV1Variant2? value)
        {
            UpdateSandboxPreviewRequestV1Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateSandboxPreviewRequestV1 FromUpdateSandboxPreviewRequestV1Variant2(global::Baseten.UpdateSandboxPreviewRequestV1Variant2? value) => new UpdateSandboxPreviewRequestV1(value);

        /// <summary>
        ///
        /// </summary>
        public UpdateSandboxPreviewRequestV1(
            global::Baseten.SandboxPreviewConfigurationV1? configuration,
            global::Baseten.UpdateSandboxPreviewRequestV1Variant2? updateSandboxPreviewRequestV1Variant2
            )
        {
            Configuration = configuration;
            UpdateSandboxPreviewRequestV1Variant2 = updateSandboxPreviewRequestV1Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UpdateSandboxPreviewRequestV1Variant2 as object ??
            Configuration as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Configuration?.ToString() ??
            UpdateSandboxPreviewRequestV1Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConfiguration && IsUpdateSandboxPreviewRequestV1Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.SandboxPreviewConfigurationV1, TResult>? configuration = null,
            global::System.Func<global::Baseten.UpdateSandboxPreviewRequestV1Variant2, TResult>? updateSandboxPreviewRequestV1Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Configuration is { } __value0 && configuration != null)
            {
                return configuration(__value0);
            }
            else if (UpdateSandboxPreviewRequestV1Variant2 is { } __value1 && updateSandboxPreviewRequestV1Variant2 != null)
            {
                return updateSandboxPreviewRequestV1Variant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.SandboxPreviewConfigurationV1>? configuration = null,

            global::System.Action<global::Baseten.UpdateSandboxPreviewRequestV1Variant2>? updateSandboxPreviewRequestV1Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Configuration is { } __value0)
            {
                configuration?.Invoke(__value0);
            }
            else if (UpdateSandboxPreviewRequestV1Variant2 is { } __value1)
            {
                updateSandboxPreviewRequestV1Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.SandboxPreviewConfigurationV1>? configuration = null,
            global::System.Action<global::Baseten.UpdateSandboxPreviewRequestV1Variant2>? updateSandboxPreviewRequestV1Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Configuration is { } __value0)
            {
                configuration?.Invoke(__value0);
            }
            else if (UpdateSandboxPreviewRequestV1Variant2 is { } __value1)
            {
                updateSandboxPreviewRequestV1Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Configuration,
                typeof(global::Baseten.SandboxPreviewConfigurationV1),
                UpdateSandboxPreviewRequestV1Variant2,
                typeof(global::Baseten.UpdateSandboxPreviewRequestV1Variant2),
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
        public bool Equals(UpdateSandboxPreviewRequestV1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.SandboxPreviewConfigurationV1?>.Default.Equals(Configuration, other.Configuration) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpdateSandboxPreviewRequestV1Variant2?>.Default.Equals(UpdateSandboxPreviewRequestV1Variant2, other.UpdateSandboxPreviewRequestV1Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UpdateSandboxPreviewRequestV1 obj1, UpdateSandboxPreviewRequestV1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateSandboxPreviewRequestV1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdateSandboxPreviewRequestV1 obj1, UpdateSandboxPreviewRequestV1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateSandboxPreviewRequestV1 o && Equals(o);
        }
    }
}
