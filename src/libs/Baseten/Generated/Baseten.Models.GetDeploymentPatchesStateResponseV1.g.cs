
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The patch state of the development deployment.<br/>
    /// The watch client computes its next patch off `pending_patch_point` when present,<br/>
    /// else `running_patch_point`.
    /// </summary>
    public sealed partial class GetDeploymentPatchesStateResponseV1
    {
        /// <summary>
        /// The patch point the deployment is recorded as running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running_patch_point")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentPatchPointWithHashV1 RunningPatchPoint { get; set; }

        /// <summary>
        /// The latest staged-but-unsynced patch point, or null when the deployment is recorded as caught up.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_patch_point")]
        public global::Baseten.DeploymentPatchPointWithHashV1? PendingPatchPoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentPatchesStateResponseV1" /> class.
        /// </summary>
        /// <param name="runningPatchPoint">
        /// The patch point the deployment is recorded as running.
        /// </param>
        /// <param name="pendingPatchPoint">
        /// The latest staged-but-unsynced patch point, or null when the deployment is recorded as caught up.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentPatchesStateResponseV1(
            global::Baseten.DeploymentPatchPointWithHashV1 runningPatchPoint,
            global::Baseten.DeploymentPatchPointWithHashV1? pendingPatchPoint)
        {
            this.RunningPatchPoint = runningPatchPoint ?? throw new global::System.ArgumentNullException(nameof(runningPatchPoint));
            this.PendingPatchPoint = pendingPatchPoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentPatchesStateResponseV1" /> class.
        /// </summary>
        public GetDeploymentPatchesStateResponseV1()
        {
        }

    }
}