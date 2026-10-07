
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateRouteConnectionRequestV1ConfigDiscriminatorProvider
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
    public static class CreateRouteConnectionRequestV1ConfigDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRouteConnectionRequestV1ConfigDiscriminatorProvider value)
        {
            return value switch
            {
                CreateRouteConnectionRequestV1ConfigDiscriminatorProvider.Anthropic => "ANTHROPIC",
                CreateRouteConnectionRequestV1ConfigDiscriminatorProvider.Openai => "OPENAI",
                CreateRouteConnectionRequestV1ConfigDiscriminatorProvider.Xai => "XAI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRouteConnectionRequestV1ConfigDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "ANTHROPIC" => CreateRouteConnectionRequestV1ConfigDiscriminatorProvider.Anthropic,
                "OPENAI" => CreateRouteConnectionRequestV1ConfigDiscriminatorProvider.Openai,
                "XAI" => CreateRouteConnectionRequestV1ConfigDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}