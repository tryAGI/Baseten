
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Capability a volume token grants.<br/>
    /// - ``PULL``: read volume data.<br/>
    /// - ``INSPECT``: read volume metadata without data access.<br/>
    /// - ``PUSH``: upload and commit volume versions.<br/>
    /// - ``TAG``: move or remove tags.
    /// </summary>
    public enum VolumeTokenScopeV1
    {
        /// <summary>
        /// read volume metadata without data access.
        /// </summary>
        Inspect,
        /// <summary>
        /// read volume data.
        /// </summary>
        Pull,
        /// <summary>
        /// upload and commit volume versions.
        /// </summary>
        Push,
        /// <summary>
        /// move or remove tags.
        /// </summary>
        Tag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VolumeTokenScopeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VolumeTokenScopeV1 value)
        {
            return value switch
            {
                VolumeTokenScopeV1.Inspect => "INSPECT",
                VolumeTokenScopeV1.Pull => "PULL",
                VolumeTokenScopeV1.Push => "PUSH",
                VolumeTokenScopeV1.Tag => "TAG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VolumeTokenScopeV1? ToEnum(string value)
        {
            return value switch
            {
                "INSPECT" => VolumeTokenScopeV1.Inspect,
                "PULL" => VolumeTokenScopeV1.Pull,
                "PUSH" => VolumeTokenScopeV1.Push,
                "TAG" => VolumeTokenScopeV1.Tag,
                _ => null,
            };
        }
    }
}