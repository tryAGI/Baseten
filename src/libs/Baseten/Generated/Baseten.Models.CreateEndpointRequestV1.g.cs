
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEndpointRequestV1
    {
        /// <summary>
        /// Globally-unique slug of the form '{org_prefix}/{name}'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// The endpoint's upstream targets. Exactly one target is supported at this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.EndpointTargetRequestV1> Targets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEndpointRequestV1" /> class.
        /// </summary>
        /// <param name="slug">
        /// Globally-unique slug of the form '{org_prefix}/{name}'.
        /// </param>
        /// <param name="targets">
        /// The endpoint's upstream targets. Exactly one target is supported at this time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEndpointRequestV1(
            string slug,
            global::System.Collections.Generic.IList<global::Baseten.EndpointTargetRequestV1> targets)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEndpointRequestV1" /> class.
        /// </summary>
        public CreateEndpointRequestV1()
        {
        }

    }
}