
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Authentication using GCP Workload Identity Federation.
    /// </summary>
    public sealed partial class VolumeSyncAuthenticationGCPOIDCV1
    {
        /// <summary>
        /// GCP service account to impersonate through OIDC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccount { get; set; }

        /// <summary>
        /// Full resource name of the GCP workload identity provider.
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
        /// Initializes a new instance of the <see cref="VolumeSyncAuthenticationGCPOIDCV1" /> class.
        /// </summary>
        /// <param name="serviceAccount">
        /// GCP service account to impersonate through OIDC.
        /// </param>
        /// <param name="workloadIdentityProvider">
        /// Full resource name of the GCP workload identity provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeSyncAuthenticationGCPOIDCV1(
            string serviceAccount,
            string workloadIdentityProvider)
        {
            this.ServiceAccount = serviceAccount ?? throw new global::System.ArgumentNullException(nameof(serviceAccount));
            this.WorkloadIdentityProvider = workloadIdentityProvider ?? throw new global::System.ArgumentNullException(nameof(workloadIdentityProvider));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSyncAuthenticationGCPOIDCV1" /> class.
        /// </summary>
        public VolumeSyncAuthenticationGCPOIDCV1()
        {
        }

    }
}