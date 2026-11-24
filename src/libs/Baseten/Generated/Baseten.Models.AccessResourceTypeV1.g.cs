
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Type of a resource a role assignment can select.
    /// </summary>
    public enum AccessResourceTypeV1
    {
        /// <summary>
        ///
        /// </summary>
        Chain,
        /// <summary>
        ///
        /// </summary>
        Environment,
        /// <summary>
        ///
        /// </summary>
        GatewayEndpoint,
        /// <summary>
        ///
        /// </summary>
        GatewayGroup,
        /// <summary>
        ///
        /// </summary>
        GatewayKey,
        /// <summary>
        ///
        /// </summary>
        GridConnection,
        /// <summary>
        ///
        /// </summary>
        GridRoute,
        /// <summary>
        ///
        /// </summary>
        LibraryListing,
        /// <summary>
        ///
        /// </summary>
        Model,
        /// <summary>
        ///
        /// </summary>
        ModelApi,
        /// <summary>
        ///
        /// </summary>
        Sandbox,
        /// <summary>
        ///
        /// </summary>
        Secret,
        /// <summary>
        ///
        /// </summary>
        ServiceAccount,
        /// <summary>
        ///
        /// </summary>
        TrainingJob,
        /// <summary>
        ///
        /// </summary>
        TrainingLoop,
        /// <summary>
        ///
        /// </summary>
        TrainingProject,
        /// <summary>
        ///
        /// </summary>
        Volume,
        /// <summary>
        ///
        /// </summary>
        WebhookSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessResourceTypeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessResourceTypeV1 value)
        {
            return value switch
            {
                AccessResourceTypeV1.Chain => "CHAIN",
                AccessResourceTypeV1.Environment => "ENVIRONMENT",
                AccessResourceTypeV1.GatewayEndpoint => "GATEWAY_ENDPOINT",
                AccessResourceTypeV1.GatewayGroup => "GATEWAY_GROUP",
                AccessResourceTypeV1.GatewayKey => "GATEWAY_KEY",
                AccessResourceTypeV1.GridConnection => "GRID_CONNECTION",
                AccessResourceTypeV1.GridRoute => "GRID_ROUTE",
                AccessResourceTypeV1.LibraryListing => "LIBRARY_LISTING",
                AccessResourceTypeV1.Model => "MODEL",
                AccessResourceTypeV1.ModelApi => "MODEL_API",
                AccessResourceTypeV1.Sandbox => "SANDBOX",
                AccessResourceTypeV1.Secret => "SECRET",
                AccessResourceTypeV1.ServiceAccount => "SERVICE_ACCOUNT",
                AccessResourceTypeV1.TrainingJob => "TRAINING_JOB",
                AccessResourceTypeV1.TrainingLoop => "TRAINING_LOOP",
                AccessResourceTypeV1.TrainingProject => "TRAINING_PROJECT",
                AccessResourceTypeV1.Volume => "VOLUME",
                AccessResourceTypeV1.WebhookSecret => "WEBHOOK_SECRET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessResourceTypeV1? ToEnum(string value)
        {
            return value switch
            {
                "CHAIN" => AccessResourceTypeV1.Chain,
                "ENVIRONMENT" => AccessResourceTypeV1.Environment,
                "GATEWAY_ENDPOINT" => AccessResourceTypeV1.GatewayEndpoint,
                "GATEWAY_GROUP" => AccessResourceTypeV1.GatewayGroup,
                "GATEWAY_KEY" => AccessResourceTypeV1.GatewayKey,
                "GRID_CONNECTION" => AccessResourceTypeV1.GridConnection,
                "GRID_ROUTE" => AccessResourceTypeV1.GridRoute,
                "LIBRARY_LISTING" => AccessResourceTypeV1.LibraryListing,
                "MODEL" => AccessResourceTypeV1.Model,
                "MODEL_API" => AccessResourceTypeV1.ModelApi,
                "SANDBOX" => AccessResourceTypeV1.Sandbox,
                "SECRET" => AccessResourceTypeV1.Secret,
                "SERVICE_ACCOUNT" => AccessResourceTypeV1.ServiceAccount,
                "TRAINING_JOB" => AccessResourceTypeV1.TrainingJob,
                "TRAINING_LOOP" => AccessResourceTypeV1.TrainingLoop,
                "TRAINING_PROJECT" => AccessResourceTypeV1.TrainingProject,
                "VOLUME" => AccessResourceTypeV1.Volume,
                "WEBHOOK_SECRET" => AccessResourceTypeV1.WebhookSecret,
                _ => null,
            };
        }
    }
}