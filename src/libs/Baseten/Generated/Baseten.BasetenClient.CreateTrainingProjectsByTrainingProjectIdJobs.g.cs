
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {


        private static readonly global::Baseten.EndPointSecurityRequirement s_CreateTrainingProjectsByTrainingProjectIdJobsSecurityRequirement0 =
            new global::Baseten.EndPointSecurityRequirement
            {
                Authorizations = new global::Baseten.EndPointAuthorizationRequirement[]
                {                    new global::Baseten.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Baseten.EndPointSecurityRequirement[] s_CreateTrainingProjectsByTrainingProjectIdJobsSecurityRequirements =
            new global::Baseten.EndPointSecurityRequirement[]
            {                s_CreateTrainingProjectsByTrainingProjectIdJobsSecurityRequirement0,
            };
        partial void PrepareCreateTrainingProjectsByTrainingProjectIdJobsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string trainingProjectId,
            global::Baseten.CreateTrainingJobRequestV1 request);
        partial void PrepareCreateTrainingProjectsByTrainingProjectIdJobsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string trainingProjectId,
            global::Baseten.CreateTrainingJobRequestV1 request);
        partial void ProcessCreateTrainingProjectsByTrainingProjectIdJobsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTrainingProjectsByTrainingProjectIdJobsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a training job.<br/>
        /// Creates a training job with the specified configuration.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "training_job": {<br/>
        ///     "image": {<br/>
        ///       "base_image": "hello-world",<br/>
        ///       "docker_auth": null<br/>
        ///     },<br/>
        ///     "compute": {<br/>
        ///       "node_count": 1,<br/>
        ///       "cpu_count": 1,<br/>
        ///       "memory": "2Gi",<br/>
        ///       "accelerator": {<br/>
        ///         "accelerator": "H100",<br/>
        ///         "count": 2<br/>
        ///       }<br/>
        ///     },<br/>
        ///     "runtime": {<br/>
        ///       "start_commands": [<br/>
        ///         "python main.py"<br/>
        ///       ],<br/>
        ///       "environment_variables": {<br/>
        ///         "API_KEY": "your_api_key_here",<br/>
        ///         "PATH": "/usr/bin"<br/>
        ///       },<br/>
        ///       "artifacts": null,<br/>
        ///       "enable_cache": true,<br/>
        ///       "cache_config": {<br/>
        ///         "enable_legacy_hf_mount": true,<br/>
        ///         "enabled": true,<br/>
        ///         "mount_base_path": "/root/.cache",<br/>
        ///         "require_cache_affinity": true<br/>
        ///       },<br/>
        ///       "checkpointing_config": {<br/>
        ///         "enabled": true,<br/>
        ///         "checkpoint_path": "/mnt/ckpts",<br/>
        ///         "volume_size_gib": 10<br/>
        ///       },<br/>
        ///       "load_checkpoint_config": null<br/>
        ///     },<br/>
        ///     "name": "gpt-oss-job",<br/>
        ///     "truss_user_env": null,<br/>
        ///     "interactive_session": null,<br/>
        ///     "weights": [<br/>
        ///       {<br/>
        ///         "allow_patterns": null,<br/>
        ///         "auth": null,<br/>
        ///         "auth_secret_name": null,<br/>
        ///         "ignore_patterns": null,<br/>
        ///         "mount_location": "/app/models/base",<br/>
        ///         "source": "hf://meta-llama/Llama-3-8B@main"<br/>
        ///       }<br/>
        ///     ],<br/>
        ///     "enable_baseten_workdir": false,<br/>
        ///     "priority": 0<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.CreateTrainingJobResponseV1> CreateTrainingProjectsByTrainingProjectIdJobsAsync(
            string trainingProjectId,

            global::Baseten.CreateTrainingJobRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTrainingProjectsByTrainingProjectIdJobsArguments(
                httpClient: HttpClient,
                trainingProjectId: ref trainingProjectId,
                request: request);


            var __authorizations = global::Baseten.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateTrainingProjectsByTrainingProjectIdJobsSecurityRequirements,
                operationName: "CreateTrainingProjectsByTrainingProjectIdJobsAsync");

            using var __timeoutCancellationTokenSource = global::Baseten.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Baseten.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Baseten.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Baseten.PathBuilder(
                                path: $"/v1/training_projects/{trainingProjectId}/jobs",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Baseten.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::Baseten.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateTrainingProjectsByTrainingProjectIdJobsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    trainingProjectId: trainingProjectId!,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Baseten.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Baseten.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createTrainingProjectsByTrainingProjectIdJobs",
                                methodName: "CreateTrainingProjectsByTrainingProjectIdJobsAsync",
                                pathTemplate: "$\"/v1/training_projects/{trainingProjectId}/jobs\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Baseten.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Baseten.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createTrainingProjectsByTrainingProjectIdJobs",
                                methodName: "CreateTrainingProjectsByTrainingProjectIdJobsAsync",
                                pathTemplate: "$\"/v1/training_projects/{trainingProjectId}/jobs\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Baseten.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Baseten.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Baseten.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Baseten.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createTrainingProjectsByTrainingProjectIdJobs",
                                methodName: "CreateTrainingProjectsByTrainingProjectIdJobsAsync",
                                pathTemplate: "$\"/v1/training_projects/{trainingProjectId}/jobs\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Baseten.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateTrainingProjectsByTrainingProjectIdJobsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Baseten.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Baseten.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createTrainingProjectsByTrainingProjectIdJobs",
                                methodName: "CreateTrainingProjectsByTrainingProjectIdJobsAsync",
                                pathTemplate: "$\"/v1/training_projects/{trainingProjectId}/jobs\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Baseten.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Baseten.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createTrainingProjectsByTrainingProjectIdJobs",
                                methodName: "CreateTrainingProjectsByTrainingProjectIdJobsAsync",
                                pathTemplate: "$\"/v1/training_projects/{trainingProjectId}/jobs\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateTrainingProjectsByTrainingProjectIdJobsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Baseten.CreateTrainingJobResponseV1.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Baseten.CreateTrainingJobResponseV1.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Create a training job.<br/>
        /// Creates a training job with the specified configuration.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJob">
        /// The training job to create.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Baseten.CreateTrainingJobResponseV1> CreateTrainingProjectsByTrainingProjectIdJobsAsync(
            string trainingProjectId,
            global::Baseten.CreateTrainingJobV1 trainingJob,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Baseten.CreateTrainingJobRequestV1
            {
                TrainingJob = trainingJob,
            };

            return await CreateTrainingProjectsByTrainingProjectIdJobsAsync(
                trainingProjectId: trainingProjectId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}