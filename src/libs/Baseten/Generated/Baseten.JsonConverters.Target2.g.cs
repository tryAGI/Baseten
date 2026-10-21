#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class Target2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.Target2>
    {
        /// <inheritdoc />
        public override global::Baseten.Target2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.CreateGridRouteRequestV1TargetDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.CreateGridRouteRequestV1TargetDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.CreateGridRouteRequestV1TargetDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1? basetenModelApi = default;
            if (discriminator?.Type == global::Baseten.CreateGridRouteRequestV1TargetDiscriminatorType.BasetenModelApi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1)}");
                basetenModelApi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.UpsertGridRouteTargetConnectionV1? connection = default;
            if (discriminator?.Type == global::Baseten.CreateGridRouteRequestV1TargetDiscriminatorType.Connection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpsertGridRouteTargetConnectionV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpsertGridRouteTargetConnectionV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.UpsertGridRouteTargetConnectionV1)}");
                connection = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.UpsertGridRouteTargetClassifierV1? classifier = default;
            if (discriminator?.Type == global::Baseten.CreateGridRouteRequestV1TargetDiscriminatorType.Classifier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpsertGridRouteTargetClassifierV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpsertGridRouteTargetClassifierV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.UpsertGridRouteTargetClassifierV1)}");
                classifier = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.Target2(
                discriminator?.Type,
                basetenModelApi,

                connection,

                classifier
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.Target2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBasetenModelApi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBasetenModelApi(), typeInfo);
            }
            else if (value.IsConnection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpsertGridRouteTargetConnectionV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpsertGridRouteTargetConnectionV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.UpsertGridRouteTargetConnectionV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConnection(), typeInfo);
            }
            else if (value.IsClassifier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpsertGridRouteTargetClassifierV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpsertGridRouteTargetClassifierV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.UpsertGridRouteTargetClassifierV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickClassifier(), typeInfo);
            }
        }
    }
}