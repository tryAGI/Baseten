
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``PATCH /v1/loops/user_config``.
    /// </summary>
    public sealed partial class PatchLoopsUserConfigResponseV1
    {
        /// <summary>
        /// The updated Loops user config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.LoopsUserConfigV1 UserConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchLoopsUserConfigResponseV1" /> class.
        /// </summary>
        /// <param name="userConfig">
        /// The updated Loops user config.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchLoopsUserConfigResponseV1(
            global::Baseten.LoopsUserConfigV1 userConfig)
        {
            this.UserConfig = userConfig ?? throw new global::System.ArgumentNullException(nameof(userConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchLoopsUserConfigResponseV1" /> class.
        /// </summary>
        public PatchLoopsUserConfigResponseV1()
        {
        }

    }
}