
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``GET /v1/loops/capabilities``.<br/>
    /// A model Baseten does not support has no entry at all, so an empty list for<br/>
    /// a single-model request means exactly that.
    /// </summary>
    public sealed partial class GetLoopsCapabilitiesResponseV1
    {
        /// <summary>
        /// Models Baseten supports for this use case, each carrying an 'enabled' flag saying whether this workspace can run it now, and 'enablement_details' when it cannot. Filter on 'enabled' to get the models you can use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.SupportedModelV1> SupportedModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsCapabilitiesResponseV1" /> class.
        /// </summary>
        /// <param name="supportedModels">
        /// Models Baseten supports for this use case, each carrying an 'enabled' flag saying whether this workspace can run it now, and 'enablement_details' when it cannot. Filter on 'enabled' to get the models you can use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLoopsCapabilitiesResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.SupportedModelV1> supportedModels)
        {
            this.SupportedModels = supportedModels ?? throw new global::System.ArgumentNullException(nameof(supportedModels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsCapabilitiesResponseV1" /> class.
        /// </summary>
        public GetLoopsCapabilitiesResponseV1()
        {
        }

    }
}