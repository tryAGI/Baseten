
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum GridConnectionV1ConfigDiscriminatorProvider
    {
        /// <summary>
        ///
        /// </summary>
        Anthropic,
        /// <summary>
        ///
        /// </summary>
        Azure,
        /// <summary>
        ///
        /// </summary>
        Bedrock,
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
    public static class GridConnectionV1ConfigDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GridConnectionV1ConfigDiscriminatorProvider value)
        {
            return value switch
            {
                GridConnectionV1ConfigDiscriminatorProvider.Anthropic => "ANTHROPIC",
                GridConnectionV1ConfigDiscriminatorProvider.Azure => "AZURE",
                GridConnectionV1ConfigDiscriminatorProvider.Bedrock => "BEDROCK",
                GridConnectionV1ConfigDiscriminatorProvider.Openai => "OPENAI",
                GridConnectionV1ConfigDiscriminatorProvider.Vertex => "VERTEX",
                GridConnectionV1ConfigDiscriminatorProvider.Xai => "XAI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GridConnectionV1ConfigDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "ANTHROPIC" => GridConnectionV1ConfigDiscriminatorProvider.Anthropic,
                "AZURE" => GridConnectionV1ConfigDiscriminatorProvider.Azure,
                "BEDROCK" => GridConnectionV1ConfigDiscriminatorProvider.Bedrock,
                "OPENAI" => GridConnectionV1ConfigDiscriminatorProvider.Openai,
                "VERTEX" => GridConnectionV1ConfigDiscriminatorProvider.Vertex,
                "XAI" => GridConnectionV1ConfigDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}