
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A response to update the environment settings for a chainlet. If updating the instance type<br/>
    /// resulted in a re-deployment, `requires_redeployment` will be True and the resulting deployment<br/>
    /// will be returned in the `chain_deployment` field.
    /// </summary>
    public sealed partial class UpdateChainletEnvironmentInstanceTypeResponseV1
    {
        /// <summary>
        /// Whether the resource update requires a re-deployment to update the instance type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_redeployment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequiresRedeployment { get; set; }

        /// <summary>
        /// The chain deployment resulting from the resource update, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_deployment")]
        public global::Baseten.ChainDeploymentV1? ChainDeployment { get; set; }

        /// <summary>
        /// The updated chainlet environment settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chainlet_environment_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentSettingsV1> ChainletEnvironmentSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChainletEnvironmentInstanceTypeResponseV1" /> class.
        /// </summary>
        /// <param name="requiresRedeployment">
        /// Whether the resource update requires a re-deployment to update the instance type.
        /// </param>
        /// <param name="chainletEnvironmentSettings">
        /// The updated chainlet environment settings
        /// </param>
        /// <param name="chainDeployment">
        /// The chain deployment resulting from the resource update, if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChainletEnvironmentInstanceTypeResponseV1(
            bool requiresRedeployment,
            global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentSettingsV1> chainletEnvironmentSettings,
            global::Baseten.ChainDeploymentV1? chainDeployment)
        {
            this.RequiresRedeployment = requiresRedeployment;
            this.ChainDeployment = chainDeployment;
            this.ChainletEnvironmentSettings = chainletEnvironmentSettings ?? throw new global::System.ArgumentNullException(nameof(chainletEnvironmentSettings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChainletEnvironmentInstanceTypeResponseV1" /> class.
        /// </summary>
        public UpdateChainletEnvironmentInstanceTypeResponseV1()
        {
        }
    }
}