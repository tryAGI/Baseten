
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Team the new model will belong to. Only valid when `name` is set; defaults to the organization's default team when omitted. Must not be set when `model_id` is set (the existing model already has a team).<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class PrepareModelUploadRequestV1TeamId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}