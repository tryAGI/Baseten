#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Retries a failed development deployment<br/>
        /// Retries a failed development deployment and returns the retry status and updated deployment.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/development/retry \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RetryDeploymentResponseV1> CreateModelsByModelIdDeploymentsDevelopmentRetryAsync(
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}