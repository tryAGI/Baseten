
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Latest deployment status for a loop deployment.
    /// </summary>
    public sealed partial class LoopDeploymentStatusV1
    {
        /// <summary>
        /// Latest status of the loop deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.NameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.Name Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopDeploymentStatusV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Latest status of the loop deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopDeploymentStatusV1(
            global::Baseten.Name name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopDeploymentStatusV1" /> class.
        /// </summary>
        public LoopDeploymentStatusV1()
        {
        }
    }
}