
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A patch to stage against the development deployment.<br/>
    /// Staging is durable on its own: the patch is persisted independently of the<br/>
    /// later sync, so a failed sync does not lose it.
    /// </summary>
    public sealed partial class CreateDeploymentPatchRequestV1
    {
        /// <summary>
        /// Content hash of the patch point this patch is applied on - the link the staged patch must build on. A stale value (the base moved underneath the client) is rejected with a conflict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev_patch_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrevPatchHash { get; set; }

        /// <summary>
        /// The source state after this patch. The server derives its content hash from `content_hashes`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_patch_point")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentPatchPointV1 NextPatchPoint { get; set; }

        /// <summary>
        /// The ordered ops that make up this patch. At least one op is required; a patch that changes nothing is not a valid request. There is no op for a directory: a directory comes into existence when the first file under it is added, and is removed when its last file is removed, so directory creation and deletion happen implicitly through the file ops. Adding or removing an otherwise empty directory therefore produces no ops even though it changes the source hash; do not send a patch request for such a change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_ops")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.PatchOpsItem> PatchOps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentPatchRequestV1" /> class.
        /// </summary>
        /// <param name="prevPatchHash">
        /// Content hash of the patch point this patch is applied on - the link the staged patch must build on. A stale value (the base moved underneath the client) is rejected with a conflict.
        /// </param>
        /// <param name="nextPatchPoint">
        /// The source state after this patch. The server derives its content hash from `content_hashes`.
        /// </param>
        /// <param name="patchOps">
        /// The ordered ops that make up this patch. At least one op is required; a patch that changes nothing is not a valid request. There is no op for a directory: a directory comes into existence when the first file under it is added, and is removed when its last file is removed, so directory creation and deletion happen implicitly through the file ops. Adding or removing an otherwise empty directory therefore produces no ops even though it changes the source hash; do not send a patch request for such a change.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentPatchRequestV1(
            string prevPatchHash,
            global::Baseten.DeploymentPatchPointV1 nextPatchPoint,
            global::System.Collections.Generic.IList<global::Baseten.PatchOpsItem> patchOps)
        {
            this.PrevPatchHash = prevPatchHash ?? throw new global::System.ArgumentNullException(nameof(prevPatchHash));
            this.NextPatchPoint = nextPatchPoint ?? throw new global::System.ArgumentNullException(nameof(nextPatchPoint));
            this.PatchOps = patchOps ?? throw new global::System.ArgumentNullException(nameof(patchOps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentPatchRequestV1" /> class.
        /// </summary>
        public CreateDeploymentPatchRequestV1()
        {
        }

    }
}