#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class CheckpointsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.CheckpointsItem>
    {
        /// <inheritdoc />
        public override global::Baseten.CheckpointsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.LoadCheckpointConfigCheckpointDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.LoadCheckpointConfigCheckpointDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.LoadCheckpointConfigCheckpointDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.BasetenLatestCheckpointConfig? basetenLatestCheckpoint = default;
            if (discriminator?.Typ == global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp.BasetenLatestCheckpoint)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.BasetenLatestCheckpointConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.BasetenLatestCheckpointConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.BasetenLatestCheckpointConfig)}");
                basetenLatestCheckpoint = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.BasetenNamedCheckpointConfig? basetenNamedCheckpoint = default;
            if (discriminator?.Typ == global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp.BasetenNamedCheckpoint)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.BasetenNamedCheckpointConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.BasetenNamedCheckpointConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.BasetenNamedCheckpointConfig)}");
                basetenNamedCheckpoint = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.CheckpointsItem(
                discriminator?.Typ,
                basetenLatestCheckpoint,

                basetenNamedCheckpoint
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.CheckpointsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBasetenLatestCheckpoint)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.BasetenLatestCheckpointConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.BasetenLatestCheckpointConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.BasetenLatestCheckpointConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BasetenLatestCheckpoint, typeInfo);
            }
            else if (value.IsBasetenNamedCheckpoint)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.BasetenNamedCheckpointConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.BasetenNamedCheckpointConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.BasetenNamedCheckpointConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BasetenNamedCheckpoint, typeInfo);
            }
        }
    }
}