
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {


        private static readonly global::Baseten.EndPointSecurityRequirement s_CreateModelsByModelIdEnvironmentsByEnvNamePromoteSecurityRequirement0 =
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
        private static readonly global::Baseten.EndPointSecurityRequirement[] s_CreateModelsByModelIdEnvironmentsByEnvNamePromoteSecurityRequirements =
            new global::Baseten.EndPointSecurityRequirement[]
            {                s_CreateModelsByModelIdEnvironmentsByEnvNamePromoteSecurityRequirement0,
            };
        partial void PrepareCreateModelsByModelIdEnvironmentsByEnvNamePromoteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelId,
            ref string envName,
            global::Baseten.PromoteToEnvironmentRequestV1 request);
        partial void PrepareCreateModelsByModelIdEnvironmentsByEnvNamePromoteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelId,
            string envName,
            global::Baseten.PromoteToEnvironmentRequestV1 request);
        partial void ProcessCreateModelsByModelIdEnvironmentsByEnvNamePromoteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateModelsByModelIdEnvironmentsByEnvNamePromoteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Promotes a deployment to an environment<br/>
        /// Promotes an existing deployment to an environment and returns the promoted deployment.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/promote \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "scale_down_previous_deployment": true,<br/>
        ///   "deployment_id": null,<br/>
        ///   "preserve_env_instance_type": true<br/>
        /// }'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.DeploymentV1> CreateModelsByModelIdEnvironmentsByEnvNamePromoteAsync(
            string modelId,
            string envName,

            global::Baseten.PromoteToEnvironmentRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateModelsByModelIdEnvironmentsByEnvNamePromoteArguments(
                httpClient: HttpClient,
                modelId: ref modelId,
                envName: ref envName,
                request: request);


            var __authorizations = global::Baseten.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateModelsByModelIdEnvironmentsByEnvNamePromoteSecurityRequirements,
                operationName: "CreateModelsByModelIdEnvironmentsByEnvNamePromoteAsync");

            var __pathBuilder = new global::Baseten.PathBuilder(
                path: $"/v1/models/{modelId}/environments/{envName}/promote",
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
            PrepareCreateModelsByModelIdEnvironmentsByEnvNamePromoteRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                modelId: modelId,
                envName: envName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateModelsByModelIdEnvironmentsByEnvNamePromoteResponse(
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
                ProcessCreateModelsByModelIdEnvironmentsByEnvNamePromoteResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Baseten.DeploymentV1.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Baseten.DeploymentV1.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Promotes a deployment to an environment<br/>
        /// Promotes an existing deployment to an environment and returns the promoted deployment.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="scaleDownPreviousDeployment">
        /// Whether to scale down the previous deployment after promoting<br/>
        /// Default Value: true
        /// </param>
        /// <param name="deploymentId">
        /// The id of the deployment to promote
        /// </param>
        /// <param name="preserveEnvInstanceType">
        /// Whether to use the promoting deployment's instance type or preserve target environment's instance type<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Baseten.DeploymentV1> CreateModelsByModelIdEnvironmentsByEnvNamePromoteAsync(
            string modelId,
            string envName,
            string deploymentId,
            bool? scaleDownPreviousDeployment = default,
            bool? preserveEnvInstanceType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Baseten.PromoteToEnvironmentRequestV1
            {
                ScaleDownPreviousDeployment = scaleDownPreviousDeployment,
                DeploymentId = deploymentId,
                PreserveEnvInstanceType = preserveEnvInstanceType,
            };

            return await CreateModelsByModelIdEnvironmentsByEnvNamePromoteAsync(
                modelId: modelId,
                envName: envName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}