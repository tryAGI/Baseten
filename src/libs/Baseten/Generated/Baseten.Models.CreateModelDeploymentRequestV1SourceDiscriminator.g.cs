
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelDeploymentRequestV1SourceDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.CreateModelDeploymentRequestV1SourceDiscriminatorKindJsonConverter))]
        public global::Baseten.CreateModelDeploymentRequestV1SourceDiscriminatorKind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelDeploymentRequestV1SourceDiscriminator" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelDeploymentRequestV1SourceDiscriminator(
            global::Baseten.CreateModelDeploymentRequestV1SourceDiscriminatorKind? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelDeploymentRequestV1SourceDiscriminator" /> class.
        /// </summary>
        public CreateModelDeploymentRequestV1SourceDiscriminator()
        {
        }

    }
}