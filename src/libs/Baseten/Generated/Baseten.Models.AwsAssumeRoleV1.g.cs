
#nullable enable

namespace Baseten
{
    /// <summary>
    /// AWS AssumeRole trust-policy inputs for the organization.
    /// </summary>
    public sealed partial class AwsAssumeRoleV1
    {
        /// <summary>
        /// Baseten role ARN to allow in an IAM role's trust policy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseten_role_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BasetenRoleArn { get; set; }

        /// <summary>
        /// sts:ExternalId Baseten presents when assuming the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsAssumeRoleV1" /> class.
        /// </summary>
        /// <param name="basetenRoleArn">
        /// Baseten role ARN to allow in an IAM role's trust policy
        /// </param>
        /// <param name="externalId">
        /// sts:ExternalId Baseten presents when assuming the role
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwsAssumeRoleV1(
            string basetenRoleArn,
            string externalId)
        {
            this.BasetenRoleArn = basetenRoleArn ?? throw new global::System.ArgumentNullException(nameof(basetenRoleArn));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsAssumeRoleV1" /> class.
        /// </summary>
        public AwsAssumeRoleV1()
        {
        }

    }
}