#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Force rolls forward a rolling promotion<br/>
        /// Immediately completes the rolling promotion, shifting all traffic to the new version. This works even if the promotion is in the process of rolling back.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/force_roll_forward_promotion \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.SignalPromotionResponseV1> CreateModelsByModelIdEnvironmentsByEnvNameForceRollForwardPromotionAsync(
            string modelId,
            string envName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}