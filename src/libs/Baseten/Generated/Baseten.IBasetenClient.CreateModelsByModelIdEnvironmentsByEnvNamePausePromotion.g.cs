#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Pauses a rolling promotion<br/>
        /// Pauses an in-progress rolling promotion after the current step completes. No further scaling changes are made until resumed.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/pause_promotion \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.SignalPromotionResponseV1> CreateModelsByModelIdEnvironmentsByEnvNamePausePromotionAsync(
            string modelId,
            string envName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}