
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum LibraryListingMetadataV1InputModalitie
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
    public static class LibraryListingMetadataV1InputModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LibraryListingMetadataV1InputModalitie value)
        {
            return value switch
            {
                LibraryListingMetadataV1InputModalitie.Audio => "audio",
                LibraryListingMetadataV1InputModalitie.Embedding => "embedding",
                LibraryListingMetadataV1InputModalitie.Image => "image",
                LibraryListingMetadataV1InputModalitie.Text => "text",
                LibraryListingMetadataV1InputModalitie.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LibraryListingMetadataV1InputModalitie? ToEnum(string value)
        {
            return value switch
            {
                "audio" => LibraryListingMetadataV1InputModalitie.Audio,
                "embedding" => LibraryListingMetadataV1InputModalitie.Embedding,
                "image" => LibraryListingMetadataV1InputModalitie.Image,
                "text" => LibraryListingMetadataV1InputModalitie.Text,
                "video" => LibraryListingMetadataV1InputModalitie.Video,
                _ => null,
            };
        }
    }
}