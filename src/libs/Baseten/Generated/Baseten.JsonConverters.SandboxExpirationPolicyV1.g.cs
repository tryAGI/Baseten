#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class SandboxExpirationPolicyV1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.SandboxExpirationPolicyV1>
    {
        /// <inheritdoc />
        public override global::Baseten.SandboxExpirationPolicyV1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.SandboxExpirationPolicyV1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.SandboxExpirationPolicyV1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.SandboxExpirationPolicyV1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.SandboxTTLIdleExpirationPolicyV1? ttlIdle = default;
            if (discriminator?.Type == global::Baseten.SandboxExpirationPolicyV1DiscriminatorType.TtlIdle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.SandboxTTLIdleExpirationPolicyV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.SandboxTTLIdleExpirationPolicyV1)}");
                ttlIdle = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1? ttlMaxAge = default;
            if (discriminator?.Type == global::Baseten.SandboxExpirationPolicyV1DiscriminatorType.TtlMaxAge)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1)}");
                ttlMaxAge = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.SandboxDateExpirationPolicyV1? date = default;
            if (discriminator?.Type == global::Baseten.SandboxExpirationPolicyV1DiscriminatorType.Date)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.SandboxDateExpirationPolicyV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.SandboxDateExpirationPolicyV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.SandboxDateExpirationPolicyV1)}");
                date = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.SandboxExpirationPolicyV1(
                discriminator?.Type,
                ttlIdle,

                ttlMaxAge,

                date
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.SandboxExpirationPolicyV1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTtlIdle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.SandboxTTLIdleExpirationPolicyV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTtlIdle(), typeInfo);
            }
            else if (value.IsTtlMaxAge)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTtlMaxAge(), typeInfo);
            }
            else if (value.IsDate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.SandboxDateExpirationPolicyV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.SandboxDateExpirationPolicyV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.SandboxDateExpirationPolicyV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDate(), typeInfo);
            }
        }
    }
}