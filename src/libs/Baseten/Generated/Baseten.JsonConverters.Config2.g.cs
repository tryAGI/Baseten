#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class Config2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.Config2>
    {
        /// <inheritdoc />
        public override global::Baseten.Config2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.CreateRouteConnectionRequestV1ConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.CreateRouteConnectionRequestV1ConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.CreateRouteConnectionRequestV1ConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.RouteConnectionConfigAnthropicV1? anthropic = default;
            if (discriminator?.Provider == global::Baseten.CreateRouteConnectionRequestV1ConfigDiscriminatorProvider.Anthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteConnectionConfigAnthropicV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteConnectionConfigAnthropicV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.RouteConnectionConfigAnthropicV1)}");
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.RouteConnectionConfigOpenAIV1? openai = default;
            if (discriminator?.Provider == global::Baseten.CreateRouteConnectionRequestV1ConfigDiscriminatorProvider.Openai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteConnectionConfigOpenAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteConnectionConfigOpenAIV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.RouteConnectionConfigOpenAIV1)}");
                openai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.RouteConnectionConfigXAIV1? xai = default;
            if (discriminator?.Provider == global::Baseten.CreateRouteConnectionRequestV1ConfigDiscriminatorProvider.Xai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteConnectionConfigXAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteConnectionConfigXAIV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.RouteConnectionConfigXAIV1)}");
                xai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.Config2(
                discriminator?.Provider,
                anthropic,

                openai,

                xai
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.Config2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAnthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteConnectionConfigAnthropicV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteConnectionConfigAnthropicV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.RouteConnectionConfigAnthropicV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAnthropic(), typeInfo);
            }
            else if (value.IsOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteConnectionConfigOpenAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteConnectionConfigOpenAIV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.RouteConnectionConfigOpenAIV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenai(), typeInfo);
            }
            else if (value.IsXai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteConnectionConfigXAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteConnectionConfigXAIV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.RouteConnectionConfigXAIV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickXai(), typeInfo);
            }
        }
    }
}