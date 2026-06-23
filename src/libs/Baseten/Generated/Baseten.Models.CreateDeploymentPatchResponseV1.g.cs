
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The created patch, represented by the patch point it produced.
    /// </summary>
    public sealed partial class CreateDeploymentPatchResponseV1
    {
        /// <summary>
        /// The resulting patch point the staged patch produced; matches the pending point a subsequent state read returns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_point")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentPatchPointWithHashV1 PatchPoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentPatchResponseV1" /> class.
        /// </summary>
        /// <param name="patchPoint">
        /// The resulting patch point the staged patch produced; matches the pending point a subsequent state read returns.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentPatchResponseV1(
            global::Baseten.DeploymentPatchPointWithHashV1 patchPoint)
        {
            this.PatchPoint = patchPoint ?? throw new global::System.ArgumentNullException(nameof(patchPoint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentPatchResponseV1" /> class.
        /// </summary>
        public CreateDeploymentPatchResponseV1()
        {
        }

    }
}