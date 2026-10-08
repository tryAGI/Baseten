
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSandboxConfigurationResponseV1
    {
        /// <summary>
        /// Available Carbon-compatible regions, sorted by name. Empty when none are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.SandboxRegionV1> Regions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSandboxConfigurationResponseV1" /> class.
        /// </summary>
        /// <param name="regions">
        /// Available Carbon-compatible regions, sorted by name. Empty when none are available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSandboxConfigurationResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.SandboxRegionV1> regions)
        {
            this.Regions = regions ?? throw new global::System.ArgumentNullException(nameof(regions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSandboxConfigurationResponseV1" /> class.
        /// </summary>
        public GetSandboxConfigurationResponseV1()
        {
        }

    }
}