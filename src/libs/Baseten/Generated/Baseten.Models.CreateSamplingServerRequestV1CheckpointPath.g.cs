
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Optional bt:// URI of an existing sampler-target checkpoint to load weights from on startup. Form: bt://loops:&lt;trainer_id&gt;/sampler_weights/&lt;checkpoint_name&gt;.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class CreateSamplingServerRequestV1CheckpointPath
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}