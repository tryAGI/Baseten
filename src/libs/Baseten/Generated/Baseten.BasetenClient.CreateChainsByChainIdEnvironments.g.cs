
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {


        private static readonly global::Baseten.EndPointSecurityRequirement s_CreateChainsByChainIdEnvironmentsSecurityRequirement0 =
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
        private static readonly global::Baseten.EndPointSecurityRequirement[] s_CreateChainsByChainIdEnvironmentsSecurityRequirements =
            new global::Baseten.EndPointSecurityRequirement[]
            {                s_CreateChainsByChainIdEnvironmentsSecurityRequirement0,
            };
        partial void PrepareCreateChainsByChainIdEnvironmentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string chainId,
            global::Baseten.CreateChainEnvironmentRequestV1 request);
        partial void PrepareCreateChainsByChainIdEnvironmentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string chainId,
            global::Baseten.CreateChainEnvironmentRequestV1 request);
        partial void ProcessCreateChainsByChainIdEnvironmentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateChainsByChainIdEnvironmentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a chain environment<br/>
        /// Create a chain environment. Returns the resulting environment.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/environments \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "staging",<br/>
        ///   "promotion_settings": {<br/>
        ///     "promotion_cleanup_strategy": null,<br/>
        ///     "ramp_up_duration_seconds": 600,<br/>
        ///     "ramp_up_while_promoting": true,<br/>
        ///     "redeploy_on_promotion": true,<br/>
        ///     "rolling_deploy": null,<br/>
        ///     "rolling_deploy_config": null<br/>
        ///   },<br/>
        ///   "chainlet_settings": [<br/>
        ///     {<br/>
        ///       "autoscaling_settings": {<br/>
        ///         "autoscaling_window": 800,<br/>
        ///         "concurrency_target": 4,<br/>
        ///         "max_replica": 3,<br/>
        ///         "min_replica": 2,<br/>
        ///         "scale_down_delay": 63,<br/>
        ///         "target_in_flight_tokens": null,<br/>
        ///         "target_utilization_percentage": null<br/>
        ///       },<br/>
        ///       "chainlet_name": "HelloWorld",<br/>
        ///       "instance_type_id": "2x8"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "autoscaling_settings": {<br/>
        ///         "autoscaling_window": null,<br/>
        ///         "concurrency_target": null,<br/>
        ///         "max_replica": 3,<br/>
        ///         "min_replica": 3,<br/>
        ///         "scale_down_delay": null,<br/>
        ///         "target_in_flight_tokens": null,<br/>
        ///         "target_utilization_percentage": null<br/>
        ///       },<br/>
        ///       "chainlet_name": "RandInt",<br/>
        ///       "instance_type_id": "A10Gx8x32"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.ChainEnvironmentV1> CreateChainsByChainIdEnvironmentsAsync(
            string chainId,

            global::Baseten.CreateChainEnvironmentRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateChainsByChainIdEnvironmentsArguments(
                httpClient: HttpClient,
                chainId: ref chainId,
                request: request);


            var __authorizations = global::Baseten.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateChainsByChainIdEnvironmentsSecurityRequirements,
                operationName: "CreateChainsByChainIdEnvironmentsAsync");

            var __pathBuilder = new global::Baseten.PathBuilder(
                path: $"/v1/chains/{chainId}/environments",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareCreateChainsByChainIdEnvironmentsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                chainId: chainId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateChainsByChainIdEnvironmentsResponse(
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
                ProcessCreateChainsByChainIdEnvironmentsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Baseten.ChainEnvironmentV1.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Baseten.ChainEnvironmentV1.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Create a chain environment<br/>
        /// Create a chain environment. Returns the resulting environment.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="name">
        /// Name of the environment
        /// </param>
        /// <param name="promotionSettings">
        /// Promotion settings for the environment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chainletSettings">
        /// Mapping of chainlet name to the desired chainlet environment settings<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Baseten.ChainEnvironmentV1> CreateChainsByChainIdEnvironmentsAsync(
            string chainId,
            string name,
            global::Baseten.UpdatePromotionSettingsV1? promotionSettings = default,
            global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentSettingsRequestV1>? chainletSettings = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Baseten.CreateChainEnvironmentRequestV1
            {
                Name = name,
                PromotionSettings = promotionSettings,
                ChainletSettings = chainletSettings,
            };

            return await CreateChainsByChainIdEnvironmentsAsync(
                chainId: chainId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}