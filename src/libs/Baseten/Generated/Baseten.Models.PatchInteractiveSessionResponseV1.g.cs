
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response after patching an interactive session.
    /// </summary>
    public sealed partial class PatchInteractiveSessionResponseV1
    {
        /// <summary>
        /// The updated interactive session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interactive_session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.InteractiveSessionV1 InteractiveSession { get; set; }

        /// <summary>
        /// Human-readable summary of what was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchInteractiveSessionResponseV1" /> class.
        /// </summary>
        /// <param name="interactiveSession">
        /// The updated interactive session.
        /// </param>
        /// <param name="message">
        /// Human-readable summary of what was updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchInteractiveSessionResponseV1(
            global::Baseten.InteractiveSessionV1 interactiveSession,
            string message)
        {
            this.InteractiveSession = interactiveSession ?? throw new global::System.ArgumentNullException(nameof(interactiveSession));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchInteractiveSessionResponseV1" /> class.
        /// </summary>
        public PatchInteractiveSessionResponseV1()
        {
        }
    }
}