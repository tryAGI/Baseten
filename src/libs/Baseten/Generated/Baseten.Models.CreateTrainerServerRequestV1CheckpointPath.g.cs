
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Optional bt:// URI of an existing trainer-target checkpoint to resume training from. Form: bt://trainers:&lt;trainer_id&gt;/weights/&lt;checkpoint_name&gt;.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class CreateTrainerServerRequestV1CheckpointPath
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}