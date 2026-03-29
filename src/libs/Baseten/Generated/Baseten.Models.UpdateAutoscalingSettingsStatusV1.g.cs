
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The status of a request to update autoscaling settings.
    /// </summary>
    public enum UpdateAutoscalingSettingsStatusV1
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Unchanged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAutoscalingSettingsStatusV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAutoscalingSettingsStatusV1 value)
        {
            return value switch
            {
                UpdateAutoscalingSettingsStatusV1.Accepted => "ACCEPTED",
                UpdateAutoscalingSettingsStatusV1.Queued => "QUEUED",
                UpdateAutoscalingSettingsStatusV1.Unchanged => "UNCHANGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAutoscalingSettingsStatusV1? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => UpdateAutoscalingSettingsStatusV1.Accepted,
                "QUEUED" => UpdateAutoscalingSettingsStatusV1.Queued,
                "UNCHANGED" => UpdateAutoscalingSettingsStatusV1.Unchanged,
                _ => null,
            };
        }
    }
}