
#nullable enable

namespace Baseten
{
    /// <summary>
    /// AWS credentials
    /// </summary>
    public sealed partial class AWSCredentialsV1
    {
        /// <summary>
        /// The AWS access key ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_access_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsAccessKeyId { get; set; }

        /// <summary>
        /// The AWS secret access key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_secret_access_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsSecretAccessKey { get; set; }

        /// <summary>
        /// The AWS session token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_session_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsSessionToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSCredentialsV1" /> class.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// The AWS access key ID
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// The AWS secret access key
        /// </param>
        /// <param name="awsSessionToken">
        /// The AWS session token
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AWSCredentialsV1(
            string awsAccessKeyId,
            string awsSecretAccessKey,
            string awsSessionToken)
        {
            this.AwsAccessKeyId = awsAccessKeyId ?? throw new global::System.ArgumentNullException(nameof(awsAccessKeyId));
            this.AwsSecretAccessKey = awsSecretAccessKey ?? throw new global::System.ArgumentNullException(nameof(awsSecretAccessKey));
            this.AwsSessionToken = awsSessionToken ?? throw new global::System.ArgumentNullException(nameof(awsSessionToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSCredentialsV1" /> class.
        /// </summary>
        public AWSCredentialsV1()
        {
        }
    }
}