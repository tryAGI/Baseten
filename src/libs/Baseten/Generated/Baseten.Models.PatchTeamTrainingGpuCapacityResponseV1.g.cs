
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for setting a team's GPU capacity ceiling.
    /// </summary>
    public sealed partial class PatchTeamTrainingGpuCapacityResponseV1
    {
        /// <summary>
        /// The updated per-team GPU capacity limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_gpu_capacity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.TeamTrainingGpuCapacityItemV1 TeamGpuCapacity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamTrainingGpuCapacityResponseV1" /> class.
        /// </summary>
        /// <param name="teamGpuCapacity">
        /// The updated per-team GPU capacity limit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamTrainingGpuCapacityResponseV1(
            global::Baseten.TeamTrainingGpuCapacityItemV1 teamGpuCapacity)
        {
            this.TeamGpuCapacity = teamGpuCapacity ?? throw new global::System.ArgumentNullException(nameof(teamGpuCapacity));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamTrainingGpuCapacityResponseV1" /> class.
        /// </summary>
        public PatchTeamTrainingGpuCapacityResponseV1()
        {
        }

    }
}