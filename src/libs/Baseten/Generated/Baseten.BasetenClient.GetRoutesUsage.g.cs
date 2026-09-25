
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {


        private static readonly global::Baseten.EndPointSecurityRequirement s_GetRoutesUsageSecurityRequirement0 =
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
        private static readonly global::Baseten.EndPointSecurityRequirement[] s_GetRoutesUsageSecurityRequirements =
            new global::Baseten.EndPointSecurityRequirement[]
            {                s_GetRoutesUsageSecurityRequirement0,
            };
        partial void PrepareGetRoutesUsageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? cursor,
            ref int? limit,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            global::System.Collections.Generic.IList<global::Baseten.RouteUsageDimensionV1>? groupBy,
            global::System.Collections.Generic.IList<string>? apiKeyPrefixes,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? routeIds,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<global::Baseten.RouteProviderV1>? providers);
        partial void PrepareGetRoutesUsageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? cursor,
            int? limit,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            global::System.Collections.Generic.IList<global::Baseten.RouteUsageDimensionV1>? groupBy,
            global::System.Collections.Generic.IList<string>? apiKeyPrefixes,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? routeIds,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<global::Baseten.RouteProviderV1>? providers);
        partial void ProcessGetRoutesUsageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetRoutesUsageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets daily route usage and estimated costs<br/>
        /// Buckets are UTC days, and days with no usage are included. Organization admins see all route usage in the organization. Other members, including viewers, see only usage from Routes keys they created, including keys that have since expired, been revoked, or been deleted. Model API costs use your prices at the time of each request. xAI costs are the charges xAI reports. OpenAI and Anthropic costs are estimated from Baseten's reference prices and may differ from your provider's bill. Vertex and OpenAI-compatible usage has no cost estimate. Costs for OpenAI, Anthropic, and xAI estimate what you pay those providers; they are not Baseten charges. A null cost means some usage in that result could not be priced. Usage is retained for 92 days.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 7
        /// </param>
        /// <param name="startDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="apiKeyPrefixes"></param>
        /// <param name="userIds"></param>
        /// <param name="routeIds"></param>
        /// <param name="models"></param>
        /// <param name="providers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/routes/usage \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.RoutesUsageResponseV1> GetRoutesUsageAsync(
            string? cursor = default,
            int? limit = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::System.Collections.Generic.IList<global::Baseten.RouteUsageDimensionV1>? groupBy = default,
            global::System.Collections.Generic.IList<string>? apiKeyPrefixes = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? routeIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Baseten.RouteProviderV1>? providers = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetRoutesUsageAsResponseAsync(
                cursor: cursor,
                limit: limit,
                startDate: startDate,
                endDate: endDate,
                groupBy: groupBy,
                apiKeyPrefixes: apiKeyPrefixes,
                userIds: userIds,
                routeIds: routeIds,
                models: models,
                providers: providers,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Gets daily route usage and estimated costs<br/>
        /// Buckets are UTC days, and days with no usage are included. Organization admins see all route usage in the organization. Other members, including viewers, see only usage from Routes keys they created, including keys that have since expired, been revoked, or been deleted. Model API costs use your prices at the time of each request. xAI costs are the charges xAI reports. OpenAI and Anthropic costs are estimated from Baseten's reference prices and may differ from your provider's bill. Vertex and OpenAI-compatible usage has no cost estimate. Costs for OpenAI, Anthropic, and xAI estimate what you pay those providers; they are not Baseten charges. A null cost means some usage in that result could not be priced. Usage is retained for 92 days.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 7
        /// </param>
        /// <param name="startDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="apiKeyPrefixes"></param>
        /// <param name="userIds"></param>
        /// <param name="routeIds"></param>
        /// <param name="models"></param>
        /// <param name="providers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/routes/usage \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RoutesUsageResponseV1>> GetRoutesUsageAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::System.Collections.Generic.IList<global::Baseten.RouteUsageDimensionV1>? groupBy = default,
            global::System.Collections.Generic.IList<string>? apiKeyPrefixes = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? routeIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Baseten.RouteProviderV1>? providers = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetRoutesUsageArguments(
                httpClient: HttpClient,
                cursor: ref cursor,
                limit: ref limit,
                startDate: startDate,
                endDate: endDate,
                groupBy: groupBy,
                apiKeyPrefixes: apiKeyPrefixes,
                userIds: userIds,
                routeIds: routeIds,
                models: models,
                providers: providers);


            var __authorizations = global::Baseten.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetRoutesUsageSecurityRequirements,
                operationName: "GetRoutesUsageAsync");

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
                                path: "/v1/routes/usage",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("cursor", cursor)
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("start_date", startDate?.ToString())
                                .AddOptionalParameter("end_date", endDate?.ToString())
                                .AddOptionalParameter("group_by", groupBy, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("api_key_prefixes", apiKeyPrefixes, delimiter: ",", explode: true)
                                .AddOptionalParameter("user_ids", userIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("route_ids", routeIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("models", models, delimiter: ",", explode: true)
                                .AddOptionalParameter("providers", providers, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
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
                PrepareGetRoutesUsageRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    cursor: cursor,
                    limit: limit,
                    startDate: startDate,
                    endDate: endDate,
                    groupBy: groupBy,
                    apiKeyPrefixes: apiKeyPrefixes,
                    userIds: userIds,
                    routeIds: routeIds,
                    models: models,
                    providers: providers);

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
                                operationId: "getRoutesUsage",
                                methodName: "GetRoutesUsageAsync",
                                pathTemplate: "\"/v1/routes/usage\"",
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
                                operationId: "getRoutesUsage",
                                methodName: "GetRoutesUsageAsync",
                                pathTemplate: "\"/v1/routes/usage\"",
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
                                operationId: "getRoutesUsage",
                                methodName: "GetRoutesUsageAsync",
                                pathTemplate: "\"/v1/routes/usage\"",
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
                ProcessGetRoutesUsageResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Baseten.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Baseten.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getRoutesUsage",
                                methodName: "GetRoutesUsageAsync",
                                pathTemplate: "\"/v1/routes/usage\"",
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
                                operationId: "getRoutesUsage",
                                methodName: "GetRoutesUsageAsync",
                                pathTemplate: "\"/v1/routes/usage\"",
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
                                ProcessGetRoutesUsageResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Baseten.RoutesUsageResponseV1.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Baseten.AutoSDKHttpResponse<global::Baseten.RoutesUsageResponseV1>(
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

                                    var __value = await global::Baseten.RoutesUsageResponseV1.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Baseten.AutoSDKHttpResponse<global::Baseten.RoutesUsageResponseV1>(
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