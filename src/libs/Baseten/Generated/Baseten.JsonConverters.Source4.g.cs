#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class Source4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.Source4>
    {
        /// <inheritdoc />
        public override global::Baseten.Source4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.LoopsCheckpointS3SourceV1? s3 = default;
            if (discriminator?.Kind == global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminatorKind.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.LoopsCheckpointS3SourceV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.LoopsCheckpointS3SourceV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.LoopsCheckpointS3SourceV1)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.LoopsCheckpointVolumeSourceV1? volume = default;
            if (discriminator?.Kind == global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminatorKind.Volume)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.LoopsCheckpointVolumeSourceV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.LoopsCheckpointVolumeSourceV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.LoopsCheckpointVolumeSourceV1)}");
                volume = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.Source4(
                discriminator?.Kind,
                s3,

                volume
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.Source4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.LoopsCheckpointS3SourceV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.LoopsCheckpointS3SourceV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.LoopsCheckpointS3SourceV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3!, typeInfo);
            }
            else if (value.IsVolume)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.LoopsCheckpointVolumeSourceV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.LoopsCheckpointVolumeSourceV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.LoopsCheckpointVolumeSourceV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Volume!, typeInfo);
            }
        }
    }
}