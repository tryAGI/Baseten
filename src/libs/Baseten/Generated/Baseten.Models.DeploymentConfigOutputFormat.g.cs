
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeploymentConfigOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Both,
        /// <summary>
        /// 
        /// </summary>
        Parsed,
        /// <summary>
        /// 
        /// </summary>
        Raw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentConfigOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentConfigOutputFormat value)
        {
            return value switch
            {
                DeploymentConfigOutputFormat.Both => "both",
                DeploymentConfigOutputFormat.Parsed => "parsed",
                DeploymentConfigOutputFormat.Raw => "raw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentConfigOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "both" => DeploymentConfigOutputFormat.Both,
                "parsed" => DeploymentConfigOutputFormat.Parsed,
                "raw" => DeploymentConfigOutputFormat.Raw,
                _ => null,
            };
        }
    }
}