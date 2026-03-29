
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {
        partial void PrepareEditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdInteractiveSessionsBySessionIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string trainingProjectId,
            ref string trainingJobId,
            ref string sessionId,
            global::Baseten.PatchInteractiveSessionRequestV1 request);
        partial void PrepareEditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdInteractiveSessionsBySessionIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string trainingProjectId,
            string trainingJobId,
            string sessionId,
            global::Baseten.PatchInteractiveSessionRequestV1 request);
        partial void ProcessEditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdInteractiveSessionsBySessionIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdInteractiveSessionsBySessionIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Patch an interactive session.<br/>
        /// Update specific fields on a training job's interactive session. Only provided (non-null) fields are updated.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs/{training_job_id}/interactive_sessions/{session_id} \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "timeout_minutes": null,<br/>
        ///   "trigger": null<br/>
        /// }'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.PatchInteractiveSessionResponseV1> EditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdInteractiveSessionsBySessionIdAsync(
            string trainingProjectId,
            string trainingJobId,
            string sessionId,

            global::Baseten.PatchInteractiveSessionRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdInteractiveSessionsBySessionIdArguments(
                httpClient: HttpClient,
                trainingProjectId: ref trainingProjectId,
                trainingJobId: ref trainingJobId,
                sessionId: ref sessionId,
                request: request);

            var __pathBuilder = new global::Baseten.PathBuilder(
                path: $"/v1/training_projects/{trainingProjectId}/jobs/{trainingJobId}/interactive_sessions/{sessionId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareEditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdInteractiveSessionsBySessionIdRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                trainingProjectId: trainingProjectId,
                trainingJobId: trainingJobId,
                sessionId: sessionId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessEditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdInteractiveSessionsBySessionIdResponse(
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
                ProcessEditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdInteractiveSessionsBySessionIdResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Baseten.PatchInteractiveSessionResponseV1.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Baseten.PatchInteractiveSessionResponseV1.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Patch an interactive session.<br/>
        /// Update specific fields on a training job's interactive session. Only provided (non-null) fields are updated.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="sessionId"></param>
        /// <param name="timeoutMinutes">
        /// For on_startup sessions, minutes to add to the expiration. For on_demand/on_failure sessions, minutes to add to the timeout. Use -1 for infinite timeout (bumps by 10 years).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="trigger">
        /// Update when the interactive session is created. Cannot be changed if the session trigger is 'on_startup'.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Baseten.PatchInteractiveSessionResponseV1> EditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdInteractiveSessionsBySessionIdAsync(
            string trainingProjectId,
            string trainingJobId,
            string sessionId,
            int? timeoutMinutes = default,
            global::Baseten.V1InteractiveSessionTrigger? trigger = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Baseten.PatchInteractiveSessionRequestV1
            {
                TimeoutMinutes = timeoutMinutes,
                Trigger = trigger,
            };

            return await EditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdInteractiveSessionsBySessionIdAsync(
                trainingProjectId: trainingProjectId,
                trainingJobId: trainingJobId,
                sessionId: sessionId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}