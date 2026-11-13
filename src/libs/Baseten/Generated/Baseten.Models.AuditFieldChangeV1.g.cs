
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A field's value before and after an update.
    /// </summary>
    public sealed partial class AuditFieldChangeV1
    {
        /// <summary>
        /// The value before the update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Old { get; set; }

        /// <summary>
        /// The value after the update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object New { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditFieldChangeV1" /> class.
        /// </summary>
        /// <param name="old">
        /// The value before the update.
        /// </param>
        /// <param name="new">
        /// The value after the update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditFieldChangeV1(
            object old,
            object @new)
        {
            this.Old = old ?? throw new global::System.ArgumentNullException(nameof(old));
            this.New = @new ?? throw new global::System.ArgumentNullException(nameof(@new));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditFieldChangeV1" /> class.
        /// </summary>
        public AuditFieldChangeV1()
        {
        }

    }
}