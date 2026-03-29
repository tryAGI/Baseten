
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to promote a deployment to production.
    /// </summary>
    public sealed partial class PromoteRequestV1
    {
        /// <summary>
        /// Whether to scale down the previous production deployment after promoting<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_down_previous_production")]
        public bool? ScaleDownPreviousProduction { get; set; }

        /// <summary>
        /// Whether to use the promoting deployment's instance type or preserve target environment's instance type<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_env_instance_type")]
        public bool? PreserveEnvInstanceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteRequestV1" /> class.
        /// </summary>
        /// <param name="scaleDownPreviousProduction">
        /// Whether to scale down the previous production deployment after promoting<br/>
        /// Default Value: true
        /// </param>
        /// <param name="preserveEnvInstanceType">
        /// Whether to use the promoting deployment's instance type or preserve target environment's instance type<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromoteRequestV1(
            bool? scaleDownPreviousProduction,
            bool? preserveEnvInstanceType)
        {
            this.ScaleDownPreviousProduction = scaleDownPreviousProduction;
            this.PreserveEnvInstanceType = preserveEnvInstanceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteRequestV1" /> class.
        /// </summary>
        public PromoteRequestV1()
        {
        }
    }
}