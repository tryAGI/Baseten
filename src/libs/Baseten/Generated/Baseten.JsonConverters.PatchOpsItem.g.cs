#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class PatchOpsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.PatchOpsItem>
    {
        /// <inheritdoc />
        public override global::Baseten.PatchOpsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.DeploymentPatchOpModelCodeV1? modelCode = default;
            if (discriminator?.Type == global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.ModelCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.DeploymentPatchOpModelCodeV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.DeploymentPatchOpModelCodeV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.DeploymentPatchOpModelCodeV1)}");
                modelCode = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.DeploymentPatchOpPackageV1? package = default;
            if (discriminator?.Type == global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.Package)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.DeploymentPatchOpPackageV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.DeploymentPatchOpPackageV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.DeploymentPatchOpPackageV1)}");
                package = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.DeploymentPatchOpConfigV1? config = default;
            if (discriminator?.Type == global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.Config)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.DeploymentPatchOpConfigV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.DeploymentPatchOpConfigV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.DeploymentPatchOpConfigV1)}");
                config = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.DeploymentPatchOpPythonRequirementV1? pythonRequirement = default;
            if (discriminator?.Type == global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.PythonRequirement)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.DeploymentPatchOpPythonRequirementV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.DeploymentPatchOpPythonRequirementV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.DeploymentPatchOpPythonRequirementV1)}");
                pythonRequirement = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.DeploymentPatchOpEnvVarV1? environmentVariable = default;
            if (discriminator?.Type == global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.EnvironmentVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.DeploymentPatchOpEnvVarV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.DeploymentPatchOpEnvVarV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.DeploymentPatchOpEnvVarV1)}");
                environmentVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.DeploymentPatchOpExternalDataV1? externalData = default;
            if (discriminator?.Type == global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.ExternalData)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.DeploymentPatchOpExternalDataV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.DeploymentPatchOpExternalDataV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.DeploymentPatchOpExternalDataV1)}");
                externalData = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.PatchOpsItem(
                discriminator?.Type,
                modelCode,

                package,

                config,

                pythonRequirement,

                environmentVariable,

                externalData
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.PatchOpsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsModelCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.DeploymentPatchOpModelCodeV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.DeploymentPatchOpModelCodeV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.DeploymentPatchOpModelCodeV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelCode!, typeInfo);
            }
            else if (value.IsPackage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.DeploymentPatchOpPackageV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.DeploymentPatchOpPackageV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.DeploymentPatchOpPackageV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Package!, typeInfo);
            }
            else if (value.IsConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.DeploymentPatchOpConfigV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.DeploymentPatchOpConfigV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.DeploymentPatchOpConfigV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Config!, typeInfo);
            }
            else if (value.IsPythonRequirement)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.DeploymentPatchOpPythonRequirementV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.DeploymentPatchOpPythonRequirementV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.DeploymentPatchOpPythonRequirementV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PythonRequirement!, typeInfo);
            }
            else if (value.IsEnvironmentVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.DeploymentPatchOpEnvVarV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.DeploymentPatchOpEnvVarV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.DeploymentPatchOpEnvVarV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EnvironmentVariable!, typeInfo);
            }
            else if (value.IsExternalData)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.DeploymentPatchOpExternalDataV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.DeploymentPatchOpExternalDataV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.DeploymentPatchOpExternalDataV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExternalData!, typeInfo);
            }
        }
    }
}