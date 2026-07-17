
#nullable enable

namespace Baseten
{
    /// <summary>
    /// S3 key of the uploaded archive, from the credentials returned by `POST /v1/prepare_model_upload`. Omit for model formats that are not built from an archive (for example, BIS-LLM), where prepare issues no upload target.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class DeploymentArchiveSourceV1S3Key
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}