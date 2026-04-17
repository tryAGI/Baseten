
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTrainerServerResponseV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainer_server")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.TrainerServerV1 TrainerServer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainerServerResponseV1" /> class.
        /// </summary>
        /// <param name="trainerServer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrainerServerResponseV1(
            global::Baseten.TrainerServerV1 trainerServer)
        {
            this.TrainerServer = trainerServer ?? throw new global::System.ArgumentNullException(nameof(trainerServer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainerServerResponseV1" /> class.
        /// </summary>
        public CreateTrainerServerResponseV1()
        {
        }
    }
}