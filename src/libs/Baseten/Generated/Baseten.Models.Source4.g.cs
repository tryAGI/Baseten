#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// `s3` means the files endpoint serves presigned URLs for this checkpoint; `volume` carries the ref to pull instead.
    /// </summary>
    public readonly partial struct Source4 : global::System.IEquatable<Source4>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminatorKind? Kind { get; }

        /// <summary>
        /// The checkpoint's files are fetched as presigned URLs, page by page.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.LoopsCheckpointS3SourceV1? S3 { get; init; }
#else
        public global::Baseten.LoopsCheckpointS3SourceV1? S3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(S3))]
#endif
        public bool IsS3 => S3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickS3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.LoopsCheckpointS3SourceV1? value)
        {
            value = S3;
            return IsS3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointS3SourceV1 PickS3() => IsS3
            ? S3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'S3' but the value was {ToString()}.");

        /// <summary>
        /// The checkpoint's files are pulled from a Baseten volume.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.LoopsCheckpointVolumeSourceV1? Volume { get; init; }
#else
        public global::Baseten.LoopsCheckpointVolumeSourceV1? Volume { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Volume))]
#endif
        public bool IsVolume => Volume != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVolume(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.LoopsCheckpointVolumeSourceV1? value)
        {
            value = Volume;
            return IsVolume;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointVolumeSourceV1 PickVolume() => IsVolume
            ? Volume!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Volume' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source4(global::Baseten.LoopsCheckpointS3SourceV1 value) => new Source4((global::Baseten.LoopsCheckpointS3SourceV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.LoopsCheckpointS3SourceV1?(Source4 @this) => @this.S3;

        /// <summary>
        ///
        /// </summary>
        public Source4(global::Baseten.LoopsCheckpointS3SourceV1? value)
        {
            S3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source4 FromS3(global::Baseten.LoopsCheckpointS3SourceV1? value) => new Source4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source4(global::Baseten.LoopsCheckpointVolumeSourceV1 value) => new Source4((global::Baseten.LoopsCheckpointVolumeSourceV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.LoopsCheckpointVolumeSourceV1?(Source4 @this) => @this.Volume;

        /// <summary>
        ///
        /// </summary>
        public Source4(global::Baseten.LoopsCheckpointVolumeSourceV1? value)
        {
            Volume = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source4 FromVolume(global::Baseten.LoopsCheckpointVolumeSourceV1? value) => new Source4(value);

        /// <summary>
        ///
        /// </summary>
        public Source4(
            global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminatorKind? kind,
            global::Baseten.LoopsCheckpointS3SourceV1? s3,
            global::Baseten.LoopsCheckpointVolumeSourceV1? volume
            )
        {
            Kind = kind;

            S3 = s3;
            Volume = volume;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Volume as object ??
            S3 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            S3?.ToString() ??
            Volume?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsS3 && !IsVolume || !IsS3 && IsVolume;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.LoopsCheckpointS3SourceV1, TResult>? s3 = null,
            global::System.Func<global::Baseten.LoopsCheckpointVolumeSourceV1, TResult>? volume = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsS3 && s3 != null)
            {
                return s3(S3!);
            }
            else if (IsVolume && volume != null)
            {
                return volume(Volume!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.LoopsCheckpointS3SourceV1>? s3 = null,

            global::System.Action<global::Baseten.LoopsCheckpointVolumeSourceV1>? volume = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsS3)
            {
                s3?.Invoke(S3!);
            }
            else if (IsVolume)
            {
                volume?.Invoke(Volume!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.LoopsCheckpointS3SourceV1>? s3 = null,
            global::System.Action<global::Baseten.LoopsCheckpointVolumeSourceV1>? volume = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsS3)
            {
                s3?.Invoke(S3!);
            }
            else if (IsVolume)
            {
                volume?.Invoke(Volume!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                S3,
                typeof(global::Baseten.LoopsCheckpointS3SourceV1),
                Volume,
                typeof(global::Baseten.LoopsCheckpointVolumeSourceV1),
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
        public bool Equals(Source4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.LoopsCheckpointS3SourceV1?>.Default.Equals(S3, other.S3) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.LoopsCheckpointVolumeSourceV1?>.Default.Equals(Volume, other.Volume)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Source4 obj1, Source4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Source4 obj1, Source4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source4 o && Equals(o);
        }
    }
}
