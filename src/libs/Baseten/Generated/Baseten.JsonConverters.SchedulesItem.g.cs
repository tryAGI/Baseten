#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class SchedulesItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.SchedulesItem>
    {
        /// <inheritdoc />
        public override global::Baseten.SchedulesItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.AutoscalingScheduleV1? daily = default;
            if (discriminator?.Cadence == global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence.Daily)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AutoscalingScheduleV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AutoscalingScheduleV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AutoscalingScheduleV1)}");
                daily = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.OneTimeAutoscalingScheduleV1? oneTime = default;
            if (discriminator?.Cadence == global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence.OneTime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.OneTimeAutoscalingScheduleV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.OneTimeAutoscalingScheduleV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.OneTimeAutoscalingScheduleV1)}");
                oneTime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.SchedulesItem(
                discriminator?.Cadence,
                daily,

                oneTime
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.SchedulesItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDaily)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AutoscalingScheduleV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AutoscalingScheduleV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AutoscalingScheduleV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Daily!, typeInfo);
            }
            else if (value.IsOneTime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.OneTimeAutoscalingScheduleV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.OneTimeAutoscalingScheduleV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.OneTimeAutoscalingScheduleV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OneTime!, typeInfo);
            }
        }
    }
}