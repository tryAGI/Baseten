#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Lists the cold starts of a model environment<br/>
        /// Lists replica cold starts of every deployment that was active on the environment in the given time range, newest first by default. Pass the `cursor` from a response to fetch the next page.
        /// </summary>
        /// <param name="startEpochMillis"></param>
        /// <param name="endEpochMillis"></param>
        /// <param name="minDurationMs">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="outcomes"></param>
        /// <param name="phase">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="search">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="sortBy">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="direction">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/cold_starts \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ColdStartAttemptsV1> GetModelsByModelIdEnvironmentsByEnvNameColdStartsAsync(
            int startEpochMillis,
            int endEpochMillis,
            string modelId,
            string envName,
            int? minDurationMs = default,
            string? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::Baseten.ColdStartOutcomeV1>? outcomes = default,
            global::Baseten.ColdStartPhaseV1? phase = default,
            string? search = default,
            global::Baseten.ColdStartSortFieldV1? sortBy = default,
            global::Baseten.SortOrderV1? direction = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lists the cold starts of a model environment<br/>
        /// Lists replica cold starts of every deployment that was active on the environment in the given time range, newest first by default. Pass the `cursor` from a response to fetch the next page.
        /// </summary>
        /// <param name="startEpochMillis"></param>
        /// <param name="endEpochMillis"></param>
        /// <param name="minDurationMs">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="outcomes"></param>
        /// <param name="phase">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="search">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="sortBy">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="direction">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/cold_starts \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ColdStartAttemptsV1>> GetModelsByModelIdEnvironmentsByEnvNameColdStartsAsResponseAsync(
            int startEpochMillis,
            int endEpochMillis,
            string modelId,
            string envName,
            int? minDurationMs = default,
            string? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::Baseten.ColdStartOutcomeV1>? outcomes = default,
            global::Baseten.ColdStartPhaseV1? phase = default,
            string? search = default,
            global::Baseten.ColdStartSortFieldV1? sortBy = default,
            global::Baseten.SortOrderV1? direction = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}