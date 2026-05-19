
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Add a deployment from an archive previously uploaded via the credentials<br/>
    /// issued by `POST /v1/prepare_model_upload`.
    /// </summary>
    public sealed partial class DeploymentArchiveSourceV1
    {
        /// <summary>
        /// Default Value: model_archive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Deployment-level configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentArchivePayloadV1 Deployment { get; set; }

        /// <summary>
        /// S3 key of the uploaded archive, from the credentials returned by `POST /v1/prepare_model_upload`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string S3Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentArchiveSourceV1" /> class.
        /// </summary>
        /// <param name="deployment">
        /// Deployment-level configuration.
        /// </param>
        /// <param name="s3Key">
        /// S3 key of the uploaded archive, from the credentials returned by `POST /v1/prepare_model_upload`.
        /// </param>
        /// <param name="kind">
        /// Default Value: model_archive
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentArchiveSourceV1(
            global::Baseten.DeploymentArchivePayloadV1 deployment,
            string s3Key,
            string? kind)
        {
            this.Kind = kind;
            this.Deployment = deployment ?? throw new global::System.ArgumentNullException(nameof(deployment));
            this.S3Key = s3Key ?? throw new global::System.ArgumentNullException(nameof(s3Key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentArchiveSourceV1" /> class.
        /// </summary>
        public DeploymentArchiveSourceV1()
        {
        }

    }
}