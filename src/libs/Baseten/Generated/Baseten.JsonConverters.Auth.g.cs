#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class AuthJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.Auth>
    {
        /// <inheritdoc />
        public override global::Baseten.Auth Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridConnectionConfigBedrockV1AuthDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridConnectionConfigBedrockV1AuthDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.GridConnectionConfigBedrockV1AuthDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.GridConnectionBedrockApiKeyAuthV1? apiKey = default;
            if (discriminator?.Method == global::Baseten.GridConnectionConfigBedrockV1AuthDiscriminatorMethod.ApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridConnectionBedrockApiKeyAuthV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridConnectionBedrockApiKeyAuthV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.GridConnectionBedrockApiKeyAuthV1)}");
                apiKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.GridConnectionBedrockAccessKeysAuthV1? accessKeys = default;
            if (discriminator?.Method == global::Baseten.GridConnectionConfigBedrockV1AuthDiscriminatorMethod.AccessKeys)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridConnectionBedrockAccessKeysAuthV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridConnectionBedrockAccessKeysAuthV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.GridConnectionBedrockAccessKeysAuthV1)}");
                accessKeys = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.Auth(
                discriminator?.Method,
                apiKey,

                accessKeys
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.Auth value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridConnectionBedrockApiKeyAuthV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridConnectionBedrockApiKeyAuthV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.GridConnectionBedrockApiKeyAuthV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickApiKey(), typeInfo);
            }
            else if (value.IsAccessKeys)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.GridConnectionBedrockAccessKeysAuthV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.GridConnectionBedrockAccessKeysAuthV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.GridConnectionBedrockAccessKeysAuthV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAccessKeys(), typeInfo);
            }
        }
    }
}