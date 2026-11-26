
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Replica lifecycle status.
    /// </summary>
    public enum HotLoadReplicaV1ReplicaStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        NotReady,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Ready,
        /// <summary>
        ///
        /// </summary>
        Terminating,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HotLoadReplicaV1ReplicaStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HotLoadReplicaV1ReplicaStatus value)
        {
            return value switch
            {
                HotLoadReplicaV1ReplicaStatus.Failed => "failed",
                HotLoadReplicaV1ReplicaStatus.NotReady => "not_ready",
                HotLoadReplicaV1ReplicaStatus.Pending => "pending",
                HotLoadReplicaV1ReplicaStatus.Ready => "ready",
                HotLoadReplicaV1ReplicaStatus.Terminating => "terminating",
                HotLoadReplicaV1ReplicaStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HotLoadReplicaV1ReplicaStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => HotLoadReplicaV1ReplicaStatus.Failed,
                "not_ready" => HotLoadReplicaV1ReplicaStatus.NotReady,
                "pending" => HotLoadReplicaV1ReplicaStatus.Pending,
                "ready" => HotLoadReplicaV1ReplicaStatus.Ready,
                "terminating" => HotLoadReplicaV1ReplicaStatus.Terminating,
                "unknown" => HotLoadReplicaV1ReplicaStatus.Unknown,
                _ => null,
            };
        }
    }
}