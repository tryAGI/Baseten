
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
        /// Baseline GPU allocation; jobs below this threshold are expected to run immediately. 0 if not configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Baseline { get; set; }

        /// <summary>
        /// Maximum concurrent GPUs of this type for this org
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// GPUs currently in use by active training jobs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UsageCount { get; set; }

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
        /// Baseline GPU allocation; jobs below this threshold are expected to run immediately. 0 if not configured.
        /// </param>
        /// <param name="limit">
        /// Maximum concurrent GPUs of this type for this org
        /// </param>
        /// <param name="usageCount">
        /// GPUs currently in use by active training jobs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingGpuCapacityItemV1(
            string gpuType,
            int baseline,
            int limit,
            int usageCount)
        {
            this.GpuType = gpuType ?? throw new global::System.ArgumentNullException(nameof(gpuType));
            this.Baseline = baseline;
            this.Limit = limit;
            this.UsageCount = usageCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingGpuCapacityItemV1" /> class.
        /// </summary>
        public TrainingGpuCapacityItemV1()
        {
        }
    }
}