
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Configuration to specify the compute for a training job.
    /// </summary>
    public sealed partial class CreateTrainingJobComputeV1
    {
        /// <summary>
        /// Number of nodes for the training job.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_count")]
        public int? NodeCount { get; set; }

        /// <summary>
        /// Number of cpus for the training job.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_count")]
        public int? CpuCount { get; set; }

        /// <summary>
        /// Memory for the training job.<br/>
        /// Default Value: 2Gi
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public string? Memory { get; set; }

        /// <summary>
        /// GPU specification for the training job<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accelerator")]
        public global::Baseten.CreateTrainingJobAcceleratorV1? Accelerator { get; set; }

        /// <summary>
        /// Capacity guarantee for the job. 'dedicated' (the default) runs on on-demand capacity that is not preempted. 'spot' runs on interruptible capacity that may be preempted; the user is responsible for checkpointing their own progress.<br/>
        /// Default Value: dedicated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availability_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.V1AvailabilityModelJsonConverter))]
        public global::Baseten.V1AvailabilityModel? AvailabilityModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobComputeV1" /> class.
        /// </summary>
        /// <param name="nodeCount">
        /// Number of nodes for the training job.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="cpuCount">
        /// Number of cpus for the training job.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="memory">
        /// Memory for the training job.<br/>
        /// Default Value: 2Gi
        /// </param>
        /// <param name="accelerator">
        /// GPU specification for the training job<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="availabilityModel">
        /// Capacity guarantee for the job. 'dedicated' (the default) runs on on-demand capacity that is not preempted. 'spot' runs on interruptible capacity that may be preempted; the user is responsible for checkpointing their own progress.<br/>
        /// Default Value: dedicated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrainingJobComputeV1(
            int? nodeCount,
            int? cpuCount,
            string? memory,
            global::Baseten.CreateTrainingJobAcceleratorV1? accelerator,
            global::Baseten.V1AvailabilityModel? availabilityModel)
        {
            this.NodeCount = nodeCount;
            this.CpuCount = cpuCount;
            this.Memory = memory;
            this.Accelerator = accelerator;
            this.AvailabilityModel = availabilityModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobComputeV1" /> class.
        /// </summary>
        public CreateTrainingJobComputeV1()
        {
        }

    }
}