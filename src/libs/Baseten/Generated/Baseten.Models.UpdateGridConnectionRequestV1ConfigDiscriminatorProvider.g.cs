
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateGridConnectionRequestV1ConfigDiscriminatorProvider
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
        Vertex,
        /// <summary>
        ///
        /// </summary>
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGridConnectionRequestV1ConfigDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGridConnectionRequestV1ConfigDiscriminatorProvider value)
        {
            return value switch
            {
                UpdateGridConnectionRequestV1ConfigDiscriminatorProvider.Anthropic => "ANTHROPIC",
                UpdateGridConnectionRequestV1ConfigDiscriminatorProvider.Openai => "OPENAI",
                UpdateGridConnectionRequestV1ConfigDiscriminatorProvider.Vertex => "VERTEX",
                UpdateGridConnectionRequestV1ConfigDiscriminatorProvider.Xai => "XAI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGridConnectionRequestV1ConfigDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "ANTHROPIC" => UpdateGridConnectionRequestV1ConfigDiscriminatorProvider.Anthropic,
                "OPENAI" => UpdateGridConnectionRequestV1ConfigDiscriminatorProvider.Openai,
                "VERTEX" => UpdateGridConnectionRequestV1ConfigDiscriminatorProvider.Vertex,
                "XAI" => UpdateGridConnectionRequestV1ConfigDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}