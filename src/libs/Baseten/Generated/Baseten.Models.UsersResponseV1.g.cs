
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A page of users in the caller's workspace.
    /// </summary>
    public sealed partial class UsersResponseV1
    {
        /// <summary>
        /// Items in this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.UserInfoV1> Items { get; set; }

        /// <summary>
        /// Pagination metadata for the page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.PaginationResponseV1 Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersResponseV1" /> class.
        /// </summary>
        /// <param name="items">
        /// Items in this page.
        /// </param>
        /// <param name="pagination">
        /// Pagination metadata for the page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsersResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.UserInfoV1> items,
            global::Baseten.PaginationResponseV1 pagination)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersResponseV1" /> class.
        /// </summary>
        public UsersResponseV1()
        {
        }

    }
}