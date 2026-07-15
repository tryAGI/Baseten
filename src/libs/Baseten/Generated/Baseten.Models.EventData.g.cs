#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Structured details of the action, discriminated by `event_type`.
    /// </summary>
    public readonly partial struct EventData : global::System.IEquatable<EventData>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType? EventType { get; }

        /// <summary>
        /// A model deployment was created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventModelDeployedV1? ModelDeployed { get; init; }
#else
        public global::Baseten.AuditLogEventModelDeployedV1? ModelDeployed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelDeployed))]
#endif
        public bool IsModelDeployed => ModelDeployed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModelDeployed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventModelDeployedV1? value)
        {
            value = ModelDeployed;
            return IsModelDeployed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventModelDeployedV1 PickModelDeployed() => IsModelDeployed
            ? ModelDeployed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelDeployed' but the value was {ToString()}.");

        /// <summary>
        /// A model deployment was activated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventModelDeploymentActivatedV1? ModelDeploymentActivated { get; init; }
#else
        public global::Baseten.AuditLogEventModelDeploymentActivatedV1? ModelDeploymentActivated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelDeploymentActivated))]
#endif
        public bool IsModelDeploymentActivated => ModelDeploymentActivated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModelDeploymentActivated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventModelDeploymentActivatedV1? value)
        {
            value = ModelDeploymentActivated;
            return IsModelDeploymentActivated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentActivatedV1 PickModelDeploymentActivated() => IsModelDeploymentActivated
            ? ModelDeploymentActivated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelDeploymentActivated' but the value was {ToString()}.");

        /// <summary>
        /// A model deployment was deactivated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventModelDeploymentDeactivatedV1? ModelDeploymentDeactivated { get; init; }
#else
        public global::Baseten.AuditLogEventModelDeploymentDeactivatedV1? ModelDeploymentDeactivated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelDeploymentDeactivated))]
#endif
        public bool IsModelDeploymentDeactivated => ModelDeploymentDeactivated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModelDeploymentDeactivated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventModelDeploymentDeactivatedV1? value)
        {
            value = ModelDeploymentDeactivated;
            return IsModelDeploymentDeactivated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentDeactivatedV1 PickModelDeploymentDeactivated() => IsModelDeploymentDeactivated
            ? ModelDeploymentDeactivated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelDeploymentDeactivated' but the value was {ToString()}.");

        /// <summary>
        /// A model deployment build was retried.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventModelDeploymentRetriedV1? ModelDeploymentRetried { get; init; }
#else
        public global::Baseten.AuditLogEventModelDeploymentRetriedV1? ModelDeploymentRetried { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelDeploymentRetried))]
#endif
        public bool IsModelDeploymentRetried => ModelDeploymentRetried != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModelDeploymentRetried(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventModelDeploymentRetriedV1? value)
        {
            value = ModelDeploymentRetried;
            return IsModelDeploymentRetried;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentRetriedV1 PickModelDeploymentRetried() => IsModelDeploymentRetried
            ? ModelDeploymentRetried!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelDeploymentRetried' but the value was {ToString()}.");

        /// <summary>
        /// A model deployment was promoted to an environment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventModelDeploymentPromotedV1? ModelDeploymentPromoted { get; init; }
#else
        public global::Baseten.AuditLogEventModelDeploymentPromotedV1? ModelDeploymentPromoted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelDeploymentPromoted))]
#endif
        public bool IsModelDeploymentPromoted => ModelDeploymentPromoted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModelDeploymentPromoted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventModelDeploymentPromotedV1? value)
        {
            value = ModelDeploymentPromoted;
            return IsModelDeploymentPromoted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentPromotedV1 PickModelDeploymentPromoted() => IsModelDeploymentPromoted
            ? ModelDeploymentPromoted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelDeploymentPromoted' but the value was {ToString()}.");

        /// <summary>
        /// A model deployment's autoscaling settings were changed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1? ModelDeploymentAutoscalingSettingsChanged { get; init; }
#else
        public global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1? ModelDeploymentAutoscalingSettingsChanged { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelDeploymentAutoscalingSettingsChanged))]
#endif
        public bool IsModelDeploymentAutoscalingSettingsChanged => ModelDeploymentAutoscalingSettingsChanged != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModelDeploymentAutoscalingSettingsChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1? value)
        {
            value = ModelDeploymentAutoscalingSettingsChanged;
            return IsModelDeploymentAutoscalingSettingsChanged;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1 PickModelDeploymentAutoscalingSettingsChanged() => IsModelDeploymentAutoscalingSettingsChanged
            ? ModelDeploymentAutoscalingSettingsChanged!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelDeploymentAutoscalingSettingsChanged' but the value was {ToString()}.");

        /// <summary>
        /// A model deployment's instance type was changed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1? ModelDeploymentInstanceTypeChanged { get; init; }
#else
        public global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1? ModelDeploymentInstanceTypeChanged { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelDeploymentInstanceTypeChanged))]
#endif
        public bool IsModelDeploymentInstanceTypeChanged => ModelDeploymentInstanceTypeChanged != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModelDeploymentInstanceTypeChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1? value)
        {
            value = ModelDeploymentInstanceTypeChanged;
            return IsModelDeploymentInstanceTypeChanged;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1 PickModelDeploymentInstanceTypeChanged() => IsModelDeploymentInstanceTypeChanged
            ? ModelDeploymentInstanceTypeChanged!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelDeploymentInstanceTypeChanged' but the value was {ToString()}.");

        /// <summary>
        /// A model deployment was deleted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventModelDeploymentDeletedV1? ModelDeploymentDeleted { get; init; }
#else
        public global::Baseten.AuditLogEventModelDeploymentDeletedV1? ModelDeploymentDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelDeploymentDeleted))]
#endif
        public bool IsModelDeploymentDeleted => ModelDeploymentDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModelDeploymentDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventModelDeploymentDeletedV1? value)
        {
            value = ModelDeploymentDeleted;
            return IsModelDeploymentDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentDeletedV1 PickModelDeploymentDeleted() => IsModelDeploymentDeleted
            ? ModelDeploymentDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelDeploymentDeleted' but the value was {ToString()}.");

        /// <summary>
        /// A model was deleted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventModelDeletedV1? ModelDeleted { get; init; }
#else
        public global::Baseten.AuditLogEventModelDeletedV1? ModelDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelDeleted))]
#endif
        public bool IsModelDeleted => ModelDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModelDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventModelDeletedV1? value)
        {
            value = ModelDeleted;
            return IsModelDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventModelDeletedV1 PickModelDeleted() => IsModelDeleted
            ? ModelDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelDeleted' but the value was {ToString()}.");

        /// <summary>
        /// A chain deployment was created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventChainDeployedV1? ChainDeployed { get; init; }
#else
        public global::Baseten.AuditLogEventChainDeployedV1? ChainDeployed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChainDeployed))]
#endif
        public bool IsChainDeployed => ChainDeployed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChainDeployed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventChainDeployedV1? value)
        {
            value = ChainDeployed;
            return IsChainDeployed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventChainDeployedV1 PickChainDeployed() => IsChainDeployed
            ? ChainDeployed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChainDeployed' but the value was {ToString()}.");

        /// <summary>
        /// A chain deployment was activated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventChainDeploymentActivatedV1? ChainDeploymentActivated { get; init; }
#else
        public global::Baseten.AuditLogEventChainDeploymentActivatedV1? ChainDeploymentActivated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChainDeploymentActivated))]
#endif
        public bool IsChainDeploymentActivated => ChainDeploymentActivated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChainDeploymentActivated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventChainDeploymentActivatedV1? value)
        {
            value = ChainDeploymentActivated;
            return IsChainDeploymentActivated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventChainDeploymentActivatedV1 PickChainDeploymentActivated() => IsChainDeploymentActivated
            ? ChainDeploymentActivated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChainDeploymentActivated' but the value was {ToString()}.");

        /// <summary>
        /// A chain deployment was deactivated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventChainDeploymentDeactivatedV1? ChainDeploymentDeactivated { get; init; }
#else
        public global::Baseten.AuditLogEventChainDeploymentDeactivatedV1? ChainDeploymentDeactivated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChainDeploymentDeactivated))]
#endif
        public bool IsChainDeploymentDeactivated => ChainDeploymentDeactivated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChainDeploymentDeactivated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventChainDeploymentDeactivatedV1? value)
        {
            value = ChainDeploymentDeactivated;
            return IsChainDeploymentDeactivated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventChainDeploymentDeactivatedV1 PickChainDeploymentDeactivated() => IsChainDeploymentDeactivated
            ? ChainDeploymentDeactivated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChainDeploymentDeactivated' but the value was {ToString()}.");

        /// <summary>
        /// A chain deployment was promoted to an environment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventChainDeploymentPromotedV1? ChainDeploymentPromoted { get; init; }
#else
        public global::Baseten.AuditLogEventChainDeploymentPromotedV1? ChainDeploymentPromoted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChainDeploymentPromoted))]
#endif
        public bool IsChainDeploymentPromoted => ChainDeploymentPromoted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChainDeploymentPromoted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventChainDeploymentPromotedV1? value)
        {
            value = ChainDeploymentPromoted;
            return IsChainDeploymentPromoted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventChainDeploymentPromotedV1 PickChainDeploymentPromoted() => IsChainDeploymentPromoted
            ? ChainDeploymentPromoted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChainDeploymentPromoted' but the value was {ToString()}.");

        /// <summary>
        /// A chainlet's autoscaling settings were changed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1? ChainletAutoscalingSettingsChanged { get; init; }
#else
        public global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1? ChainletAutoscalingSettingsChanged { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChainletAutoscalingSettingsChanged))]
#endif
        public bool IsChainletAutoscalingSettingsChanged => ChainletAutoscalingSettingsChanged != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChainletAutoscalingSettingsChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1? value)
        {
            value = ChainletAutoscalingSettingsChanged;
            return IsChainletAutoscalingSettingsChanged;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1 PickChainletAutoscalingSettingsChanged() => IsChainletAutoscalingSettingsChanged
            ? ChainletAutoscalingSettingsChanged!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChainletAutoscalingSettingsChanged' but the value was {ToString()}.");

        /// <summary>
        /// A chainlet's instance type was changed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventChainletInstanceTypeChangedV1? ChainletInstanceTypeChanged { get; init; }
#else
        public global::Baseten.AuditLogEventChainletInstanceTypeChangedV1? ChainletInstanceTypeChanged { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChainletInstanceTypeChanged))]
#endif
        public bool IsChainletInstanceTypeChanged => ChainletInstanceTypeChanged != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChainletInstanceTypeChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventChainletInstanceTypeChangedV1? value)
        {
            value = ChainletInstanceTypeChanged;
            return IsChainletInstanceTypeChanged;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventChainletInstanceTypeChangedV1 PickChainletInstanceTypeChanged() => IsChainletInstanceTypeChanged
            ? ChainletInstanceTypeChanged!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChainletInstanceTypeChanged' but the value was {ToString()}.");

        /// <summary>
        /// A chain deployment was deleted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventChainDeploymentDeletedV1? ChainDeploymentDeleted { get; init; }
#else
        public global::Baseten.AuditLogEventChainDeploymentDeletedV1? ChainDeploymentDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChainDeploymentDeleted))]
#endif
        public bool IsChainDeploymentDeleted => ChainDeploymentDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChainDeploymentDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventChainDeploymentDeletedV1? value)
        {
            value = ChainDeploymentDeleted;
            return IsChainDeploymentDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventChainDeploymentDeletedV1 PickChainDeploymentDeleted() => IsChainDeploymentDeleted
            ? ChainDeploymentDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChainDeploymentDeleted' but the value was {ToString()}.");

        /// <summary>
        /// A chain was deleted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventChainDeletedV1? ChainDeleted { get; init; }
#else
        public global::Baseten.AuditLogEventChainDeletedV1? ChainDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChainDeleted))]
