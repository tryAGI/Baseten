
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The current status of a Loops sampler.
    /// </summary>
    public sealed partial class LoopsSamplerStatusV1
    {
        /// <summary>
        /// The current status of the Loops sampler.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.DeploymentStatusV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentStatusV1 Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsSamplerStatusV1" /> class.
        /// </summary>
        /// <param name="name">
        /// The current status of the Loops sampler.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsSamplerStatusV1(
            global::Baseten.DeploymentStatusV1 name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsSamplerStatusV1" /> class.
        /// </summary>
        public LoopsSamplerStatusV1()
        {
        }

    }
}