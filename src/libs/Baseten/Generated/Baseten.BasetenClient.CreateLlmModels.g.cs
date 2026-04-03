
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {
        partial void PrepareCreateLlmModelsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Baseten.CreateLLMModelRequestV1 request);
        partial void PrepareCreateLlmModelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Baseten.CreateLLMModelRequestV1 request);
        partial void ProcessCreateLlmModelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateLlmModelsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates a new BIS LLM deployment
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/llm_models \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "resources": null,<br/>
        ///   "llm_version": null,<br/>
        ///   "llm_config": null,<br/>
        ///   "environment_variables": null,<br/>
        ///   "autoscaling_settings": {<br/>
        ///     "autoscaling_window": 600,<br/>
        ///     "concurrency_target": null,<br/>
        ///     "max_replica": 5,<br/>
        ///     "min_replica": 1,<br/>
        ///     "scale_down_delay": 300,<br/>
        ///     "target_in_flight_tokens": null,<br/>
        ///     "target_utilization_percentage": null<br/>
        ///   },<br/>
        ///   "additional_autoscaling_config": {<br/>
        ///     "metrics": [<br/>
        ///       {<br/>
        ///         "name": "in_flight_tokens",<br/>
        ///         "target": 40000<br/>
        ///       }<br/>
        ///     ]<br/>
        ///   },<br/>
        ///   "metadata": {<br/>
        ///     "environment": "production",<br/>
        ///     "git_sha": "abc123"<br/>
        ///   },<br/>
        ///   "weights": [<br/>
        ///     {<br/>
        ///       "mount_location": "/models/base",<br/>
        ///       "source": "hf://meta-llama/Llama-3-8B"<br/>
        ///     }<br/>
        ///   ],<br/>
        ///   "name": null<br/>
        /// }'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.LLMModelV1> CreateLlmModelsAsync(

            global::Baseten.CreateLLMModelRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateLlmModelsArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Baseten.PathBuilder(
                path: "/v1/llm_models",
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
            PrepareCreateLlmModelsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateLlmModelsResponse(
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
                ProcessCreateLlmModelsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Baseten.LLMModelV1.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Baseten.LLMModelV1.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Creates a new BIS LLM deployment
        /// </summary>
        /// <param name="resources">
        /// Resources allocated to the model
        /// </param>
        /// <param name="llmVersion">
        /// Version of the helm chart to use<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="llmConfig">
        /// Configuration specific to the LLM model
        /// </param>
        /// <param name="environmentVariables">
        /// Environment variables for the model
        /// </param>
        /// <param name="autoscalingSettings">
        /// Autoscaling settings for the model<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="additionalAutoscalingConfig">
        /// Additional autoscaling configuration (e.g. target in-flight tokens)<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadata">
        /// User-defined metadata for the deployment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="weights">
        /// Weight configurations for BDN model weight distribution<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="name">
        /// Name of the model
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Baseten.LLMModelV1> CreateLlmModelsAsync(
            object resources,
            string name,
            string? llmVersion = default,
            object? llmConfig = default,
            object? environmentVariables = default,
            global::Baseten.UpdateAutoscalingSettingsV1? autoscalingSettings = default,
            object? additionalAutoscalingConfig = default,
            object? metadata = default,
            global::System.Collections.Generic.IList<object>? weights = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Baseten.CreateLLMModelRequestV1
            {
                Resources = resources,
                LlmVersion = llmVersion,
                LlmConfig = llmConfig,
                EnvironmentVariables = environmentVariables,
                AutoscalingSettings = autoscalingSettings,
                AdditionalAutoscalingConfig = additionalAutoscalingConfig,
                Metadata = metadata,
                Weights = weights,
                Name = name,
            };

            return await CreateLlmModelsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}