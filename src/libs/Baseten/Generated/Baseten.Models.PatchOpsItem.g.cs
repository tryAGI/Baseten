#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PatchOpsItem : global::System.IEquatable<PatchOpsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType? Type { get; }

        /// <summary>
        /// Add, update, or remove a file under the model code directory.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.DeploymentPatchOpModelCodeV1? ModelCode { get; init; }
#else
        public global::Baseten.DeploymentPatchOpModelCodeV1? ModelCode { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelCode))]
#endif
        public bool IsModelCode => ModelCode != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModelCode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.DeploymentPatchOpModelCodeV1? value)
        {
            value = ModelCode;
            return IsModelCode;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.DeploymentPatchOpModelCodeV1 PickModelCode() => IsModelCode
            ? ModelCode!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelCode' but the value was {ToString()}.");

        /// <summary>
        /// Add, update, or remove a file under the bundled packages directory.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.DeploymentPatchOpPackageV1? Package { get; init; }
#else
        public global::Baseten.DeploymentPatchOpPackageV1? Package { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Package))]
#endif
        public bool IsPackage => Package != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPackage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.DeploymentPatchOpPackageV1? value)
        {
            value = Package;
            return IsPackage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.DeploymentPatchOpPackageV1 PickPackage() => IsPackage
            ? Package!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Package' but the value was {ToString()}.");

        /// <summary>
        /// Replace the config when config.yaml changes.<br/>
        /// Config has no action: it is always a full replacement of the parsed config.<br/>
        /// Derived changes (environment variables, external data, requirements) are<br/>
        /// emitted as their own ops alongside this one.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.DeploymentPatchOpConfigV1? Config { get; init; }
#else
        public global::Baseten.DeploymentPatchOpConfigV1? Config { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Config))]
#endif
        public bool IsConfig => Config != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.DeploymentPatchOpConfigV1? value)
        {
            value = Config;
            return IsConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.DeploymentPatchOpConfigV1 PickConfig() => IsConfig
            ? Config!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Config' but the value was {ToString()}.");

        /// <summary>
        /// Add, update, or remove a single Python requirement.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.DeploymentPatchOpPythonRequirementV1? PythonRequirement { get; init; }
#else
        public global::Baseten.DeploymentPatchOpPythonRequirementV1? PythonRequirement { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PythonRequirement))]
#endif
        public bool IsPythonRequirement => PythonRequirement != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPythonRequirement(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.DeploymentPatchOpPythonRequirementV1? value)
        {
            value = PythonRequirement;
            return IsPythonRequirement;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.DeploymentPatchOpPythonRequirementV1 PickPythonRequirement() => IsPythonRequirement
            ? PythonRequirement!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PythonRequirement' but the value was {ToString()}.");

        /// <summary>
        /// Add, update, or remove a single environment variable.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.DeploymentPatchOpEnvVarV1? EnvironmentVariable { get; init; }
#else
        public global::Baseten.DeploymentPatchOpEnvVarV1? EnvironmentVariable { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentVariable))]
#endif
        public bool IsEnvironmentVariable => EnvironmentVariable != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnvironmentVariable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.DeploymentPatchOpEnvVarV1? value)
        {
            value = EnvironmentVariable;
            return IsEnvironmentVariable;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.DeploymentPatchOpEnvVarV1 PickEnvironmentVariable() => IsEnvironmentVariable
            ? EnvironmentVariable!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentVariable' but the value was {ToString()}.");

        /// <summary>
        /// Add, update, or remove a single external data item.<br/>
        /// External data is referenced by config, not stored in the source. The backend<br/>
        /// only adds or removes it, where adding re-downloads (overwriting any existing<br/>
        /// file), so `update` is accepted and treated identically to `add`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.DeploymentPatchOpExternalDataV1? ExternalData { get; init; }
#else
        public global::Baseten.DeploymentPatchOpExternalDataV1? ExternalData { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExternalData))]
