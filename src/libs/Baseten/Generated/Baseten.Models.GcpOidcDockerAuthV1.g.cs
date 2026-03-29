
#nullable enable

namespace Baseten
{
    /// <summary>
    /// GCP OIDC details for the registry.
    /// </summary>
    public sealed partial class GcpOidcDockerAuthV1
    {
        /// <summary>
        /// GCP service account name for OIDC authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccount { get; set; }

        /// <summary>
        /// GCP workload identity provider for OIDC authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_identity_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkloadIdentityProvider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GcpOidcDockerAuthV1" /> class.
        /// </summary>
        /// <param name="serviceAccount">
        /// GCP service account name for OIDC authentication
        /// </param>
        /// <param name="workloadIdentityProvider">
        /// GCP workload identity provider for OIDC authentication
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GcpOidcDockerAuthV1(
            string serviceAccount,
            string workloadIdentityProvider)
        {
            this.ServiceAccount = serviceAccount ?? throw new global::System.ArgumentNullException(nameof(serviceAccount));
            this.WorkloadIdentityProvider = workloadIdentityProvider ?? throw new global::System.ArgumentNullException(nameof(workloadIdentityProvider));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GcpOidcDockerAuthV1" /> class.
        /// </summary>
        public GcpOidcDockerAuthV1()
        {
        }
    }
}