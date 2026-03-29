
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum LoadCheckpointConfigCheckpointDiscriminatorTyp
    {
        /// <summary>
        /// 
        /// </summary>
        BasetenLatestCheckpoint,
        /// <summary>
        /// 
        /// </summary>
        BasetenNamedCheckpoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LoadCheckpointConfigCheckpointDiscriminatorTypExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LoadCheckpointConfigCheckpointDiscriminatorTyp value)
        {
            return value switch
            {
                LoadCheckpointConfigCheckpointDiscriminatorTyp.BasetenLatestCheckpoint => "baseten_latest_checkpoint",
                LoadCheckpointConfigCheckpointDiscriminatorTyp.BasetenNamedCheckpoint => "baseten_named_checkpoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LoadCheckpointConfigCheckpointDiscriminatorTyp? ToEnum(string value)
        {
            return value switch
            {
                "baseten_latest_checkpoint" => LoadCheckpointConfigCheckpointDiscriminatorTyp.BasetenLatestCheckpoint,
                "baseten_named_checkpoint" => LoadCheckpointConfigCheckpointDiscriminatorTyp.BasetenNamedCheckpoint,
                _ => null,
            };
        }
    }
}