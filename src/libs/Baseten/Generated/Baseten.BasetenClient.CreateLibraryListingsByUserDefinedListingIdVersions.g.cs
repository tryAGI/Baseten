
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {
        partial void PrepareCreateLibraryListingsByUserDefinedListingIdVersionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string userDefinedListingId,
            global::Baseten.CreateLibraryListingVersionRequestV1 request);
        partial void PrepareCreateLibraryListingsByUserDefinedListingIdVersionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string userDefinedListingId,
            global::Baseten.CreateLibraryListingVersionRequestV1 request);
        partial void ProcessCreateLibraryListingsByUserDefinedListingIdVersionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateLibraryListingsByUserDefinedListingIdVersionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates a new library listing version<br/>
        /// Creates a new library listing version from an existing model version. The model version must be fully built (have an image_uri). If a listing with the given id already exists for the org, a new version is added. Otherwise, a new listing is created.
        /// </summary>
        /// <param name="userDefinedListingId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/library_listings/{user_defined_listing_id}/versions \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "display_name": null,<br/>
        ///   "is_public": null,<br/>
        ///   "oracle_version_id": null,<br/>
        ///   "allow_truss_download": null,<br/>
        ///   "version_tag": null<br/>
        /// }'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.LibraryListingVersionV1> CreateLibraryListingsByUserDefinedListingIdVersionsAsync(
            string userDefinedListingId,

            global::Baseten.CreateLibraryListingVersionRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateLibraryListingsByUserDefinedListingIdVersionsArguments(
                httpClient: HttpClient,
                userDefinedListingId: ref userDefinedListingId,
                request: request);

            var __pathBuilder = new global::Baseten.PathBuilder(
                path: $"/v1/library_listings/{userDefinedListingId}/versions",
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
            PrepareCreateLibraryListingsByUserDefinedListingIdVersionsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                userDefinedListingId: userDefinedListingId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateLibraryListingsByUserDefinedListingIdVersionsResponse(
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
                ProcessCreateLibraryListingsByUserDefinedListingIdVersionsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Baseten.LibraryListingVersionV1.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Baseten.LibraryListingVersionV1.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Creates a new library listing version<br/>
        /// Creates a new library listing version from an existing model version. The model version must be fully built (have an image_uri). If a listing with the given id already exists for the org, a new version is added. Otherwise, a new listing is created.
        /// </summary>
        /// <param name="userDefinedListingId"></param>
        /// <param name="displayName">
        /// Display name of the library listing. Required when creating a new listing.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="isPublic">
        /// Whether the listing is publicly accessible. Only used when creating a new listing.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="oracleVersionId">
        /// Id of the source model version to publish
        /// </param>
        /// <param name="allowTrussDownload">
        /// Whether users deploying this model can download the Truss<br/>
        /// Default Value: false
        /// </param>
        /// <param name="versionTag">
        /// Human-readable tag for this version
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Baseten.LibraryListingVersionV1> CreateLibraryListingsByUserDefinedListingIdVersionsAsync(
            string userDefinedListingId,
            string oracleVersionId,
            string versionTag,
            string? displayName = default,
            bool? isPublic = default,
            bool? allowTrussDownload = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Baseten.CreateLibraryListingVersionRequestV1
            {
                DisplayName = displayName,
                IsPublic = isPublic,
                OracleVersionId = oracleVersionId,
                AllowTrussDownload = allowTrussDownload,
                VersionTag = versionTag,
            };

            return await CreateLibraryListingsByUserDefinedListingIdVersionsAsync(
                userDefinedListingId: userDefinedListingId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}