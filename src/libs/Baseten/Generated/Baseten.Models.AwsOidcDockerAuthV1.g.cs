
#nullable enable

namespace Baseten
{
    /// <summary>
    /// AWS OIDC details for the registry.
    /// </summary>
    public sealed partial class AwsOidcDockerAuthV1
    {
        /// <summary>
        /// AWS IAM role ARN for OIDC authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        /// AWS region for OIDC authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsOidcDockerAuthV1" /> class.
        /// </summary>
        /// <param name="roleArn">
        /// AWS IAM role ARN for OIDC authentication
        /// </param>
        /// <param name="region">
        /// AWS region for OIDC authentication
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwsOidcDockerAuthV1(
            string roleArn,
            string region)
        {
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsOidcDockerAuthV1" /> class.
        /// </summary>
        public AwsOidcDockerAuthV1()
        {
        }
    }
}