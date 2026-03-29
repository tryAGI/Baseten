
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A model.
    /// </summary>
    public sealed partial class ModelV1
    {
        /// <summary>
        /// Unique identifier of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Time the model was created in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Name of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Number of deployments of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DeploymentsCount { get; set; }

        /// <summary>
        /// Unique identifier of the production deployment of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("production_deployment_id")]
        public string? ProductionDeploymentId { get; set; }

        /// <summary>
        /// Unique identifier of the development deployment of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("development_deployment_id")]
        public string? DevelopmentDeploymentId { get; set; }

        /// <summary>
        /// Name of the instance type for the production deployment of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstanceTypeName { get; set; }

        /// <summary>
        /// Name of the team associated with the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the model
        /// </param>
        /// <param name="createdAt">
        /// Time the model was created in ISO 8601 format
        /// </param>
        /// <param name="name">
        /// Name of the model
        /// </param>
        /// <param name="deploymentsCount">
        /// Number of deployments of the model
        /// </param>
        /// <param name="instanceTypeName">
        /// Name of the instance type for the production deployment of the model
        /// </param>
        /// <param name="teamName">
        /// Name of the team associated with the model.
        /// </param>
        /// <param name="productionDeploymentId">
        /// Unique identifier of the production deployment of the model
        /// </param>
        /// <param name="developmentDeploymentId">
        /// Unique identifier of the development deployment of the model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelV1(
            string id,
            global::System.DateTime createdAt,
            string name,
            int deploymentsCount,
            string instanceTypeName,
            string teamName,
            string? productionDeploymentId,
            string? developmentDeploymentId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DeploymentsCount = deploymentsCount;
            this.ProductionDeploymentId = productionDeploymentId;
            this.DevelopmentDeploymentId = developmentDeploymentId;
            this.InstanceTypeName = instanceTypeName ?? throw new global::System.ArgumentNullException(nameof(instanceTypeName));
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelV1" /> class.
        /// </summary>
        public ModelV1()
        {
        }
    }
}