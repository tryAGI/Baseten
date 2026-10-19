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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/promote \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "scale_down_previous_deployment": true,<br/>
        ///   "deployment_id": null,<br/>
        ///   "preserve_env_instance_type": true,<br/>
        ///   "environment_settings_update": {<br/>
        ///     "autoscaling_settings": {<br/>
        ///       "max_replica": 4,<br/>
        ///       "min_replica": 2<br/>
        ///     }<br/>
        ///   },<br/>
        ///   "promotion_settings_override": {<br/>
        ///     "rolling_deploy_config": {<br/>
        ///       "max_surge_percent": 50<br/>
        ///     }<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DeploymentV1> CreateModelsByModelIdEnvironmentsByEnvNamePromoteAsync(
            string modelId,
            string envName,

            global::Baseten.PromoteToEnvironmentRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Promotes a deployment to an environment<br/>
        /// Promotes an existing deployment to an environment and returns the promoted deployment.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/promote \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "scale_down_previous_deployment": true,<br/>
        ///   "deployment_id": null,<br/>
        ///   "preserve_env_instance_type": true,<br/>
        ///   "environment_settings_update": {<br/>
        ///     "autoscaling_settings": {<br/>
        ///       "max_replica": 4,<br/>
        ///       "min_replica": 2<br/>
        ///     }<br/>
        ///   },<br/>
        ///   "promotion_settings_override": {<br/>
        ///     "rolling_deploy_config": {<br/>
        ///       "max_surge_percent": 50<br/>
        ///     }<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.DeploymentV1>> CreateModelsByModelIdEnvironmentsByEnvNamePromoteAsResponseAsync(
            string modelId,
            string envName,

            global::Baseten.PromoteToEnvironmentRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="environmentSettingsUpdate">
        /// Changes to the environment's settings. Omitted fields are unchanged. The promoted deployment uses the environment's current settings with these changes applied, and the environment keeps the result when the promotion completes.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="promotionSettingsOverride">
        /// Promotion settings for this promotion only. Omitted fields keep the environment's values, and the environment's promotion settings are unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.DeploymentV1> CreateModelsByModelIdEnvironmentsByEnvNamePromoteAsync(
            string modelId,
            string envName,
            string deploymentId,
            bool? scaleDownPreviousDeployment = default,
            bool? preserveEnvInstanceType = default,
            global::Baseten.PromotionEnvironmentSettingsUpdateV1? environmentSettingsUpdate = default,
            global::Baseten.UpdatePromotionSettingsV1? promotionSettingsOverride = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}