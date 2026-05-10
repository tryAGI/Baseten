
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Latest deployment status for a Loops deployment.
    /// </summary>
    public sealed partial class LoopsDeploymentStatusV1
    {
        /// <summary>
        /// Latest status of the Loops deployment.
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
        /// Initializes a new instance of the <see cref="LoopsDeploymentStatusV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Latest status of the Loops deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsDeploymentStatusV1(
            global::Baseten.Name name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsDeploymentStatusV1" /> class.
        /// </summary>
        public LoopsDeploymentStatusV1()
        {
        }

    }
}