#endif
        public bool IsChainDeleted => ChainDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChainDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventChainDeletedV1? value)
        {
            value = ChainDeleted;
            return IsChainDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventChainDeletedV1 PickChainDeleted() => IsChainDeleted
            ? ChainDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChainDeleted' but the value was {ToString()}.");

        /// <summary>
        /// A chain environment was created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventChainEnvironmentCreatedV1? ChainEnvironmentCreated { get; init; }
#else
        public global::Baseten.AuditLogEventChainEnvironmentCreatedV1? ChainEnvironmentCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChainEnvironmentCreated))]
#endif
        public bool IsChainEnvironmentCreated => ChainEnvironmentCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChainEnvironmentCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventChainEnvironmentCreatedV1? value)
        {
            value = ChainEnvironmentCreated;
            return IsChainEnvironmentCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventChainEnvironmentCreatedV1 PickChainEnvironmentCreated() => IsChainEnvironmentCreated
            ? ChainEnvironmentCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChainEnvironmentCreated' but the value was {ToString()}.");

        /// <summary>
        /// A chain environment was updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventChainEnvironmentUpdatedV1? ChainEnvironmentUpdated { get; init; }
#else
        public global::Baseten.AuditLogEventChainEnvironmentUpdatedV1? ChainEnvironmentUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChainEnvironmentUpdated))]
#endif
        public bool IsChainEnvironmentUpdated => ChainEnvironmentUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChainEnvironmentUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventChainEnvironmentUpdatedV1? value)
        {
            value = ChainEnvironmentUpdated;
            return IsChainEnvironmentUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventChainEnvironmentUpdatedV1 PickChainEnvironmentUpdated() => IsChainEnvironmentUpdated
            ? ChainEnvironmentUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChainEnvironmentUpdated' but the value was {ToString()}.");

        /// <summary>
        /// A secret was created or updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventSecretUpdatedV1? SecretUpdated { get; init; }
#else
        public global::Baseten.AuditLogEventSecretUpdatedV1? SecretUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SecretUpdated))]
#endif
        public bool IsSecretUpdated => SecretUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSecretUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventSecretUpdatedV1? value)
        {
            value = SecretUpdated;
            return IsSecretUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventSecretUpdatedV1 PickSecretUpdated() => IsSecretUpdated
            ? SecretUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SecretUpdated' but the value was {ToString()}.");

        /// <summary>
        /// A secret was deleted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventSecretDeletedV1? SecretDeleted { get; init; }
#else
        public global::Baseten.AuditLogEventSecretDeletedV1? SecretDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SecretDeleted))]
#endif
        public bool IsSecretDeleted => SecretDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSecretDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventSecretDeletedV1? value)
        {
            value = SecretDeleted;
            return IsSecretDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventSecretDeletedV1 PickSecretDeleted() => IsSecretDeleted
            ? SecretDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SecretDeleted' but the value was {ToString()}.");

        /// <summary>
        /// An API key was created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventApiKeyCreatedV1? ApiKeyCreated { get; init; }
#else
        public global::Baseten.AuditLogEventApiKeyCreatedV1? ApiKeyCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiKeyCreated))]
#endif
        public bool IsApiKeyCreated => ApiKeyCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApiKeyCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventApiKeyCreatedV1? value)
        {
            value = ApiKeyCreated;
            return IsApiKeyCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventApiKeyCreatedV1 PickApiKeyCreated() => IsApiKeyCreated
            ? ApiKeyCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiKeyCreated' but the value was {ToString()}.");

        /// <summary>
        /// An API key was revoked.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventApiKeyDeletedV1? ApiKeyDeleted { get; init; }
#else
        public global::Baseten.AuditLogEventApiKeyDeletedV1? ApiKeyDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiKeyDeleted))]
#endif
        public bool IsApiKeyDeleted => ApiKeyDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApiKeyDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventApiKeyDeletedV1? value)
        {
            value = ApiKeyDeleted;
            return IsApiKeyDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventApiKeyDeletedV1 PickApiKeyDeleted() => IsApiKeyDeleted
            ? ApiKeyDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiKeyDeleted' but the value was {ToString()}.");

        /// <summary>
        /// A Frontier Gateway endpoint was created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventGatewayEndpointCreatedV1? GatewayEndpointCreated { get; init; }
#else
        public global::Baseten.AuditLogEventGatewayEndpointCreatedV1? GatewayEndpointCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GatewayEndpointCreated))]
#endif
        public bool IsGatewayEndpointCreated => GatewayEndpointCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGatewayEndpointCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventGatewayEndpointCreatedV1? value)
        {
            value = GatewayEndpointCreated;
            return IsGatewayEndpointCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventGatewayEndpointCreatedV1 PickGatewayEndpointCreated() => IsGatewayEndpointCreated
            ? GatewayEndpointCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GatewayEndpointCreated' but the value was {ToString()}.");

        /// <summary>
        /// A Frontier Gateway endpoint was updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventGatewayEndpointUpdatedV1? GatewayEndpointUpdated { get; init; }
#else
        public global::Baseten.AuditLogEventGatewayEndpointUpdatedV1? GatewayEndpointUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GatewayEndpointUpdated))]
#endif
        public bool IsGatewayEndpointUpdated => GatewayEndpointUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGatewayEndpointUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventGatewayEndpointUpdatedV1? value)
        {
            value = GatewayEndpointUpdated;
            return IsGatewayEndpointUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventGatewayEndpointUpdatedV1 PickGatewayEndpointUpdated() => IsGatewayEndpointUpdated
            ? GatewayEndpointUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GatewayEndpointUpdated' but the value was {ToString()}.");

        /// <summary>
        /// A Frontier Gateway endpoint was deleted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventGatewayEndpointDeletedV1? GatewayEndpointDeleted { get; init; }
#else
        public global::Baseten.AuditLogEventGatewayEndpointDeletedV1? GatewayEndpointDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GatewayEndpointDeleted))]
#endif
        public bool IsGatewayEndpointDeleted => GatewayEndpointDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGatewayEndpointDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventGatewayEndpointDeletedV1? value)
        {
            value = GatewayEndpointDeleted;
            return IsGatewayEndpointDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventGatewayEndpointDeletedV1 PickGatewayEndpointDeleted() => IsGatewayEndpointDeleted
            ? GatewayEndpointDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GatewayEndpointDeleted' but the value was {ToString()}.");

        /// <summary>
        /// A user was invited to the organization.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventUserInvitedV1? UserInvited { get; init; }
#else
        public global::Baseten.AuditLogEventUserInvitedV1? UserInvited { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserInvited))]
#endif
        public bool IsUserInvited => UserInvited != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUserInvited(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventUserInvitedV1? value)
        {
            value = UserInvited;
            return IsUserInvited;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventUserInvitedV1 PickUserInvited() => IsUserInvited
            ? UserInvited!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserInvited' but the value was {ToString()}.");

        /// <summary>
        /// A user joined the organization.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventUserJoinedOrganizationV1? UserJoinedOrganization { get; init; }
#else
        public global::Baseten.AuditLogEventUserJoinedOrganizationV1? UserJoinedOrganization { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserJoinedOrganization))]
#endif
        public bool IsUserJoinedOrganization => UserJoinedOrganization != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUserJoinedOrganization(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventUserJoinedOrganizationV1? value)
        {
            value = UserJoinedOrganization;
            return IsUserJoinedOrganization;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventUserJoinedOrganizationV1 PickUserJoinedOrganization() => IsUserJoinedOrganization
            ? UserJoinedOrganization!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserJoinedOrganization' but the value was {ToString()}.");

        /// <summary>
        /// A webhook signing secret was created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1? WebhookSigningSecretCreated { get; init; }
#else
        public global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1? WebhookSigningSecretCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookSigningSecretCreated))]
#endif
        public bool IsWebhookSigningSecretCreated => WebhookSigningSecretCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebhookSigningSecretCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1? value)
        {
            value = WebhookSigningSecretCreated;
            return IsWebhookSigningSecretCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1 PickWebhookSigningSecretCreated() => IsWebhookSigningSecretCreated
            ? WebhookSigningSecretCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookSigningSecretCreated' but the value was {ToString()}.");

        /// <summary>
        /// A webhook signing secret was rotated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1? WebhookSigningSecretRotated { get; init; }
#else
        public global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1? WebhookSigningSecretRotated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookSigningSecretRotated))]
#endif
        public bool IsWebhookSigningSecretRotated => WebhookSigningSecretRotated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebhookSigningSecretRotated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1? value)
        {
            value = WebhookSigningSecretRotated;
            return IsWebhookSigningSecretRotated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1 PickWebhookSigningSecretRotated() => IsWebhookSigningSecretRotated
            ? WebhookSigningSecretRotated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookSigningSecretRotated' but the value was {ToString()}.");

        /// <summary>
        /// A webhook signing secret was deleted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1? WebhookSigningSecretDeleted { get; init; }
#else
        public global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1? WebhookSigningSecretDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookSigningSecretDeleted))]
#endif
        public bool IsWebhookSigningSecretDeleted => WebhookSigningSecretDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebhookSigningSecretDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1? value)
        {
            value = WebhookSigningSecretDeleted;
            return IsWebhookSigningSecretDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1 PickWebhookSigningSecretDeleted() => IsWebhookSigningSecretDeleted
            ? WebhookSigningSecretDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookSigningSecretDeleted' but the value was {ToString()}.");

        /// <summary>
        /// A user's organization role was updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventUserRoleUpdatedV1? UserRoleUpdated { get; init; }
#else
        public global::Baseten.AuditLogEventUserRoleUpdatedV1? UserRoleUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserRoleUpdated))]
#endif
        public bool IsUserRoleUpdated => UserRoleUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUserRoleUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventUserRoleUpdatedV1? value)
        {
            value = UserRoleUpdated;
            return IsUserRoleUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventUserRoleUpdatedV1 PickUserRoleUpdated() => IsUserRoleUpdated
            ? UserRoleUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserRoleUpdated' but the value was {ToString()}.");

        /// <summary>
        /// A user's team role was updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventUserTeamRoleUpdatedV1? UserTeamRoleUpdated { get; init; }
#else
        public global::Baseten.AuditLogEventUserTeamRoleUpdatedV1? UserTeamRoleUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserTeamRoleUpdated))]
#endif
        public bool IsUserTeamRoleUpdated => UserTeamRoleUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUserTeamRoleUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventUserTeamRoleUpdatedV1? value)
        {
            value = UserTeamRoleUpdated;
            return IsUserTeamRoleUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventUserTeamRoleUpdatedV1 PickUserTeamRoleUpdated() => IsUserTeamRoleUpdated
            ? UserTeamRoleUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserTeamRoleUpdated' but the value was {ToString()}.");

        /// <summary>
        /// A user was removed from the organization.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventUserRemovedV1? UserRemoved { get; init; }
#else
        public global::Baseten.AuditLogEventUserRemovedV1? UserRemoved { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserRemoved))]
#endif
        public bool IsUserRemoved => UserRemoved != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUserRemoved(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventUserRemovedV1? value)
        {
            value = UserRemoved;
            return IsUserRemoved;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventUserRemovedV1 PickUserRemoved() => IsUserRemoved
            ? UserRemoved!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserRemoved' but the value was {ToString()}.");

        /// <summary>
        /// A directory group's role was updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1? DirectoryGroupRoleUpdated { get; init; }
#else
        public global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1? DirectoryGroupRoleUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DirectoryGroupRoleUpdated))]
#endif
        public bool IsDirectoryGroupRoleUpdated => DirectoryGroupRoleUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDirectoryGroupRoleUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1? value)
        {
            value = DirectoryGroupRoleUpdated;
            return IsDirectoryGroupRoleUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1 PickDirectoryGroupRoleUpdated() => IsDirectoryGroupRoleUpdated
            ? DirectoryGroupRoleUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DirectoryGroupRoleUpdated' but the value was {ToString()}.");

        /// <summary>
        /// Group-based admin enforcement was enabled for the organization.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1? RequireGroupBasedAdminsEnabled { get; init; }
#else
        public global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1? RequireGroupBasedAdminsEnabled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequireGroupBasedAdminsEnabled))]
