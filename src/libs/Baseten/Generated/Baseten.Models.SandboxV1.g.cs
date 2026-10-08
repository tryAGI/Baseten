#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Sandbox resource with configuration and server-managed fields at the root. No metadata, spec, or runtime wrapper.<br/>
    /// Example: {"lifecycle":{"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"},"network":{"proxy":{"allowed_domains":["api.openai.com","pypi.org","files.pythonhosted.org","registry.npmjs.org"],"bypass":["registry.npmjs.org"],"forbidden_domains":["facebook.com","*.facebook.com"],"routing":[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"}}]},"subnet":"default"},"region":"us-pdx-1","envs":[{"name":"NODE_ENV","secret":false,"value":"production"},{"name":"PORT","secret":false,"value":"3000"}],"image":"baseten/base-image:latest","memory":4096,"ports":[{"name":"http","protocol":"HTTP","target":3000}],"external_id":"api-review-20260916-001","labels":{"env":"development","project":"api-review","team":"engineering"},"name":"baseten-api-review-0916","url":"https://sbx-baseten-api-review-0916-esb1qo.us-pdx-1.b10.run","status":"DEPLOYED","created_at":"2026-09-16T21:26:58.545765901Z","updated_at":"2026-09-16T21:31:13Z","created_by":"sandbox-automation","updated_by":"sandbox-automation","last_used_at":"2026-09-16T21:31:13Z","expires_in":86400}
    /// </summary>
    public readonly partial struct SandboxV1 : global::System.IEquatable<SandboxV1>
    {
        /// <summary>
        /// Writable sandbox configuration. Fields are serialized at the root of the request or resource.<br/>
        /// Example: {"lifecycle":{"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"},"network":{"proxy":{"allowed_domains":["api.openai.com","pypi.org","files.pythonhosted.org","registry.npmjs.org"],"bypass":["registry.npmjs.org"],"forbidden_domains":["facebook.com","*.facebook.com"],"routing":[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"},"secrets":{"openai-key":"sk-proj-demo-not-a-valid-api-key"}}]},"subnet":"default"},"region":"us-pdx-1","envs":[{"name":"NODE_ENV","secret":false,"value":"production"},{"name":"PORT","secret":false,"value":"3000"}],"image":"baseten/base-image:latest","memory":4096,"ports":[{"name":"http","protocol":"HTTP","target":3000}],"external_id":"api-review-20260916-001","labels":{"env":"development","project":"api-review","team":"engineering"}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.SandboxConfigurationV1? Configuration { get; init; }
#else
        public global::Baseten.SandboxConfigurationV1? Configuration { get; }
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
            out global::Baseten.SandboxConfigurationV1? value)
        {
            value = Configuration;
            return IsConfiguration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxConfigurationV1 PickConfiguration() => Configuration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Configuration' but the value was {ToString()}.");

        /// <summary>
        /// Server-managed sandbox fields.<br/>
        /// Example: {"name":"baseten-api-review-0916","url":"https://sbx-baseten-api-review-0916-esb1qo.us-pdx-1.b10.run","status":"DEPLOYED","created_at":"2026-09-16T21:26:58.545765901Z","updated_at":"2026-09-16T21:31:13Z","created_by":"sandbox-automation","updated_by":"sandbox-automation","last_used_at":"2026-09-16T21:31:13Z","expires_in":86400}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.SandboxV1Variant2? SandboxV1Variant2 { get; init; }
#else
        public global::Baseten.SandboxV1Variant2? SandboxV1Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SandboxV1Variant2))]
#endif
        public bool IsSandboxV1Variant2 => SandboxV1Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSandboxV1Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.SandboxV1Variant2? value)
        {
            value = SandboxV1Variant2;
            return IsSandboxV1Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxV1Variant2 PickSandboxV1Variant2() => SandboxV1Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SandboxV1Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxV1(global::Baseten.SandboxConfigurationV1 value) => new SandboxV1((global::Baseten.SandboxConfigurationV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.SandboxConfigurationV1?(SandboxV1 @this) => @this.Configuration;

        /// <summary>
        ///
        /// </summary>
        public SandboxV1(global::Baseten.SandboxConfigurationV1? value)
        {
            Configuration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxV1 FromConfiguration(global::Baseten.SandboxConfigurationV1? value) => new SandboxV1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxV1(global::Baseten.SandboxV1Variant2 value) => new SandboxV1((global::Baseten.SandboxV1Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.SandboxV1Variant2?(SandboxV1 @this) => @this.SandboxV1Variant2;

        /// <summary>
        ///
        /// </summary>
        public SandboxV1(global::Baseten.SandboxV1Variant2? value)
        {
            SandboxV1Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxV1 FromSandboxV1Variant2(global::Baseten.SandboxV1Variant2? value) => new SandboxV1(value);

        /// <summary>
        ///
        /// </summary>
        public SandboxV1(
            global::Baseten.SandboxConfigurationV1? configuration,
            global::Baseten.SandboxV1Variant2? sandboxV1Variant2
            )
        {
            Configuration = configuration;
            SandboxV1Variant2 = sandboxV1Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SandboxV1Variant2 as object ??
            Configuration as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Configuration?.ToString() ??
            SandboxV1Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConfiguration && IsSandboxV1Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.SandboxConfigurationV1, TResult>? configuration = null,
            global::System.Func<global::Baseten.SandboxV1Variant2, TResult>? sandboxV1Variant2 = null,
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
            else if (SandboxV1Variant2 is { } __value1 && sandboxV1Variant2 != null)
            {
                return sandboxV1Variant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.SandboxConfigurationV1>? configuration = null,

            global::System.Action<global::Baseten.SandboxV1Variant2>? sandboxV1Variant2 = null,
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
            else if (SandboxV1Variant2 is { } __value1)
            {
                sandboxV1Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.SandboxConfigurationV1>? configuration = null,
            global::System.Action<global::Baseten.SandboxV1Variant2>? sandboxV1Variant2 = null,
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
            else if (SandboxV1Variant2 is { } __value1)
            {
                sandboxV1Variant2?.Invoke(__value1);
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
                typeof(global::Baseten.SandboxConfigurationV1),
                SandboxV1Variant2,
                typeof(global::Baseten.SandboxV1Variant2),
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
        public bool Equals(SandboxV1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.SandboxConfigurationV1?>.Default.Equals(Configuration, other.Configuration) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.SandboxV1Variant2?>.Default.Equals(SandboxV1Variant2, other.SandboxV1Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SandboxV1 obj1, SandboxV1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SandboxV1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SandboxV1 obj1, SandboxV1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SandboxV1 o && Equals(o);
        }
    }
}
