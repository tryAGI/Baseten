
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Image processing status. Only BUILT images are ready to use.<br/>
    /// Included only in responses<br/>
    /// Example: BUILT
    /// </summary>
    public enum ImageStatusV1
    {
        /// <summary>
        ///
        /// </summary>
        Building,
        /// <summary>
        ///
        /// </summary>
        Built,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Uploading,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageStatusV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageStatusV1 value)
        {
            return value switch
            {
                ImageStatusV1.Building => "BUILDING",
                ImageStatusV1.Built => "BUILT",
                ImageStatusV1.Failed => "FAILED",
                ImageStatusV1.Uploading => "UPLOADING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageStatusV1? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => ImageStatusV1.Building,
                "BUILT" => ImageStatusV1.Built,
                "FAILED" => ImageStatusV1.Failed,
                "UPLOADING" => ImageStatusV1.Uploading,
                _ => null,
            };
        }
    }
}