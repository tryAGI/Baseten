
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Per-team GPU capacity and current usage for one GPU type.
    /// </summary>
    public sealed partial class TeamTrainingGpuCapacityItemV1
    {
        /// <summary>
        /// Team identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Team name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamName { get; set; }

        /// <summary>
        /// GPU type identifier (e.g. H100, A100-40GB)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GpuType { get; set; }

        /// <summary>
        /// Baseline GPU allocation for the team. 0 if not configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Baseline { get; set; }

        /// <summary>
        /// Maximum concurrent GPUs of this type for this team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// GPUs currently in use by the team's active training jobs
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
        /// Initializes a new instance of the <see cref="TeamTrainingGpuCapacityItemV1" /> class.
        /// </summary>
        /// <param name="teamId">
        /// Team identifier
        /// </param>
        /// <param name="teamName">
        /// Team name
        /// </param>
        /// <param name="gpuType">
        /// GPU type identifier (e.g. H100, A100-40GB)
        /// </param>
        /// <param name="baseline">
        /// Baseline GPU allocation for the team. 0 if not configured.
        /// </param>
        /// <param name="limit">
        /// Maximum concurrent GPUs of this type for this team
        /// </param>
        /// <param name="usageCount">
        /// GPUs currently in use by the team's active training jobs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamTrainingGpuCapacityItemV1(
            string teamId,
            string teamName,
            string gpuType,
            int baseline,
            int limit,
            int usageCount)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
            this.GpuType = gpuType ?? throw new global::System.ArgumentNullException(nameof(gpuType));
            this.Baseline = baseline;
            this.Limit = limit;
            this.UsageCount = usageCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamTrainingGpuCapacityItemV1" /> class.
        /// </summary>
        public TeamTrainingGpuCapacityItemV1()
        {
        }

    }
}