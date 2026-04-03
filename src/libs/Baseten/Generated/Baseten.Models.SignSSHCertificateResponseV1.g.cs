
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response containing a signed SSH certificate for proxy authentication.
    /// </summary>
    public sealed partial class SignSSHCertificateResponseV1
    {
        /// <summary>
        /// The signed SSH certificate in OpenSSH format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_certificate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SshCertificate { get; set; }

        /// <summary>
        /// Signed JWT (ES256) for SSH proxy authorization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Jwt { get; set; }

        /// <summary>
        /// Address of the SSH proxy to connect to (host:port).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProxyAddress { get; set; }

        /// <summary>
        /// When the certificate expires, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_cert_expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime SshCertExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignSSHCertificateResponseV1" /> class.
        /// </summary>
        /// <param name="sshCertificate">
        /// The signed SSH certificate in OpenSSH format.
        /// </param>
        /// <param name="jwt">
        /// Signed JWT (ES256) for SSH proxy authorization.
        /// </param>
        /// <param name="proxyAddress">
        /// Address of the SSH proxy to connect to (host:port).
        /// </param>
        /// <param name="sshCertExpiresAt">
        /// When the certificate expires, in ISO 8601 format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignSSHCertificateResponseV1(
            string sshCertificate,
            string jwt,
            string proxyAddress,
            global::System.DateTime sshCertExpiresAt)
        {
            this.SshCertificate = sshCertificate ?? throw new global::System.ArgumentNullException(nameof(sshCertificate));
            this.Jwt = jwt ?? throw new global::System.ArgumentNullException(nameof(jwt));
            this.ProxyAddress = proxyAddress ?? throw new global::System.ArgumentNullException(nameof(proxyAddress));
            this.SshCertExpiresAt = sshCertExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignSSHCertificateResponseV1" /> class.
        /// </summary>
        public SignSSHCertificateResponseV1()
        {
        }
    }
}