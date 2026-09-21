
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum VolumeSyncStatusV1
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Failed,
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
        Syncing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VolumeSyncStatusV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VolumeSyncStatusV1 value)
        {
            return value switch
            {
                VolumeSyncStatusV1.Canceled => "CANCELED",
                VolumeSyncStatusV1.Failed => "FAILED",
                VolumeSyncStatusV1.Pending => "PENDING",
                VolumeSyncStatusV1.Ready => "READY",
                VolumeSyncStatusV1.Syncing => "SYNCING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VolumeSyncStatusV1? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => VolumeSyncStatusV1.Canceled,
                "FAILED" => VolumeSyncStatusV1.Failed,
                "PENDING" => VolumeSyncStatusV1.Pending,
                "READY" => VolumeSyncStatusV1.Ready,
                "SYNCING" => VolumeSyncStatusV1.Syncing,
                _ => null,
            };
        }
    }
}