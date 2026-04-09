
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {


        private static readonly global::Baseten.EndPointSecurityRequirement s_CreateChainsByChainIdEnvironmentsByEnvNamePromoteSecurityRequirement0 =
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
        private static readonly global::Baseten.EndPointSecurityRequirement[] s_CreateChainsByChainIdEnvironmentsByEnvNamePromoteSecurityRequirements =
            new global::Baseten.EndPointSecurityRequirement[]
            {                s_CreateChainsByChainIdEnvironmentsByEnvNamePromoteSecurityRequirement0,
            };
        partial void PrepareCreateChainsByChainIdEnvironmentsByEnvNamePromoteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string chainId,
            ref string envName,
            global::Baseten.PromoteToChainEnvironmentRequestV1 request);
        partial void PrepareCreateChainsByChainIdEnvironmentsByEnvNamePromoteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string chainId,
            string envName,
            global::Baseten.PromoteToChainEnvironmentRequestV1 request);
        partial void ProcessCreateChainsByChainIdEnvironmentsByEnvNamePromoteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateChainsByChainIdEnvironmentsByEnvNamePromoteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Promotes a chain deployment to an environment<br/>
        /// Promotes an existing chain deployment to an environment and returns the promoted chain deployment.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="envName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/environments/{env_name}/promote \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "scale_down_previous_deployment": true,<br/>
        ///   "deployment_id": null<br/>
        /// }'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.ChainDeploymentV1> CreateChainsByChainIdEnvironmentsByEnvNamePromoteAsync(
            string chainId,
            string envName,

            global::Baseten.PromoteToChainEnvironmentRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateChainsByChainIdEnvironmentsByEnvNamePromoteArguments(
                httpClient: HttpClient,
                chainId: ref chainId,
                envName: ref envName,
                request: request);


            var __authorizations = global::Baseten.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateChainsByChainIdEnvironmentsByEnvNamePromoteSecurityRequirements,
                operationName: "CreateChainsByChainIdEnvironmentsByEnvNamePromoteAsync");

            var __pathBuilder = new global::Baseten.PathBuilder(
                path: $"/v1/chains/{chainId}/environments/{envName}/promote",
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
            PrepareCreateChainsByChainIdEnvironmentsByEnvNamePromoteRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                chainId: chainId,
                envName: envName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateChainsByChainIdEnvironmentsByEnvNamePromoteResponse(
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
                ProcessCreateChainsByChainIdEnvironmentsByEnvNamePromoteResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Baseten.ChainDeploymentV1.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Baseten.ChainDeploymentV1.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Promotes a chain deployment to an environment<br/>
        /// Promotes an existing chain deployment to an environment and returns the promoted chain deployment.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="envName"></param>
        /// <param name="scaleDownPreviousDeployment">
        /// Whether to scale down the previous deployment after promoting<br/>
        /// Default Value: true
        /// </param>
        /// <param name="deploymentId">
        /// The id of the chain deployment to promote
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Baseten.ChainDeploymentV1> CreateChainsByChainIdEnvironmentsByEnvNamePromoteAsync(
            string chainId,
            string envName,
            string deploymentId,
            bool? scaleDownPreviousDeployment = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Baseten.PromoteToChainEnvironmentRequestV1
            {
                ScaleDownPreviousDeployment = scaleDownPreviousDeployment,
                DeploymentId = deploymentId,
            };

            return await CreateChainsByChainIdEnvironmentsByEnvNamePromoteAsync(
                chainId: chainId,
                envName: envName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}