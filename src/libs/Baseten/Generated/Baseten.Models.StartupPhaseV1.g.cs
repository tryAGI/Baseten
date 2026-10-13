
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A stage of a replica startup.<br/>
    /// - ``SCHEDULING``: waiting for the replica to be placed on a node.<br/>
    /// - ``IMAGE_PULL``: pulling the container image.<br/>
    /// - ``WEIGHT_DOWNLOAD``: downloading model weights.<br/>
    /// - ``CONTAINER_CREATE``: creating and starting the model container, including<br/>
    ///   ``CONTAINER_START`` and ``READINESS``.<br/>
    /// - ``CONTAINER_START``: starting the model container.<br/>
    /// - ``READINESS``: waiting for the model to pass its readiness check.<br/>
    /// ``CONTAINER_START`` and ``READINESS`` are accepted as filters but are reported only as<br/>
    /// part of ``CONTAINER_CREATE``.
    /// </summary>
    public enum StartupPhaseV1
    {
        /// <summary>
        /// creating and starting the model container, including
        /// </summary>
        ContainerCreate,
        /// <summary>
        /// starting the model container.
        /// </summary>
        ContainerStart,
        /// <summary>
        /// pulling the container image.
        /// </summary>
        ImagePull,
        /// <summary>
        /// waiting for the model to pass its readiness check.
        /// </summary>
        Readiness,
        /// <summary>
        /// waiting for the replica to be placed on a node.
        /// </summary>
        Scheduling,
        /// <summary>
        /// downloading model weights.
        /// </summary>
        WeightDownload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StartupPhaseV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartupPhaseV1 value)
        {
            return value switch
            {
                StartupPhaseV1.ContainerCreate => "CONTAINER_CREATE",
                StartupPhaseV1.ContainerStart => "CONTAINER_START",
                StartupPhaseV1.ImagePull => "IMAGE_PULL",
                StartupPhaseV1.Readiness => "READINESS",
                StartupPhaseV1.Scheduling => "SCHEDULING",
                StartupPhaseV1.WeightDownload => "WEIGHT_DOWNLOAD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartupPhaseV1? ToEnum(string value)
        {
            return value switch
            {
                "CONTAINER_CREATE" => StartupPhaseV1.ContainerCreate,
                "CONTAINER_START" => StartupPhaseV1.ContainerStart,
                "IMAGE_PULL" => StartupPhaseV1.ImagePull,
                "READINESS" => StartupPhaseV1.Readiness,
                "SCHEDULING" => StartupPhaseV1.Scheduling,
                "WEIGHT_DOWNLOAD" => StartupPhaseV1.WeightDownload,
                _ => null,
            };
        }
    }
}