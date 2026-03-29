
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1InteractiveSessionProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Cursor,
        /// <summary>
        /// 
        /// </summary>
        VsCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1InteractiveSessionProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1InteractiveSessionProvider value)
        {
            return value switch
            {
                V1InteractiveSessionProvider.Cursor => "cursor",
                V1InteractiveSessionProvider.VsCode => "vs_code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1InteractiveSessionProvider? ToEnum(string value)
        {
            return value switch
            {
                "cursor" => V1InteractiveSessionProvider.Cursor,
                "vs_code" => V1InteractiveSessionProvider.VsCode,
                _ => null,
            };
        }
    }
}