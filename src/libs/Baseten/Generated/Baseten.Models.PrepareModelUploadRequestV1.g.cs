
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Body for `POST /v1/prepare_model_upload`.<br/>
    /// Validates the same payload the commit endpoint will validate, and on<br/>
    /// `dry_run=false` issues STS upload credentials. Exactly one of `name` or<br/>
    /// `model_id` is required: `name` validates the new-model path (`POST<br/>
    /// /v1/models`); `model_id` validates the add-deployment path (`POST<br/>
    /// /v1/models/{model_id}/deployments`).
    /// </summary>
    public sealed partial class PrepareModelUploadRequestV1
    {
        /// <summary>
        /// Deployment-level payload, identical to the payload sent at commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentArchivePayloadV1 Deployment { get; set; }

        /// <summary>
        /// Set to validate a new-model push. Exactly one of `name` or `model_id` is required.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Team the new model will belong to. Only valid when `name` is set; defaults to the organization's default team when omitted. Must not be set when `model_id` is set (the existing model already has a team).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Set to validate an add-deployment push to an existing model. Exactly one of `name` or `model_id` is required.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// If true, validate the payload only and do not issue upload credentials. The response sets `creds`, `s3_bucket`, and `s3_key` to `null`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dry_run")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepareModelUploadRequestV1" /> class.
        /// </summary>
        /// <param name="deployment">
        /// Deployment-level payload, identical to the payload sent at commit.
        /// </param>
        /// <param name="name">
        /// Set to validate a new-model push. Exactly one of `name` or `model_id` is required.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="teamId">
        /// Team the new model will belong to. Only valid when `name` is set; defaults to the organization's default team when omitted. Must not be set when `model_id` is set (the existing model already has a team).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="modelId">
        /// Set to validate an add-deployment push to an existing model. Exactly one of `name` or `model_id` is required.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="dryRun">
        /// If true, validate the payload only and do not issue upload credentials. The response sets `creds`, `s3_bucket`, and `s3_key` to `null`.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrepareModelUploadRequestV1(
            global::Baseten.DeploymentArchivePayloadV1 deployment,
            string? name,
            string? teamId,
            string? modelId,
            bool? dryRun)
        {
            this.Deployment = deployment ?? throw new global::System.ArgumentNullException(nameof(deployment));
            this.Name = name;
            this.TeamId = teamId;
            this.ModelId = modelId;
            this.DryRun = dryRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepareModelUploadRequestV1" /> class.
        /// </summary>
        public PrepareModelUploadRequestV1()
        {
        }

    }
}