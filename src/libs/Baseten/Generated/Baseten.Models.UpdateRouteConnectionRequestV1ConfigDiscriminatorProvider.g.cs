
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateRouteConnectionRequestV1ConfigDiscriminatorProvider
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
    public static class UpdateRouteConnectionRequestV1ConfigDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRouteConnectionRequestV1ConfigDiscriminatorProvider value)
        {
            return value switch
            {
                UpdateRouteConnectionRequestV1ConfigDiscriminatorProvider.Anthropic => "ANTHROPIC",
                UpdateRouteConnectionRequestV1ConfigDiscriminatorProvider.Openai => "OPENAI",
                UpdateRouteConnectionRequestV1ConfigDiscriminatorProvider.Xai => "XAI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRouteConnectionRequestV1ConfigDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "ANTHROPIC" => UpdateRouteConnectionRequestV1ConfigDiscriminatorProvider.Anthropic,
                "OPENAI" => UpdateRouteConnectionRequestV1ConfigDiscriminatorProvider.Openai,
                "XAI" => UpdateRouteConnectionRequestV1ConfigDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}