
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateGridConnectionRequestV1ConfigDiscriminatorProvider
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
    public static class CreateGridConnectionRequestV1ConfigDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGridConnectionRequestV1ConfigDiscriminatorProvider value)
        {
            return value switch
            {
                CreateGridConnectionRequestV1ConfigDiscriminatorProvider.Anthropic => "ANTHROPIC",
                CreateGridConnectionRequestV1ConfigDiscriminatorProvider.Openai => "OPENAI",
                CreateGridConnectionRequestV1ConfigDiscriminatorProvider.Xai => "XAI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGridConnectionRequestV1ConfigDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "ANTHROPIC" => CreateGridConnectionRequestV1ConfigDiscriminatorProvider.Anthropic,
                "OPENAI" => CreateGridConnectionRequestV1ConfigDiscriminatorProvider.Openai,
                "XAI" => CreateGridConnectionRequestV1ConfigDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}