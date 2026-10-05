
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteRefV1
    {
        /// <summary>
        /// Stable route identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the route to send in the inference request's model field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteRefV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable route identifier.
        /// </param>
        /// <param name="slug">
        /// Name of the route to send in the inference request's model field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteRefV1(
            string id,
            string slug)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteRefV1" /> class.
        /// </summary>
        public RouteRefV1()
        {
        }

    }
}