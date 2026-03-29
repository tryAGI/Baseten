
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingProjectV1
    {
        /// <summary>
        /// Unique identifier of the training project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the training project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Time the training project was created in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time the training project was updated in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Name of the team associated with the training project.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        public string? TeamName { get; set; }

        /// <summary>
        /// Most recently created training job for the training project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_job")]
        public global::Baseten.TrainingJobV1? LatestJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingProjectV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the training project
        /// </param>
        /// <param name="name">
        /// Name of the training project.
        /// </param>
        /// <param name="createdAt">
        /// Time the training project was created in ISO 8601 format.
        /// </param>
        /// <param name="updatedAt">
        /// Time the training project was updated in ISO 8601 format.
        /// </param>
        /// <param name="teamName">
        /// Name of the team associated with the training project.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="latestJob">
        /// Most recently created training job for the training project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingProjectV1(
            string id,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? teamName,
            global::Baseten.TrainingJobV1? latestJob)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TeamName = teamName;
            this.LatestJob = latestJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingProjectV1" /> class.
        /// </summary>
        public TrainingProjectV1()
        {
        }
    }
}