
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Create a model from an archive previously uploaded via the credentials<br/>
    /// issued by `POST /v1/prepare_model_upload`.
    /// </summary>
    public sealed partial class ModelArchiveSourceV1
    {
        /// <summary>
        /// Default Value: model_archive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Name of the new model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Deployment-level configuration for the model's first deployment.
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
        /// If true, the uploaded archive is not downloadable after creation. Locked at model creation; cannot be changed by subsequent deployments.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_archive_download")]
        public bool? DisableArchiveDownload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelArchiveSourceV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the new model.
        /// </param>
        /// <param name="deployment">
        /// Deployment-level configuration for the model's first deployment.
        /// </param>
        /// <param name="s3Key">
        /// S3 key of the uploaded archive, from the credentials returned by `POST /v1/prepare_model_upload`.
        /// </param>
        /// <param name="kind">
        /// Default Value: model_archive
        /// </param>
        /// <param name="disableArchiveDownload">
        /// If true, the uploaded archive is not downloadable after creation. Locked at model creation; cannot be changed by subsequent deployments.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelArchiveSourceV1(
            string name,
            global::Baseten.DeploymentArchivePayloadV1 deployment,
            string s3Key,
            string? kind,
            bool? disableArchiveDownload)
        {
            this.Kind = kind;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Deployment = deployment ?? throw new global::System.ArgumentNullException(nameof(deployment));
            this.S3Key = s3Key ?? throw new global::System.ArgumentNullException(nameof(s3Key));
            this.DisableArchiveDownload = disableArchiveDownload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelArchiveSourceV1" /> class.
        /// </summary>
        public ModelArchiveSourceV1()
        {
        }

    }
}