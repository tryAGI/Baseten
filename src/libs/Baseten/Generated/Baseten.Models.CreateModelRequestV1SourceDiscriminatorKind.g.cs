
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelRequestV1SourceDiscriminatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        LibraryListing,
        /// <summary>
        /// 
        /// </summary>
        ModelArchive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelRequestV1SourceDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelRequestV1SourceDiscriminatorKind value)
        {
            return value switch
            {
                CreateModelRequestV1SourceDiscriminatorKind.LibraryListing => "library_listing",
                CreateModelRequestV1SourceDiscriminatorKind.ModelArchive => "model_archive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelRequestV1SourceDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "library_listing" => CreateModelRequestV1SourceDiscriminatorKind.LibraryListing,
                "model_archive" => CreateModelRequestV1SourceDiscriminatorKind.ModelArchive,
                _ => null,
            };
        }
    }
}