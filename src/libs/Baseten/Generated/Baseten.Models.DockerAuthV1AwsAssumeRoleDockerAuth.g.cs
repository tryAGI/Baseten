
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Required when auth_method is AWS_ASSUME_ROLE. Baseten assumes the given IAM role with its own AWS principal and your organization's external ID, with no OIDC provider registration in your account.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class DockerAuthV1AwsAssumeRoleDockerAuth
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}