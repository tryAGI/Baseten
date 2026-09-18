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
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteV1TargetDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteV1TargetDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.RouteV1TargetDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.RouteTargetBasetenModelAPIV1? basetenModelApi = default;
            if (discriminator?.Type == global::Baseten.RouteV1TargetDiscriminatorType.BasetenModelApi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetBasetenModelAPIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetBasetenModelAPIV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.RouteTargetBasetenModelAPIV1)}");
                basetenModelApi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.RouteTargetAnthropicV1? anthropic = default;
            if (discriminator?.Type == global::Baseten.RouteV1TargetDiscriminatorType.Anthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetAnthropicV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetAnthropicV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.RouteTargetAnthropicV1)}");
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.RouteTargetOpenAIV1? openai = default;
            if (discriminator?.Type == global::Baseten.RouteV1TargetDiscriminatorType.Openai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetOpenAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetOpenAIV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.RouteTargetOpenAIV1)}");
                openai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.RouteTargetXAIV1? xai = default;
            if (discriminator?.Type == global::Baseten.RouteV1TargetDiscriminatorType.Xai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetXAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetXAIV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.RouteTargetXAIV1)}");
                xai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.RouteTargetVertexV1? vertex = default;
            if (discriminator?.Type == global::Baseten.RouteV1TargetDiscriminatorType.Vertex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetVertexV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetVertexV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.RouteTargetVertexV1)}");
                vertex = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.RouteTargetOpenAICompatibleV1? openaiCompatible = default;
            if (discriminator?.Type == global::Baseten.RouteV1TargetDiscriminatorType.OpenaiCompatible)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetOpenAICompatibleV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetOpenAICompatibleV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.RouteTargetOpenAICompatibleV1)}");
                openaiCompatible = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.Target(
                discriminator?.Type,
                basetenModelApi,

                anthropic,

                openai,

                xai,

                vertex,

                openaiCompatible
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetBasetenModelAPIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetBasetenModelAPIV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.RouteTargetBasetenModelAPIV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BasetenModelApi!, typeInfo);
            }
            else if (value.IsAnthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetAnthropicV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetAnthropicV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.RouteTargetAnthropicV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anthropic!, typeInfo);
            }
            else if (value.IsOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetOpenAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetOpenAIV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.RouteTargetOpenAIV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openai!, typeInfo);
            }
            else if (value.IsXai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetXAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetXAIV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.RouteTargetXAIV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Xai!, typeInfo);
            }
            else if (value.IsVertex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetVertexV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetVertexV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.RouteTargetVertexV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vertex!, typeInfo);
            }
            else if (value.IsOpenaiCompatible)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.RouteTargetOpenAICompatibleV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.RouteTargetOpenAICompatibleV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.RouteTargetOpenAICompatibleV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenaiCompatible!, typeInfo);
            }
        }
    }
}