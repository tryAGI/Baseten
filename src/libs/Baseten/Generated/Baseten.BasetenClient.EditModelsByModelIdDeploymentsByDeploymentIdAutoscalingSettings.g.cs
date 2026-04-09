
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {


        private static readonly global::Baseten.EndPointSecurityRequirement s_EditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsSecurityRequirement0 =
            new global::Baseten.EndPointSecurityRequirement
            {
                Authorizations = new global::Baseten.EndPointAuthorizationRequirement[]
                {                    new global::Baseten.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Baseten.EndPointSecurityRequirement[] s_EditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsSecurityRequirements =
            new global::Baseten.EndPointSecurityRequirement[]
            {                s_EditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsSecurityRequirement0,
            };
        partial void PrepareEditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelId,
            ref string deploymentId,
            global::Baseten.UpdateAutoscalingSettingsV1 request);
        partial void PrepareEditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelId,
            string deploymentId,
            global::Baseten.UpdateAutoscalingSettingsV1 request);
        partial void ProcessEditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Updates a deployment's autoscaling settings<br/>
        /// Updates a deployment's autoscaling settings and returns the update status.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/autoscaling_settings \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "min_replica": 0,<br/>
        ///   "max_replica": 7,<br/>
        ///   "autoscaling_window": 600,<br/>
        ///   "scale_down_delay": 120,<br/>
        ///   "concurrency_target": 2,<br/>
        ///   "target_utilization_percentage": 70,<br/>
        ///   "target_in_flight_tokens": 40000<br/>
        /// }'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.UpdateAutoscalingSettingsResponseV1> EditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsAsync(
            string modelId,
            string deploymentId,

            global::Baseten.UpdateAutoscalingSettingsV1 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsArguments(
                httpClient: HttpClient,
                modelId: ref modelId,
                deploymentId: ref deploymentId,
                request: request);


            var __authorizations = global::Baseten.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_EditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsSecurityRequirements,
                operationName: "EditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsAsync");

            var __pathBuilder = new global::Baseten.PathBuilder(
                path: $"/v1/models/{modelId}/deployments/{deploymentId}/autoscaling_settings",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareEditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                modelId: modelId,
                deploymentId: deploymentId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessEditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessEditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Baseten.UpdateAutoscalingSettingsResponseV1.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Baseten.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Baseten.UpdateAutoscalingSettingsResponseV1.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Baseten.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Updates a deployment's autoscaling settings<br/>
        /// Updates a deployment's autoscaling settings and returns the update status.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="minReplica">
        /// Minimum number of replicas<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="maxReplica">
        /// Maximum number of replicas<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="autoscalingWindow">
        /// Timeframe of traffic considered for autoscaling decisions<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="scaleDownDelay">
        /// Waiting period before scaling down any active replica<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="concurrencyTarget">
        /// Number of requests per replica before scaling up<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="targetUtilizationPercentage">
        /// Target utilization percentage for scaling up/down.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="targetInFlightTokens">
        /// Target number of in-flight tokens for autoscaling decisions. Early access only.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Baseten.UpdateAutoscalingSettingsResponseV1> EditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsAsync(
            string modelId,
            string deploymentId,
            int? minReplica = default,
            int? maxReplica = default,
            int? autoscalingWindow = default,
            int? scaleDownDelay = default,
            int? concurrencyTarget = default,
            int? targetUtilizationPercentage = default,
            int? targetInFlightTokens = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Baseten.UpdateAutoscalingSettingsV1
            {
                MinReplica = minReplica,
                MaxReplica = maxReplica,
                AutoscalingWindow = autoscalingWindow,
                ScaleDownDelay = scaleDownDelay,
                ConcurrencyTarget = concurrencyTarget,
                TargetUtilizationPercentage = targetUtilizationPercentage,
                TargetInFlightTokens = targetInFlightTokens,
            };

            return await EditModelsByModelIdDeploymentsByDeploymentIdAutoscalingSettingsAsync(
                modelId: modelId,
                deploymentId: deploymentId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}