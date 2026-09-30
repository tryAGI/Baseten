
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteHarnessConfigsResponseV1
    {
        /// <summary>
        /// Default models for each harness, keyed by harness. A harness is omitted when none of its roles has a route.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harness_configs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Baseten.RouteHarnessConfigV1> HarnessConfigs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteHarnessConfigsResponseV1" /> class.
        /// </summary>
        /// <param name="harnessConfigs">
        /// Default models for each harness, keyed by harness. A harness is omitted when none of its roles has a route.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteHarnessConfigsResponseV1(
            global::System.Collections.Generic.Dictionary<string, global::Baseten.RouteHarnessConfigV1> harnessConfigs)
        {
            this.HarnessConfigs = harnessConfigs ?? throw new global::System.ArgumentNullException(nameof(harnessConfigs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteHarnessConfigsResponseV1" /> class.
        /// </summary>
        public RouteHarnessConfigsResponseV1()
        {
        }

    }
}