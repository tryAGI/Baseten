
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to promote a deployment to a environment.
    /// </summary>
    public sealed partial class PromoteToEnvironmentRequestV1
    {
        /// <summary>
        /// Whether to scale down the previous deployment after promoting<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_down_previous_deployment")]
        public bool? ScaleDownPreviousDeployment { get; set; }

        /// <summary>
        /// The id of the deployment to promote
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// Whether to use the promoting deployment's instance type or preserve target environment's instance type<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_env_instance_type")]
        public bool? PreserveEnvInstanceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteToEnvironmentRequestV1" /> class.
        /// </summary>
        /// <param name="deploymentId">
        /// The id of the deployment to promote
        /// </param>
        /// <param name="scaleDownPreviousDeployment">
        /// Whether to scale down the previous deployment after promoting<br/>
        /// Default Value: true
        /// </param>
        /// <param name="preserveEnvInstanceType">
        /// Whether to use the promoting deployment's instance type or preserve target environment's instance type<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromoteToEnvironmentRequestV1(
            string deploymentId,
            bool? scaleDownPreviousDeployment,
            bool? preserveEnvInstanceType)
        {
            this.ScaleDownPreviousDeployment = scaleDownPreviousDeployment;
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.PreserveEnvInstanceType = preserveEnvInstanceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteToEnvironmentRequestV1" /> class.
        /// </summary>
        public PromoteToEnvironmentRequestV1()
        {
        }
    }
}