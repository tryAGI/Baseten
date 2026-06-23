
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``GET /v1/loops/user_config``.
    /// </summary>
    public sealed partial class GetLoopsUserConfigResponseV1
    {
        /// <summary>
        /// The caller's Loops user config.
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
        /// Initializes a new instance of the <see cref="GetLoopsUserConfigResponseV1" /> class.
        /// </summary>
        /// <param name="userConfig">
        /// The caller's Loops user config.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLoopsUserConfigResponseV1(
            global::Baseten.LoopsUserConfigV1 userConfig)
        {
            this.UserConfig = userConfig ?? throw new global::System.ArgumentNullException(nameof(userConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsUserConfigResponseV1" /> class.
        /// </summary>
        public GetLoopsUserConfigResponseV1()
        {
        }

    }
}