#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Preview fields to change. name and port cannot be changed.
    /// </summary>
    public readonly partial struct UpdateSandboxPreviewRequestV1 : global::System.IEquatable<UpdateSandboxPreviewRequestV1>
    {
        /// <summary>
        /// Mutable preview configuration. ttl and expires_at are mutually exclusive; supplying both returns 400.
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
        public object? Object =>
            Configuration as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Configuration?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConfiguration;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.SandboxPreviewConfigurationV1, TResult>? configuration = null,
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

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.SandboxPreviewConfigurationV1>? configuration = null,
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
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.SandboxPreviewConfigurationV1>? configuration = null,
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
                global::System.Collections.Generic.EqualityComparer<global::Baseten.SandboxPreviewConfigurationV1?>.Default.Equals(Configuration, other.Configuration)
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
