
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The response to a request to retry a deployment.
    /// </summary>
    public sealed partial class RetryDeploymentResponseV1
    {
        /// <summary>
        /// Whether the retry was successfully initiated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retried")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Retried { get; set; }

        /// <summary>
        /// Explanation of the result. Provided when retried is false to explain why retry was not possible.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// The deployment that was retried
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentV1 Deployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryDeploymentResponseV1" /> class.
        /// </summary>
        /// <param name="retried">
        /// Whether the retry was successfully initiated
        /// </param>
        /// <param name="deployment">
        /// The deployment that was retried
        /// </param>
        /// <param name="reason">
        /// Explanation of the result. Provided when retried is false to explain why retry was not possible.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetryDeploymentResponseV1(
            bool retried,
            global::Baseten.DeploymentV1 deployment,
            string? reason)
        {
            this.Retried = retried;
            this.Reason = reason;
            this.Deployment = deployment ?? throw new global::System.ArgumentNullException(nameof(deployment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryDeploymentResponseV1" /> class.
        /// </summary>
        public RetryDeploymentResponseV1()
        {
        }
    }
}