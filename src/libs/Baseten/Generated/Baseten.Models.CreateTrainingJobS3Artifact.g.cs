
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTrainingJobS3Artifact
    {
        /// <summary>
        /// S3 bucket of the uploaded runtime artifact. Use the `s3_bucket` returned by `GET /v1/blobs/credentials/train`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string S3Bucket { get; set; }

        /// <summary>
        /// S3 key of the uploaded runtime artifact. Use the `s3_key` returned by `GET /v1/blobs/credentials/train`.
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
        /// Initializes a new instance of the <see cref="CreateTrainingJobS3Artifact" /> class.
        /// </summary>
        /// <param name="s3Bucket">
        /// S3 bucket of the uploaded runtime artifact. Use the `s3_bucket` returned by `GET /v1/blobs/credentials/train`.
        /// </param>
        /// <param name="s3Key">
        /// S3 key of the uploaded runtime artifact. Use the `s3_key` returned by `GET /v1/blobs/credentials/train`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrainingJobS3Artifact(
            string s3Bucket,
            string s3Key)
        {
            this.S3Bucket = s3Bucket ?? throw new global::System.ArgumentNullException(nameof(s3Bucket));
            this.S3Key = s3Key ?? throw new global::System.ArgumentNullException(nameof(s3Key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobS3Artifact" /> class.
        /// </summary>
        public CreateTrainingJobS3Artifact()
        {
        }

    }
}