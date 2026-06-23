
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The outcome of a sync that ran.<br/>
    /// Operational failures (a transient patch failure, an invalid patch sequence)<br/>
    /// are surfaced as HTTP errors rather than fields here, so a 2xx means the sync<br/>
    /// reached a verdict.
    /// </summary>
    public sealed partial class SyncDeploymentPatchesResponseV1
    {
        /// <summary>
        /// If set, the change cannot be patched and a full push is required; the value explains why. If null, the deployment is now in sync.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("needs_full_deploy_reason")]
        public string? NeedsFullDeployReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncDeploymentPatchesResponseV1" /> class.
        /// </summary>
        /// <param name="needsFullDeployReason">
        /// If set, the change cannot be patched and a full push is required; the value explains why. If null, the deployment is now in sync.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SyncDeploymentPatchesResponseV1(
            string? needsFullDeployReason)
        {
            this.NeedsFullDeployReason = needsFullDeployReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncDeploymentPatchesResponseV1" /> class.
        /// </summary>
        public SyncDeploymentPatchesResponseV1()
        {
        }

    }
}