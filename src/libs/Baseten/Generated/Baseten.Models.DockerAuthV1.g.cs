
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Docker authentication credentials.
    /// </summary>
    public sealed partial class DockerAuthV1
    {
        /// <summary>
        /// Registry to authenticate with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Registry { get; set; }

        /// <summary>
        /// Method to authenticate with the registry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.DockerAuthTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DockerAuthType AuthMethod { get; set; }

        /// <summary>
        /// GCP service account details for the registry<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gcp_service_account_json_docker_auth")]
        public global::Baseten.GcpServiceAccountJsonDockerAuthV1? GcpServiceAccountJsonDockerAuth { get; set; }

        /// <summary>
        /// AWS details for the registry<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_iam_docker_auth")]
        public global::Baseten.AwsIamDockerAuthV1? AwsIamDockerAuth { get; set; }

        /// <summary>
        /// AWS OIDC details for the registry<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_oidc_docker_auth")]
        public global::Baseten.AwsOidcDockerAuthV1? AwsOidcDockerAuth { get; set; }

        /// <summary>
        /// GCP OIDC details for the registry<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gcp_oidc_docker_auth")]
        public global::Baseten.GcpOidcDockerAuthV1? GcpOidcDockerAuth { get; set; }

        /// <summary>
        /// Required when auth_method is REGISTRY_SECRET. Supports any Docker registry (Docker Hub, GHCR, NGC, etc.) via username:password credentials stored as a Baseten secret.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry_secret_docker_auth")]
        public global::Baseten.RegistrySecretDockerAuthV1? RegistrySecretDockerAuth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DockerAuthV1" /> class.
        /// </summary>
        /// <param name="registry">
        /// Registry to authenticate with
        /// </param>
        /// <param name="authMethod">
        /// Method to authenticate with the registry
        /// </param>
        /// <param name="gcpServiceAccountJsonDockerAuth">
        /// GCP service account details for the registry<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="awsIamDockerAuth">
        /// AWS details for the registry<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="awsOidcDockerAuth">
        /// AWS OIDC details for the registry<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="gcpOidcDockerAuth">
        /// GCP OIDC details for the registry<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="registrySecretDockerAuth">
        /// Required when auth_method is REGISTRY_SECRET. Supports any Docker registry (Docker Hub, GHCR, NGC, etc.) via username:password credentials stored as a Baseten secret.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DockerAuthV1(
            string registry,
            global::Baseten.DockerAuthType authMethod,
            global::Baseten.GcpServiceAccountJsonDockerAuthV1? gcpServiceAccountJsonDockerAuth,
            global::Baseten.AwsIamDockerAuthV1? awsIamDockerAuth,
            global::Baseten.AwsOidcDockerAuthV1? awsOidcDockerAuth,
            global::Baseten.GcpOidcDockerAuthV1? gcpOidcDockerAuth,
            global::Baseten.RegistrySecretDockerAuthV1? registrySecretDockerAuth)
        {
            this.Registry = registry ?? throw new global::System.ArgumentNullException(nameof(registry));
            this.AuthMethod = authMethod;
            this.GcpServiceAccountJsonDockerAuth = gcpServiceAccountJsonDockerAuth;
            this.AwsIamDockerAuth = awsIamDockerAuth;
            this.AwsOidcDockerAuth = awsOidcDockerAuth;
            this.GcpOidcDockerAuth = gcpOidcDockerAuth;
            this.RegistrySecretDockerAuth = registrySecretDockerAuth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DockerAuthV1" /> class.
        /// </summary>
        public DockerAuthV1()
        {
        }
    }
}