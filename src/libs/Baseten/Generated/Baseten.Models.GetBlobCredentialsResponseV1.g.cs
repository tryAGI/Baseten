
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response to create a new set of credentials for blob upload.
    /// </summary>
    public sealed partial class GetBlobCredentialsResponseV1
    {
        /// <summary>
        /// The credentials to upload the blob to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AWSCredentialsV1 Creds { get; set; }

        /// <summary>
        /// The S3 key to upload the blob to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string S3Key { get; set; }

        /// <summary>
        /// The S3 bucket to upload the blob to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string S3Bucket { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlobCredentialsResponseV1" /> class.
        /// </summary>
        /// <param name="creds">
        /// The credentials to upload the blob to
        /// </param>
        /// <param name="s3Key">
        /// The S3 key to upload the blob to
        /// </param>
        /// <param name="s3Bucket">
        /// The S3 bucket to upload the blob to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBlobCredentialsResponseV1(
            global::Baseten.AWSCredentialsV1 creds,
            string s3Key,
            string s3Bucket)
        {
            this.Creds = creds ?? throw new global::System.ArgumentNullException(nameof(creds));
            this.S3Key = s3Key ?? throw new global::System.ArgumentNullException(nameof(s3Key));
            this.S3Bucket = s3Bucket ?? throw new global::System.ArgumentNullException(nameof(s3Bucket));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlobCredentialsResponseV1" /> class.
        /// </summary>
        public GetBlobCredentialsResponseV1()
        {
        }
    }
}