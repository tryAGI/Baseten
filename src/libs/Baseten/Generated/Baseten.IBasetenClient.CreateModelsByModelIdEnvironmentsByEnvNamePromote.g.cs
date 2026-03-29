#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Promotes a deployment to an environment<br/>
        /// Promotes an existing deployment to an environment and returns the promoted deployment.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/promote \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "scale_down_previous_deployment": true,<br/>
        ///   "deployment_id": null,<br/>
        ///   "preserve_env_instance_type": true<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DeploymentV1> CreateModelsByModelIdEnvironmentsByEnvNamePromoteAsync(
            string modelId,
            string envName,

            global::Baseten.PromoteToEnvironmentRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Promotes a deployment to an environment<br/>
        /// Promotes an existing deployment to an environment and returns the promoted deployment.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="scaleDownPreviousDeployment">
        /// Whether to scale down the previous deployment after promoting<br/>
        /// Default Value: true
        /// </param>
        /// <param name="deploymentId">
        /// The id of the deployment to promote
        /// </param>
        /// <param name="preserveEnvInstanceType">
        /// Whether to use the promoting deployment's instance type or preserve target environment's instance type<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.DeploymentV1> CreateModelsByModelIdEnvironmentsByEnvNamePromoteAsync(
            string modelId,
            string envName,
            string deploymentId,
            bool? scaleDownPreviousDeployment = default,
            bool? preserveEnvInstanceType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}