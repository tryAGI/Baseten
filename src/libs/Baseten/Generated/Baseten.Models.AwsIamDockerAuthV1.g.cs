
#nullable enable

namespace Baseten
{
    /// <summary>
    /// AWS details for the registry.
    /// </summary>
    public sealed partial class AwsIamDockerAuthV1
    {
        /// <summary>
        /// Name of the access key secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_key_secret_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.SecretReferenceV1 AccessKeySecretRef { get; set; }

        /// <summary>
        /// Name of the secret key secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_access_key_secret_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.SecretReferenceV1 SecretAccessKeySecretRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsIamDockerAuthV1" /> class.
        /// </summary>
        /// <param name="accessKeySecretRef">
        /// Name of the access key secret
        /// </param>
        /// <param name="secretAccessKeySecretRef">
        /// Name of the secret key secret
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwsIamDockerAuthV1(
            global::Baseten.SecretReferenceV1 accessKeySecretRef,
            global::Baseten.SecretReferenceV1 secretAccessKeySecretRef)
        {
            this.AccessKeySecretRef = accessKeySecretRef ?? throw new global::System.ArgumentNullException(nameof(accessKeySecretRef));
            this.SecretAccessKeySecretRef = secretAccessKeySecretRef ?? throw new global::System.ArgumentNullException(nameof(secretAccessKeySecretRef));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsIamDockerAuthV1" /> class.
        /// </summary>
        public AwsIamDockerAuthV1()
        {
        }
    }
}