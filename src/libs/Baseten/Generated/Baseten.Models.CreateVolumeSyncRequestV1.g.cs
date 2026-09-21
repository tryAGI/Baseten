
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to start an asynchronous volume sync.
    /// </summary>
    public sealed partial class CreateVolumeSyncRequestV1
    {
        /// <summary>
        /// Remote source to sync from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.Source2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.Source2 Source { get; set; }

        /// <summary>
        /// BDN volume to sync into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.VolumeSyncDestinationV1 Destination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVolumeSyncRequestV1" /> class.
        /// </summary>
        /// <param name="source">
        /// Remote source to sync from.
        /// </param>
        /// <param name="destination">
        /// BDN volume to sync into.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVolumeSyncRequestV1(
            global::Baseten.Source2 source,
            global::Baseten.VolumeSyncDestinationV1 destination)
        {
            this.Source = source;
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVolumeSyncRequestV1" /> class.
        /// </summary>
        public CreateVolumeSyncRequestV1()
        {
        }

    }
}