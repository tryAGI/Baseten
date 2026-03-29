
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GitInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_commit_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LatestCommitSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_tag")]
        public string? LatestTag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits_since_tag")]
        public int? CommitsSinceTag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_uncommitted_changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasUncommittedChanges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitInfo" /> class.
        /// </summary>
        /// <param name="latestCommitSha"></param>
        /// <param name="hasUncommittedChanges"></param>
        /// <param name="latestTag"></param>
        /// <param name="commitsSinceTag"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GitInfo(
            string latestCommitSha,
            bool hasUncommittedChanges,
            string? latestTag,
            int? commitsSinceTag)
        {
            this.LatestCommitSha = latestCommitSha ?? throw new global::System.ArgumentNullException(nameof(latestCommitSha));
            this.LatestTag = latestTag;
            this.CommitsSinceTag = commitsSinceTag;
            this.HasUncommittedChanges = hasUncommittedChanges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitInfo" /> class.
        /// </summary>
        public GitInfo()
        {
        }
    }
}