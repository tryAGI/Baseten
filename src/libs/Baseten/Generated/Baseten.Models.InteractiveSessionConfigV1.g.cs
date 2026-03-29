
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Configuration for interactive debugging sessions on training jobs.
    /// </summary>
    public sealed partial class InteractiveSessionConfigV1
    {
        /// <summary>
        /// When to create the interactive session. 'on_startup' creates on job start, 'on_failure' creates on job failure, 'on_demand' bypasses automatic session creation.<br/>
        /// Default Value: on_demand
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.V1InteractiveSessionTriggerJsonConverter))]
        public global::Baseten.V1InteractiveSessionTrigger? Trigger { get; set; }

        /// <summary>
        /// Number of minutes before the interactive session times out.<br/>
        /// Default Value: 480
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_minutes")]
        public int? TimeoutMinutes { get; set; }

        /// <summary>
        /// The IDE client for the interactive session.<br/>
        /// Default Value: vs_code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.V1InteractiveSessionProviderJsonConverter))]
        public global::Baseten.V1InteractiveSessionProvider? SessionProvider { get; set; }

        /// <summary>
        /// The authentication provider for the interactive session.<br/>
        /// Default Value: github
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.V1InteractiveSessionAuthProviderJsonConverter))]
        public global::Baseten.V1InteractiveSessionAuthProvider? AuthProvider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractiveSessionConfigV1" /> class.
        /// </summary>
        /// <param name="trigger">
        /// When to create the interactive session. 'on_startup' creates on job start, 'on_failure' creates on job failure, 'on_demand' bypasses automatic session creation.<br/>
        /// Default Value: on_demand
        /// </param>
        /// <param name="timeoutMinutes">
        /// Number of minutes before the interactive session times out.<br/>
        /// Default Value: 480
        /// </param>
        /// <param name="sessionProvider">
        /// The IDE client for the interactive session.<br/>
        /// Default Value: vs_code
        /// </param>
        /// <param name="authProvider">
        /// The authentication provider for the interactive session.<br/>
        /// Default Value: github
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InteractiveSessionConfigV1(
            global::Baseten.V1InteractiveSessionTrigger? trigger,
            int? timeoutMinutes,
            global::Baseten.V1InteractiveSessionProvider? sessionProvider,
            global::Baseten.V1InteractiveSessionAuthProvider? authProvider)
        {
            this.Trigger = trigger;
            this.TimeoutMinutes = timeoutMinutes;
            this.SessionProvider = sessionProvider;
            this.AuthProvider = authProvider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractiveSessionConfigV1" /> class.
        /// </summary>
        public InteractiveSessionConfigV1()
        {
        }
    }
}