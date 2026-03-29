
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoadCheckpointConfigCheckpointDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typ")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.LoadCheckpointConfigCheckpointDiscriminatorTypJsonConverter))]
        public global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp? Typ { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadCheckpointConfigCheckpointDiscriminator" /> class.
        /// </summary>
        /// <param name="typ"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoadCheckpointConfigCheckpointDiscriminator(
            global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp? typ)
        {
            this.Typ = typ;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadCheckpointConfigCheckpointDiscriminator" /> class.
        /// </summary>
        public LoadCheckpointConfigCheckpointDiscriminator()
        {
        }
    }
}