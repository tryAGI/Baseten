
#nullable enable

namespace Baseten
{
    /// <summary>
    /// AWS assume-role details for the registry.
    /// </summary>
    public sealed partial class AwsAssumeRoleDockerAuthV1
    {
        /// <summary>
        /// AWS IAM role ARN that Baseten assumes to pull from the registry. The role's trust policy must allow Baseten's AWS principal with your Baseten-provided external ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        /// AWS region of the registry
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
        /// Initializes a new instance of the <see cref="AwsAssumeRoleDockerAuthV1" /> class.
        /// </summary>
        /// <param name="roleArn">
        /// AWS IAM role ARN that Baseten assumes to pull from the registry. The role's trust policy must allow Baseten's AWS principal with your Baseten-provided external ID.
        /// </param>
        /// <param name="region">
        /// AWS region of the registry
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwsAssumeRoleDockerAuthV1(
            string roleArn,
            string region)
        {
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsAssumeRoleDockerAuthV1" /> class.
        /// </summary>
        public AwsAssumeRoleDockerAuthV1()
        {
        }

    }
}