#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class SandboxImageV1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.SandboxImageV1>
    {
        /// <inheritdoc />
        public override global::Baseten.SandboxImageV1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Baseten.SandboxImageSummaryV1? summary = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.SandboxImageSummaryV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.SandboxImageSummaryV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.SandboxImageSummaryV1).Name}");
                summary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Baseten.SandboxImageV1Variant2? sandboxImageV1Variant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.SandboxImageV1Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.SandboxImageV1Variant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.SandboxImageV1Variant2).Name}");
                sandboxImageV1Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Baseten.SandboxImageV1(
                summary,

                sandboxImageV1Variant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.SandboxImageV1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsSummary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.SandboxImageSummaryV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.SandboxImageSummaryV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.SandboxImageSummaryV1).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.PickSummary(), typeInfo);
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
            if (value.IsSandboxImageV1Variant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.SandboxImageV1Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.SandboxImageV1Variant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.SandboxImageV1Variant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.PickSandboxImageV1Variant2(), typeInfo);
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