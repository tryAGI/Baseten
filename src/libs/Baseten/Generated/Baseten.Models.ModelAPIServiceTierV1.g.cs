
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelAPIServiceTierV1
    {
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Flex,
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelAPIServiceTierV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelAPIServiceTierV1 value)
        {
            return value switch
            {
                ModelAPIServiceTierV1.Default => "DEFAULT",
                ModelAPIServiceTierV1.Flex => "FLEX",
                ModelAPIServiceTierV1.Priority => "PRIORITY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelAPIServiceTierV1? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => ModelAPIServiceTierV1.Default,
                "FLEX" => ModelAPIServiceTierV1.Flex,
                "PRIORITY" => ModelAPIServiceTierV1.Priority,
                _ => null,
            };
        }
    }
}