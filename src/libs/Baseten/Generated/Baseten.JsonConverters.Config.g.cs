#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class ConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.Config>
    {
        /// <inheritdoc />
        public override global::Baseten.Config Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridConnectionV1ConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridConnectionV1ConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.GridConnectionV1ConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.GridConnectionConfigAnthropicV1? anthropic = default;
            if (discriminator?.Provider == global::Baseten.GridConnectionV1ConfigDiscriminatorProvider.Anthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridConnectionConfigAnthropicV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridConnectionConfigAnthropicV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.GridConnectionConfigAnthropicV1)}");
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.GridConnectionConfigOpenAIV1? openai = default;
            if (discriminator?.Provider == global::Baseten.GridConnectionV1ConfigDiscriminatorProvider.Openai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridConnectionConfigOpenAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridConnectionConfigOpenAIV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.GridConnectionConfigOpenAIV1)}");
                openai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.GridConnectionConfigXAIV1? xai = default;
            if (discriminator?.Provider == global::Baseten.GridConnectionV1ConfigDiscriminatorProvider.Xai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridConnectionConfigXAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridConnectionConfigXAIV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.GridConnectionConfigXAIV1)}");
                xai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.GridConnectionConfigVertexV1? vertex = default;
            if (discriminator?.Provider == global::Baseten.GridConnectionV1ConfigDiscriminatorProvider.Vertex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridConnectionConfigVertexV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridConnectionConfigVertexV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.GridConnectionConfigVertexV1)}");
                vertex = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.Config(
                discriminator?.Provider,
                anthropic,

                openai,

                xai,

                vertex
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.Config value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAnthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridConnectionConfigAnthropicV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridConnectionConfigAnthropicV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.GridConnectionConfigAnthropicV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAnthropic(), typeInfo);
            }
            else if (value.IsOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridConnectionConfigOpenAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridConnectionConfigOpenAIV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.GridConnectionConfigOpenAIV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenai(), typeInfo);
            }
            else if (value.IsXai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridConnectionConfigXAIV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridConnectionConfigXAIV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.GridConnectionConfigXAIV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickXai(), typeInfo);
            }
            else if (value.IsVertex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridConnectionConfigVertexV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridConnectionConfigVertexV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.GridConnectionConfigVertexV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickVertex(), typeInfo);
            }
        }
    }
}