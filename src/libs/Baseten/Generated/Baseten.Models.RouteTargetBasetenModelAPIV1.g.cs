
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteTargetBasetenModelAPIV1
    {
        /// <summary>
        /// Target kind for a Baseten Model API.
        /// </summary>
        /// <default>"BASETEN_MODEL_API"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "BASETEN_MODEL_API";

        /// <summary>
        /// Name of the target Model API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_api")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelApi { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTargetBasetenModelAPIV1" /> class.
        /// </summary>
        /// <param name="modelApi">
        /// Name of the target Model API.
        /// </param>
        /// <param name="type">
        /// Target kind for a Baseten Model API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteTargetBasetenModelAPIV1(
            string modelApi,
            string type = "BASETEN_MODEL_API")
        {
            this.Type = type;
            this.ModelApi = modelApi ?? throw new global::System.ArgumentNullException(nameof(modelApi));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTargetBasetenModelAPIV1" /> class.
        /// </summary>
        public RouteTargetBasetenModelAPIV1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RouteTargetBasetenModelAPIV1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RouteTargetBasetenModelAPIV1 FromModelApi(string modelApi)
        {
            return new RouteTargetBasetenModelAPIV1
            {
                ModelApi = modelApi,
            };
        }

    }
}