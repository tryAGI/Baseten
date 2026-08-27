
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum LibraryListingMetadataV1OutputModalitie
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
        Text,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LibraryListingMetadataV1OutputModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LibraryListingMetadataV1OutputModalitie value)
        {
            return value switch
            {
                LibraryListingMetadataV1OutputModalitie.Audio => "audio",
                LibraryListingMetadataV1OutputModalitie.Embedding => "embedding",
                LibraryListingMetadataV1OutputModalitie.Image => "image",
                LibraryListingMetadataV1OutputModalitie.Text => "text",
                LibraryListingMetadataV1OutputModalitie.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LibraryListingMetadataV1OutputModalitie? ToEnum(string value)
        {
            return value switch
            {
                "audio" => LibraryListingMetadataV1OutputModalitie.Audio,
                "embedding" => LibraryListingMetadataV1OutputModalitie.Embedding,
                "image" => LibraryListingMetadataV1OutputModalitie.Image,
                "text" => LibraryListingMetadataV1OutputModalitie.Text,
                "video" => LibraryListingMetadataV1OutputModalitie.Video,
                _ => null,
            };
        }
    }
}