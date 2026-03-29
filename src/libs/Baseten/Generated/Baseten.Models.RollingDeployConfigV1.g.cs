
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Rolling deploy config for promoting chains and oracles
    /// </summary>
    public sealed partial class RollingDeployConfigV1
    {
        /// <summary>
        /// The rolling deploy strategy to use for promotions.<br/>
        /// Default Value: REPLICA
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rolling_deploy_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.RollingDeployStrategyV1JsonConverter))]
        public global::Baseten.RollingDeployStrategyV1? RollingDeployStrategy { get; set; }

        /// <summary>
        /// The maximum surge percentage for rolling deploys.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_surge_percent")]
        public int? MaxSurgePercent { get; set; }

        /// <summary>
        /// The maximum unavailable percentage for rolling deploys.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_unavailable_percent")]
        public int? MaxUnavailablePercent { get; set; }

        /// <summary>
        /// The stabilization time in seconds for rolling deploys.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stabilization_time_seconds")]
        public int? StabilizationTimeSeconds { get; set; }

        /// <summary>
        /// The replica overhead percentage for rolling deploys.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_overhead_percent")]
        public int? ReplicaOverheadPercent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RollingDeployConfigV1" /> class.
        /// </summary>
        /// <param name="rollingDeployStrategy">
        /// The rolling deploy strategy to use for promotions.<br/>
        /// Default Value: REPLICA
        /// </param>
        /// <param name="maxSurgePercent">
        /// The maximum surge percentage for rolling deploys.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="maxUnavailablePercent">
        /// The maximum unavailable percentage for rolling deploys.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="stabilizationTimeSeconds">
        /// The stabilization time in seconds for rolling deploys.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="replicaOverheadPercent">
        /// The replica overhead percentage for rolling deploys.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RollingDeployConfigV1(
            global::Baseten.RollingDeployStrategyV1? rollingDeployStrategy,
            int? maxSurgePercent,
            int? maxUnavailablePercent,
            int? stabilizationTimeSeconds,
            int? replicaOverheadPercent)
        {
            this.RollingDeployStrategy = rollingDeployStrategy;
            this.MaxSurgePercent = maxSurgePercent;
            this.MaxUnavailablePercent = maxUnavailablePercent;
            this.StabilizationTimeSeconds = stabilizationTimeSeconds;
            this.ReplicaOverheadPercent = replicaOverheadPercent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RollingDeployConfigV1" /> class.
        /// </summary>
        public RollingDeployConfigV1()
        {
        }
    }
}