
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTrainingJobAcceleratorV1
    {
        /// <summary>
        /// GPU type for the training job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accelerator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Accelerator { get; set; }

        /// <summary>
        /// GPUs needed for the training job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobAcceleratorV1" /> class.
        /// </summary>
        /// <param name="accelerator">
        /// GPU type for the training job.
        /// </param>
        /// <param name="count">
        /// GPUs needed for the training job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrainingJobAcceleratorV1(
            string accelerator,
            int count)
        {
            this.Accelerator = accelerator ?? throw new global::System.ArgumentNullException(nameof(accelerator));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobAcceleratorV1" /> class.
        /// </summary>
        public CreateTrainingJobAcceleratorV1()
        {
        }
    }
}