
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The status of a deployment.
    /// </summary>
    public enum DeploymentStatusV1
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Building,
        /// <summary>
        /// 
        /// </summary>
        BuildFailed,
        /// <summary>
        /// 
        /// </summary>
        BuildStopped,
        /// <summary>
        /// 
        /// </summary>
        Deactivating,
        /// <summary>
        /// 
        /// </summary>
        Deploying,
        /// <summary>
        /// 
        /// </summary>
        DeployFailed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        LoadingModel,
        /// <summary>
        /// 
        /// </summary>
        ScaledToZero,
        /// <summary>
        /// 
        /// </summary>
        Unhealthy,
        /// <summary>
        /// 
        /// </summary>
        Updating,
        /// <summary>
        /// 
        /// </summary>
        WakingUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentStatusV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentStatusV1 value)
        {
            return value switch
            {
                DeploymentStatusV1.Active => "ACTIVE",
                DeploymentStatusV1.Building => "BUILDING",
                DeploymentStatusV1.BuildFailed => "BUILD_FAILED",
                DeploymentStatusV1.BuildStopped => "BUILD_STOPPED",
                DeploymentStatusV1.Deactivating => "DEACTIVATING",
                DeploymentStatusV1.Deploying => "DEPLOYING",
                DeploymentStatusV1.DeployFailed => "DEPLOY_FAILED",
                DeploymentStatusV1.Failed => "FAILED",
                DeploymentStatusV1.Inactive => "INACTIVE",
                DeploymentStatusV1.LoadingModel => "LOADING_MODEL",
                DeploymentStatusV1.ScaledToZero => "SCALED_TO_ZERO",
                DeploymentStatusV1.Unhealthy => "UNHEALTHY",
                DeploymentStatusV1.Updating => "UPDATING",
                DeploymentStatusV1.WakingUp => "WAKING_UP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentStatusV1? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => DeploymentStatusV1.Active,
                "BUILDING" => DeploymentStatusV1.Building,
                "BUILD_FAILED" => DeploymentStatusV1.BuildFailed,
                "BUILD_STOPPED" => DeploymentStatusV1.BuildStopped,
                "DEACTIVATING" => DeploymentStatusV1.Deactivating,
                "DEPLOYING" => DeploymentStatusV1.Deploying,
                "DEPLOY_FAILED" => DeploymentStatusV1.DeployFailed,
                "FAILED" => DeploymentStatusV1.Failed,
                "INACTIVE" => DeploymentStatusV1.Inactive,
                "LOADING_MODEL" => DeploymentStatusV1.LoadingModel,
                "SCALED_TO_ZERO" => DeploymentStatusV1.ScaledToZero,
                "UNHEALTHY" => DeploymentStatusV1.Unhealthy,
                "UPDATING" => DeploymentStatusV1.Updating,
                "WAKING_UP" => DeploymentStatusV1.WakingUp,
                _ => null,
            };
        }
    }
}