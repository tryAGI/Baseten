
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum LibraryListingModality
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
        /// <summary>
        ///
        /// </summary>
        Embedding,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Rerank,
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LibraryListingModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LibraryListingModality value)
        {
            return value switch
            {
                LibraryListingModality.Audio => "audio",
                LibraryListingModality.Embedding => "embedding",
                LibraryListingModality.Image => "image",
                LibraryListingModality.Rerank => "rerank",
                LibraryListingModality.Text => "text",
                LibraryListingModality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LibraryListingModality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => LibraryListingModality.Audio,
                "embedding" => LibraryListingModality.Embedding,
                "image" => LibraryListingModality.Image,
                "rerank" => LibraryListingModality.Rerank,
                "text" => LibraryListingModality.Text,
                "video" => LibraryListingModality.Video,
                _ => null,
            };
        }
    }
}