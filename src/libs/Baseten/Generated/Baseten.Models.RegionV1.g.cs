
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A region that deployments can be placed in.
    /// </summary>
    public sealed partial class RegionV1
    {
        /// <summary>
        /// Stable identifier for the region, used when selecting a deployment region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Human-readable name of the region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionV1" /> class.
        /// </summary>
        /// <param name="slug">
        /// Stable identifier for the region, used when selecting a deployment region.
        /// </param>
        /// <param name="displayName">
        /// Human-readable name of the region.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionV1(
            string slug,
            string displayName)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionV1" /> class.
        /// </summary>
        public RegionV1()
        {
        }

    }
}