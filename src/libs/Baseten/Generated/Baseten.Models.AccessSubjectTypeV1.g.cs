
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Who holds a role.
    /// </summary>
    public enum AccessSubjectTypeV1
    {
        /// <summary>
        ///
        /// </summary>
        DirectoryGroup,
        /// <summary>
        ///
        /// </summary>
        ServiceAccount,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessSubjectTypeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessSubjectTypeV1 value)
        {
            return value switch
            {
                AccessSubjectTypeV1.DirectoryGroup => "DIRECTORY_GROUP",
                AccessSubjectTypeV1.ServiceAccount => "SERVICE_ACCOUNT",
                AccessSubjectTypeV1.User => "USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessSubjectTypeV1? ToEnum(string value)
        {
            return value switch
            {
                "DIRECTORY_GROUP" => AccessSubjectTypeV1.DirectoryGroup,
                "SERVICE_ACCOUNT" => AccessSubjectTypeV1.ServiceAccount,
                "USER" => AccessSubjectTypeV1.User,
                _ => null,
            };
        }
    }
}