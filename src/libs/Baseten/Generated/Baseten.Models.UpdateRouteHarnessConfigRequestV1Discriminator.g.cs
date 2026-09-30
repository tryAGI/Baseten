
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRouteHarnessConfigRequestV1Discriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harness")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.UpdateRouteHarnessConfigRequestV1DiscriminatorHarnessJsonConverter))]
        public global::Baseten.UpdateRouteHarnessConfigRequestV1DiscriminatorHarness? Harness { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteHarnessConfigRequestV1Discriminator" /> class.
        /// </summary>
        /// <param name="harness"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRouteHarnessConfigRequestV1Discriminator(
            global::Baseten.UpdateRouteHarnessConfigRequestV1DiscriminatorHarness? harness)
        {
            this.Harness = harness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteHarnessConfigRequestV1Discriminator" /> class.
        /// </summary>
        public UpdateRouteHarnessConfigRequestV1Discriminator()
        {
        }

    }
}