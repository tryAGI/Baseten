
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {


        private static readonly global::Baseten.EndPointSecurityRequirement s_GetChainsByChainIdAuditLogsSecurityRequirement0 =
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
        private static readonly global::Baseten.EndPointSecurityRequirement[] s_GetChainsByChainIdAuditLogsSecurityRequirements =
            new global::Baseten.EndPointSecurityRequirement[]
            {                s_GetChainsByChainIdAuditLogsSecurityRequirement0,
            };
        partial void PrepareGetChainsByChainIdAuditLogsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? cursor,
            ref int? limit,
            ref global::Baseten.AuditLogSortDirectionV1? direction,
            ref string? search,
            global::System.Collections.Generic.IList<global::Baseten.AuditLogEventTypeGroupV1>? eventTypeGroups,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? deploymentIds,
            global::System.Collections.Generic.IList<string>? chainDeploymentIds,
            global::System.Collections.Generic.IList<string>? environmentNames,
            global::System.Collections.Generic.IList<global::Baseten.AuditLogSourceV1>? sources,
            int? startEpochMillis,
            int? endEpochMillis,
            ref string chainId);
        partial void PrepareGetChainsByChainIdAuditLogsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? cursor,
            int? limit,
            global::Baseten.AuditLogSortDirectionV1? direction,
            string? search,
            global::System.Collections.Generic.IList<global::Baseten.AuditLogEventTypeGroupV1>? eventTypeGroups,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? deploymentIds,
            global::System.Collections.Generic.IList<string>? chainDeploymentIds,
            global::System.Collections.Generic.IList<string>? environmentNames,
            global::System.Collections.Generic.IList<global::Baseten.AuditLogSourceV1>? sources,
            int? startEpochMillis,
            int? endEpochMillis,
            string chainId);
        partial void ProcessGetChainsByChainIdAuditLogsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetChainsByChainIdAuditLogsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets the audit log for a chain<br/>
        /// Returns audit-log entries for a single chain, newest first. Use the filters to narrow by event type, actor, chain deployment, environment, source, or time window, and the cursor to page.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="direction">
        /// Sort order of returned entries, by creation time.<br/>
        /// Default Value: DESC
        /// </param>
        /// <param name="search">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="eventTypeGroups"></param>
        /// <param name="userIds"></param>
        /// <param name="deploymentIds"></param>
        /// <param name="chainDeploymentIds"></param>
        /// <param name="environmentNames"></param>
        /// <param name="sources"></param>
        /// <param name="startEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chainId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/audit_logs \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.ListAuditLogsResponseV1> GetChainsByChainIdAuditLogsAsync(
            string chainId,
            string? cursor = default,
            int? limit = default,
            global::Baseten.AuditLogSortDirectionV1? direction = default,
            string? search = default,
            global::System.Collections.Generic.IList<global::Baseten.AuditLogEventTypeGroupV1>? eventTypeGroups = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? deploymentIds = default,
            global::System.Collections.Generic.IList<string>? chainDeploymentIds = default,
            global::System.Collections.Generic.IList<string>? environmentNames = default,
            global::System.Collections.Generic.IList<global::Baseten.AuditLogSourceV1>? sources = default,
            int? startEpochMillis = default,
            int? endEpochMillis = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetChainsByChainIdAuditLogsAsResponseAsync(
                chainId: chainId,
                cursor: cursor,
                limit: limit,
                direction: direction,
                search: search,
                eventTypeGroups: eventTypeGroups,
                userIds: userIds,
                deploymentIds: deploymentIds,
                chainDeploymentIds: chainDeploymentIds,
                environmentNames: environmentNames,
                sources: sources,
                startEpochMillis: startEpochMillis,
                endEpochMillis: endEpochMillis,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Gets the audit log for a chain<br/>
        /// Returns audit-log entries for a single chain, newest first. Use the filters to narrow by event type, actor, chain deployment, environment, source, or time window, and the cursor to page.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="direction">
        /// Sort order of returned entries, by creation time.<br/>
        /// Default Value: DESC
        /// </param>
        /// <param name="search">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="eventTypeGroups"></param>
        /// <param name="userIds"></param>
        /// <param name="deploymentIds"></param>
        /// <param name="chainDeploymentIds"></param>
        /// <param name="environmentNames"></param>
        /// <param name="sources"></param>
        /// <param name="startEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chainId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/audit_logs \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ListAuditLogsResponseV1>> GetChainsByChainIdAuditLogsAsResponseAsync(
            string chainId,
            string? cursor = default,
            int? limit = default,
            global::Baseten.AuditLogSortDirectionV1? direction = default,
            string? search = default,
            global::System.Collections.Generic.IList<global::Baseten.AuditLogEventTypeGroupV1>? eventTypeGroups = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? deploymentIds = default,
            global::System.Collections.Generic.IList<string>? chainDeploymentIds = default,
            global::System.Collections.Generic.IList<string>? environmentNames = default,
            global::System.Collections.Generic.IList<global::Baseten.AuditLogSourceV1>? sources = default,
            int? startEpochMillis = default,
            int? endEpochMillis = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetChainsByChainIdAuditLogsArguments(
                httpClient: HttpClient,
                cursor: ref cursor,
                limit: ref limit,
                direction: ref direction,
                search: ref search,
                eventTypeGroups: eventTypeGroups,
                userIds: userIds,
                deploymentIds: deploymentIds,
                chainDeploymentIds: chainDeploymentIds,
                environmentNames: environmentNames,
                sources: sources,
                startEpochMillis: startEpochMillis,
                endEpochMillis: endEpochMillis,
                chainId: ref chainId);


            var __authorizations = global::Baseten.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetChainsByChainIdAuditLogsSecurityRequirements,
                operationName: "GetChainsByChainIdAuditLogsAsync");

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
                                path: $"/v1/chains/{chainId}/audit_logs",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("cursor", cursor)
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("direction", direction?.ToValueString())
                                .AddOptionalParameter("search", search)
                                .AddOptionalParameter("event_type_groups", eventTypeGroups, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("user_ids", userIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("deployment_ids", deploymentIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("chain_deployment_ids", chainDeploymentIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("environment_names", environmentNames, delimiter: ",", explode: true)
                                .AddOptionalParameter("sources", sources, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("start_epoch_millis", startEpochMillis?.ToString())
                                .AddOptionalParameter("end_epoch_millis", endEpochMillis?.ToString())
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
                PrepareGetChainsByChainIdAuditLogsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    cursor: cursor,
                    limit: limit,
                    direction: direction,
                    search: search,
                    eventTypeGroups: eventTypeGroups,
                    userIds: userIds,
                    deploymentIds: deploymentIds,
                    chainDeploymentIds: chainDeploymentIds,
                    environmentNames: environmentNames,
                    sources: sources,
                    startEpochMillis: startEpochMillis,
                    endEpochMillis: endEpochMillis,
                    chainId: chainId!);

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
                                operationId: "getChainsByChainIdAuditLogs",
                                methodName: "GetChainsByChainIdAuditLogsAsync",
                                pathTemplate: "$\"/v1/chains/{chainId}/audit_logs\"",
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
                                operationId: "getChainsByChainIdAuditLogs",
                                methodName: "GetChainsByChainIdAuditLogsAsync",
                                pathTemplate: "$\"/v1/chains/{chainId}/audit_logs\"",
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
                                operationId: "getChainsByChainIdAuditLogs",
                                methodName: "GetChainsByChainIdAuditLogsAsync",
                                pathTemplate: "$\"/v1/chains/{chainId}/audit_logs\"",
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
                ProcessGetChainsByChainIdAuditLogsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Baseten.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Baseten.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getChainsByChainIdAuditLogs",
                                methodName: "GetChainsByChainIdAuditLogsAsync",
                                pathTemplate: "$\"/v1/chains/{chainId}/audit_logs\"",
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
                                operationId: "getChainsByChainIdAuditLogs",
                                methodName: "GetChainsByChainIdAuditLogsAsync",
                                pathTemplate: "$\"/v1/chains/{chainId}/audit_logs\"",
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
                                ProcessGetChainsByChainIdAuditLogsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Baseten.ListAuditLogsResponseV1.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Baseten.AutoSDKHttpResponse<global::Baseten.ListAuditLogsResponseV1>(
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

                                    var __value = await global::Baseten.ListAuditLogsResponseV1.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Baseten.AutoSDKHttpResponse<global::Baseten.ListAuditLogsResponseV1>(
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