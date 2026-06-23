
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Add, update, or remove a single external data item.<br/>
    /// External data is referenced by config, not stored in the source. The backend<br/>
    /// only adds or removes it, where adding re-downloads (overwriting any existing<br/>
    /// file), so `update` is accepted and treated identically to `add`.
    /// </summary>
    public sealed partial class DeploymentPatchOpExternalDataV1
    {
        /// <summary>
        /// Default Value: external_data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// How this op changes the item. `UPDATE` is treated identically to `ADD`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.DeploymentPatchActionV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentPatchActionV1 Action { get; set; }

        /// <summary>
        /// The single external data item descriptor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchOpExternalDataV1" /> class.
        /// </summary>
        /// <param name="action">
        /// How this op changes the item. `UPDATE` is treated identically to `ADD`.
        /// </param>
        /// <param name="item">
        /// The single external data item descriptor.
        /// </param>
        /// <param name="type">
        /// Default Value: external_data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentPatchOpExternalDataV1(
            global::Baseten.DeploymentPatchActionV1 action,
            global::System.Collections.Generic.Dictionary<string, string> item,
            string? type)
        {
            this.Type = type;
            this.Action = action;
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchOpExternalDataV1" /> class.
        /// </summary>
        public DeploymentPatchOpExternalDataV1()
        {
        }

    }
}