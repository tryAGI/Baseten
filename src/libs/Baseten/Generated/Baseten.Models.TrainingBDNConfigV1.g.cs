
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Read-only BDN mounts with the same reference semantics as inference.
    /// </summary>
    public sealed partial class TrainingBDNConfigV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mounts")]
        public global::System.Collections.Generic.IList<global::Baseten.TrainingBDNMountV1>? Mounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingBDNConfigV1" /> class.
        /// </summary>
        /// <param name="mounts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingBDNConfigV1(
            global::System.Collections.Generic.IList<global::Baseten.TrainingBDNMountV1>? mounts)
        {
            this.Mounts = mounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingBDNConfigV1" /> class.
        /// </summary>
        public TrainingBDNConfigV1()
        {
        }

    }
}