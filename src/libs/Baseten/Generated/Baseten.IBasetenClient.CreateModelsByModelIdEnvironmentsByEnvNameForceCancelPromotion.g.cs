#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Force cancels a rolling promotion<br/>
        /// Immediately cancels an in-progress rolling promotion and triggers rollback to the previous version.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/force_cancel_promotion \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.SignalPromotionResponseV1> CreateModelsByModelIdEnvironmentsByEnvNameForceCancelPromotionAsync(
            string modelId,
            string envName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}