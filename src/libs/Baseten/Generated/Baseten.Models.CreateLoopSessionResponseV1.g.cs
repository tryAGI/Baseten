
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLoopSessionResponseV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.LoopSessionV1 Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoopSessionResponseV1" /> class.
        /// </summary>
        /// <param name="session"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLoopSessionResponseV1(
            global::Baseten.LoopSessionV1 session)
        {
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoopSessionResponseV1" /> class.
        /// </summary>
        public CreateLoopSessionResponseV1()
        {
        }
    }
}