
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Lifecycle state for the checkpoint uploader.
    /// </summary>
    public enum CheckpointSyncStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Syncing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheckpointSyncStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckpointSyncStatus value)
        {
            return value switch
            {
                CheckpointSyncStatus.Completed => "COMPLETED",
                CheckpointSyncStatus.Syncing => "SYNCING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckpointSyncStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => CheckpointSyncStatus.Completed,
                "SYNCING" => CheckpointSyncStatus.Syncing,
                _ => null,
            };
        }
    }
}