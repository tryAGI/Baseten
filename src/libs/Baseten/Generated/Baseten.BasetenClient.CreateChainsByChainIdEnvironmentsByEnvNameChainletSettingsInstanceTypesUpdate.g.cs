
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {
        partial void PrepareCreateChainsByChainIdEnvironmentsByEnvNameChainletSettingsInstanceTypesUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string chainId,
            ref string envName,
            global::Baseten.UpdateChainletEnvironmentInstanceTypeRequestV1 request);
        partial void PrepareCreateChainsByChainIdEnvironmentsByEnvNameChainletSettingsInstanceTypesUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string chainId,
            string envName,
            global::Baseten.UpdateChainletEnvironmentInstanceTypeRequestV1 request);
        partial void ProcessCreateChainsByChainIdEnvironmentsByEnvNameChainletSettingsInstanceTypesUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateChainsByChainIdEnvironmentsByEnvNameChainletSettingsInstanceTypesUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a chainlet environment's instance type settings.<br/>
        /// Updates a chainlet environment's instance type settings. The chainlet environment setting must exist. When updated, a new chain deployment is created and deployed. It is promoted to the chain environment according to promotion settings on the environment.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="envName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/environments/{env_name}/chainlet_settings/instance_types/update \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "updates": [<br/>
        ///     {<br/>
        ///       "chainlet_name": "HelloWorld",<br/>
        ///       "instance_type_id": "1x4"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "chainlet_name": "RandInt",<br/>
        ///       "instance_type_id": "A10G:2x24x96"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.UpdateChainletEnvironmentInstanceTypeResponseV1> CreateChainsByChainIdEnvironmentsByEnvNameChainletSettingsInstanceTypesUpdateAsync(
            string chainId,
            string envName,

            global::Baseten.UpdateChainletEnvironmentInstanceTypeRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateChainsByChainIdEnvironmentsByEnvNameChainletSettingsInstanceTypesUpdateArguments(
                httpClient: HttpClient,
                chainId: ref chainId,
                envName: ref envName,
                request: request);

            var __pathBuilder = new global::Baseten.PathBuilder(
                path: $"/v1/chains/{chainId}/environments/{envName}/chainlet_settings/instance_types/update",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
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
            PrepareCreateChainsByChainIdEnvironmentsByEnvNameChainletSettingsInstanceTypesUpdateRequest(
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
            ProcessCreateChainsByChainIdEnvironmentsByEnvNameChainletSettingsInstanceTypesUpdateResponse(
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
                ProcessCreateChainsByChainIdEnvironmentsByEnvNameChainletSettingsInstanceTypesUpdateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Baseten.UpdateChainletEnvironmentInstanceTypeResponseV1.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Baseten.UpdateChainletEnvironmentInstanceTypeResponseV1.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Update a chainlet environment's instance type settings.<br/>
        /// Updates a chainlet environment's instance type settings. The chainlet environment setting must exist. When updated, a new chain deployment is created and deployed. It is promoted to the chain environment according to promotion settings on the environment.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="envName"></param>
        /// <param name="updates">
        /// Mapping of chainlet name to the desired chainlet instance type. If the chainlet name doesn't exist, an error is returned.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Baseten.UpdateChainletEnvironmentInstanceTypeResponseV1> CreateChainsByChainIdEnvironmentsByEnvNameChainletSettingsInstanceTypesUpdateAsync(
            string chainId,
            string envName,
            global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentInstanceTypeUpdateV1> updates,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Baseten.UpdateChainletEnvironmentInstanceTypeRequestV1
            {
                Updates = updates,
            };

            return await CreateChainsByChainIdEnvironmentsByEnvNameChainletSettingsInstanceTypesUpdateAsync(
                chainId: chainId,
                envName: envName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}