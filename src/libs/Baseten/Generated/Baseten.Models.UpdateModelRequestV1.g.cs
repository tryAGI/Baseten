
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to update a model.
    /// </summary>
    public sealed partial class UpdateModelRequestV1
    {
        /// <summary>
        /// New name for the model, unique within its team. Renaming does not change the model ID, endpoints, or deployments. Pushes that still use the old model_name create another model or target a model that now uses that name, so update config.yaml after renaming.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateModelRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the model, unique within its team. Renaming does not change the model ID, endpoints, or deployments. Pushes that still use the old model_name create another model or target a model that now uses that name, so update config.yaml after renaming.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateModelRequestV1(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateModelRequestV1" /> class.
        /// </summary>
        public UpdateModelRequestV1()
        {
        }

    }
}