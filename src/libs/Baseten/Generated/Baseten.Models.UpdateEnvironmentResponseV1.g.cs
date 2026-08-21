
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// The response to a request to update an environment's settings.
    /// </summary>
    public sealed partial class UpdateEnvironmentResponseV1
    {
        /// <summary>
        /// The environment after the update, matching the shape returned by GET.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.EnvironmentV1 Environment { get; set; }

        /// <summary>
        /// Deprecated. Kept for legacy autoscaling-only update operation behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.UpdateAutoscalingSettingsStatusV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.UpdateAutoscalingSettingsStatusV1 Status { get; set; }

        /// <summary>
        /// Deprecated. Kept for legacy autoscaling-only update operation behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentResponseV1" /> class.
        /// </summary>
        /// <param name="environment">
        /// The environment after the update, matching the shape returned by GET.
        /// </param>
        /// <param name="status">
        /// Deprecated. Kept for legacy autoscaling-only update operation behavior.
        /// </param>
        /// <param name="message">
        /// Deprecated. Kept for legacy autoscaling-only update operation behavior.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEnvironmentResponseV1(
            global::Baseten.EnvironmentV1 environment,
            global::Baseten.UpdateAutoscalingSettingsStatusV1 status,
            string message)
        {
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentResponseV1" /> class.
        /// </summary>
        public UpdateEnvironmentResponseV1()
        {
        }

    }
}