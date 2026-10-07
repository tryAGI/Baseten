
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum RouteConnectionV1ConfigDiscriminatorProvider
    {
        /// <summary>
        ///
        /// </summary>
        Anthropic,
        /// <summary>
        ///
        /// </summary>
        Openai,
        /// <summary>
        ///
        /// </summary>
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RouteConnectionV1ConfigDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RouteConnectionV1ConfigDiscriminatorProvider value)
        {
            return value switch
            {
                RouteConnectionV1ConfigDiscriminatorProvider.Anthropic => "ANTHROPIC",
                RouteConnectionV1ConfigDiscriminatorProvider.Openai => "OPENAI",
                RouteConnectionV1ConfigDiscriminatorProvider.Xai => "XAI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RouteConnectionV1ConfigDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "ANTHROPIC" => RouteConnectionV1ConfigDiscriminatorProvider.Anthropic,
                "OPENAI" => RouteConnectionV1ConfigDiscriminatorProvider.Openai,
                "XAI" => RouteConnectionV1ConfigDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}