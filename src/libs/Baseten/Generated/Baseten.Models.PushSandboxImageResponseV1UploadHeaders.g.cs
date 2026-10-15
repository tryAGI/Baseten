
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Headers the source archive upload must send, in addition to Content-Type, with exactly these names and values. Present only with upload_url, when memory or volume was set. upload_url is signed for these headers, so storage rejects an upload that omits or changes them. Treat names and values as opaque.
    /// </summary>
    public sealed partial class PushSandboxImageResponseV1UploadHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}