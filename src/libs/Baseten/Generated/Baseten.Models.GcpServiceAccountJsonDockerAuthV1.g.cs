
#nullable enable

namespace Baseten
{
    /// <summary>
    /// GCP details for the registry.
    /// </summary>
    public sealed partial class GcpServiceAccountJsonDockerAuthV1
    {
        /// <summary>
        /// Name of the service account secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_json_secret_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.SecretReferenceV1 ServiceAccountJsonSecretRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GcpServiceAccountJsonDockerAuthV1" /> class.
        /// </summary>
        /// <param name="serviceAccountJsonSecretRef">
        /// Name of the service account secret
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GcpServiceAccountJsonDockerAuthV1(
            global::Baseten.SecretReferenceV1 serviceAccountJsonSecretRef)
        {
            this.ServiceAccountJsonSecretRef = serviceAccountJsonSecretRef ?? throw new global::System.ArgumentNullException(nameof(serviceAccountJsonSecretRef));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GcpServiceAccountJsonDockerAuthV1" /> class.
        /// </summary>
        public GcpServiceAccountJsonDockerAuthV1()
        {
        }
    }
}