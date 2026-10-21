
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateGridConnectionRequestV1ConfigDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.UpdateGridConnectionRequestV1ConfigDiscriminatorProviderJsonConverter))]
        public global::Baseten.UpdateGridConnectionRequestV1ConfigDiscriminatorProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGridConnectionRequestV1ConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateGridConnectionRequestV1ConfigDiscriminator(
            global::Baseten.UpdateGridConnectionRequestV1ConfigDiscriminatorProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGridConnectionRequestV1ConfigDiscriminator" /> class.
        /// </summary>
        public UpdateGridConnectionRequestV1ConfigDiscriminator()
        {
        }

    }
}