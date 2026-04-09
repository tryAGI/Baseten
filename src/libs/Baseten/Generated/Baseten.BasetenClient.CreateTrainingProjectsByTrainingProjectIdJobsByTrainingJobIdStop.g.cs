
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {


        private static readonly global::Baseten.EndPointSecurityRequirement s_CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopSecurityRequirement0 =
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
        private static readonly global::Baseten.EndPointSecurityRequirement[] s_CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopSecurityRequirements =
            new global::Baseten.EndPointSecurityRequirement[]
            {                s_CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopSecurityRequirement0,
            };
        partial void PrepareCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string trainingProjectId,
            ref string trainingJobId,
            global::Baseten.StopTrainingJobRequestV1 request);
        partial void PrepareCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string trainingProjectId,
            string trainingJobId,
            global::Baseten.StopTrainingJobRequestV1 request);
        partial void ProcessCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Stop a training job.<br/>
        /// Stops a training job.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs/{training_job_id}/stop \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{}'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.StopTrainingJobResponseV1> CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopAsync(
            string trainingProjectId,
            string trainingJobId,

            global::Baseten.StopTrainingJobRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopArguments(
                httpClient: HttpClient,
                trainingProjectId: ref trainingProjectId,
                trainingJobId: ref trainingJobId,
                request: request);


            var __authorizations = global::Baseten.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopSecurityRequirements,
                operationName: "CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopAsync");

            var __pathBuilder = new global::Baseten.PathBuilder(
                path: $"/v1/training_projects/{trainingProjectId}/jobs/{trainingJobId}/stop",
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
            PrepareCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                trainingProjectId: trainingProjectId,
                trainingJobId: trainingJobId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopResponse(
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
                ProcessCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Baseten.StopTrainingJobResponseV1.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Baseten.StopTrainingJobResponseV1.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Stop a training job.<br/>
        /// Stops a training job.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Baseten.StopTrainingJobResponseV1> CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopAsync(
            string trainingProjectId,
            string trainingJobId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Baseten.StopTrainingJobRequestV1
            {
            };

            return await CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopAsync(
                trainingProjectId: trainingProjectId,
                trainingJobId: trainingJobId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}