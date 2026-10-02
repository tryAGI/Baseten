
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrimaryHarnessDefaultsV1
    {
        /// <summary>
        /// Route for the primary model, which new sessions use. Null when the team has no route to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        public global::Baseten.RouteHarnessModelV1? Primary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryHarnessDefaultsV1" /> class.
        /// </summary>
        /// <param name="primary">
        /// Route for the primary model, which new sessions use. Null when the team has no route to use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrimaryHarnessDefaultsV1(
            global::Baseten.RouteHarnessModelV1? primary)
        {
            this.Primary = primary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryHarnessDefaultsV1" /> class.
        /// </summary>
        public PrimaryHarnessDefaultsV1()
        {
        }

    }
}