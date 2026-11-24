
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to start an asynchronous volume sync.
    /// </summary>
    public sealed partial class CreateVolumeSyncRequestV1
    {
        /// <summary>
        /// Where the volumes are stored. Defaults to your organization's hosting when it has one, and is required when it has more than one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hosting")]
        public global::Baseten.VolumeHostingV1? Hosting { get; set; }

        /// <summary>
        /// Remote source to sync from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.Source3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.Source3 Source { get; set; }

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
        /// <param name="hosting">
        /// Where the volumes are stored. Defaults to your organization's hosting when it has one, and is required when it has more than one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVolumeSyncRequestV1(
            global::Baseten.Source3 source,
            global::Baseten.VolumeSyncDestinationV1 destination,
            global::Baseten.VolumeHostingV1? hosting)
        {
            this.Hosting = hosting;
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