#endif
        public bool IsRequireGroupBasedAdminsEnabled => RequireGroupBasedAdminsEnabled != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRequireGroupBasedAdminsEnabled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1? value)
        {
            value = RequireGroupBasedAdminsEnabled;
            return IsRequireGroupBasedAdminsEnabled;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1 PickRequireGroupBasedAdminsEnabled() => IsRequireGroupBasedAdminsEnabled
            ? RequireGroupBasedAdminsEnabled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequireGroupBasedAdminsEnabled' but the value was {ToString()}.");

        /// <summary>
        /// A model environment was created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventEnvironmentCreatedV1? EnvironmentCreated { get; init; }
#else
        public global::Baseten.AuditLogEventEnvironmentCreatedV1? EnvironmentCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentCreated))]
#endif
        public bool IsEnvironmentCreated => EnvironmentCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnvironmentCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventEnvironmentCreatedV1? value)
        {
            value = EnvironmentCreated;
            return IsEnvironmentCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventEnvironmentCreatedV1 PickEnvironmentCreated() => IsEnvironmentCreated
            ? EnvironmentCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentCreated' but the value was {ToString()}.");

        /// <summary>
        /// A model environment's settings were updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventEnvironmentUpdatedV1? EnvironmentUpdated { get; init; }
#else
        public global::Baseten.AuditLogEventEnvironmentUpdatedV1? EnvironmentUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentUpdated))]
#endif
        public bool IsEnvironmentUpdated => EnvironmentUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnvironmentUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventEnvironmentUpdatedV1? value)
        {
            value = EnvironmentUpdated;
            return IsEnvironmentUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventEnvironmentUpdatedV1 PickEnvironmentUpdated() => IsEnvironmentUpdated
            ? EnvironmentUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentUpdated' but the value was {ToString()}.");

        /// <summary>
        /// A model environment was deleted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventEnvironmentDeletedV1? EnvironmentDeleted { get; init; }
#else
        public global::Baseten.AuditLogEventEnvironmentDeletedV1? EnvironmentDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentDeleted))]
#endif
        public bool IsEnvironmentDeleted => EnvironmentDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnvironmentDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventEnvironmentDeletedV1? value)
        {
            value = EnvironmentDeleted;
            return IsEnvironmentDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventEnvironmentDeletedV1 PickEnvironmentDeleted() => IsEnvironmentDeleted
            ? EnvironmentDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentDeleted' but the value was {ToString()}.");

        /// <summary>
        /// A replica of a model deployment was terminated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventReplicaTerminatedV1? ReplicaTerminated { get; init; }
#else
        public global::Baseten.AuditLogEventReplicaTerminatedV1? ReplicaTerminated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReplicaTerminated))]
#endif
        public bool IsReplicaTerminated => ReplicaTerminated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReplicaTerminated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventReplicaTerminatedV1? value)
        {
            value = ReplicaTerminated;
            return IsReplicaTerminated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventReplicaTerminatedV1 PickReplicaTerminated() => IsReplicaTerminated
            ? ReplicaTerminated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReplicaTerminated' but the value was {ToString()}.");

        /// <summary>
        /// A user-initiated promotion control signal was sent to a rolling promotion.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventModelPromotionControlActionV1? ModelPromotionControlAction { get; init; }
#else
        public global::Baseten.AuditLogEventModelPromotionControlActionV1? ModelPromotionControlAction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelPromotionControlAction))]
#endif
        public bool IsModelPromotionControlAction => ModelPromotionControlAction != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModelPromotionControlAction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventModelPromotionControlActionV1? value)
        {
            value = ModelPromotionControlAction;
            return IsModelPromotionControlAction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventModelPromotionControlActionV1 PickModelPromotionControlAction() => IsModelPromotionControlAction
            ? ModelPromotionControlAction!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelPromotionControlAction' but the value was {ToString()}.");

        /// <summary>
        /// An SSH certificate was signed for a workload.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.AuditLogEventSshCertificateSignedV1? SshCertificateSigned { get; init; }
#else
        public global::Baseten.AuditLogEventSshCertificateSignedV1? SshCertificateSigned { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SshCertificateSigned))]
