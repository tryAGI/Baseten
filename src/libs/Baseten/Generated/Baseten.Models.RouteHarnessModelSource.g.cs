
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum RouteHarnessModelSource
    {
        /// <summary>
        ///
        /// </summary>
        Baseten,
        /// <summary>
        ///
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RouteHarnessModelSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RouteHarnessModelSource value)
        {
            return value switch
            {
                RouteHarnessModelSource.Baseten => "baseten",
                RouteHarnessModelSource.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RouteHarnessModelSource? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => RouteHarnessModelSource.Baseten,
                "team" => RouteHarnessModelSource.Team,
                _ => null,
            };
        }
    }
}