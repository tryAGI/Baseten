#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class TargetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.Target>
    {
        /// <inheritdoc />
        public override global::Baseten.Target Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridRouteV1TargetDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridRouteV1TargetDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.GridRouteV1TargetDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.GridRouteTargetBasetenModelAPIV1? basetenModelApi = default;
            if (discriminator?.Type == global::Baseten.GridRouteV1TargetDiscriminatorType.BasetenModelApi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridRouteTargetBasetenModelAPIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridRouteTargetBasetenModelAPIV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.GridRouteTargetBasetenModelAPIV1)}");
                basetenModelApi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.GridRouteTargetConnectionV1? connection = default;
            if (discriminator?.Type == global::Baseten.GridRouteV1TargetDiscriminatorType.Connection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridRouteTargetConnectionV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridRouteTargetConnectionV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.GridRouteTargetConnectionV1)}");
                connection = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.GridRouteTargetClassifierV1? classifier = default;
            if (discriminator?.Type == global::Baseten.GridRouteV1TargetDiscriminatorType.Classifier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridRouteTargetClassifierV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridRouteTargetClassifierV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.GridRouteTargetClassifierV1)}");
                classifier = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.Target(
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
            global::Baseten.Target value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBasetenModelApi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridRouteTargetBasetenModelAPIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridRouteTargetBasetenModelAPIV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.GridRouteTargetBasetenModelAPIV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBasetenModelApi(), typeInfo);
            }
            else if (value.IsConnection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridRouteTargetConnectionV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridRouteTargetConnectionV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.GridRouteTargetConnectionV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConnection(), typeInfo);
            }
            else if (value.IsClassifier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridRouteTargetClassifierV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridRouteTargetClassifierV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.GridRouteTargetClassifierV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickClassifier(), typeInfo);
            }
        }
    }
}