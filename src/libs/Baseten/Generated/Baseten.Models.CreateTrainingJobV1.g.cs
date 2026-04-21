
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Configuration for a training job.
    /// </summary>
    public sealed partial class CreateTrainingJobV1
    {
        /// <summary>
        /// Configuration to create a training job image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.CreateTrainingJobImageV1 Image { get; set; }

        /// <summary>
        /// Configuration to specify the compute for a training job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute")]
        public global::Baseten.CreateTrainingJobComputeV1? Compute { get; set; }

        /// <summary>
        /// Configuration for the runtime environment of the training job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public global::Baseten.CreateTrainingJobRuntimeV1? Runtime { get; set; }

        /// <summary>
        /// Name of the training job.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Truss user environment information<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truss_user_env")]
        public global::Baseten.TrussUserEnv? TrussUserEnv { get; set; }

        /// <summary>
        /// Configuration for interactive debugging sessions.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interactive_session")]
        public global::Baseten.InteractiveSessionConfigV1? InteractiveSession { get; set; }

        /// <summary>
        /// MDN weight sources to mount in the training container. Weights are mirrored and cached for fast startup.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weights")]
        public global::System.Collections.Generic.IList<global::Baseten.CreateJobWeightConfigV1>? Weights { get; set; }

        /// <summary>
        /// When enabled, uses /b10/workspace as the working directory instead of the image WORKDIR.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_baseten_workdir")]
        public bool? EnableBasetenWorkdir { get; set; }

        /// <summary>
        /// Queue priority. Higher values are dequeued first. Defaults to 0.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobV1" /> class.
        /// </summary>
        /// <param name="image">
        /// Configuration to create a training job image.
        /// </param>
        /// <param name="compute">
        /// Configuration to specify the compute for a training job.
        /// </param>
        /// <param name="runtime">
        /// Configuration for the runtime environment of the training job.
        /// </param>
        /// <param name="name">
        /// Name of the training job.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="trussUserEnv">
        /// Truss user environment information<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="interactiveSession">
        /// Configuration for interactive debugging sessions.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="weights">
        /// MDN weight sources to mount in the training container. Weights are mirrored and cached for fast startup.
        /// </param>
        /// <param name="enableBasetenWorkdir">
        /// When enabled, uses /b10/workspace as the working directory instead of the image WORKDIR.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="priority">
        /// Queue priority. Higher values are dequeued first. Defaults to 0.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrainingJobV1(
            global::Baseten.CreateTrainingJobImageV1 image,
            global::Baseten.CreateTrainingJobComputeV1? compute,
            global::Baseten.CreateTrainingJobRuntimeV1? runtime,
            string? name,
            global::Baseten.TrussUserEnv? trussUserEnv,
            global::Baseten.InteractiveSessionConfigV1? interactiveSession,
            global::System.Collections.Generic.IList<global::Baseten.CreateJobWeightConfigV1>? weights,
            bool? enableBasetenWorkdir,
            int? priority)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Compute = compute;
            this.Runtime = runtime;
            this.Name = name;
            this.TrussUserEnv = trussUserEnv;
            this.InteractiveSession = interactiveSession;
            this.Weights = weights;
            this.EnableBasetenWorkdir = enableBasetenWorkdir;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobV1" /> class.
        /// </summary>
        public CreateTrainingJobV1()
        {
        }
    }
}