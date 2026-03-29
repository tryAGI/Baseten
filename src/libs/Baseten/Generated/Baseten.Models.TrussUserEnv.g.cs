
#nullable enable

namespace Baseten
{
    /// <summary>
    /// This data models is used to flexibly store info alongside oracle versions.<br/>
    /// There is a corresponding data model in the truss client.<br/>
    /// In contrast, here all fields are optional for backwards compatibility with old<br/>
    /// clients.
    /// </summary>
    public sealed partial class TrussUserEnv
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truss_client_version")]
        public string? TrussClientVersion { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("python_version")]
        public string? PythonVersion { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pydantic_version")]
        public string? PydanticVersion { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mypy_version")]
        public string? MypyVersion { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_library_deployment")]
        public bool? IsLibraryDeployment { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_frontend_deployment")]
        public bool? IsFrontendDeployment { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_info")]
        public global::Baseten.GitInfo? GitInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrussUserEnv" /> class.
        /// </summary>
        /// <param name="trussClientVersion">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="pythonVersion">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="pydanticVersion">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="mypyVersion">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="isLibraryDeployment">
        /// Default Value: false
        /// </param>
        /// <param name="isFrontendDeployment">
        /// Default Value: false
        /// </param>
        /// <param name="gitInfo">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrussUserEnv(
            string? trussClientVersion,
            string? pythonVersion,
            string? pydanticVersion,
            string? mypyVersion,
            bool? isLibraryDeployment,
            bool? isFrontendDeployment,
            global::Baseten.GitInfo? gitInfo)
        {
            this.TrussClientVersion = trussClientVersion;
            this.PythonVersion = pythonVersion;
            this.PydanticVersion = pydanticVersion;
            this.MypyVersion = mypyVersion;
            this.IsLibraryDeployment = isLibraryDeployment;
            this.IsFrontendDeployment = isFrontendDeployment;
            this.GitInfo = gitInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrussUserEnv" /> class.
        /// </summary>
        public TrussUserEnv()
        {
        }
    }
}