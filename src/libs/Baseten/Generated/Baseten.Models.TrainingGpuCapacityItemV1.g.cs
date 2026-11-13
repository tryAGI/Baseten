
#nullable enable

namespace Baseten
{
    /// <summary>
    /// GPU capacity and current usage for one GPU type.
    /// </summary>
    public sealed partial class TrainingGpuCapacityItemV1
    {
        /// <summary>
        /// GPU type identifier (e.g. H100, A100-40GB)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GpuType { get; set; }

        /// <summary>
        /// Configured minimum GPU allocation (`min_gpus`). 0 if not configured. Use `on_demand_cap` for the cap applied to on-demand jobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Baseline { get; set; }

        /// <summary>
        /// Configured maximum GPU allocation (`max_gpus`). Use `on_demand_cap` and `spot_cap` for the caps applied to jobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// Maximum concurrent GPUs of this type for on-demand (non-spot) jobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_demand_cap")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OnDemandCap { get; set; }

        /// <summary>
        /// Maximum concurrent GPUs of this type for spot jobs. Spot shares this cap with on-demand jobs: spot can use up to the cap minus on-demand GPUs in use. Null if spot is not enabled for the organization.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spot_cap")]
        public int? SpotCap { get; set; }

        /// <summary>
        /// GPUs currently in use by active training jobs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UsageCount { get; set; }

        /// <summary>
        /// Portion of usage_count from on-demand (non-spot) jobs.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dedicated_usage_count")]
        public int? DedicatedUsageCount { get; set; }

        /// <summary>
        /// Portion of usage_count from spot jobs.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spot_usage_count")]
        public int? SpotUsageCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingGpuCapacityItemV1" /> class.
        /// </summary>
        /// <param name="gpuType">
        /// GPU type identifier (e.g. H100, A100-40GB)
        /// </param>
        /// <param name="baseline">
        /// Configured minimum GPU allocation (`min_gpus`). 0 if not configured. Use `on_demand_cap` for the cap applied to on-demand jobs.
        /// </param>
        /// <param name="limit">
        /// Configured maximum GPU allocation (`max_gpus`). Use `on_demand_cap` and `spot_cap` for the caps applied to jobs.
        /// </param>
        /// <param name="onDemandCap">
        /// Maximum concurrent GPUs of this type for on-demand (non-spot) jobs.
        /// </param>
        /// <param name="usageCount">
        /// GPUs currently in use by active training jobs
        /// </param>
        /// <param name="spotCap">
        /// Maximum concurrent GPUs of this type for spot jobs. Spot shares this cap with on-demand jobs: spot can use up to the cap minus on-demand GPUs in use. Null if spot is not enabled for the organization.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="dedicatedUsageCount">
        /// Portion of usage_count from on-demand (non-spot) jobs.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="spotUsageCount">
        /// Portion of usage_count from spot jobs.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingGpuCapacityItemV1(
            string gpuType,
            int baseline,
            int limit,
            int onDemandCap,
            int usageCount,
            int? spotCap,
            int? dedicatedUsageCount,
            int? spotUsageCount)
        {
            this.GpuType = gpuType ?? throw new global::System.ArgumentNullException(nameof(gpuType));
            this.Baseline = baseline;
            this.Limit = limit;
            this.OnDemandCap = onDemandCap;
            this.SpotCap = spotCap;
            this.UsageCount = usageCount;
            this.DedicatedUsageCount = dedicatedUsageCount;
            this.SpotUsageCount = spotUsageCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingGpuCapacityItemV1" /> class.
        /// </summary>
        public TrainingGpuCapacityItemV1()
        {
        }

    }
}