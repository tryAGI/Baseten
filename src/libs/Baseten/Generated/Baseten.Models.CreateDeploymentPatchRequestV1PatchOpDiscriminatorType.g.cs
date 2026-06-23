
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentPatchRequestV1PatchOpDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Config,
        /// <summary>
        /// 
        /// </summary>
        EnvironmentVariable,
        /// <summary>
        /// 
        /// </summary>
        ExternalData,
        /// <summary>
        /// 
        /// </summary>
        ModelCode,
        /// <summary>
        /// 
        /// </summary>
        Package,
        /// <summary>
        /// 
        /// </summary>
        PythonRequirement,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentPatchRequestV1PatchOpDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentPatchRequestV1PatchOpDiscriminatorType value)
        {
            return value switch
            {
                CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.Config => "config",
                CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.EnvironmentVariable => "environment_variable",
                CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.ExternalData => "external_data",
                CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.ModelCode => "model_code",
                CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.Package => "package",
                CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.PythonRequirement => "python_requirement",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentPatchRequestV1PatchOpDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "config" => CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.Config,
                "environment_variable" => CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.EnvironmentVariable,
                "external_data" => CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.ExternalData,
                "model_code" => CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.ModelCode,
                "package" => CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.Package,
                "python_requirement" => CreateDeploymentPatchRequestV1PatchOpDiscriminatorType.PythonRequirement,
                _ => null,
            };
        }
    }
}