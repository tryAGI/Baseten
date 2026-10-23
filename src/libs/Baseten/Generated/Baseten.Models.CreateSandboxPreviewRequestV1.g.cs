#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Preview to create. Only port is required. ttl and expires_at are mutually exclusive; supplying both returns 400.
    /// </summary>
    public readonly partial struct CreateSandboxPreviewRequestV1 : global::System.IEquatable<CreateSandboxPreviewRequestV1>
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
        public global::Baseten.CreateSandboxPreviewRequestV1Variant2? CreateSandboxPreviewRequestV1Variant2 { get; init; }
#else
        public global::Baseten.CreateSandboxPreviewRequestV1Variant2? CreateSandboxPreviewRequestV1Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateSandboxPreviewRequestV1Variant2))]
#endif
        public bool IsCreateSandboxPreviewRequestV1Variant2 => CreateSandboxPreviewRequestV1Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateSandboxPreviewRequestV1Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.CreateSandboxPreviewRequestV1Variant2? value)
        {
            value = CreateSandboxPreviewRequestV1Variant2;
            return IsCreateSandboxPreviewRequestV1Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateSandboxPreviewRequestV1Variant2 PickCreateSandboxPreviewRequestV1Variant2() => CreateSandboxPreviewRequestV1Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateSandboxPreviewRequestV1Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateSandboxPreviewRequestV1(global::Baseten.SandboxPreviewConfigurationV1 value) => new CreateSandboxPreviewRequestV1((global::Baseten.SandboxPreviewConfigurationV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.SandboxPreviewConfigurationV1?(CreateSandboxPreviewRequestV1 @this) => @this.Configuration;

        /// <summary>
        ///
        /// </summary>
        public CreateSandboxPreviewRequestV1(global::Baseten.SandboxPreviewConfigurationV1? value)
        {
            Configuration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateSandboxPreviewRequestV1 FromConfiguration(global::Baseten.SandboxPreviewConfigurationV1? value) => new CreateSandboxPreviewRequestV1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateSandboxPreviewRequestV1(global::Baseten.CreateSandboxPreviewRequestV1Variant2 value) => new CreateSandboxPreviewRequestV1((global::Baseten.CreateSandboxPreviewRequestV1Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.CreateSandboxPreviewRequestV1Variant2?(CreateSandboxPreviewRequestV1 @this) => @this.CreateSandboxPreviewRequestV1Variant2;

        /// <summary>
        ///
        /// </summary>
        public CreateSandboxPreviewRequestV1(global::Baseten.CreateSandboxPreviewRequestV1Variant2? value)
        {
            CreateSandboxPreviewRequestV1Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateSandboxPreviewRequestV1 FromCreateSandboxPreviewRequestV1Variant2(global::Baseten.CreateSandboxPreviewRequestV1Variant2? value) => new CreateSandboxPreviewRequestV1(value);

        /// <summary>
        ///
        /// </summary>
        public CreateSandboxPreviewRequestV1(
            global::Baseten.SandboxPreviewConfigurationV1? configuration,
            global::Baseten.CreateSandboxPreviewRequestV1Variant2? createSandboxPreviewRequestV1Variant2
            )
        {
            Configuration = configuration;
            CreateSandboxPreviewRequestV1Variant2 = createSandboxPreviewRequestV1Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateSandboxPreviewRequestV1Variant2 as object ??
            Configuration as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Configuration?.ToString() ??
            CreateSandboxPreviewRequestV1Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConfiguration && IsCreateSandboxPreviewRequestV1Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.SandboxPreviewConfigurationV1, TResult>? configuration = null,
            global::System.Func<global::Baseten.CreateSandboxPreviewRequestV1Variant2, TResult>? createSandboxPreviewRequestV1Variant2 = null,
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
            else if (CreateSandboxPreviewRequestV1Variant2 is { } __value1 && createSandboxPreviewRequestV1Variant2 != null)
            {
                return createSandboxPreviewRequestV1Variant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.SandboxPreviewConfigurationV1>? configuration = null,

            global::System.Action<global::Baseten.CreateSandboxPreviewRequestV1Variant2>? createSandboxPreviewRequestV1Variant2 = null,
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
            else if (CreateSandboxPreviewRequestV1Variant2 is { } __value1)
            {
                createSandboxPreviewRequestV1Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.SandboxPreviewConfigurationV1>? configuration = null,
            global::System.Action<global::Baseten.CreateSandboxPreviewRequestV1Variant2>? createSandboxPreviewRequestV1Variant2 = null,
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
            else if (CreateSandboxPreviewRequestV1Variant2 is { } __value1)
            {
                createSandboxPreviewRequestV1Variant2?.Invoke(__value1);
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
                CreateSandboxPreviewRequestV1Variant2,
                typeof(global::Baseten.CreateSandboxPreviewRequestV1Variant2),
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
        public bool Equals(CreateSandboxPreviewRequestV1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.SandboxPreviewConfigurationV1?>.Default.Equals(Configuration, other.Configuration) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.CreateSandboxPreviewRequestV1Variant2?>.Default.Equals(CreateSandboxPreviewRequestV1Variant2, other.CreateSandboxPreviewRequestV1Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateSandboxPreviewRequestV1 obj1, CreateSandboxPreviewRequestV1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateSandboxPreviewRequestV1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateSandboxPreviewRequestV1 obj1, CreateSandboxPreviewRequestV1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateSandboxPreviewRequestV1 o && Equals(o);
        }
    }
}
