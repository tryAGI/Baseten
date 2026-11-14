
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for the training GPU capacity endpoint.
    /// </summary>
    public sealed partial class GetTrainingGpuCapacityResponseV1
    {
        /// <summary>
        /// Organization GPU quotas and current usage per GPU type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_capacities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingGpuCapacityItemV1> GpuCapacities { get; set; }

        /// <summary>
        /// Per-team GPU quotas and current usage per GPU type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_gpu_capacities")]
        public global::System.Collections.Generic.IList<global::Baseten.TeamTrainingGpuCapacityItemV1>? TeamGpuCapacities { get; set; }

        /// <summary>
        /// Whether the organization can submit spot training jobs.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spot_enabled")]
        public bool? SpotEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingGpuCapacityResponseV1" /> class.
        /// </summary>
        /// <param name="gpuCapacities">
        /// Organization GPU quotas and current usage per GPU type
        /// </param>
        /// <param name="teamGpuCapacities">
        /// Per-team GPU quotas and current usage per GPU type
        /// </param>
        /// <param name="spotEnabled">
        /// Whether the organization can submit spot training jobs.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrainingGpuCapacityResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.TrainingGpuCapacityItemV1> gpuCapacities,
            global::System.Collections.Generic.IList<global::Baseten.TeamTrainingGpuCapacityItemV1>? teamGpuCapacities,
            bool? spotEnabled)
        {
            this.GpuCapacities = gpuCapacities ?? throw new global::System.ArgumentNullException(nameof(gpuCapacities));
            this.TeamGpuCapacities = teamGpuCapacities;
            this.SpotEnabled = spotEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingGpuCapacityResponseV1" /> class.
        /// </summary>
        public GetTrainingGpuCapacityResponseV1()
        {
        }

    }
}