#endif
        public bool IsExternalData => ExternalData != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickExternalData(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.DeploymentPatchOpExternalDataV1? value)
        {
            value = ExternalData;
            return IsExternalData;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.DeploymentPatchOpExternalDataV1 PickExternalData() => IsExternalData
            ? ExternalData!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ExternalData' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PatchOpsItem(global::Baseten.DeploymentPatchOpModelCodeV1 value) => new PatchOpsItem((global::Baseten.DeploymentPatchOpModelCodeV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.DeploymentPatchOpModelCodeV1?(PatchOpsItem @this) => @this.ModelCode;

        /// <summary>
        /// 
        /// </summary>
        public PatchOpsItem(global::Baseten.DeploymentPatchOpModelCodeV1? value)
        {
            ModelCode = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PatchOpsItem FromModelCode(global::Baseten.DeploymentPatchOpModelCodeV1? value) => new PatchOpsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PatchOpsItem(global::Baseten.DeploymentPatchOpPackageV1 value) => new PatchOpsItem((global::Baseten.DeploymentPatchOpPackageV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.DeploymentPatchOpPackageV1?(PatchOpsItem @this) => @this.Package;

        /// <summary>
        /// 
        /// </summary>
        public PatchOpsItem(global::Baseten.DeploymentPatchOpPackageV1? value)
        {
            Package = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PatchOpsItem FromPackage(global::Baseten.DeploymentPatchOpPackageV1? value) => new PatchOpsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PatchOpsItem(global::Baseten.DeploymentPatchOpConfigV1 value) => new PatchOpsItem((global::Baseten.DeploymentPatchOpConfigV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.DeploymentPatchOpConfigV1?(PatchOpsItem @this) => @this.Config;

        /// <summary>
        /// 
        /// </summary>
        public PatchOpsItem(global::Baseten.DeploymentPatchOpConfigV1? value)
        {
            Config = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PatchOpsItem FromConfig(global::Baseten.DeploymentPatchOpConfigV1? value) => new PatchOpsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PatchOpsItem(global::Baseten.DeploymentPatchOpPythonRequirementV1 value) => new PatchOpsItem((global::Baseten.DeploymentPatchOpPythonRequirementV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.DeploymentPatchOpPythonRequirementV1?(PatchOpsItem @this) => @this.PythonRequirement;

        /// <summary>
        /// 
        /// </summary>
        public PatchOpsItem(global::Baseten.DeploymentPatchOpPythonRequirementV1? value)
        {
            PythonRequirement = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PatchOpsItem FromPythonRequirement(global::Baseten.DeploymentPatchOpPythonRequirementV1? value) => new PatchOpsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PatchOpsItem(global::Baseten.DeploymentPatchOpEnvVarV1 value) => new PatchOpsItem((global::Baseten.DeploymentPatchOpEnvVarV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.DeploymentPatchOpEnvVarV1?(PatchOpsItem @this) => @this.EnvironmentVariable;

        /// <summary>
        /// 
        /// </summary>
        public PatchOpsItem(global::Baseten.DeploymentPatchOpEnvVarV1? value)
        {
            EnvironmentVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PatchOpsItem FromEnvironmentVariable(global::Baseten.DeploymentPatchOpEnvVarV1? value) => new PatchOpsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PatchOpsItem(global::Baseten.DeploymentPatchOpExternalDataV1 value) => new PatchOpsItem((global::Baseten.DeploymentPatchOpExternalDataV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.DeploymentPatchOpExternalDataV1?(PatchOpsItem @this) => @this.ExternalData;

        /// <summary>
        /// 
        /// </summary>
        public PatchOpsItem(global::Baseten.DeploymentPatchOpExternalDataV1? value)
        {
            ExternalData = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PatchOpsItem FromExternalData(global::Baseten.DeploymentPatchOpExternalDataV1? value) => new PatchOpsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public PatchOpsItem(
            global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType? type,
            global::Baseten.DeploymentPatchOpModelCodeV1? modelCode,
            global::Baseten.DeploymentPatchOpPackageV1? package,
            global::Baseten.DeploymentPatchOpConfigV1? config,
            global::Baseten.DeploymentPatchOpPythonRequirementV1? pythonRequirement,
            global::Baseten.DeploymentPatchOpEnvVarV1? environmentVariable,
            global::Baseten.DeploymentPatchOpExternalDataV1? externalData
            )
        {
            Type = type;

            ModelCode = modelCode;
            Package = package;
            Config = config;
            PythonRequirement = pythonRequirement;
            EnvironmentVariable = environmentVariable;
            ExternalData = externalData;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ExternalData as object ??
            EnvironmentVariable as object ??
            PythonRequirement as object ??
            Config as object ??
            Package as object ??
            ModelCode as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModelCode?.ToString() ??
            Package?.ToString() ??
            Config?.ToString() ??
            PythonRequirement?.ToString() ??
            EnvironmentVariable?.ToString() ??
            ExternalData?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModelCode && !IsPackage && !IsConfig && !IsPythonRequirement && !IsEnvironmentVariable && !IsExternalData || !IsModelCode && IsPackage && !IsConfig && !IsPythonRequirement && !IsEnvironmentVariable && !IsExternalData || !IsModelCode && !IsPackage && IsConfig && !IsPythonRequirement && !IsEnvironmentVariable && !IsExternalData || !IsModelCode && !IsPackage && !IsConfig && IsPythonRequirement && !IsEnvironmentVariable && !IsExternalData || !IsModelCode && !IsPackage && !IsConfig && !IsPythonRequirement && IsEnvironmentVariable && !IsExternalData || !IsModelCode && !IsPackage && !IsConfig && !IsPythonRequirement && !IsEnvironmentVariable && IsExternalData;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.DeploymentPatchOpModelCodeV1, TResult>? modelCode = null,
            global::System.Func<global::Baseten.DeploymentPatchOpPackageV1, TResult>? package = null,
            global::System.Func<global::Baseten.DeploymentPatchOpConfigV1, TResult>? config = null,
            global::System.Func<global::Baseten.DeploymentPatchOpPythonRequirementV1, TResult>? pythonRequirement = null,
            global::System.Func<global::Baseten.DeploymentPatchOpEnvVarV1, TResult>? environmentVariable = null,
            global::System.Func<global::Baseten.DeploymentPatchOpExternalDataV1, TResult>? externalData = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelCode && modelCode != null)
            {
                return modelCode(ModelCode!);
            }
            else if (IsPackage && package != null)
            {
                return package(Package!);
            }
            else if (IsConfig && config != null)
            {
                return config(Config!);
            }
            else if (IsPythonRequirement && pythonRequirement != null)
            {
                return pythonRequirement(PythonRequirement!);
            }
            else if (IsEnvironmentVariable && environmentVariable != null)
            {
                return environmentVariable(EnvironmentVariable!);
            }
            else if (IsExternalData && externalData != null)
            {
                return externalData(ExternalData!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.DeploymentPatchOpModelCodeV1>? modelCode = null,

            global::System.Action<global::Baseten.DeploymentPatchOpPackageV1>? package = null,

            global::System.Action<global::Baseten.DeploymentPatchOpConfigV1>? config = null,

            global::System.Action<global::Baseten.DeploymentPatchOpPythonRequirementV1>? pythonRequirement = null,

            global::System.Action<global::Baseten.DeploymentPatchOpEnvVarV1>? environmentVariable = null,

            global::System.Action<global::Baseten.DeploymentPatchOpExternalDataV1>? externalData = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelCode)
            {
                modelCode?.Invoke(ModelCode!);
            }
            else if (IsPackage)
            {
                package?.Invoke(Package!);
            }
            else if (IsConfig)
            {
                config?.Invoke(Config!);
            }
            else if (IsPythonRequirement)
            {
                pythonRequirement?.Invoke(PythonRequirement!);
            }
            else if (IsEnvironmentVariable)
            {
                environmentVariable?.Invoke(EnvironmentVariable!);
            }
            else if (IsExternalData)
            {
                externalData?.Invoke(ExternalData!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.DeploymentPatchOpModelCodeV1>? modelCode = null,
            global::System.Action<global::Baseten.DeploymentPatchOpPackageV1>? package = null,
            global::System.Action<global::Baseten.DeploymentPatchOpConfigV1>? config = null,
            global::System.Action<global::Baseten.DeploymentPatchOpPythonRequirementV1>? pythonRequirement = null,
            global::System.Action<global::Baseten.DeploymentPatchOpEnvVarV1>? environmentVariable = null,
            global::System.Action<global::Baseten.DeploymentPatchOpExternalDataV1>? externalData = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelCode)
            {
                modelCode?.Invoke(ModelCode!);
            }
            else if (IsPackage)
            {
                package?.Invoke(Package!);
            }
            else if (IsConfig)
            {
                config?.Invoke(Config!);
            }
            else if (IsPythonRequirement)
            {
                pythonRequirement?.Invoke(PythonRequirement!);
            }
            else if (IsEnvironmentVariable)
            {
                environmentVariable?.Invoke(EnvironmentVariable!);
            }
            else if (IsExternalData)
            {
                externalData?.Invoke(ExternalData!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelCode,
                typeof(global::Baseten.DeploymentPatchOpModelCodeV1),
                Package,
                typeof(global::Baseten.DeploymentPatchOpPackageV1),
                Config,
                typeof(global::Baseten.DeploymentPatchOpConfigV1),
                PythonRequirement,
                typeof(global::Baseten.DeploymentPatchOpPythonRequirementV1),
                EnvironmentVariable,
                typeof(global::Baseten.DeploymentPatchOpEnvVarV1),
                ExternalData,
                typeof(global::Baseten.DeploymentPatchOpExternalDataV1),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(PatchOpsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.DeploymentPatchOpModelCodeV1?>.Default.Equals(ModelCode, other.ModelCode) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.DeploymentPatchOpPackageV1?>.Default.Equals(Package, other.Package) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.DeploymentPatchOpConfigV1?>.Default.Equals(Config, other.Config) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.DeploymentPatchOpPythonRequirementV1?>.Default.Equals(PythonRequirement, other.PythonRequirement) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.DeploymentPatchOpEnvVarV1?>.Default.Equals(EnvironmentVariable, other.EnvironmentVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.DeploymentPatchOpExternalDataV1?>.Default.Equals(ExternalData, other.ExternalData) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PatchOpsItem obj1, PatchOpsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PatchOpsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PatchOpsItem obj1, PatchOpsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PatchOpsItem o && Equals(o);
        }
    }
}
