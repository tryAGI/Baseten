#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class SandboxV1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.SandboxV1>
    {
        /// <inheritdoc />
        public override global::Baseten.SandboxV1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Baseten.SandboxConfigurationV1? configuration = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.SandboxConfigurationV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.SandboxConfigurationV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.SandboxConfigurationV1).Name}");
                configuration = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Baseten.SandboxV1Variant2? sandboxV1Variant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.SandboxV1Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.SandboxV1Variant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.SandboxV1Variant2).Name}");
                sandboxV1Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Baseten.SandboxV1(
                configuration,

                sandboxV1Variant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.SandboxV1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsConfiguration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.SandboxConfigurationV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.SandboxConfigurationV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.SandboxConfigurationV1).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.PickConfiguration(), typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsSandboxV1Variant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.SandboxV1Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.SandboxV1Variant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.SandboxV1Variant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.PickSandboxV1Variant2(), typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}