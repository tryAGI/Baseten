
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestBackpressurePolicyV1
    {
        /// <summary>
        /// 
        /// </summary>
        QueueOnFull,
        /// <summary>
        /// 
        /// </summary>
        RejectOnFull,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestBackpressurePolicyV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestBackpressurePolicyV1 value)
        {
            return value switch
            {
                RequestBackpressurePolicyV1.QueueOnFull => "queue_on_full",
                RequestBackpressurePolicyV1.RejectOnFull => "reject_on_full",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestBackpressurePolicyV1? ToEnum(string value)
        {
            return value switch
            {
                "queue_on_full" => RequestBackpressurePolicyV1.QueueOnFull,
                "reject_on_full" => RequestBackpressurePolicyV1.RejectOnFull,
                _ => null,
            };
        }
    }
}