#endif
        public bool IsSshCertificateSigned => SshCertificateSigned != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSshCertificateSigned(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.AuditLogEventSshCertificateSignedV1? value)
        {
            value = SshCertificateSigned;
            return IsSshCertificateSigned;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.AuditLogEventSshCertificateSignedV1 PickSshCertificateSigned() => IsSshCertificateSigned
            ? SshCertificateSigned!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SshCertificateSigned' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventModelDeployedV1 value) => new EventData((global::Baseten.AuditLogEventModelDeployedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventModelDeployedV1?(EventData @this) => @this.ModelDeployed;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventModelDeployedV1? value)
        {
            ModelDeployed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromModelDeployed(global::Baseten.AuditLogEventModelDeployedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventModelDeploymentActivatedV1 value) => new EventData((global::Baseten.AuditLogEventModelDeploymentActivatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventModelDeploymentActivatedV1?(EventData @this) => @this.ModelDeploymentActivated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventModelDeploymentActivatedV1? value)
        {
            ModelDeploymentActivated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromModelDeploymentActivated(global::Baseten.AuditLogEventModelDeploymentActivatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventModelDeploymentDeactivatedV1 value) => new EventData((global::Baseten.AuditLogEventModelDeploymentDeactivatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventModelDeploymentDeactivatedV1?(EventData @this) => @this.ModelDeploymentDeactivated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventModelDeploymentDeactivatedV1? value)
        {
            ModelDeploymentDeactivated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromModelDeploymentDeactivated(global::Baseten.AuditLogEventModelDeploymentDeactivatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventModelDeploymentRetriedV1 value) => new EventData((global::Baseten.AuditLogEventModelDeploymentRetriedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventModelDeploymentRetriedV1?(EventData @this) => @this.ModelDeploymentRetried;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventModelDeploymentRetriedV1? value)
        {
            ModelDeploymentRetried = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromModelDeploymentRetried(global::Baseten.AuditLogEventModelDeploymentRetriedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventModelDeploymentPromotedV1 value) => new EventData((global::Baseten.AuditLogEventModelDeploymentPromotedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventModelDeploymentPromotedV1?(EventData @this) => @this.ModelDeploymentPromoted;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventModelDeploymentPromotedV1? value)
        {
            ModelDeploymentPromoted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromModelDeploymentPromoted(global::Baseten.AuditLogEventModelDeploymentPromotedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1 value) => new EventData((global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1?(EventData @this) => @this.ModelDeploymentAutoscalingSettingsChanged;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1? value)
        {
            ModelDeploymentAutoscalingSettingsChanged = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromModelDeploymentAutoscalingSettingsChanged(global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1 value) => new EventData((global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1?(EventData @this) => @this.ModelDeploymentInstanceTypeChanged;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1? value)
        {
            ModelDeploymentInstanceTypeChanged = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromModelDeploymentInstanceTypeChanged(global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventModelDeploymentDeletedV1 value) => new EventData((global::Baseten.AuditLogEventModelDeploymentDeletedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventModelDeploymentDeletedV1?(EventData @this) => @this.ModelDeploymentDeleted;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventModelDeploymentDeletedV1? value)
        {
            ModelDeploymentDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromModelDeploymentDeleted(global::Baseten.AuditLogEventModelDeploymentDeletedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventModelDeletedV1 value) => new EventData((global::Baseten.AuditLogEventModelDeletedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventModelDeletedV1?(EventData @this) => @this.ModelDeleted;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventModelDeletedV1? value)
        {
            ModelDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromModelDeleted(global::Baseten.AuditLogEventModelDeletedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventChainDeployedV1 value) => new EventData((global::Baseten.AuditLogEventChainDeployedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventChainDeployedV1?(EventData @this) => @this.ChainDeployed;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventChainDeployedV1? value)
        {
            ChainDeployed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromChainDeployed(global::Baseten.AuditLogEventChainDeployedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventChainDeploymentActivatedV1 value) => new EventData((global::Baseten.AuditLogEventChainDeploymentActivatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventChainDeploymentActivatedV1?(EventData @this) => @this.ChainDeploymentActivated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventChainDeploymentActivatedV1? value)
        {
            ChainDeploymentActivated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromChainDeploymentActivated(global::Baseten.AuditLogEventChainDeploymentActivatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventChainDeploymentDeactivatedV1 value) => new EventData((global::Baseten.AuditLogEventChainDeploymentDeactivatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventChainDeploymentDeactivatedV1?(EventData @this) => @this.ChainDeploymentDeactivated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventChainDeploymentDeactivatedV1? value)
        {
            ChainDeploymentDeactivated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromChainDeploymentDeactivated(global::Baseten.AuditLogEventChainDeploymentDeactivatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventChainDeploymentPromotedV1 value) => new EventData((global::Baseten.AuditLogEventChainDeploymentPromotedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventChainDeploymentPromotedV1?(EventData @this) => @this.ChainDeploymentPromoted;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventChainDeploymentPromotedV1? value)
        {
            ChainDeploymentPromoted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromChainDeploymentPromoted(global::Baseten.AuditLogEventChainDeploymentPromotedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1 value) => new EventData((global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1?(EventData @this) => @this.ChainletAutoscalingSettingsChanged;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1? value)
        {
            ChainletAutoscalingSettingsChanged = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromChainletAutoscalingSettingsChanged(global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventChainletInstanceTypeChangedV1 value) => new EventData((global::Baseten.AuditLogEventChainletInstanceTypeChangedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventChainletInstanceTypeChangedV1?(EventData @this) => @this.ChainletInstanceTypeChanged;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventChainletInstanceTypeChangedV1? value)
        {
            ChainletInstanceTypeChanged = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromChainletInstanceTypeChanged(global::Baseten.AuditLogEventChainletInstanceTypeChangedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventChainDeploymentDeletedV1 value) => new EventData((global::Baseten.AuditLogEventChainDeploymentDeletedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventChainDeploymentDeletedV1?(EventData @this) => @this.ChainDeploymentDeleted;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventChainDeploymentDeletedV1? value)
        {
            ChainDeploymentDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromChainDeploymentDeleted(global::Baseten.AuditLogEventChainDeploymentDeletedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventChainDeletedV1 value) => new EventData((global::Baseten.AuditLogEventChainDeletedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventChainDeletedV1?(EventData @this) => @this.ChainDeleted;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventChainDeletedV1? value)
        {
            ChainDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromChainDeleted(global::Baseten.AuditLogEventChainDeletedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventChainEnvironmentCreatedV1 value) => new EventData((global::Baseten.AuditLogEventChainEnvironmentCreatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventChainEnvironmentCreatedV1?(EventData @this) => @this.ChainEnvironmentCreated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventChainEnvironmentCreatedV1? value)
        {
            ChainEnvironmentCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromChainEnvironmentCreated(global::Baseten.AuditLogEventChainEnvironmentCreatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventChainEnvironmentUpdatedV1 value) => new EventData((global::Baseten.AuditLogEventChainEnvironmentUpdatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventChainEnvironmentUpdatedV1?(EventData @this) => @this.ChainEnvironmentUpdated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventChainEnvironmentUpdatedV1? value)
        {
            ChainEnvironmentUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromChainEnvironmentUpdated(global::Baseten.AuditLogEventChainEnvironmentUpdatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventSecretUpdatedV1 value) => new EventData((global::Baseten.AuditLogEventSecretUpdatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventSecretUpdatedV1?(EventData @this) => @this.SecretUpdated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventSecretUpdatedV1? value)
        {
            SecretUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromSecretUpdated(global::Baseten.AuditLogEventSecretUpdatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventSecretDeletedV1 value) => new EventData((global::Baseten.AuditLogEventSecretDeletedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventSecretDeletedV1?(EventData @this) => @this.SecretDeleted;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventSecretDeletedV1? value)
        {
            SecretDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromSecretDeleted(global::Baseten.AuditLogEventSecretDeletedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventApiKeyCreatedV1 value) => new EventData((global::Baseten.AuditLogEventApiKeyCreatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventApiKeyCreatedV1?(EventData @this) => @this.ApiKeyCreated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventApiKeyCreatedV1? value)
        {
            ApiKeyCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromApiKeyCreated(global::Baseten.AuditLogEventApiKeyCreatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventApiKeyDeletedV1 value) => new EventData((global::Baseten.AuditLogEventApiKeyDeletedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventApiKeyDeletedV1?(EventData @this) => @this.ApiKeyDeleted;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventApiKeyDeletedV1? value)
        {
            ApiKeyDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromApiKeyDeleted(global::Baseten.AuditLogEventApiKeyDeletedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventGatewayEndpointCreatedV1 value) => new EventData((global::Baseten.AuditLogEventGatewayEndpointCreatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventGatewayEndpointCreatedV1?(EventData @this) => @this.GatewayEndpointCreated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventGatewayEndpointCreatedV1? value)
        {
            GatewayEndpointCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromGatewayEndpointCreated(global::Baseten.AuditLogEventGatewayEndpointCreatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventGatewayEndpointUpdatedV1 value) => new EventData((global::Baseten.AuditLogEventGatewayEndpointUpdatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventGatewayEndpointUpdatedV1?(EventData @this) => @this.GatewayEndpointUpdated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventGatewayEndpointUpdatedV1? value)
        {
            GatewayEndpointUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromGatewayEndpointUpdated(global::Baseten.AuditLogEventGatewayEndpointUpdatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventGatewayEndpointDeletedV1 value) => new EventData((global::Baseten.AuditLogEventGatewayEndpointDeletedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventGatewayEndpointDeletedV1?(EventData @this) => @this.GatewayEndpointDeleted;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventGatewayEndpointDeletedV1? value)
        {
            GatewayEndpointDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromGatewayEndpointDeleted(global::Baseten.AuditLogEventGatewayEndpointDeletedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventUserInvitedV1 value) => new EventData((global::Baseten.AuditLogEventUserInvitedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventUserInvitedV1?(EventData @this) => @this.UserInvited;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventUserInvitedV1? value)
        {
            UserInvited = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromUserInvited(global::Baseten.AuditLogEventUserInvitedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventUserJoinedOrganizationV1 value) => new EventData((global::Baseten.AuditLogEventUserJoinedOrganizationV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventUserJoinedOrganizationV1?(EventData @this) => @this.UserJoinedOrganization;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventUserJoinedOrganizationV1? value)
        {
            UserJoinedOrganization = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromUserJoinedOrganization(global::Baseten.AuditLogEventUserJoinedOrganizationV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1 value) => new EventData((global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1?(EventData @this) => @this.WebhookSigningSecretCreated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1? value)
        {
            WebhookSigningSecretCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromWebhookSigningSecretCreated(global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1 value) => new EventData((global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1?(EventData @this) => @this.WebhookSigningSecretRotated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1? value)
        {
            WebhookSigningSecretRotated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromWebhookSigningSecretRotated(global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1 value) => new EventData((global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1?(EventData @this) => @this.WebhookSigningSecretDeleted;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1? value)
        {
            WebhookSigningSecretDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromWebhookSigningSecretDeleted(global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventUserRoleUpdatedV1 value) => new EventData((global::Baseten.AuditLogEventUserRoleUpdatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventUserRoleUpdatedV1?(EventData @this) => @this.UserRoleUpdated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventUserRoleUpdatedV1? value)
        {
            UserRoleUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromUserRoleUpdated(global::Baseten.AuditLogEventUserRoleUpdatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventUserTeamRoleUpdatedV1 value) => new EventData((global::Baseten.AuditLogEventUserTeamRoleUpdatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventUserTeamRoleUpdatedV1?(EventData @this) => @this.UserTeamRoleUpdated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventUserTeamRoleUpdatedV1? value)
        {
            UserTeamRoleUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromUserTeamRoleUpdated(global::Baseten.AuditLogEventUserTeamRoleUpdatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventUserRemovedV1 value) => new EventData((global::Baseten.AuditLogEventUserRemovedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventUserRemovedV1?(EventData @this) => @this.UserRemoved;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventUserRemovedV1? value)
        {
            UserRemoved = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromUserRemoved(global::Baseten.AuditLogEventUserRemovedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1 value) => new EventData((global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1?(EventData @this) => @this.DirectoryGroupRoleUpdated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1? value)
        {
            DirectoryGroupRoleUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromDirectoryGroupRoleUpdated(global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1 value) => new EventData((global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1?(EventData @this) => @this.RequireGroupBasedAdminsEnabled;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1? value)
        {
            RequireGroupBasedAdminsEnabled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromRequireGroupBasedAdminsEnabled(global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventEnvironmentCreatedV1 value) => new EventData((global::Baseten.AuditLogEventEnvironmentCreatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventEnvironmentCreatedV1?(EventData @this) => @this.EnvironmentCreated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventEnvironmentCreatedV1? value)
        {
            EnvironmentCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromEnvironmentCreated(global::Baseten.AuditLogEventEnvironmentCreatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventEnvironmentUpdatedV1 value) => new EventData((global::Baseten.AuditLogEventEnvironmentUpdatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventEnvironmentUpdatedV1?(EventData @this) => @this.EnvironmentUpdated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventEnvironmentUpdatedV1? value)
        {
            EnvironmentUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromEnvironmentUpdated(global::Baseten.AuditLogEventEnvironmentUpdatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventEnvironmentDeletedV1 value) => new EventData((global::Baseten.AuditLogEventEnvironmentDeletedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventEnvironmentDeletedV1?(EventData @this) => @this.EnvironmentDeleted;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventEnvironmentDeletedV1? value)
        {
            EnvironmentDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromEnvironmentDeleted(global::Baseten.AuditLogEventEnvironmentDeletedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventReplicaTerminatedV1 value) => new EventData((global::Baseten.AuditLogEventReplicaTerminatedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventReplicaTerminatedV1?(EventData @this) => @this.ReplicaTerminated;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventReplicaTerminatedV1? value)
        {
            ReplicaTerminated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromReplicaTerminated(global::Baseten.AuditLogEventReplicaTerminatedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventModelPromotionControlActionV1 value) => new EventData((global::Baseten.AuditLogEventModelPromotionControlActionV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventModelPromotionControlActionV1?(EventData @this) => @this.ModelPromotionControlAction;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventModelPromotionControlActionV1? value)
        {
            ModelPromotionControlAction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromModelPromotionControlAction(global::Baseten.AuditLogEventModelPromotionControlActionV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventData(global::Baseten.AuditLogEventSshCertificateSignedV1 value) => new EventData((global::Baseten.AuditLogEventSshCertificateSignedV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.AuditLogEventSshCertificateSignedV1?(EventData @this) => @this.SshCertificateSigned;

        /// <summary>
        /// 
        /// </summary>
        public EventData(global::Baseten.AuditLogEventSshCertificateSignedV1? value)
        {
            SshCertificateSigned = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventData FromSshCertificateSigned(global::Baseten.AuditLogEventSshCertificateSignedV1? value) => new EventData(value);

        /// <summary>
        /// 
        /// </summary>
        public EventData(
            global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType? eventType,
            global::Baseten.AuditLogEventModelDeployedV1? modelDeployed,
            global::Baseten.AuditLogEventModelDeploymentActivatedV1? modelDeploymentActivated,
            global::Baseten.AuditLogEventModelDeploymentDeactivatedV1? modelDeploymentDeactivated,
            global::Baseten.AuditLogEventModelDeploymentRetriedV1? modelDeploymentRetried,
            global::Baseten.AuditLogEventModelDeploymentPromotedV1? modelDeploymentPromoted,
            global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1? modelDeploymentAutoscalingSettingsChanged,
            global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1? modelDeploymentInstanceTypeChanged,
            global::Baseten.AuditLogEventModelDeploymentDeletedV1? modelDeploymentDeleted,
            global::Baseten.AuditLogEventModelDeletedV1? modelDeleted,
            global::Baseten.AuditLogEventChainDeployedV1? chainDeployed,
            global::Baseten.AuditLogEventChainDeploymentActivatedV1? chainDeploymentActivated,
            global::Baseten.AuditLogEventChainDeploymentDeactivatedV1? chainDeploymentDeactivated,
            global::Baseten.AuditLogEventChainDeploymentPromotedV1? chainDeploymentPromoted,
            global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1? chainletAutoscalingSettingsChanged,
            global::Baseten.AuditLogEventChainletInstanceTypeChangedV1? chainletInstanceTypeChanged,
            global::Baseten.AuditLogEventChainDeploymentDeletedV1? chainDeploymentDeleted,
            global::Baseten.AuditLogEventChainDeletedV1? chainDeleted,
            global::Baseten.AuditLogEventChainEnvironmentCreatedV1? chainEnvironmentCreated,
            global::Baseten.AuditLogEventChainEnvironmentUpdatedV1? chainEnvironmentUpdated,
            global::Baseten.AuditLogEventSecretUpdatedV1? secretUpdated,
            global::Baseten.AuditLogEventSecretDeletedV1? secretDeleted,
            global::Baseten.AuditLogEventApiKeyCreatedV1? apiKeyCreated,
            global::Baseten.AuditLogEventApiKeyDeletedV1? apiKeyDeleted,
            global::Baseten.AuditLogEventGatewayEndpointCreatedV1? gatewayEndpointCreated,
            global::Baseten.AuditLogEventGatewayEndpointUpdatedV1? gatewayEndpointUpdated,
            global::Baseten.AuditLogEventGatewayEndpointDeletedV1? gatewayEndpointDeleted,
            global::Baseten.AuditLogEventUserInvitedV1? userInvited,
            global::Baseten.AuditLogEventUserJoinedOrganizationV1? userJoinedOrganization,
            global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1? webhookSigningSecretCreated,
            global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1? webhookSigningSecretRotated,
            global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1? webhookSigningSecretDeleted,
            global::Baseten.AuditLogEventUserRoleUpdatedV1? userRoleUpdated,
            global::Baseten.AuditLogEventUserTeamRoleUpdatedV1? userTeamRoleUpdated,
            global::Baseten.AuditLogEventUserRemovedV1? userRemoved,
            global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1? directoryGroupRoleUpdated,
            global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1? requireGroupBasedAdminsEnabled,
            global::Baseten.AuditLogEventEnvironmentCreatedV1? environmentCreated,
            global::Baseten.AuditLogEventEnvironmentUpdatedV1? environmentUpdated,
            global::Baseten.AuditLogEventEnvironmentDeletedV1? environmentDeleted,
            global::Baseten.AuditLogEventReplicaTerminatedV1? replicaTerminated,
            global::Baseten.AuditLogEventModelPromotionControlActionV1? modelPromotionControlAction,
            global::Baseten.AuditLogEventSshCertificateSignedV1? sshCertificateSigned
            )
        {
            EventType = eventType;

            ModelDeployed = modelDeployed;
            ModelDeploymentActivated = modelDeploymentActivated;
            ModelDeploymentDeactivated = modelDeploymentDeactivated;
            ModelDeploymentRetried = modelDeploymentRetried;
            ModelDeploymentPromoted = modelDeploymentPromoted;
            ModelDeploymentAutoscalingSettingsChanged = modelDeploymentAutoscalingSettingsChanged;
            ModelDeploymentInstanceTypeChanged = modelDeploymentInstanceTypeChanged;
            ModelDeploymentDeleted = modelDeploymentDeleted;
            ModelDeleted = modelDeleted;
            ChainDeployed = chainDeployed;
            ChainDeploymentActivated = chainDeploymentActivated;
            ChainDeploymentDeactivated = chainDeploymentDeactivated;
            ChainDeploymentPromoted = chainDeploymentPromoted;
            ChainletAutoscalingSettingsChanged = chainletAutoscalingSettingsChanged;
            ChainletInstanceTypeChanged = chainletInstanceTypeChanged;
            ChainDeploymentDeleted = chainDeploymentDeleted;
            ChainDeleted = chainDeleted;
            ChainEnvironmentCreated = chainEnvironmentCreated;
            ChainEnvironmentUpdated = chainEnvironmentUpdated;
            SecretUpdated = secretUpdated;
            SecretDeleted = secretDeleted;
            ApiKeyCreated = apiKeyCreated;
            ApiKeyDeleted = apiKeyDeleted;
            GatewayEndpointCreated = gatewayEndpointCreated;
            GatewayEndpointUpdated = gatewayEndpointUpdated;
            GatewayEndpointDeleted = gatewayEndpointDeleted;
            UserInvited = userInvited;
            UserJoinedOrganization = userJoinedOrganization;
            WebhookSigningSecretCreated = webhookSigningSecretCreated;
            WebhookSigningSecretRotated = webhookSigningSecretRotated;
            WebhookSigningSecretDeleted = webhookSigningSecretDeleted;
            UserRoleUpdated = userRoleUpdated;
            UserTeamRoleUpdated = userTeamRoleUpdated;
            UserRemoved = userRemoved;
            DirectoryGroupRoleUpdated = directoryGroupRoleUpdated;
            RequireGroupBasedAdminsEnabled = requireGroupBasedAdminsEnabled;
            EnvironmentCreated = environmentCreated;
            EnvironmentUpdated = environmentUpdated;
            EnvironmentDeleted = environmentDeleted;
            ReplicaTerminated = replicaTerminated;
            ModelPromotionControlAction = modelPromotionControlAction;
            SshCertificateSigned = sshCertificateSigned;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SshCertificateSigned as object ??
            ModelPromotionControlAction as object ??
            ReplicaTerminated as object ??
            EnvironmentDeleted as object ??
            EnvironmentUpdated as object ??
            EnvironmentCreated as object ??
            RequireGroupBasedAdminsEnabled as object ??
            DirectoryGroupRoleUpdated as object ??
            UserRemoved as object ??
            UserTeamRoleUpdated as object ??
            UserRoleUpdated as object ??
            WebhookSigningSecretDeleted as object ??
            WebhookSigningSecretRotated as object ??
            WebhookSigningSecretCreated as object ??
            UserJoinedOrganization as object ??
            UserInvited as object ??
            GatewayEndpointDeleted as object ??
            GatewayEndpointUpdated as object ??
            GatewayEndpointCreated as object ??
            ApiKeyDeleted as object ??
            ApiKeyCreated as object ??
            SecretDeleted as object ??
            SecretUpdated as object ??
            ChainEnvironmentUpdated as object ??
            ChainEnvironmentCreated as object ??
            ChainDeleted as object ??
            ChainDeploymentDeleted as object ??
            ChainletInstanceTypeChanged as object ??
            ChainletAutoscalingSettingsChanged as object ??
            ChainDeploymentPromoted as object ??
            ChainDeploymentDeactivated as object ??
            ChainDeploymentActivated as object ??
            ChainDeployed as object ??
            ModelDeleted as object ??
            ModelDeploymentDeleted as object ??
            ModelDeploymentInstanceTypeChanged as object ??
            ModelDeploymentAutoscalingSettingsChanged as object ??
            ModelDeploymentPromoted as object ??
            ModelDeploymentRetried as object ??
            ModelDeploymentDeactivated as object ??
            ModelDeploymentActivated as object ??
            ModelDeployed as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModelDeployed?.ToString() ??
            ModelDeploymentActivated?.ToString() ??
            ModelDeploymentDeactivated?.ToString() ??
            ModelDeploymentRetried?.ToString() ??
            ModelDeploymentPromoted?.ToString() ??
            ModelDeploymentAutoscalingSettingsChanged?.ToString() ??
            ModelDeploymentInstanceTypeChanged?.ToString() ??
            ModelDeploymentDeleted?.ToString() ??
            ModelDeleted?.ToString() ??
            ChainDeployed?.ToString() ??
            ChainDeploymentActivated?.ToString() ??
            ChainDeploymentDeactivated?.ToString() ??
            ChainDeploymentPromoted?.ToString() ??
            ChainletAutoscalingSettingsChanged?.ToString() ??
            ChainletInstanceTypeChanged?.ToString() ??
            ChainDeploymentDeleted?.ToString() ??
            ChainDeleted?.ToString() ??
            ChainEnvironmentCreated?.ToString() ??
            ChainEnvironmentUpdated?.ToString() ??
            SecretUpdated?.ToString() ??
            SecretDeleted?.ToString() ??
            ApiKeyCreated?.ToString() ??
            ApiKeyDeleted?.ToString() ??
            GatewayEndpointCreated?.ToString() ??
            GatewayEndpointUpdated?.ToString() ??
            GatewayEndpointDeleted?.ToString() ??
            UserInvited?.ToString() ??
            UserJoinedOrganization?.ToString() ??
            WebhookSigningSecretCreated?.ToString() ??
            WebhookSigningSecretRotated?.ToString() ??
            WebhookSigningSecretDeleted?.ToString() ??
            UserRoleUpdated?.ToString() ??
            UserTeamRoleUpdated?.ToString() ??
            UserRemoved?.ToString() ??
            DirectoryGroupRoleUpdated?.ToString() ??
            RequireGroupBasedAdminsEnabled?.ToString() ??
            EnvironmentCreated?.ToString() ??
            EnvironmentUpdated?.ToString() ??
            EnvironmentDeleted?.ToString() ??
            ReplicaTerminated?.ToString() ??
            ModelPromotionControlAction?.ToString() ??
            SshCertificateSigned?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && IsReplicaTerminated && !IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && IsModelPromotionControlAction && !IsSshCertificateSigned || !IsModelDeployed && !IsModelDeploymentActivated && !IsModelDeploymentDeactivated && !IsModelDeploymentRetried && !IsModelDeploymentPromoted && !IsModelDeploymentAutoscalingSettingsChanged && !IsModelDeploymentInstanceTypeChanged && !IsModelDeploymentDeleted && !IsModelDeleted && !IsChainDeployed && !IsChainDeploymentActivated && !IsChainDeploymentDeactivated && !IsChainDeploymentPromoted && !IsChainletAutoscalingSettingsChanged && !IsChainletInstanceTypeChanged && !IsChainDeploymentDeleted && !IsChainDeleted && !IsChainEnvironmentCreated && !IsChainEnvironmentUpdated && !IsSecretUpdated && !IsSecretDeleted && !IsApiKeyCreated && !IsApiKeyDeleted && !IsGatewayEndpointCreated && !IsGatewayEndpointUpdated && !IsGatewayEndpointDeleted && !IsUserInvited && !IsUserJoinedOrganization && !IsWebhookSigningSecretCreated && !IsWebhookSigningSecretRotated && !IsWebhookSigningSecretDeleted && !IsUserRoleUpdated && !IsUserTeamRoleUpdated && !IsUserRemoved && !IsDirectoryGroupRoleUpdated && !IsRequireGroupBasedAdminsEnabled && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentDeleted && !IsReplicaTerminated && !IsModelPromotionControlAction && IsSshCertificateSigned;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.AuditLogEventModelDeployedV1, TResult>? modelDeployed = null,
            global::System.Func<global::Baseten.AuditLogEventModelDeploymentActivatedV1, TResult>? modelDeploymentActivated = null,
            global::System.Func<global::Baseten.AuditLogEventModelDeploymentDeactivatedV1, TResult>? modelDeploymentDeactivated = null,
            global::System.Func<global::Baseten.AuditLogEventModelDeploymentRetriedV1, TResult>? modelDeploymentRetried = null,
            global::System.Func<global::Baseten.AuditLogEventModelDeploymentPromotedV1, TResult>? modelDeploymentPromoted = null,
            global::System.Func<global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1, TResult>? modelDeploymentAutoscalingSettingsChanged = null,
            global::System.Func<global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1, TResult>? modelDeploymentInstanceTypeChanged = null,
            global::System.Func<global::Baseten.AuditLogEventModelDeploymentDeletedV1, TResult>? modelDeploymentDeleted = null,
            global::System.Func<global::Baseten.AuditLogEventModelDeletedV1, TResult>? modelDeleted = null,
            global::System.Func<global::Baseten.AuditLogEventChainDeployedV1, TResult>? chainDeployed = null,
            global::System.Func<global::Baseten.AuditLogEventChainDeploymentActivatedV1, TResult>? chainDeploymentActivated = null,
            global::System.Func<global::Baseten.AuditLogEventChainDeploymentDeactivatedV1, TResult>? chainDeploymentDeactivated = null,
            global::System.Func<global::Baseten.AuditLogEventChainDeploymentPromotedV1, TResult>? chainDeploymentPromoted = null,
            global::System.Func<global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1, TResult>? chainletAutoscalingSettingsChanged = null,
            global::System.Func<global::Baseten.AuditLogEventChainletInstanceTypeChangedV1, TResult>? chainletInstanceTypeChanged = null,
            global::System.Func<global::Baseten.AuditLogEventChainDeploymentDeletedV1, TResult>? chainDeploymentDeleted = null,
            global::System.Func<global::Baseten.AuditLogEventChainDeletedV1, TResult>? chainDeleted = null,
            global::System.Func<global::Baseten.AuditLogEventChainEnvironmentCreatedV1, TResult>? chainEnvironmentCreated = null,
            global::System.Func<global::Baseten.AuditLogEventChainEnvironmentUpdatedV1, TResult>? chainEnvironmentUpdated = null,
            global::System.Func<global::Baseten.AuditLogEventSecretUpdatedV1, TResult>? secretUpdated = null,
            global::System.Func<global::Baseten.AuditLogEventSecretDeletedV1, TResult>? secretDeleted = null,
            global::System.Func<global::Baseten.AuditLogEventApiKeyCreatedV1, TResult>? apiKeyCreated = null,
            global::System.Func<global::Baseten.AuditLogEventApiKeyDeletedV1, TResult>? apiKeyDeleted = null,
            global::System.Func<global::Baseten.AuditLogEventGatewayEndpointCreatedV1, TResult>? gatewayEndpointCreated = null,
            global::System.Func<global::Baseten.AuditLogEventGatewayEndpointUpdatedV1, TResult>? gatewayEndpointUpdated = null,
            global::System.Func<global::Baseten.AuditLogEventGatewayEndpointDeletedV1, TResult>? gatewayEndpointDeleted = null,
            global::System.Func<global::Baseten.AuditLogEventUserInvitedV1, TResult>? userInvited = null,
            global::System.Func<global::Baseten.AuditLogEventUserJoinedOrganizationV1, TResult>? userJoinedOrganization = null,
            global::System.Func<global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1, TResult>? webhookSigningSecretCreated = null,
            global::System.Func<global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1, TResult>? webhookSigningSecretRotated = null,
            global::System.Func<global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1, TResult>? webhookSigningSecretDeleted = null,
            global::System.Func<global::Baseten.AuditLogEventUserRoleUpdatedV1, TResult>? userRoleUpdated = null,
            global::System.Func<global::Baseten.AuditLogEventUserTeamRoleUpdatedV1, TResult>? userTeamRoleUpdated = null,
            global::System.Func<global::Baseten.AuditLogEventUserRemovedV1, TResult>? userRemoved = null,
            global::System.Func<global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1, TResult>? directoryGroupRoleUpdated = null,
            global::System.Func<global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1, TResult>? requireGroupBasedAdminsEnabled = null,
            global::System.Func<global::Baseten.AuditLogEventEnvironmentCreatedV1, TResult>? environmentCreated = null,
            global::System.Func<global::Baseten.AuditLogEventEnvironmentUpdatedV1, TResult>? environmentUpdated = null,
            global::System.Func<global::Baseten.AuditLogEventEnvironmentDeletedV1, TResult>? environmentDeleted = null,
            global::System.Func<global::Baseten.AuditLogEventReplicaTerminatedV1, TResult>? replicaTerminated = null,
            global::System.Func<global::Baseten.AuditLogEventModelPromotionControlActionV1, TResult>? modelPromotionControlAction = null,
            global::System.Func<global::Baseten.AuditLogEventSshCertificateSignedV1, TResult>? sshCertificateSigned = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelDeployed && modelDeployed != null)
            {
                return modelDeployed(ModelDeployed!);
            }
            else if (IsModelDeploymentActivated && modelDeploymentActivated != null)
            {
                return modelDeploymentActivated(ModelDeploymentActivated!);
            }
            else if (IsModelDeploymentDeactivated && modelDeploymentDeactivated != null)
            {
                return modelDeploymentDeactivated(ModelDeploymentDeactivated!);
            }
            else if (IsModelDeploymentRetried && modelDeploymentRetried != null)
            {
                return modelDeploymentRetried(ModelDeploymentRetried!);
            }
            else if (IsModelDeploymentPromoted && modelDeploymentPromoted != null)
            {
                return modelDeploymentPromoted(ModelDeploymentPromoted!);
            }
            else if (IsModelDeploymentAutoscalingSettingsChanged && modelDeploymentAutoscalingSettingsChanged != null)
            {
                return modelDeploymentAutoscalingSettingsChanged(ModelDeploymentAutoscalingSettingsChanged!);
            }
            else if (IsModelDeploymentInstanceTypeChanged && modelDeploymentInstanceTypeChanged != null)
            {
                return modelDeploymentInstanceTypeChanged(ModelDeploymentInstanceTypeChanged!);
            }
            else if (IsModelDeploymentDeleted && modelDeploymentDeleted != null)
            {
                return modelDeploymentDeleted(ModelDeploymentDeleted!);
            }
            else if (IsModelDeleted && modelDeleted != null)
            {
                return modelDeleted(ModelDeleted!);
            }
            else if (IsChainDeployed && chainDeployed != null)
            {
                return chainDeployed(ChainDeployed!);
            }
            else if (IsChainDeploymentActivated && chainDeploymentActivated != null)
            {
                return chainDeploymentActivated(ChainDeploymentActivated!);
            }
            else if (IsChainDeploymentDeactivated && chainDeploymentDeactivated != null)
            {
                return chainDeploymentDeactivated(ChainDeploymentDeactivated!);
            }
            else if (IsChainDeploymentPromoted && chainDeploymentPromoted != null)
            {
                return chainDeploymentPromoted(ChainDeploymentPromoted!);
            }
            else if (IsChainletAutoscalingSettingsChanged && chainletAutoscalingSettingsChanged != null)
            {
                return chainletAutoscalingSettingsChanged(ChainletAutoscalingSettingsChanged!);
            }
            else if (IsChainletInstanceTypeChanged && chainletInstanceTypeChanged != null)
            {
                return chainletInstanceTypeChanged(ChainletInstanceTypeChanged!);
            }
            else if (IsChainDeploymentDeleted && chainDeploymentDeleted != null)
            {
                return chainDeploymentDeleted(ChainDeploymentDeleted!);
            }
            else if (IsChainDeleted && chainDeleted != null)
            {
                return chainDeleted(ChainDeleted!);
            }
            else if (IsChainEnvironmentCreated && chainEnvironmentCreated != null)
            {
                return chainEnvironmentCreated(ChainEnvironmentCreated!);
            }
            else if (IsChainEnvironmentUpdated && chainEnvironmentUpdated != null)
            {
                return chainEnvironmentUpdated(ChainEnvironmentUpdated!);
            }
            else if (IsSecretUpdated && secretUpdated != null)
            {
                return secretUpdated(SecretUpdated!);
            }
            else if (IsSecretDeleted && secretDeleted != null)
            {
                return secretDeleted(SecretDeleted!);
            }
            else if (IsApiKeyCreated && apiKeyCreated != null)
            {
                return apiKeyCreated(ApiKeyCreated!);
            }
            else if (IsApiKeyDeleted && apiKeyDeleted != null)
            {
                return apiKeyDeleted(ApiKeyDeleted!);
            }
            else if (IsGatewayEndpointCreated && gatewayEndpointCreated != null)
            {
                return gatewayEndpointCreated(GatewayEndpointCreated!);
            }
            else if (IsGatewayEndpointUpdated && gatewayEndpointUpdated != null)
            {
                return gatewayEndpointUpdated(GatewayEndpointUpdated!);
            }
            else if (IsGatewayEndpointDeleted && gatewayEndpointDeleted != null)
            {
                return gatewayEndpointDeleted(GatewayEndpointDeleted!);
            }
            else if (IsUserInvited && userInvited != null)
            {
                return userInvited(UserInvited!);
            }
            else if (IsUserJoinedOrganization && userJoinedOrganization != null)
            {
                return userJoinedOrganization(UserJoinedOrganization!);
            }
            else if (IsWebhookSigningSecretCreated && webhookSigningSecretCreated != null)
            {
                return webhookSigningSecretCreated(WebhookSigningSecretCreated!);
            }
            else if (IsWebhookSigningSecretRotated && webhookSigningSecretRotated != null)
            {
                return webhookSigningSecretRotated(WebhookSigningSecretRotated!);
            }
            else if (IsWebhookSigningSecretDeleted && webhookSigningSecretDeleted != null)
            {
                return webhookSigningSecretDeleted(WebhookSigningSecretDeleted!);
            }
            else if (IsUserRoleUpdated && userRoleUpdated != null)
            {
                return userRoleUpdated(UserRoleUpdated!);
            }
            else if (IsUserTeamRoleUpdated && userTeamRoleUpdated != null)
            {
                return userTeamRoleUpdated(UserTeamRoleUpdated!);
            }
            else if (IsUserRemoved && userRemoved != null)
            {
                return userRemoved(UserRemoved!);
            }
            else if (IsDirectoryGroupRoleUpdated && directoryGroupRoleUpdated != null)
            {
                return directoryGroupRoleUpdated(DirectoryGroupRoleUpdated!);
            }
            else if (IsRequireGroupBasedAdminsEnabled && requireGroupBasedAdminsEnabled != null)
            {
                return requireGroupBasedAdminsEnabled(RequireGroupBasedAdminsEnabled!);
            }
            else if (IsEnvironmentCreated && environmentCreated != null)
            {
                return environmentCreated(EnvironmentCreated!);
            }
            else if (IsEnvironmentUpdated && environmentUpdated != null)
            {
                return environmentUpdated(EnvironmentUpdated!);
            }
            else if (IsEnvironmentDeleted && environmentDeleted != null)
            {
                return environmentDeleted(EnvironmentDeleted!);
            }
            else if (IsReplicaTerminated && replicaTerminated != null)
            {
                return replicaTerminated(ReplicaTerminated!);
            }
            else if (IsModelPromotionControlAction && modelPromotionControlAction != null)
            {
                return modelPromotionControlAction(ModelPromotionControlAction!);
            }
            else if (IsSshCertificateSigned && sshCertificateSigned != null)
            {
                return sshCertificateSigned(SshCertificateSigned!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.AuditLogEventModelDeployedV1>? modelDeployed = null,

            global::System.Action<global::Baseten.AuditLogEventModelDeploymentActivatedV1>? modelDeploymentActivated = null,

            global::System.Action<global::Baseten.AuditLogEventModelDeploymentDeactivatedV1>? modelDeploymentDeactivated = null,

            global::System.Action<global::Baseten.AuditLogEventModelDeploymentRetriedV1>? modelDeploymentRetried = null,

            global::System.Action<global::Baseten.AuditLogEventModelDeploymentPromotedV1>? modelDeploymentPromoted = null,

            global::System.Action<global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1>? modelDeploymentAutoscalingSettingsChanged = null,

            global::System.Action<global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1>? modelDeploymentInstanceTypeChanged = null,

            global::System.Action<global::Baseten.AuditLogEventModelDeploymentDeletedV1>? modelDeploymentDeleted = null,

            global::System.Action<global::Baseten.AuditLogEventModelDeletedV1>? modelDeleted = null,

            global::System.Action<global::Baseten.AuditLogEventChainDeployedV1>? chainDeployed = null,

            global::System.Action<global::Baseten.AuditLogEventChainDeploymentActivatedV1>? chainDeploymentActivated = null,

            global::System.Action<global::Baseten.AuditLogEventChainDeploymentDeactivatedV1>? chainDeploymentDeactivated = null,

            global::System.Action<global::Baseten.AuditLogEventChainDeploymentPromotedV1>? chainDeploymentPromoted = null,

            global::System.Action<global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1>? chainletAutoscalingSettingsChanged = null,

            global::System.Action<global::Baseten.AuditLogEventChainletInstanceTypeChangedV1>? chainletInstanceTypeChanged = null,

            global::System.Action<global::Baseten.AuditLogEventChainDeploymentDeletedV1>? chainDeploymentDeleted = null,

            global::System.Action<global::Baseten.AuditLogEventChainDeletedV1>? chainDeleted = null,

            global::System.Action<global::Baseten.AuditLogEventChainEnvironmentCreatedV1>? chainEnvironmentCreated = null,

            global::System.Action<global::Baseten.AuditLogEventChainEnvironmentUpdatedV1>? chainEnvironmentUpdated = null,

            global::System.Action<global::Baseten.AuditLogEventSecretUpdatedV1>? secretUpdated = null,

            global::System.Action<global::Baseten.AuditLogEventSecretDeletedV1>? secretDeleted = null,

            global::System.Action<global::Baseten.AuditLogEventApiKeyCreatedV1>? apiKeyCreated = null,

            global::System.Action<global::Baseten.AuditLogEventApiKeyDeletedV1>? apiKeyDeleted = null,

            global::System.Action<global::Baseten.AuditLogEventGatewayEndpointCreatedV1>? gatewayEndpointCreated = null,

            global::System.Action<global::Baseten.AuditLogEventGatewayEndpointUpdatedV1>? gatewayEndpointUpdated = null,

            global::System.Action<global::Baseten.AuditLogEventGatewayEndpointDeletedV1>? gatewayEndpointDeleted = null,

            global::System.Action<global::Baseten.AuditLogEventUserInvitedV1>? userInvited = null,

            global::System.Action<global::Baseten.AuditLogEventUserJoinedOrganizationV1>? userJoinedOrganization = null,

            global::System.Action<global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1>? webhookSigningSecretCreated = null,

            global::System.Action<global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1>? webhookSigningSecretRotated = null,

            global::System.Action<global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1>? webhookSigningSecretDeleted = null,

            global::System.Action<global::Baseten.AuditLogEventUserRoleUpdatedV1>? userRoleUpdated = null,

            global::System.Action<global::Baseten.AuditLogEventUserTeamRoleUpdatedV1>? userTeamRoleUpdated = null,

            global::System.Action<global::Baseten.AuditLogEventUserRemovedV1>? userRemoved = null,

            global::System.Action<global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1>? directoryGroupRoleUpdated = null,

            global::System.Action<global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1>? requireGroupBasedAdminsEnabled = null,

            global::System.Action<global::Baseten.AuditLogEventEnvironmentCreatedV1>? environmentCreated = null,

            global::System.Action<global::Baseten.AuditLogEventEnvironmentUpdatedV1>? environmentUpdated = null,

            global::System.Action<global::Baseten.AuditLogEventEnvironmentDeletedV1>? environmentDeleted = null,

            global::System.Action<global::Baseten.AuditLogEventReplicaTerminatedV1>? replicaTerminated = null,

            global::System.Action<global::Baseten.AuditLogEventModelPromotionControlActionV1>? modelPromotionControlAction = null,

            global::System.Action<global::Baseten.AuditLogEventSshCertificateSignedV1>? sshCertificateSigned = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelDeployed)
            {
                modelDeployed?.Invoke(ModelDeployed!);
            }
            else if (IsModelDeploymentActivated)
            {
                modelDeploymentActivated?.Invoke(ModelDeploymentActivated!);
            }
            else if (IsModelDeploymentDeactivated)
            {
                modelDeploymentDeactivated?.Invoke(ModelDeploymentDeactivated!);
            }
            else if (IsModelDeploymentRetried)
            {
                modelDeploymentRetried?.Invoke(ModelDeploymentRetried!);
            }
            else if (IsModelDeploymentPromoted)
            {
                modelDeploymentPromoted?.Invoke(ModelDeploymentPromoted!);
            }
            else if (IsModelDeploymentAutoscalingSettingsChanged)
            {
                modelDeploymentAutoscalingSettingsChanged?.Invoke(ModelDeploymentAutoscalingSettingsChanged!);
            }
            else if (IsModelDeploymentInstanceTypeChanged)
            {
                modelDeploymentInstanceTypeChanged?.Invoke(ModelDeploymentInstanceTypeChanged!);
            }
            else if (IsModelDeploymentDeleted)
            {
                modelDeploymentDeleted?.Invoke(ModelDeploymentDeleted!);
            }
            else if (IsModelDeleted)
            {
                modelDeleted?.Invoke(ModelDeleted!);
            }
            else if (IsChainDeployed)
            {
                chainDeployed?.Invoke(ChainDeployed!);
            }
            else if (IsChainDeploymentActivated)
            {
                chainDeploymentActivated?.Invoke(ChainDeploymentActivated!);
            }
            else if (IsChainDeploymentDeactivated)
            {
                chainDeploymentDeactivated?.Invoke(ChainDeploymentDeactivated!);
            }
            else if (IsChainDeploymentPromoted)
            {
                chainDeploymentPromoted?.Invoke(ChainDeploymentPromoted!);
            }
            else if (IsChainletAutoscalingSettingsChanged)
            {
                chainletAutoscalingSettingsChanged?.Invoke(ChainletAutoscalingSettingsChanged!);
            }
            else if (IsChainletInstanceTypeChanged)
            {
                chainletInstanceTypeChanged?.Invoke(ChainletInstanceTypeChanged!);
            }
            else if (IsChainDeploymentDeleted)
            {
                chainDeploymentDeleted?.Invoke(ChainDeploymentDeleted!);
            }
            else if (IsChainDeleted)
            {
                chainDeleted?.Invoke(ChainDeleted!);
            }
            else if (IsChainEnvironmentCreated)
            {
                chainEnvironmentCreated?.Invoke(ChainEnvironmentCreated!);
            }
            else if (IsChainEnvironmentUpdated)
            {
                chainEnvironmentUpdated?.Invoke(ChainEnvironmentUpdated!);
            }
            else if (IsSecretUpdated)
            {
                secretUpdated?.Invoke(SecretUpdated!);
            }
            else if (IsSecretDeleted)
            {
                secretDeleted?.Invoke(SecretDeleted!);
            }
            else if (IsApiKeyCreated)
            {
                apiKeyCreated?.Invoke(ApiKeyCreated!);
            }
            else if (IsApiKeyDeleted)
            {
                apiKeyDeleted?.Invoke(ApiKeyDeleted!);
            }
            else if (IsGatewayEndpointCreated)
            {
                gatewayEndpointCreated?.Invoke(GatewayEndpointCreated!);
            }
            else if (IsGatewayEndpointUpdated)
            {
                gatewayEndpointUpdated?.Invoke(GatewayEndpointUpdated!);
            }
            else if (IsGatewayEndpointDeleted)
            {
                gatewayEndpointDeleted?.Invoke(GatewayEndpointDeleted!);
            }
            else if (IsUserInvited)
            {
                userInvited?.Invoke(UserInvited!);
            }
            else if (IsUserJoinedOrganization)
            {
                userJoinedOrganization?.Invoke(UserJoinedOrganization!);
            }
            else if (IsWebhookSigningSecretCreated)
            {
                webhookSigningSecretCreated?.Invoke(WebhookSigningSecretCreated!);
            }
            else if (IsWebhookSigningSecretRotated)
            {
                webhookSigningSecretRotated?.Invoke(WebhookSigningSecretRotated!);
            }
            else if (IsWebhookSigningSecretDeleted)
            {
                webhookSigningSecretDeleted?.Invoke(WebhookSigningSecretDeleted!);
            }
            else if (IsUserRoleUpdated)
            {
                userRoleUpdated?.Invoke(UserRoleUpdated!);
            }
            else if (IsUserTeamRoleUpdated)
            {
                userTeamRoleUpdated?.Invoke(UserTeamRoleUpdated!);
            }
            else if (IsUserRemoved)
            {
                userRemoved?.Invoke(UserRemoved!);
            }
            else if (IsDirectoryGroupRoleUpdated)
            {
                directoryGroupRoleUpdated?.Invoke(DirectoryGroupRoleUpdated!);
            }
            else if (IsRequireGroupBasedAdminsEnabled)
            {
                requireGroupBasedAdminsEnabled?.Invoke(RequireGroupBasedAdminsEnabled!);
            }
            else if (IsEnvironmentCreated)
            {
                environmentCreated?.Invoke(EnvironmentCreated!);
            }
            else if (IsEnvironmentUpdated)
            {
                environmentUpdated?.Invoke(EnvironmentUpdated!);
            }
            else if (IsEnvironmentDeleted)
            {
                environmentDeleted?.Invoke(EnvironmentDeleted!);
            }
            else if (IsReplicaTerminated)
            {
                replicaTerminated?.Invoke(ReplicaTerminated!);
            }
            else if (IsModelPromotionControlAction)
            {
                modelPromotionControlAction?.Invoke(ModelPromotionControlAction!);
            }
            else if (IsSshCertificateSigned)
            {
                sshCertificateSigned?.Invoke(SshCertificateSigned!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.AuditLogEventModelDeployedV1>? modelDeployed = null,
            global::System.Action<global::Baseten.AuditLogEventModelDeploymentActivatedV1>? modelDeploymentActivated = null,
            global::System.Action<global::Baseten.AuditLogEventModelDeploymentDeactivatedV1>? modelDeploymentDeactivated = null,
            global::System.Action<global::Baseten.AuditLogEventModelDeploymentRetriedV1>? modelDeploymentRetried = null,
            global::System.Action<global::Baseten.AuditLogEventModelDeploymentPromotedV1>? modelDeploymentPromoted = null,
            global::System.Action<global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1>? modelDeploymentAutoscalingSettingsChanged = null,
            global::System.Action<global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1>? modelDeploymentInstanceTypeChanged = null,
            global::System.Action<global::Baseten.AuditLogEventModelDeploymentDeletedV1>? modelDeploymentDeleted = null,
            global::System.Action<global::Baseten.AuditLogEventModelDeletedV1>? modelDeleted = null,
            global::System.Action<global::Baseten.AuditLogEventChainDeployedV1>? chainDeployed = null,
            global::System.Action<global::Baseten.AuditLogEventChainDeploymentActivatedV1>? chainDeploymentActivated = null,
            global::System.Action<global::Baseten.AuditLogEventChainDeploymentDeactivatedV1>? chainDeploymentDeactivated = null,
            global::System.Action<global::Baseten.AuditLogEventChainDeploymentPromotedV1>? chainDeploymentPromoted = null,
            global::System.Action<global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1>? chainletAutoscalingSettingsChanged = null,
            global::System.Action<global::Baseten.AuditLogEventChainletInstanceTypeChangedV1>? chainletInstanceTypeChanged = null,
            global::System.Action<global::Baseten.AuditLogEventChainDeploymentDeletedV1>? chainDeploymentDeleted = null,
            global::System.Action<global::Baseten.AuditLogEventChainDeletedV1>? chainDeleted = null,
            global::System.Action<global::Baseten.AuditLogEventChainEnvironmentCreatedV1>? chainEnvironmentCreated = null,
            global::System.Action<global::Baseten.AuditLogEventChainEnvironmentUpdatedV1>? chainEnvironmentUpdated = null,
            global::System.Action<global::Baseten.AuditLogEventSecretUpdatedV1>? secretUpdated = null,
            global::System.Action<global::Baseten.AuditLogEventSecretDeletedV1>? secretDeleted = null,
            global::System.Action<global::Baseten.AuditLogEventApiKeyCreatedV1>? apiKeyCreated = null,
            global::System.Action<global::Baseten.AuditLogEventApiKeyDeletedV1>? apiKeyDeleted = null,
            global::System.Action<global::Baseten.AuditLogEventGatewayEndpointCreatedV1>? gatewayEndpointCreated = null,
            global::System.Action<global::Baseten.AuditLogEventGatewayEndpointUpdatedV1>? gatewayEndpointUpdated = null,
            global::System.Action<global::Baseten.AuditLogEventGatewayEndpointDeletedV1>? gatewayEndpointDeleted = null,
            global::System.Action<global::Baseten.AuditLogEventUserInvitedV1>? userInvited = null,
            global::System.Action<global::Baseten.AuditLogEventUserJoinedOrganizationV1>? userJoinedOrganization = null,
            global::System.Action<global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1>? webhookSigningSecretCreated = null,
            global::System.Action<global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1>? webhookSigningSecretRotated = null,
            global::System.Action<global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1>? webhookSigningSecretDeleted = null,
            global::System.Action<global::Baseten.AuditLogEventUserRoleUpdatedV1>? userRoleUpdated = null,
            global::System.Action<global::Baseten.AuditLogEventUserTeamRoleUpdatedV1>? userTeamRoleUpdated = null,
            global::System.Action<global::Baseten.AuditLogEventUserRemovedV1>? userRemoved = null,
            global::System.Action<global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1>? directoryGroupRoleUpdated = null,
            global::System.Action<global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1>? requireGroupBasedAdminsEnabled = null,
            global::System.Action<global::Baseten.AuditLogEventEnvironmentCreatedV1>? environmentCreated = null,
            global::System.Action<global::Baseten.AuditLogEventEnvironmentUpdatedV1>? environmentUpdated = null,
            global::System.Action<global::Baseten.AuditLogEventEnvironmentDeletedV1>? environmentDeleted = null,
            global::System.Action<global::Baseten.AuditLogEventReplicaTerminatedV1>? replicaTerminated = null,
            global::System.Action<global::Baseten.AuditLogEventModelPromotionControlActionV1>? modelPromotionControlAction = null,
            global::System.Action<global::Baseten.AuditLogEventSshCertificateSignedV1>? sshCertificateSigned = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelDeployed)
            {
                modelDeployed?.Invoke(ModelDeployed!);
            }
            else if (IsModelDeploymentActivated)
            {
                modelDeploymentActivated?.Invoke(ModelDeploymentActivated!);
            }
            else if (IsModelDeploymentDeactivated)
            {
                modelDeploymentDeactivated?.Invoke(ModelDeploymentDeactivated!);
            }
            else if (IsModelDeploymentRetried)
            {
                modelDeploymentRetried?.Invoke(ModelDeploymentRetried!);
            }
            else if (IsModelDeploymentPromoted)
            {
                modelDeploymentPromoted?.Invoke(ModelDeploymentPromoted!);
            }
            else if (IsModelDeploymentAutoscalingSettingsChanged)
            {
                modelDeploymentAutoscalingSettingsChanged?.Invoke(ModelDeploymentAutoscalingSettingsChanged!);
            }
            else if (IsModelDeploymentInstanceTypeChanged)
            {
                modelDeploymentInstanceTypeChanged?.Invoke(ModelDeploymentInstanceTypeChanged!);
            }
            else if (IsModelDeploymentDeleted)
            {
                modelDeploymentDeleted?.Invoke(ModelDeploymentDeleted!);
            }
            else if (IsModelDeleted)
            {
                modelDeleted?.Invoke(ModelDeleted!);
            }
            else if (IsChainDeployed)
            {
                chainDeployed?.Invoke(ChainDeployed!);
            }
            else if (IsChainDeploymentActivated)
            {
                chainDeploymentActivated?.Invoke(ChainDeploymentActivated!);
            }
            else if (IsChainDeploymentDeactivated)
            {
                chainDeploymentDeactivated?.Invoke(ChainDeploymentDeactivated!);
            }
            else if (IsChainDeploymentPromoted)
            {
                chainDeploymentPromoted?.Invoke(ChainDeploymentPromoted!);
            }
            else if (IsChainletAutoscalingSettingsChanged)
            {
                chainletAutoscalingSettingsChanged?.Invoke(ChainletAutoscalingSettingsChanged!);
            }
            else if (IsChainletInstanceTypeChanged)
            {
                chainletInstanceTypeChanged?.Invoke(ChainletInstanceTypeChanged!);
            }
            else if (IsChainDeploymentDeleted)
            {
                chainDeploymentDeleted?.Invoke(ChainDeploymentDeleted!);
            }
            else if (IsChainDeleted)
            {
                chainDeleted?.Invoke(ChainDeleted!);
            }
            else if (IsChainEnvironmentCreated)
            {
                chainEnvironmentCreated?.Invoke(ChainEnvironmentCreated!);
            }
            else if (IsChainEnvironmentUpdated)
            {
                chainEnvironmentUpdated?.Invoke(ChainEnvironmentUpdated!);
            }
            else if (IsSecretUpdated)
            {
                secretUpdated?.Invoke(SecretUpdated!);
            }
            else if (IsSecretDeleted)
            {
                secretDeleted?.Invoke(SecretDeleted!);
            }
            else if (IsApiKeyCreated)
            {
                apiKeyCreated?.Invoke(ApiKeyCreated!);
            }
            else if (IsApiKeyDeleted)
            {
                apiKeyDeleted?.Invoke(ApiKeyDeleted!);
            }
            else if (IsGatewayEndpointCreated)
            {
                gatewayEndpointCreated?.Invoke(GatewayEndpointCreated!);
            }
            else if (IsGatewayEndpointUpdated)
            {
                gatewayEndpointUpdated?.Invoke(GatewayEndpointUpdated!);
            }
            else if (IsGatewayEndpointDeleted)
            {
                gatewayEndpointDeleted?.Invoke(GatewayEndpointDeleted!);
            }
            else if (IsUserInvited)
            {
                userInvited?.Invoke(UserInvited!);
            }
            else if (IsUserJoinedOrganization)
            {
                userJoinedOrganization?.Invoke(UserJoinedOrganization!);
            }
            else if (IsWebhookSigningSecretCreated)
            {
                webhookSigningSecretCreated?.Invoke(WebhookSigningSecretCreated!);
            }
            else if (IsWebhookSigningSecretRotated)
            {
                webhookSigningSecretRotated?.Invoke(WebhookSigningSecretRotated!);
            }
            else if (IsWebhookSigningSecretDeleted)
            {
                webhookSigningSecretDeleted?.Invoke(WebhookSigningSecretDeleted!);
            }
            else if (IsUserRoleUpdated)
            {
                userRoleUpdated?.Invoke(UserRoleUpdated!);
            }
            else if (IsUserTeamRoleUpdated)
            {
                userTeamRoleUpdated?.Invoke(UserTeamRoleUpdated!);
            }
            else if (IsUserRemoved)
            {
                userRemoved?.Invoke(UserRemoved!);
            }
            else if (IsDirectoryGroupRoleUpdated)
            {
                directoryGroupRoleUpdated?.Invoke(DirectoryGroupRoleUpdated!);
            }
            else if (IsRequireGroupBasedAdminsEnabled)
            {
                requireGroupBasedAdminsEnabled?.Invoke(RequireGroupBasedAdminsEnabled!);
            }
            else if (IsEnvironmentCreated)
            {
                environmentCreated?.Invoke(EnvironmentCreated!);
            }
            else if (IsEnvironmentUpdated)
            {
                environmentUpdated?.Invoke(EnvironmentUpdated!);
            }
            else if (IsEnvironmentDeleted)
            {
                environmentDeleted?.Invoke(EnvironmentDeleted!);
            }
            else if (IsReplicaTerminated)
            {
                replicaTerminated?.Invoke(ReplicaTerminated!);
            }
            else if (IsModelPromotionControlAction)
            {
                modelPromotionControlAction?.Invoke(ModelPromotionControlAction!);
            }
            else if (IsSshCertificateSigned)
            {
                sshCertificateSigned?.Invoke(SshCertificateSigned!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelDeployed,
                typeof(global::Baseten.AuditLogEventModelDeployedV1),
                ModelDeploymentActivated,
                typeof(global::Baseten.AuditLogEventModelDeploymentActivatedV1),
                ModelDeploymentDeactivated,
                typeof(global::Baseten.AuditLogEventModelDeploymentDeactivatedV1),
                ModelDeploymentRetried,
                typeof(global::Baseten.AuditLogEventModelDeploymentRetriedV1),
                ModelDeploymentPromoted,
                typeof(global::Baseten.AuditLogEventModelDeploymentPromotedV1),
                ModelDeploymentAutoscalingSettingsChanged,
                typeof(global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1),
                ModelDeploymentInstanceTypeChanged,
                typeof(global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1),
                ModelDeploymentDeleted,
                typeof(global::Baseten.AuditLogEventModelDeploymentDeletedV1),
                ModelDeleted,
                typeof(global::Baseten.AuditLogEventModelDeletedV1),
                ChainDeployed,
                typeof(global::Baseten.AuditLogEventChainDeployedV1),
                ChainDeploymentActivated,
                typeof(global::Baseten.AuditLogEventChainDeploymentActivatedV1),
                ChainDeploymentDeactivated,
                typeof(global::Baseten.AuditLogEventChainDeploymentDeactivatedV1),
                ChainDeploymentPromoted,
                typeof(global::Baseten.AuditLogEventChainDeploymentPromotedV1),
                ChainletAutoscalingSettingsChanged,
                typeof(global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1),
                ChainletInstanceTypeChanged,
                typeof(global::Baseten.AuditLogEventChainletInstanceTypeChangedV1),
                ChainDeploymentDeleted,
                typeof(global::Baseten.AuditLogEventChainDeploymentDeletedV1),
                ChainDeleted,
                typeof(global::Baseten.AuditLogEventChainDeletedV1),
                ChainEnvironmentCreated,
                typeof(global::Baseten.AuditLogEventChainEnvironmentCreatedV1),
                ChainEnvironmentUpdated,
                typeof(global::Baseten.AuditLogEventChainEnvironmentUpdatedV1),
                SecretUpdated,
                typeof(global::Baseten.AuditLogEventSecretUpdatedV1),
                SecretDeleted,
                typeof(global::Baseten.AuditLogEventSecretDeletedV1),
                ApiKeyCreated,
                typeof(global::Baseten.AuditLogEventApiKeyCreatedV1),
                ApiKeyDeleted,
                typeof(global::Baseten.AuditLogEventApiKeyDeletedV1),
                GatewayEndpointCreated,
                typeof(global::Baseten.AuditLogEventGatewayEndpointCreatedV1),
                GatewayEndpointUpdated,
                typeof(global::Baseten.AuditLogEventGatewayEndpointUpdatedV1),
                GatewayEndpointDeleted,
                typeof(global::Baseten.AuditLogEventGatewayEndpointDeletedV1),
                UserInvited,
                typeof(global::Baseten.AuditLogEventUserInvitedV1),
                UserJoinedOrganization,
                typeof(global::Baseten.AuditLogEventUserJoinedOrganizationV1),
                WebhookSigningSecretCreated,
                typeof(global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1),
                WebhookSigningSecretRotated,
                typeof(global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1),
                WebhookSigningSecretDeleted,
                typeof(global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1),
                UserRoleUpdated,
                typeof(global::Baseten.AuditLogEventUserRoleUpdatedV1),
                UserTeamRoleUpdated,
                typeof(global::Baseten.AuditLogEventUserTeamRoleUpdatedV1),
                UserRemoved,
                typeof(global::Baseten.AuditLogEventUserRemovedV1),
                DirectoryGroupRoleUpdated,
                typeof(global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1),
                RequireGroupBasedAdminsEnabled,
                typeof(global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1),
                EnvironmentCreated,
                typeof(global::Baseten.AuditLogEventEnvironmentCreatedV1),
                EnvironmentUpdated,
                typeof(global::Baseten.AuditLogEventEnvironmentUpdatedV1),
                EnvironmentDeleted,
                typeof(global::Baseten.AuditLogEventEnvironmentDeletedV1),
                ReplicaTerminated,
                typeof(global::Baseten.AuditLogEventReplicaTerminatedV1),
                ModelPromotionControlAction,
                typeof(global::Baseten.AuditLogEventModelPromotionControlActionV1),
                SshCertificateSigned,
                typeof(global::Baseten.AuditLogEventSshCertificateSignedV1),
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
        public bool Equals(EventData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventModelDeployedV1?>.Default.Equals(ModelDeployed, other.ModelDeployed) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventModelDeploymentActivatedV1?>.Default.Equals(ModelDeploymentActivated, other.ModelDeploymentActivated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventModelDeploymentDeactivatedV1?>.Default.Equals(ModelDeploymentDeactivated, other.ModelDeploymentDeactivated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventModelDeploymentRetriedV1?>.Default.Equals(ModelDeploymentRetried, other.ModelDeploymentRetried) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventModelDeploymentPromotedV1?>.Default.Equals(ModelDeploymentPromoted, other.ModelDeploymentPromoted) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1?>.Default.Equals(ModelDeploymentAutoscalingSettingsChanged, other.ModelDeploymentAutoscalingSettingsChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1?>.Default.Equals(ModelDeploymentInstanceTypeChanged, other.ModelDeploymentInstanceTypeChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventModelDeploymentDeletedV1?>.Default.Equals(ModelDeploymentDeleted, other.ModelDeploymentDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventModelDeletedV1?>.Default.Equals(ModelDeleted, other.ModelDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventChainDeployedV1?>.Default.Equals(ChainDeployed, other.ChainDeployed) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventChainDeploymentActivatedV1?>.Default.Equals(ChainDeploymentActivated, other.ChainDeploymentActivated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventChainDeploymentDeactivatedV1?>.Default.Equals(ChainDeploymentDeactivated, other.ChainDeploymentDeactivated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventChainDeploymentPromotedV1?>.Default.Equals(ChainDeploymentPromoted, other.ChainDeploymentPromoted) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1?>.Default.Equals(ChainletAutoscalingSettingsChanged, other.ChainletAutoscalingSettingsChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventChainletInstanceTypeChangedV1?>.Default.Equals(ChainletInstanceTypeChanged, other.ChainletInstanceTypeChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventChainDeploymentDeletedV1?>.Default.Equals(ChainDeploymentDeleted, other.ChainDeploymentDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventChainDeletedV1?>.Default.Equals(ChainDeleted, other.ChainDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventChainEnvironmentCreatedV1?>.Default.Equals(ChainEnvironmentCreated, other.ChainEnvironmentCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventChainEnvironmentUpdatedV1?>.Default.Equals(ChainEnvironmentUpdated, other.ChainEnvironmentUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventSecretUpdatedV1?>.Default.Equals(SecretUpdated, other.SecretUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventSecretDeletedV1?>.Default.Equals(SecretDeleted, other.SecretDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventApiKeyCreatedV1?>.Default.Equals(ApiKeyCreated, other.ApiKeyCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventApiKeyDeletedV1?>.Default.Equals(ApiKeyDeleted, other.ApiKeyDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventGatewayEndpointCreatedV1?>.Default.Equals(GatewayEndpointCreated, other.GatewayEndpointCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventGatewayEndpointUpdatedV1?>.Default.Equals(GatewayEndpointUpdated, other.GatewayEndpointUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventGatewayEndpointDeletedV1?>.Default.Equals(GatewayEndpointDeleted, other.GatewayEndpointDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventUserInvitedV1?>.Default.Equals(UserInvited, other.UserInvited) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventUserJoinedOrganizationV1?>.Default.Equals(UserJoinedOrganization, other.UserJoinedOrganization) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1?>.Default.Equals(WebhookSigningSecretCreated, other.WebhookSigningSecretCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1?>.Default.Equals(WebhookSigningSecretRotated, other.WebhookSigningSecretRotated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1?>.Default.Equals(WebhookSigningSecretDeleted, other.WebhookSigningSecretDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventUserRoleUpdatedV1?>.Default.Equals(UserRoleUpdated, other.UserRoleUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventUserTeamRoleUpdatedV1?>.Default.Equals(UserTeamRoleUpdated, other.UserTeamRoleUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventUserRemovedV1?>.Default.Equals(UserRemoved, other.UserRemoved) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1?>.Default.Equals(DirectoryGroupRoleUpdated, other.DirectoryGroupRoleUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1?>.Default.Equals(RequireGroupBasedAdminsEnabled, other.RequireGroupBasedAdminsEnabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventEnvironmentCreatedV1?>.Default.Equals(EnvironmentCreated, other.EnvironmentCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventEnvironmentUpdatedV1?>.Default.Equals(EnvironmentUpdated, other.EnvironmentUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventEnvironmentDeletedV1?>.Default.Equals(EnvironmentDeleted, other.EnvironmentDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventReplicaTerminatedV1?>.Default.Equals(ReplicaTerminated, other.ReplicaTerminated) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventModelPromotionControlActionV1?>.Default.Equals(ModelPromotionControlAction, other.ModelPromotionControlAction) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.AuditLogEventSshCertificateSignedV1?>.Default.Equals(SshCertificateSigned, other.SshCertificateSigned) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EventData obj1, EventData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EventData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EventData obj1, EventData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EventData o && Equals(o);
        }
    }
}
