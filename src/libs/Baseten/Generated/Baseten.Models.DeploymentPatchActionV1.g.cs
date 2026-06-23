
#nullable enable

namespace Baseten
{
    /// <summary>
    /// How a patch op changes its target.
    /// </summary>
    public enum DeploymentPatchActionV1
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        Remove,
        /// <summary>
        /// 
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentPatchActionV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentPatchActionV1 value)
        {
            return value switch
            {
                DeploymentPatchActionV1.Add => "ADD",
                DeploymentPatchActionV1.Remove => "REMOVE",
                DeploymentPatchActionV1.Update => "UPDATE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentPatchActionV1? ToEnum(string value)
        {
            return value switch
            {
                "ADD" => DeploymentPatchActionV1.Add,
                "REMOVE" => DeploymentPatchActionV1.Remove,
                "UPDATE" => DeploymentPatchActionV1.Update,
                _ => null,
            };
        }
    }
}