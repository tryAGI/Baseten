
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Authentication via a Baseten secret for any Docker registry (Docker Hub, GHCR, NGC, etc.).<br/>
    /// The referenced secret must contain credentials in the format 'username:password'.<br/>
    /// For Docker Hub, set registry to 'https://index.docker.io/v1/'. For GHCR, use 'ghcr.io'.
    /// </summary>
    public sealed partial class RegistrySecretDockerAuthV1
    {
        /// <summary>
        /// Reference to a Baseten secret containing credentials in the format 'username:password'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.SecretReferenceV1 SecretRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrySecretDockerAuthV1" /> class.
        /// </summary>
        /// <param name="secretRef">
        /// Reference to a Baseten secret containing credentials in the format 'username:password'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegistrySecretDockerAuthV1(
            global::Baseten.SecretReferenceV1 secretRef)
        {
            this.SecretRef = secretRef ?? throw new global::System.ArgumentNullException(nameof(secretRef));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrySecretDockerAuthV1" /> class.
        /// </summary>
        public RegistrySecretDockerAuthV1()
        {
        }
    }
}