
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateBackgroundHarnessModelsV1
    {
        /// <summary>
        /// Route ID for the primary model, which new sessions use. Omit to keep the current route, or pass null to use the team's default.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        public string? Primary { get; set; }

        /// <summary>
        /// Route ID for background tasks, such as session titles. Omit to keep the current route, or pass null to use the team's default.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public string? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBackgroundHarnessModelsV1" /> class.
        /// </summary>
        /// <param name="primary">
        /// Route ID for the primary model, which new sessions use. Omit to keep the current route, or pass null to use the team's default.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="background">
        /// Route ID for background tasks, such as session titles. Omit to keep the current route, or pass null to use the team's default.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateBackgroundHarnessModelsV1(
            string? primary,
            string? background)
        {
            this.Primary = primary;
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBackgroundHarnessModelsV1" /> class.
        /// </summary>
        public UpdateBackgroundHarnessModelsV1()
        {
        }

    }
}