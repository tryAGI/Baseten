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

            global::Baseten.RouteTargetConfigBasetenModelAPIV1? basetenModelApi = default;
            if (discriminator?.Type == global::Baseten.UpdateRouteRequestV1TargetVariant1DiscriminatorType.BasetenModelApi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetConfigBasetenModelAPIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetConfigBasetenModelAPIV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.RouteTargetConfigBasetenModelAPIV1)}");
                basetenModelApi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.RouteTargetConfigAnthropicV1? anthropic = default;
            if (discriminator?.Type == global::Baseten.UpdateRouteRequestV1TargetVariant1DiscriminatorType.Anthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetConfigAnthropicV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetConfigAnthropicV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.RouteTargetConfigAnthropicV1)}");
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.RouteTargetConfigOpenAIV1? openai = default;
            if (discriminator?.Type == global::Baseten.UpdateRouteRequestV1TargetVariant1DiscriminatorType.Openai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetConfigOpenAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetConfigOpenAIV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.RouteTargetConfigOpenAIV1)}");
                openai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.RouteTargetConfigXAIV1? xai = default;
            if (discriminator?.Type == global::Baseten.UpdateRouteRequestV1TargetVariant1DiscriminatorType.Xai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetConfigXAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetConfigXAIV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.RouteTargetConfigXAIV1)}");
                xai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.RouteTargetConfigClassifierModelBasedV1? classifierModelBased = default;
            if (discriminator?.Type == global::Baseten.UpdateRouteRequestV1TargetVariant1DiscriminatorType.ClassifierModelBased)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetConfigClassifierModelBasedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetConfigClassifierModelBasedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.RouteTargetConfigClassifierModelBasedV1)}");
                classifierModelBased = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.TargetVariant1(
                discriminator?.Type,
                basetenModelApi,

                anthropic,

                openai,

                xai,

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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetConfigBasetenModelAPIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetConfigBasetenModelAPIV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.RouteTargetConfigBasetenModelAPIV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBasetenModelApi(), typeInfo);
            }
            else if (value.IsAnthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetConfigAnthropicV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetConfigAnthropicV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.RouteTargetConfigAnthropicV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAnthropic(), typeInfo);
            }
            else if (value.IsOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetConfigOpenAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetConfigOpenAIV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.RouteTargetConfigOpenAIV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenai(), typeInfo);
            }
            else if (value.IsXai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetConfigXAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetConfigXAIV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.RouteTargetConfigXAIV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickXai(), typeInfo);
            }
            else if (value.IsClassifierModelBased)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetConfigClassifierModelBasedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetConfigClassifierModelBasedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.RouteTargetConfigClassifierModelBasedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickClassifierModelBased(), typeInfo);
            }
        }
    }
}