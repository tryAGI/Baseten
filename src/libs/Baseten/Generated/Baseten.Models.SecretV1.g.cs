
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A Baseten secret. Note that we do not support retrieving secret values.
    /// </summary>
    public sealed partial class SecretV1
    {
        /// <summary>
        /// Time the secret was created in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Name of the secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Name of the team the secret belongs to
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
        /// Initializes a new instance of the <see cref="SecretV1" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Time the secret was created in ISO 8601 format
        /// </param>
        /// <param name="name">
        /// Name of the secret
        /// </param>
        /// <param name="teamName">
        /// Name of the team the secret belongs to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretV1(
            global::System.DateTime createdAt,
            string name,
            string teamName)
        {
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretV1" /> class.
        /// </summary>
        public SecretV1()
        {
        }
    }
}