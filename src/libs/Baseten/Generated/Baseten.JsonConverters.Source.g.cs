#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class SourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.Source>
    {
        /// <inheritdoc />
        public override global::Baseten.Source Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.CreateModelRequestV1SourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.CreateModelRequestV1SourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.CreateModelRequestV1SourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.LibraryListingSourceV1? libraryListing = default;
            if (discriminator?.Kind == global::Baseten.CreateModelRequestV1SourceDiscriminatorKind.LibraryListing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.LibraryListingSourceV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.LibraryListingSourceV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.LibraryListingSourceV1)}");
                libraryListing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.ModelArchiveSourceV1? modelArchive = default;
            if (discriminator?.Kind == global::Baseten.CreateModelRequestV1SourceDiscriminatorKind.ModelArchive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.ModelArchiveSourceV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.ModelArchiveSourceV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.ModelArchiveSourceV1)}");
                modelArchive = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.Source(
                discriminator?.Kind,
                libraryListing,

                modelArchive
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.Source value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLibraryListing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.LibraryListingSourceV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.LibraryListingSourceV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.LibraryListingSourceV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LibraryListing!, typeInfo);
            }
            else if (value.IsModelArchive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.ModelArchiveSourceV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.ModelArchiveSourceV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.ModelArchiveSourceV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelArchive!, typeInfo);
            }
        }
    }
}