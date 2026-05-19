
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response from `POST /v1/prepare_model_upload`.<br/>
    /// On success with `dry_run=false`, returns STS upload credentials. On success<br/>
    /// with `dry_run=true`, `creds`, `s3_bucket`, and `s3_key` are `null` and only<br/>
    /// validation has run.
    /// </summary>
    public sealed partial class PrepareModelUploadResponseV1
    {
        /// <summary>
        /// STS credentials to upload the model archive.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creds")]
        public global::Baseten.AWSCredentialsV1? Creds { get; set; }

        /// <summary>
        /// S3 bucket the credentials are scoped to.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_bucket")]
        public string? S3Bucket { get; set; }

        /// <summary>
        /// S3 key the credentials are scoped to. Pass this to `POST /v1/models` (in the `model_archive` source) once the upload completes.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_key")]
        public string? S3Key { get; set; }

        /// <summary>
        /// AWS region the S3 bucket resides in.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_region")]
        public string? S3Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepareModelUploadResponseV1" /> class.
        /// </summary>
        /// <param name="creds">
        /// STS credentials to upload the model archive.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="s3Bucket">
        /// S3 bucket the credentials are scoped to.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="s3Key">
        /// S3 key the credentials are scoped to. Pass this to `POST /v1/models` (in the `model_archive` source) once the upload completes.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="s3Region">
        /// AWS region the S3 bucket resides in.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrepareModelUploadResponseV1(
            global::Baseten.AWSCredentialsV1? creds,
            string? s3Bucket,
            string? s3Key,
            string? s3Region)
        {
            this.Creds = creds;
            this.S3Bucket = s3Bucket;
            this.S3Key = s3Key;
            this.S3Region = s3Region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepareModelUploadResponseV1" /> class.
        /// </summary>
        public PrepareModelUploadResponseV1()
        {
        }

    }
}