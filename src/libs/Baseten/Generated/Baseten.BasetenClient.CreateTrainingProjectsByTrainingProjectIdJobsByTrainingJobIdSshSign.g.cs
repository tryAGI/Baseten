
#nullable enable

namespace Baseten
{
    public partial class BasetenClient
    {


        private static readonly global::Baseten.EndPointSecurityRequirement s_CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignSecurityRequirement0 =
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
        private static readonly global::Baseten.EndPointSecurityRequirement[] s_CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignSecurityRequirements =
            new global::Baseten.EndPointSecurityRequirement[]
            {                s_CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignSecurityRequirement0,
            };
        partial void PrepareCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string trainingProjectId,
            ref string trainingJobId,
            global::Baseten.SignSSHCertificateRequestV1 request);
        partial void PrepareCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string trainingProjectId,
            string trainingJobId,
            global::Baseten.SignSSHCertificateRequestV1 request);
        partial void ProcessCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Sign an SSH certificate for a training job.<br/>
        /// Signs a short-lived SSH certificate granting access to a specific training job pod. Returns the signed SSH certificate, a JWT token for SSH proxy authentication, the proxy address to connect through, and the certificate expiry time.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs/{training_job_id}/ssh/sign \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "public_key": null,<br/>
        ///   "replica_id": null<br/>
        /// }'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Baseten.SignSSHCertificateResponseV1> CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignAsync(
            string trainingProjectId,
            string trainingJobId,

            global::Baseten.SignSSHCertificateRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignArguments(
                httpClient: HttpClient,
                trainingProjectId: ref trainingProjectId,
                trainingJobId: ref trainingJobId,
                request: request);


            var __authorizations = global::Baseten.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignSecurityRequirements,
                operationName: "CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignAsync");

            var __pathBuilder = new global::Baseten.PathBuilder(
                path: $"/v1/training_projects/{trainingProjectId}/jobs/{trainingJobId}/ssh/sign",
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
            PrepareCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignRequest(
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
            ProcessCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignResponse(
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
                ProcessCreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Baseten.SignSSHCertificateResponseV1.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Baseten.SignSSHCertificateResponseV1.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Sign an SSH certificate for a training job.<br/>
        /// Signs a short-lived SSH certificate granting access to a specific training job pod. Returns the signed SSH certificate, a JWT token for SSH proxy authentication, the proxy address to connect through, and the certificate expiry time.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="publicKey">
        /// The user's SSH public key (e.g., 'ssh-ed25519 AAAA... user@host').
        /// </param>
        /// <param name="replicaId">
        /// The replica to connect to (0-indexed).<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Baseten.SignSSHCertificateResponseV1> CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignAsync(
            string trainingProjectId,
            string trainingJobId,
            string publicKey,
            int? replicaId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Baseten.SignSSHCertificateRequestV1
            {
                PublicKey = publicKey,
                ReplicaId = replicaId,
            };

            return await CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignAsync(
                trainingProjectId: trainingProjectId,
                trainingJobId: trainingJobId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}