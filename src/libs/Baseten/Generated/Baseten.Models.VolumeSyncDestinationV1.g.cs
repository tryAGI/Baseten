
#nullable enable

namespace Baseten
{
    /// <summary>
    /// BDN destination for a volume sync.
    /// </summary>
    public sealed partial class VolumeSyncDestinationV1
    {
        /// <summary>
        /// Destination as bdn:&lt;namespace&gt;/&lt;volume&gt; with an optional tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSyncDestinationV1" /> class.
        /// </summary>
        /// <param name="ref">
        /// Destination as bdn:&lt;namespace&gt;/&lt;volume&gt; with an optional tag.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeSyncDestinationV1(
            string @ref)
        {
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSyncDestinationV1" /> class.
        /// </summary>
        public VolumeSyncDestinationV1()
        {
        }

    }
}