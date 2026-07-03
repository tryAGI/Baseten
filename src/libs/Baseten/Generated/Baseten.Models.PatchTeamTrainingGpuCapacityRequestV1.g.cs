
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to set the GPU capacity ceiling for a (team, gpu_type) pair.<br/>
    /// Creates the limit if one doesn't already exist for this team and GPU type,<br/>
    /// otherwise updates it in place.
    /// </summary>
    public sealed partial class PatchTeamTrainingGpuCapacityRequestV1
    {
        /// <summary>
        /// Team identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// GPU type identifier (e.g. H100, A100-40GB)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GpuType { get; set; }

        /// <summary>
        /// Max concurrent GPUs of this type the team may use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxGpus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamTrainingGpuCapacityRequestV1" /> class.
        /// </summary>
        /// <param name="teamId">
        /// Team identifier
        /// </param>
        /// <param name="gpuType">
        /// GPU type identifier (e.g. H100, A100-40GB)
        /// </param>
        /// <param name="maxGpus">
        /// Max concurrent GPUs of this type the team may use
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamTrainingGpuCapacityRequestV1(
            string teamId,
            string gpuType,
            int maxGpus)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.GpuType = gpuType ?? throw new global::System.ArgumentNullException(nameof(gpuType));
            this.MaxGpus = maxGpus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamTrainingGpuCapacityRequestV1" /> class.
        /// </summary>
        public PatchTeamTrainingGpuCapacityRequestV1()
        {
        }

    }
}