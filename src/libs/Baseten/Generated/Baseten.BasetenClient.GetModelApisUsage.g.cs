
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {


        private static readonly global::Baseten.EndPointSecurityRequirement s_GetModelApisUsageSecurityRequirement0 =
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
        private static readonly global::Baseten.EndPointSecurityRequirement[] s_GetModelApisUsageSecurityRequirements =
            new global::Baseten.EndPointSecurityRequirement[]
            {                s_GetModelApisUsageSecurityRequirement0,
            };
        partial void PrepareGetModelApisUsageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTime startTime,
            global::System.DateTime? endTime,
            ref global::Baseten.BucketWidth? bucketWidth,
            global::System.Collections.Generic.IList<global::Baseten.UsageDimension>? groupBy,
            global::System.Collections.Generic.IList<string>? apiKeys,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<string>? serviceTiers,
            int? limit,
            ref string? cursor);
        partial void PrepareGetModelApisUsageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTime startTime,
            global::System.DateTime? endTime,
            global::Baseten.BucketWidth? bucketWidth,
            global::System.Collections.Generic.IList<global::Baseten.UsageDimension>? groupBy,
            global::System.Collections.Generic.IList<string>? apiKeys,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<string>? serviceTiers,
            int? limit,
            string? cursor);
        partial void ProcessGetModelApisUsageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetModelApisUsageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets Model APIs token usage in time buckets<br/>
        /// Returns your organization's Model APIs token usage as a series of contiguous time buckets, broken down by the dimensions you pass in group_by. Buckets with no usage are included, so the series has no gaps. Usage is retained for 92 days, so buckets older than that are returned with no results.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="bucketWidth">
        /// Default Value: 1d
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="apiKeys"></param>
        /// <param name="models"></param>
        /// <param name="serviceTiers"></param>
        /// <param name="limit">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/model_apis/usage \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.ModelApisUsageResponseV1> GetModelApisUsageAsync(
            global::System.DateTime startTime,
            global::System.DateTime? endTime = default,
            global::Baseten.BucketWidth? bucketWidth = default,
            global::System.Collections.Generic.IList<global::Baseten.UsageDimension>? groupBy = default,
            global::System.Collections.Generic.IList<string>? apiKeys = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<string>? serviceTiers = default,
            int? limit = default,
            string? cursor = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetModelApisUsageAsResponseAsync(
                startTime: startTime,
                endTime: endTime,
                bucketWidth: bucketWidth,
                groupBy: groupBy,
                apiKeys: apiKeys,
                models: models,
                serviceTiers: serviceTiers,
                limit: limit,
                cursor: cursor,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Gets Model APIs token usage in time buckets<br/>
        /// Returns your organization's Model APIs token usage as a series of contiguous time buckets, broken down by the dimensions you pass in group_by. Buckets with no usage are included, so the series has no gaps. Usage is retained for 92 days, so buckets older than that are returned with no results.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="bucketWidth">
        /// Default Value: 1d
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="apiKeys"></param>
        /// <param name="models"></param>
        /// <param name="serviceTiers"></param>
        /// <param name="limit">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/model_apis/usage \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ModelApisUsageResponseV1>> GetModelApisUsageAsResponseAsync(
            global::System.DateTime startTime,
            global::System.DateTime? endTime = default,
            global::Baseten.BucketWidth? bucketWidth = default,
            global::System.Collections.Generic.IList<global::Baseten.UsageDimension>? groupBy = default,
            global::System.Collections.Generic.IList<string>? apiKeys = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<string>? serviceTiers = default,
            int? limit = default,
            string? cursor = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetModelApisUsageArguments(
                httpClient: HttpClient,
                startTime: ref startTime,
                endTime: endTime,
                bucketWidth: ref bucketWidth,
                groupBy: groupBy,
                apiKeys: apiKeys,
                models: models,
                serviceTiers: serviceTiers,
                limit: limit,
                cursor: ref cursor);


            var __authorizations = global::Baseten.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetModelApisUsageSecurityRequirements,
                operationName: "GetModelApisUsageAsync");

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
                                path: "/v1/model_apis/usage",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddRequiredParameter("start_time", startTime.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("end_time", endTime?.ToString())
                                .AddOptionalParameter("bucket_width", bucketWidth?.ToValueString())
                                .AddOptionalParameter("group_by", groupBy, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("api_keys", apiKeys, delimiter: ",", explode: true)
                                .AddOptionalParameter("models", models, delimiter: ",", explode: true)
                                .AddOptionalParameter("service_tiers", serviceTiers, delimiter: ",", explode: true)
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("cursor", cursor)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Baseten.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::Baseten.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetModelApisUsageRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    startTime: startTime!,
                    endTime: endTime,
                    bucketWidth: bucketWidth,
                    groupBy: groupBy,
                    apiKeys: apiKeys,
                    models: models,
                    serviceTiers: serviceTiers,
                    limit: limit,
                    cursor: cursor);

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
                                operationId: "getModelApisUsage",
                                methodName: "GetModelApisUsageAsync",
                                pathTemplate: "\"/v1/model_apis/usage\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                        var __retryDelay = global::Baseten.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Baseten.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Baseten.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getModelApisUsage",
                                methodName: "GetModelApisUsageAsync",
                                pathTemplate: "\"/v1/model_apis/usage\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Baseten.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Baseten.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Baseten.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Baseten.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Baseten.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getModelApisUsage",
                                methodName: "GetModelApisUsageAsync",
                                pathTemplate: "\"/v1/model_apis/usage\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Baseten.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessGetModelApisUsageResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Baseten.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Baseten.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getModelApisUsage",
                                methodName: "GetModelApisUsageAsync",
                                pathTemplate: "\"/v1/model_apis/usage\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Baseten.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Baseten.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getModelApisUsage",
                                methodName: "GetModelApisUsageAsync",
                                pathTemplate: "\"/v1/model_apis/usage\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                                ProcessGetModelApisUsageResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Baseten.ModelApisUsageResponseV1.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Baseten.AutoSDKHttpResponse<global::Baseten.ModelApisUsageResponseV1>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Baseten.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Baseten.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = await global::Baseten.ModelApisUsageResponseV1.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Baseten.AutoSDKHttpResponse<global::Baseten.ModelApisUsageResponseV1>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Baseten.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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

                                    throw global::Baseten.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}