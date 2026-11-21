
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Where volumes are stored. The same name under two hostings is two different volumes.<br/>
    /// - ``BASETEN_CLOUD``: Baseten's shared fleet.<br/>
    /// - ``SINGLE_TENANT``: your organization's single-tenant workload planes.<br/>
    /// - ``SELF_HOSTED``: workload planes in your own cloud account.
    /// </summary>
    public enum VolumeHostingV1
    {
        /// <summary>
        /// Baseten's shared fleet.
        /// </summary>
        BasetenCloud,
        /// <summary>
        /// workload planes in your own cloud account.
        /// </summary>
        SelfHosted,
        /// <summary>
        /// your organization's single-tenant workload planes.
        /// </summary>
        SingleTenant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VolumeHostingV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VolumeHostingV1 value)
        {
            return value switch
            {
                VolumeHostingV1.BasetenCloud => "BASETEN_CLOUD",
                VolumeHostingV1.SelfHosted => "SELF_HOSTED",
                VolumeHostingV1.SingleTenant => "SINGLE_TENANT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VolumeHostingV1? ToEnum(string value)
        {
            return value switch
            {
                "BASETEN_CLOUD" => VolumeHostingV1.BasetenCloud,
                "SELF_HOSTED" => VolumeHostingV1.SelfHosted,
                "SINGLE_TENANT" => VolumeHostingV1.SingleTenant,
                _ => null,
            };
        }
    }
}