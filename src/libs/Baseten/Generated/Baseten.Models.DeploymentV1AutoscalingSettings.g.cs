
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Autoscaling settings for the deployment. If null, the model has not finished deploying
    /// </summary>
    public sealed partial class DeploymentV1AutoscalingSettings
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}