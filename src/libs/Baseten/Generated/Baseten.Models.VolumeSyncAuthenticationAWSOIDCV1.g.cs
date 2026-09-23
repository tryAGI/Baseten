
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Authentication using an AWS IAM role and Baseten workload identity.
    /// </summary>
    public sealed partial class VolumeSyncAuthenticationAWSOIDCV1
    {
        /// <summary>
        /// AWS IAM role ARN to assume through OIDC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        /// AWS region for the OIDC role session.
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
        /// Initializes a new instance of the <see cref="VolumeSyncAuthenticationAWSOIDCV1" /> class.
        /// </summary>
        /// <param name="roleArn">
        /// AWS IAM role ARN to assume through OIDC.
        /// </param>
        /// <param name="region">
        /// AWS region for the OIDC role session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeSyncAuthenticationAWSOIDCV1(
            string roleArn,
            string region)
        {
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSyncAuthenticationAWSOIDCV1" /> class.
        /// </summary>
        public VolumeSyncAuthenticationAWSOIDCV1()
        {
        }

    }
}