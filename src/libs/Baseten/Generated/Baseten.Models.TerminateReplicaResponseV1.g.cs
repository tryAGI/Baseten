
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The response to a request to terminate a replica in a deployment.
    /// </summary>
    public sealed partial class TerminateReplicaResponseV1
    {
        /// <summary>
        /// Whether the replica was successfully terminated<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TerminateReplicaResponseV1" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the replica was successfully terminated<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TerminateReplicaResponseV1(
            bool? success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TerminateReplicaResponseV1" /> class.
        /// </summary>
        public TerminateReplicaResponseV1()
        {
        }
    }
}