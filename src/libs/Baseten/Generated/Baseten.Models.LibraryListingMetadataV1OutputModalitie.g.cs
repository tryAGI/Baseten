
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
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
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
                LibraryListingMetadataV1OutputModalitie.Image => "image",
                LibraryListingMetadataV1OutputModalitie.Text => "text",
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
                "image" => LibraryListingMetadataV1OutputModalitie.Image,
                "text" => LibraryListingMetadataV1OutputModalitie.Text,
                _ => null,
            };
        }
    }
}