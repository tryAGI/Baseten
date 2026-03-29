
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {
        partial void PrepareEditLibraryListingsByUserDefinedListingIdVersionsByVersionTagArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string userDefinedListingId,
            ref string versionTag,
            global::Baseten.UpdateLibraryListingVersionRequestV1 request);
        partial void PrepareEditLibraryListingsByUserDefinedListingIdVersionsByVersionTagRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string userDefinedListingId,
            string versionTag,
            global::Baseten.UpdateLibraryListingVersionRequestV1 request);
        partial void ProcessEditLibraryListingsByUserDefinedListingIdVersionsByVersionTagResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEditLibraryListingsByUserDefinedListingIdVersionsByVersionTagResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Updates a library listing version<br/>
        /// Updates a library listing version. Setting is_live to true will demote the current live version.
        /// </summary>
        /// <param name="userDefinedListingId"></param>
        /// <param name="versionTag"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/library_listings/{user_defined_listing_id}/versions/{version_tag} \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "is_live": null,<br/>
        ///   "allow_truss_download": null<br/>
        /// }'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.LibraryListingVersionV1> EditLibraryListingsByUserDefinedListingIdVersionsByVersionTagAsync(
            string userDefinedListingId,
            string versionTag,

            global::Baseten.UpdateLibraryListingVersionRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEditLibraryListingsByUserDefinedListingIdVersionsByVersionTagArguments(
                httpClient: HttpClient,
                userDefinedListingId: ref userDefinedListingId,
                versionTag: ref versionTag,
                request: request);

            var __pathBuilder = new global::Baseten.PathBuilder(
                path: $"/v1/library_listings/{userDefinedListingId}/versions/{versionTag}",
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
            PrepareEditLibraryListingsByUserDefinedListingIdVersionsByVersionTagRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                userDefinedListingId: userDefinedListingId,
                versionTag: versionTag,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessEditLibraryListingsByUserDefinedListingIdVersionsByVersionTagResponse(
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
                ProcessEditLibraryListingsByUserDefinedListingIdVersionsByVersionTagResponseContent(
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
        /// Updates a library listing version<br/>
        /// Updates a library listing version. Setting is_live to true will demote the current live version.
        /// </summary>
        /// <param name="userDefinedListingId"></param>
        /// <param name="versionTag"></param>
        /// <param name="isLive">
        /// Whether this version should be the live version. Setting to true demotes the current live version.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="allowTrussDownload">
        /// Whether users deploying this model can download the Truss<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Baseten.LibraryListingVersionV1> EditLibraryListingsByUserDefinedListingIdVersionsByVersionTagAsync(
            string userDefinedListingId,
            string versionTag,
            bool? isLive = default,
            bool? allowTrussDownload = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Baseten.UpdateLibraryListingVersionRequestV1
            {
                IsLive = isLive,
                AllowTrussDownload = allowTrussDownload,
            };

            return await EditLibraryListingsByUserDefinedListingIdVersionsByVersionTagAsync(
                userDefinedListingId: userDefinedListingId,
                versionTag: versionTag,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}