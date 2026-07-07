
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Query params for ``GET /v1/models/.../deployments/.../config``.
    /// </summary>
    public sealed partial class GetDeploymentConfigRequestV1
    {
        /// <summary>
        /// 'raw': verbatim config.yaml with comments (not available for deployments created before 2026-04-30). 'parsed': dict with server-side defaults applied (always available). 'both': both fields populated.<br/>
        /// Default Value: both
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.DeploymentConfigOutputFormatJsonConverter))]
        public global::Baseten.DeploymentConfigOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentConfigRequestV1" /> class.
        /// </summary>
        /// <param name="outputFormat">
        /// 'raw': verbatim config.yaml with comments (not available for deployments created before 2026-04-30). 'parsed': dict with server-side defaults applied (always available). 'both': both fields populated.<br/>
        /// Default Value: both
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentConfigRequestV1(
            global::Baseten.DeploymentConfigOutputFormat? outputFormat)
        {
            this.OutputFormat = outputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentConfigRequestV1" /> class.
        /// </summary>
        public GetDeploymentConfigRequestV1()
        {
        }

    }
}