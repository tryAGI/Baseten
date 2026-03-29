
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Configuration to create a training job image.
    /// </summary>
    public sealed partial class CreateTrainingJobImageV1
    {
        /// <summary>
        /// Base image for the training job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseImage { get; set; }

        /// <summary>
        /// Docker authentication credentials<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docker_auth")]
        public global::Baseten.DockerAuthV1? DockerAuth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobImageV1" /> class.
        /// </summary>
        /// <param name="baseImage">
        /// Base image for the training job.
        /// </param>
        /// <param name="dockerAuth">
        /// Docker authentication credentials<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrainingJobImageV1(
            string baseImage,
            global::Baseten.DockerAuthV1? dockerAuth)
        {
            this.BaseImage = baseImage ?? throw new global::System.ArgumentNullException(nameof(baseImage));
            this.DockerAuth = dockerAuth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobImageV1" /> class.
        /// </summary>
        public CreateTrainingJobImageV1()
        {
        }
    }
}