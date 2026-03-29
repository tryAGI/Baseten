
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Required when auth_method is REGISTRY_SECRET. Supports any Docker registry (Docker Hub, GHCR, NGC, etc.) via username:password credentials stored as a Baseten secret.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class DockerAuthV1RegistrySecretDockerAuth
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}