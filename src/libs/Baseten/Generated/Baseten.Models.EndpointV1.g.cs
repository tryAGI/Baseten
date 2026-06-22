
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A Gateway endpoint: a slug and its priority-ordered targets (index 0 tried first).
    /// </summary>
    public sealed partial class EndpointV1
    {
        /// <summary>
        /// Stable identifier for the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Globally-unique routing slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Creation time, ISO 8601.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update time, ISO 8601.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The endpoint's upstream targets. Exactly one target is supported at this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.EndpointTargetV1> Targets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable identifier for the endpoint.
        /// </param>
        /// <param name="slug">
        /// Globally-unique routing slug.
        /// </param>
        /// <param name="createdAt">
        /// Creation time, ISO 8601.
        /// </param>
        /// <param name="updatedAt">
        /// Last update time, ISO 8601.
        /// </param>
        /// <param name="targets">
        /// The endpoint's upstream targets. Exactly one target is supported at this time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointV1(
            string id,
            string slug,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::Baseten.EndpointTargetV1> targets)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointV1" /> class.
        /// </summary>
        public EndpointV1()
        {
        }

    }
}