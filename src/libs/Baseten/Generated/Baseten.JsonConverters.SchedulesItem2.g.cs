#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class SchedulesItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.SchedulesItem2>
    {
        /// <inheritdoc />
        public override global::Baseten.SchedulesItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.AutoscalingScheduleUpsertV1? daily = default;
            if (discriminator?.Cadence == global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence.Daily)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AutoscalingScheduleUpsertV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AutoscalingScheduleUpsertV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AutoscalingScheduleUpsertV1)}");
                daily = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.OneTimeAutoscalingScheduleUpsertV1? oneTime = default;
            if (discriminator?.Cadence == global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence.OneTime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.OneTimeAutoscalingScheduleUpsertV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.OneTimeAutoscalingScheduleUpsertV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.OneTimeAutoscalingScheduleUpsertV1)}");
                oneTime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.SchedulesItem2(
                discriminator?.Cadence,
                daily,

                oneTime
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.SchedulesItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDaily)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AutoscalingScheduleUpsertV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AutoscalingScheduleUpsertV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AutoscalingScheduleUpsertV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Daily!, typeInfo);
            }
            else if (value.IsOneTime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.OneTimeAutoscalingScheduleUpsertV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.OneTimeAutoscalingScheduleUpsertV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.OneTimeAutoscalingScheduleUpsertV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OneTime!, typeInfo);
            }
        }
    }
}