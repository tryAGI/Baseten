
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum DeploymentReplicaStatusV1
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Starting,
        /// <summary>
        ///
        /// </summary>
        Terminated,
        /// <summary>
        ///
        /// </summary>
        Terminating,
        /// <summary>
        ///
        /// </summary>
        Unhealthy,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentReplicaStatusV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentReplicaStatusV1 value)
        {
            return value switch
            {
                DeploymentReplicaStatusV1.Active => "ACTIVE",
                DeploymentReplicaStatusV1.Starting => "STARTING",
                DeploymentReplicaStatusV1.Terminated => "TERMINATED",
                DeploymentReplicaStatusV1.Terminating => "TERMINATING",
                DeploymentReplicaStatusV1.Unhealthy => "UNHEALTHY",
                DeploymentReplicaStatusV1.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentReplicaStatusV1? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => DeploymentReplicaStatusV1.Active,
                "STARTING" => DeploymentReplicaStatusV1.Starting,
                "TERMINATED" => DeploymentReplicaStatusV1.Terminated,
                "TERMINATING" => DeploymentReplicaStatusV1.Terminating,
                "UNHEALTHY" => DeploymentReplicaStatusV1.Unhealthy,
                "UNKNOWN" => DeploymentReplicaStatusV1.Unknown,
                _ => null,
            };
        }
    }
}