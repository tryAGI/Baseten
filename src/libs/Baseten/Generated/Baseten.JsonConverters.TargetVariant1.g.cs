#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class TargetVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.TargetVariant1>
    {
        /// <inheritdoc />
        public override global::Baseten.TargetVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpdateRouteRequestV1TargetVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpdateRouteRequestV1TargetVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.UpdateRouteRequestV1TargetVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.UpsertRouteTargetBasetenModelAPIV1? basetenModelApi = default;
            if (discriminator?.Type == global::Baseten.UpdateRouteRequestV1TargetVariant1DiscriminatorType.BasetenModelApi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpsertRouteTargetBasetenModelAPIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpsertRouteTargetBasetenModelAPIV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.UpsertRouteTargetBasetenModelAPIV1)}");
                basetenModelApi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.UpsertRouteTargetConnectionV1? connection = default;
            if (discriminator?.Type == global::Baseten.UpdateRouteRequestV1TargetVariant1DiscriminatorType.Connection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpsertRouteTargetConnectionV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpsertRouteTargetConnectionV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.UpsertRouteTargetConnectionV1)}");
                connection = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.UpsertRouteTargetClassifierModelBasedV1? classifierModelBased = default;
            if (discriminator?.Type == global::Baseten.UpdateRouteRequestV1TargetVariant1DiscriminatorType.ClassifierModelBased)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpsertRouteTargetClassifierModelBasedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpsertRouteTargetClassifierModelBasedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.UpsertRouteTargetClassifierModelBasedV1)}");
                classifierModelBased = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.TargetVariant1(
                discriminator?.Type,
                basetenModelApi,

                connection,

                classifierModelBased
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.TargetVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBasetenModelApi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpsertRouteTargetBasetenModelAPIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpsertRouteTargetBasetenModelAPIV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.UpsertRouteTargetBasetenModelAPIV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBasetenModelApi(), typeInfo);
            }
            else if (value.IsConnection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpsertRouteTargetConnectionV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpsertRouteTargetConnectionV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.UpsertRouteTargetConnectionV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConnection(), typeInfo);
            }
            else if (value.IsClassifierModelBased)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpsertRouteTargetClassifierModelBasedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpsertRouteTargetClassifierModelBasedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.UpsertRouteTargetClassifierModelBasedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickClassifierModelBased(), typeInfo);
            }
        }
    }
}