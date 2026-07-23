
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A list of regions.
    /// </summary>
    public sealed partial class RegionsV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.RegionV1> Regions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsV1" /> class.
        /// </summary>
        /// <param name="regions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionsV1(
            global::System.Collections.Generic.IList<global::Baseten.RegionV1> regions)
        {
            this.Regions = regions ?? throw new global::System.ArgumentNullException(nameof(regions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsV1" /> class.
        /// </summary>
        public RegionsV1()
        {
        }

    }
}