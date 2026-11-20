
#nullable enable

namespace Baseten
{
    /// <summary>
    /// How a role is held.
    /// </summary>
    public enum AccessGrantedViaV1
    {
        /// <summary>
        ///
        /// </summary>
        Assignment,
        /// <summary>
        ///
        /// </summary>
        Membership,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessGrantedViaV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessGrantedViaV1 value)
        {
            return value switch
            {
                AccessGrantedViaV1.Assignment => "ASSIGNMENT",
                AccessGrantedViaV1.Membership => "MEMBERSHIP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessGrantedViaV1? ToEnum(string value)
        {
            return value switch
            {
                "ASSIGNMENT" => AccessGrantedViaV1.Assignment,
                "MEMBERSHIP" => AccessGrantedViaV1.Membership,
                _ => null,
            };
        }
    }
}