
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A response to querying logs.
    /// </summary>
    public sealed partial class GetLogsResponseV1
    {
        /// <summary>
        /// Logs for a specific entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.LogV1> Logs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLogsResponseV1" /> class.
        /// </summary>
        /// <param name="logs">
        /// Logs for a specific entity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLogsResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.LogV1> logs)
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLogsResponseV1" /> class.
        /// </summary>
        public GetLogsResponseV1()
        {
        }
    }
}