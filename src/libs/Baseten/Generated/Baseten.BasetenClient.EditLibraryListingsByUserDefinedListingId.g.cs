
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {


        private static readonly global::Baseten.EndPointSecurityRequirement s_EditLibraryListingsByUserDefinedListingIdSecurityRequirement0 =
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
        private static readonly global::Baseten.EndPointSecurityRequirement[] s_EditLibraryListingsByUserDefinedListingIdSecurityRequirements =
            new global::Baseten.EndPointSecurityRequirement[]
            {                s_EditLibraryListingsByUserDefinedListingIdSecurityRequirement0,
            };
        partial void PrepareEditLibraryListingsByUserDefinedListingIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string userDefinedListingId,
            global::Baseten.UpdateLibraryListingRequestV1 request);
        partial void PrepareEditLibraryListingsByUserDefinedListingIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string userDefinedListingId,
            global::Baseten.UpdateLibraryListingRequestV1 request);
        partial void ProcessEditLibraryListingsByUserDefinedListingIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEditLibraryListingsByUserDefinedListingIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Updates a library listing<br/>
        /// Updates the display name of a library listing.
        /// </summary>
        /// <param name="userDefinedListingId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/library_listings/{user_defined_listing_id} \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "display_name": null,<br/>
        ///   "is_public": null<br/>
        /// }'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.LibraryListingV1> EditLibraryListingsByUserDefinedListingIdAsync(
            string userDefinedListingId,

            global::Baseten.UpdateLibraryListingRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEditLibraryListingsByUserDefinedListingIdArguments(
                httpClient: HttpClient,
                userDefinedListingId: ref userDefinedListingId,
                request: request);


            var __authorizations = global::Baseten.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_EditLibraryListingsByUserDefinedListingIdSecurityRequirements,
                operationName: "EditLibraryListingsByUserDefinedListingIdAsync");

            var __pathBuilder = new global::Baseten.PathBuilder(
                path: $"/v1/library_listings/{userDefinedListingId}",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareEditLibraryListingsByUserDefinedListingIdRequest(
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
            ProcessEditLibraryListingsByUserDefinedListingIdResponse(
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
                ProcessEditLibraryListingsByUserDefinedListingIdResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Baseten.LibraryListingV1.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Baseten.LibraryListingV1.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Updates a library listing<br/>
        /// Updates the display name of a library listing.
        /// </summary>
        /// <param name="userDefinedListingId"></param>
        /// <param name="displayName">
        /// New display name for the library listing<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="isPublic">
        /// Whether the listing is publicly accessible<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Baseten.LibraryListingV1> EditLibraryListingsByUserDefinedListingIdAsync(
            string userDefinedListingId,
            string? displayName = default,
            bool? isPublic = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Baseten.UpdateLibraryListingRequestV1
            {
                DisplayName = displayName,
                IsPublic = isPublic,
            };

            return await EditLibraryListingsByUserDefinedListingIdAsync(
                userDefinedListingId: userDefinedListingId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}