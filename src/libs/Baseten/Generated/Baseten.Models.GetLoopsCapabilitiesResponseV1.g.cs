
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``GET /v1/loops/capabilities``.
    /// </summary>
    public sealed partial class GetLoopsCapabilitiesResponseV1
    {
        /// <summary>
        /// List of models available on the server.
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
        /// List of models available on the server.
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