
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for the training GPU capacity endpoint.
    /// </summary>
    public sealed partial class GetTrainingGpuCapacityResponseV1
    {
        /// <summary>
        /// GPU capacity limits and current usage per GPU type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_capacities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingGpuCapacityItemV1> GpuCapacities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingGpuCapacityResponseV1" /> class.
        /// </summary>
        /// <param name="gpuCapacities">
        /// GPU capacity limits and current usage per GPU type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrainingGpuCapacityResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.TrainingGpuCapacityItemV1> gpuCapacities)
        {
            this.GpuCapacities = gpuCapacities ?? throw new global::System.ArgumentNullException(nameof(gpuCapacities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingGpuCapacityResponseV1" /> class.
        /// </summary>
        public GetTrainingGpuCapacityResponseV1()
        {
        }
    }
}