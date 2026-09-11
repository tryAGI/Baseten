
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum AuthMethod
    {
        /// <summary>
        ///
        /// </summary>
        AwsAssumeRole,
        /// <summary>
        ///
        /// </summary>
        AwsOidc,
        /// <summary>
        ///
        /// </summary>
        CustomSecret,
        /// <summary>
        ///
        /// </summary>
        GcpOidc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthMethod value)
        {
            return value switch
            {
                AuthMethod.AwsAssumeRole => "AWS_ASSUME_ROLE",
                AuthMethod.AwsOidc => "AWS_OIDC",
                AuthMethod.CustomSecret => "CUSTOM_SECRET",
                AuthMethod.GcpOidc => "GCP_OIDC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "AWS_ASSUME_ROLE" => AuthMethod.AwsAssumeRole,
                "AWS_OIDC" => AuthMethod.AwsOidc,
                "CUSTOM_SECRET" => AuthMethod.CustomSecret,
                "GCP_OIDC" => AuthMethod.GcpOidc,
                _ => null,
            };
        }
    }
}