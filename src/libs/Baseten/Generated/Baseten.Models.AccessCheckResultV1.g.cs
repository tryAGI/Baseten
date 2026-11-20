
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Whether you hold a permission where a check asked about it.
    /// </summary>
    public sealed partial class AccessCheckResultV1
    {
        /// <summary>
        /// Name of the permission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Permission { get; set; }

        /// <summary>
        /// ID of the team it was checked in, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// The resource it was checked on, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public global::Baseten.AccessResourceV1? Resource { get; set; }

        /// <summary>
        /// Whether you hold the permission there
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Allowed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessCheckResultV1" /> class.
        /// </summary>
        /// <param name="permission">
        /// Name of the permission
        /// </param>
        /// <param name="allowed">
        /// Whether you hold the permission there
        /// </param>
        /// <param name="teamId">
        /// ID of the team it was checked in, if any
        /// </param>
        /// <param name="resource">
        /// The resource it was checked on, if any
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessCheckResultV1(
            string permission,
            bool allowed,
            string? teamId,
            global::Baseten.AccessResourceV1? resource)
        {
            this.Permission = permission ?? throw new global::System.ArgumentNullException(nameof(permission));
            this.TeamId = teamId;
            this.Resource = resource;
            this.Allowed = allowed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessCheckResultV1" /> class.
        /// </summary>
        public AccessCheckResultV1()
        {
        }

    }
}