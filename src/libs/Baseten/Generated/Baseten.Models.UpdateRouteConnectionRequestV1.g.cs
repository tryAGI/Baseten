
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRouteConnectionRequestV1
    {
        /// <summary>
        /// Connection fields to change. The provider must match the connection and is immutable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.Config3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.Config3 Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteConnectionRequestV1" /> class.
        /// </summary>
        /// <param name="config">
        /// Connection fields to change. The provider must match the connection and is immutable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRouteConnectionRequestV1(
            global::Baseten.Config3 config)
        {
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteConnectionRequestV1" /> class.
        /// </summary>
        public UpdateRouteConnectionRequestV1()
        {
        }

    }
}