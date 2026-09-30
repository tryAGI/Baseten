
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteHarnessConfigV1
    {
        /// <summary>
        /// Route for each model role, keyed by role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Baseten.RouteHarnessModelV1> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteHarnessConfigV1" /> class.
        /// </summary>
        /// <param name="models">
        /// Route for each model role, keyed by role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteHarnessConfigV1(
            global::System.Collections.Generic.Dictionary<string, global::Baseten.RouteHarnessModelV1> models)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteHarnessConfigV1" /> class.
        /// </summary>
        public RouteHarnessConfigV1()
        {
        }

    }
}