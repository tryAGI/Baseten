
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Built-in sandbox images.
    /// </summary>
    public sealed partial class ListSandboxLibraryImagesResponseV1
    {
        /// <summary>
        /// Built-in images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.SandboxLibraryImageV1> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSandboxLibraryImagesResponseV1" /> class.
        /// </summary>
        /// <param name="items">
        /// Built-in images.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSandboxLibraryImagesResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.SandboxLibraryImageV1> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSandboxLibraryImagesResponseV1" /> class.
        /// </summary>
        public ListSandboxLibraryImagesResponseV1()
        {
        }

    }
}