
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Capacity guarantee under which a training job is scheduled.<br/>
    /// ``DEDICATED`` is on-demand capacity that is not preempted (the default). ``SPOT`` is<br/>
    /// interruptible capacity that may be preempted; the user is responsible for checkpointing<br/>
    /// their own progress. A managed/resumable model where the platform handles<br/>
    /// checkpoint/resume on its own is intentionally not defined yet; it is planned for a<br/>
    /// future milestone.
    /// </summary>
    public enum V1AvailabilityModel
    {
        /// <summary>
        /// 
        /// </summary>
        Dedicated,
        /// <summary>
        /// 
        /// </summary>
        Spot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1AvailabilityModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1AvailabilityModel value)
        {
            return value switch
            {
                V1AvailabilityModel.Dedicated => "dedicated",
                V1AvailabilityModel.Spot => "spot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1AvailabilityModel? ToEnum(string value)
        {
            return value switch
            {
                "dedicated" => V1AvailabilityModel.Dedicated,
                "spot" => V1AvailabilityModel.Spot,
                _ => null,
            };
        }
    }
}