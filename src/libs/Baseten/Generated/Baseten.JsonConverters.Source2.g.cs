#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class Source2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.Source2>
    {
        /// <inheritdoc />
        public override global::Baseten.Source2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.VolumeSyncSourceHuggingFaceV1? huggingFace = default;
            if (discriminator?.Type == global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminatorType.HuggingFace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.VolumeSyncSourceHuggingFaceV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.VolumeSyncSourceHuggingFaceV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.VolumeSyncSourceHuggingFaceV1)}");
                huggingFace = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.VolumeSyncSourceS3V1? s3 = default;
            if (discriminator?.Type == global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminatorType.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.VolumeSyncSourceS3V1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.VolumeSyncSourceS3V1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.VolumeSyncSourceS3V1)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.VolumeSyncSourceGCSV1? gcs = default;
            if (discriminator?.Type == global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminatorType.Gcs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.VolumeSyncSourceGCSV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.VolumeSyncSourceGCSV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.VolumeSyncSourceGCSV1)}");
                gcs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.VolumeSyncSourceAzureV1? azure = default;
            if (discriminator?.Type == global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminatorType.Azure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.VolumeSyncSourceAzureV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.VolumeSyncSourceAzureV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.VolumeSyncSourceAzureV1)}");
                azure = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.VolumeSyncSourceR2V1? r2 = default;
            if (discriminator?.Type == global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminatorType.R2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.VolumeSyncSourceR2V1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.VolumeSyncSourceR2V1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.VolumeSyncSourceR2V1)}");
                r2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.VolumeSyncSourceCoreWeaveV1? coreweave = default;
            if (discriminator?.Type == global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminatorType.Coreweave)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.VolumeSyncSourceCoreWeaveV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.VolumeSyncSourceCoreWeaveV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.VolumeSyncSourceCoreWeaveV1)}");
                coreweave = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.VolumeSyncSourceBasetenTrainingV1? basetenTraining = default;
            if (discriminator?.Type == global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminatorType.BasetenTraining)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.VolumeSyncSourceBasetenTrainingV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.VolumeSyncSourceBasetenTrainingV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.VolumeSyncSourceBasetenTrainingV1)}");
                basetenTraining = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.Source2(
                discriminator?.Type,
                huggingFace,

                s3,

                gcs,

                azure,

                r2,

                coreweave,

                basetenTraining
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.Source2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsHuggingFace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.VolumeSyncSourceHuggingFaceV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.VolumeSyncSourceHuggingFaceV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.VolumeSyncSourceHuggingFaceV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HuggingFace!, typeInfo);
            }
            else if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.VolumeSyncSourceS3V1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.VolumeSyncSourceS3V1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.VolumeSyncSourceS3V1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3!, typeInfo);
            }
            else if (value.IsGcs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.VolumeSyncSourceGCSV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.VolumeSyncSourceGCSV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.VolumeSyncSourceGCSV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gcs!, typeInfo);
            }
            else if (value.IsAzure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.VolumeSyncSourceAzureV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.VolumeSyncSourceAzureV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.VolumeSyncSourceAzureV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Azure!, typeInfo);
            }
            else if (value.IsR2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.VolumeSyncSourceR2V1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.VolumeSyncSourceR2V1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.VolumeSyncSourceR2V1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.R2!, typeInfo);
            }
            else if (value.IsCoreweave)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.VolumeSyncSourceCoreWeaveV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.VolumeSyncSourceCoreWeaveV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.VolumeSyncSourceCoreWeaveV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Coreweave!, typeInfo);
            }
            else if (value.IsBasetenTraining)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.VolumeSyncSourceBasetenTrainingV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.VolumeSyncSourceBasetenTrainingV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.VolumeSyncSourceBasetenTrainingV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BasetenTraining!, typeInfo);
            }
        }
    }
}