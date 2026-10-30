
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpsertGridConnectionConfigVertexV1
    {
        /// <summary>
        /// Provider kind for Google Vertex.
        /// </summary>
        /// <default>"VERTEX"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string Provider { get; set; } = "VERTEX";

        /// <summary>
        /// Name of an existing secret, owned by the same team, that holds the provider API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretName { get; set; }

        /// <summary>
        /// Google Cloud project ID or number of a project with Vertex AI enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Google Cloud region that serves the Vertex AI models, for example `us-central1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Location { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertGridConnectionConfigVertexV1" /> class.
        /// </summary>
        /// <param name="secretName">
        /// Name of an existing secret, owned by the same team, that holds the provider API key.
        /// </param>
        /// <param name="projectId">
        /// Google Cloud project ID or number of a project with Vertex AI enabled.
        /// </param>
        /// <param name="location">
        /// Google Cloud region that serves the Vertex AI models, for example `us-central1`.
        /// </param>
        /// <param name="provider">
        /// Provider kind for Google Vertex.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertGridConnectionConfigVertexV1(
            string secretName,
            string projectId,
            string location,
            string provider = "VERTEX")
        {
            this.Provider = provider;
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertGridConnectionConfigVertexV1" /> class.
        /// </summary>
        public UpsertGridConnectionConfigVertexV1()
        {
        }

    }
}