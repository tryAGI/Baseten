#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Cancels a promotion to an environment<br/>
        /// Cancels an ongoing promotion to an environment and returns the cancellation status.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/cancel_promotion \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.CancelPromotionResponseV1> CreateModelsByModelIdEnvironmentsByEnvNameCancelPromotionAsync(
            string modelId,
            string envName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}