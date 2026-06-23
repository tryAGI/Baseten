
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for the training GPU capacity endpoint.
    /// </summary>
    public sealed partial class GetTrainingGpuCapacityResponseV1
    {
        /// <summary>
        /// Org-level GPU capacity limits and current usage per GPU type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_capacities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingGpuCapacityItemV1> GpuCapacities { get; set; }

        /// <summary>
        /// Per-team GPU capacity limits and current usage per GPU type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_gpu_capacities")]
        public global::System.Collections.Generic.IList<global::Baseten.TeamTrainingGpuCapacityItemV1>? TeamGpuCapacities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingGpuCapacityResponseV1" /> class.
        /// </summary>
        /// <param name="gpuCapacities">
        /// Org-level GPU capacity limits and current usage per GPU type
        /// </param>
        /// <param name="teamGpuCapacities">
        /// Per-team GPU capacity limits and current usage per GPU type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrainingGpuCapacityResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.TrainingGpuCapacityItemV1> gpuCapacities,
            global::System.Collections.Generic.IList<global::Baseten.TeamTrainingGpuCapacityItemV1>? teamGpuCapacities)
        {
            this.GpuCapacities = gpuCapacities ?? throw new global::System.ArgumentNullException(nameof(gpuCapacities));
            this.TeamGpuCapacities = teamGpuCapacities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingGpuCapacityResponseV1" /> class.
        /// </summary>
        public GetTrainingGpuCapacityResponseV1()
        {
        }

    }
}