
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Where a role is assigned.
    /// </summary>
    public enum AccessRoleKindV1
    {
        /// <summary>
        ///
        /// </summary>
        Membership,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessRoleKindV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessRoleKindV1 value)
        {
            return value switch
            {
                AccessRoleKindV1.Membership => "MEMBERSHIP",
                AccessRoleKindV1.Organization => "ORGANIZATION",
                AccessRoleKindV1.Team => "TEAM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessRoleKindV1? ToEnum(string value)
        {
            return value switch
            {
                "MEMBERSHIP" => AccessRoleKindV1.Membership,
                "ORGANIZATION" => AccessRoleKindV1.Organization,
                "TEAM" => AccessRoleKindV1.Team,
                _ => null,
            };
        }
    }
}