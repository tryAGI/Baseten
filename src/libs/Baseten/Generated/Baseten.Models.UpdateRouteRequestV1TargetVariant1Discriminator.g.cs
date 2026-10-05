
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRouteRequestV1TargetVariant1Discriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.UpdateRouteRequestV1TargetVariant1DiscriminatorTypeJsonConverter))]
        public global::Baseten.UpdateRouteRequestV1TargetVariant1DiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteRequestV1TargetVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRouteRequestV1TargetVariant1Discriminator(
            global::Baseten.UpdateRouteRequestV1TargetVariant1DiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteRequestV1TargetVariant1Discriminator" /> class.
        /// </summary>
        public UpdateRouteRequestV1TargetVariant1Discriminator()
        {
        }

    }
}