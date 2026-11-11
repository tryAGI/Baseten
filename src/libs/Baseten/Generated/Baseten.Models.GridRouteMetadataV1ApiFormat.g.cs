
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum GridRouteMetadataV1ApiFormat
    {
        /// <summary>
        ///
        /// </summary>
        ChatCompletions,
        /// <summary>
        ///
        /// </summary>
        Messages,
        /// <summary>
        ///
        /// </summary>
        Responses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GridRouteMetadataV1ApiFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GridRouteMetadataV1ApiFormat value)
        {
            return value switch
            {
                GridRouteMetadataV1ApiFormat.ChatCompletions => "chat_completions",
                GridRouteMetadataV1ApiFormat.Messages => "messages",
                GridRouteMetadataV1ApiFormat.Responses => "responses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GridRouteMetadataV1ApiFormat? ToEnum(string value)
        {
            return value switch
            {
                "chat_completions" => GridRouteMetadataV1ApiFormat.ChatCompletions,
                "messages" => GridRouteMetadataV1ApiFormat.Messages,
                "responses" => GridRouteMetadataV1ApiFormat.Responses,
                _ => null,
            };
        }
    }
}