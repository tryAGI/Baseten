
#nullable enable

namespace Baseten
{
    /// <summary>
    /// S3 key the credentials are scoped to. Pass this to `POST /v1/models` (in the `model_archive` source) once the upload completes. Null when no archive upload is required.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class PrepareModelUploadResponseV1S3Key
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}