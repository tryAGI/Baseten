
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``GET /v1/loops/sessions/&lt;session_id&gt;``.
    /// </summary>
    public sealed partial class GetLoopsSessionResponseV1
    {
        /// <summary>
        /// The Loops session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.LoopsSessionV1 Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsSessionResponseV1" /> class.
        /// </summary>
        /// <param name="session">
        /// The Loops session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLoopsSessionResponseV1(
            global::Baseten.LoopsSessionV1 session)
        {
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsSessionResponseV1" /> class.
        /// </summary>
        public GetLoopsSessionResponseV1()
        {
        }
    }
}