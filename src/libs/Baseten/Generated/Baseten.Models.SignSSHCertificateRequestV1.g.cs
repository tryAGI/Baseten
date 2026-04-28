
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to sign an SSH certificate for accessing a workload pod.
    /// </summary>
    public sealed partial class SignSSHCertificateRequestV1
    {
        /// <summary>
        /// The user's SSH public key (e.g., 'ssh-ed25519 AAAA... user@host').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicKey { get; set; }

        /// <summary>
        /// The replica to connect to. Required for training jobs (e.g. '0'). Optional for inference (server picks a running replica if omitted).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_id")]
        public string? ReplicaId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignSSHCertificateRequestV1" /> class.
        /// </summary>
        /// <param name="publicKey">
        /// The user's SSH public key (e.g., 'ssh-ed25519 AAAA... user@host').
        /// </param>
        /// <param name="replicaId">
        /// The replica to connect to. Required for training jobs (e.g. '0'). Optional for inference (server picks a running replica if omitted).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignSSHCertificateRequestV1(
            string publicKey,
            string? replicaId)
        {
            this.PublicKey = publicKey ?? throw new global::System.ArgumentNullException(nameof(publicKey));
            this.ReplicaId = replicaId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignSSHCertificateRequestV1" /> class.
        /// </summary>
        public SignSSHCertificateRequestV1()
        {
        }
    }
}