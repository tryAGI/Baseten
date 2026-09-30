#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class UpdateRouteHarnessConfigRequestV1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.UpdateRouteHarnessConfigRequestV1>
    {
        /// <inheritdoc />
        public override global::Baseten.UpdateRouteHarnessConfigRequestV1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpdateRouteHarnessConfigRequestV1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpdateRouteHarnessConfigRequestV1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.UpdateRouteHarnessConfigRequestV1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.UpdateClaudeCodeHarnessConfigV1? claudeCode = default;
            if (discriminator?.Harness == global::Baseten.UpdateRouteHarnessConfigRequestV1DiscriminatorHarness.ClaudeCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpdateClaudeCodeHarnessConfigV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpdateClaudeCodeHarnessConfigV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.UpdateClaudeCodeHarnessConfigV1)}");
                claudeCode = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.UpdateOpenCodeHarnessConfigV1? opencode = default;
            if (discriminator?.Harness == global::Baseten.UpdateRouteHarnessConfigRequestV1DiscriminatorHarness.Opencode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpdateOpenCodeHarnessConfigV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpdateOpenCodeHarnessConfigV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.UpdateOpenCodeHarnessConfigV1)}");
                opencode = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.UpdateCodexHarnessConfigV1? codex = default;
            if (discriminator?.Harness == global::Baseten.UpdateRouteHarnessConfigRequestV1DiscriminatorHarness.Codex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpdateCodexHarnessConfigV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpdateCodexHarnessConfigV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.UpdateCodexHarnessConfigV1)}");
                codex = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.UpdateRouteHarnessConfigRequestV1(
                discriminator?.Harness,
                claudeCode,

                opencode,

                codex
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.UpdateRouteHarnessConfigRequestV1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsClaudeCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpdateClaudeCodeHarnessConfigV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpdateClaudeCodeHarnessConfigV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.UpdateClaudeCodeHarnessConfigV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickClaudeCode(), typeInfo);
            }
            else if (value.IsOpencode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpdateOpenCodeHarnessConfigV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpdateOpenCodeHarnessConfigV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.UpdateOpenCodeHarnessConfigV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpencode(), typeInfo);
            }
            else if (value.IsCodex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpdateCodexHarnessConfigV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpdateCodexHarnessConfigV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.UpdateCodexHarnessConfigV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCodex(), typeInfo);
            }
        }
    }
}