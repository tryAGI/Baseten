
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GridBackgroundHarnessDefaultsV1
    {
        /// <summary>
        /// Route for the primary model, which new sessions use. Null when the team has no route to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        public global::Baseten.GridHarnessModelV1? Primary { get; set; }

        /// <summary>
        /// Route for background tasks, such as session titles. Null when the team has no route to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::Baseten.GridHarnessModelV1? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GridBackgroundHarnessDefaultsV1" /> class.
        /// </summary>
        /// <param name="primary">
        /// Route for the primary model, which new sessions use. Null when the team has no route to use.
        /// </param>
        /// <param name="background">
        /// Route for background tasks, such as session titles. Null when the team has no route to use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GridBackgroundHarnessDefaultsV1(
            global::Baseten.GridHarnessModelV1? primary,
            global::Baseten.GridHarnessModelV1? background)
        {
            this.Primary = primary;
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridBackgroundHarnessDefaultsV1" /> class.
        /// </summary>
        public GridBackgroundHarnessDefaultsV1()
        {
        }

    }
}