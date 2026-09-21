#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Remote source to sync from.
    /// </summary>
    public readonly partial struct Source2 : global::System.IEquatable<Source2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Hugging Face source.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.VolumeSyncSourceHuggingFaceV1? HuggingFace { get; init; }
#else
        public global::Baseten.VolumeSyncSourceHuggingFaceV1? HuggingFace { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HuggingFace))]
#endif
        public bool IsHuggingFace => HuggingFace != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHuggingFace(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.VolumeSyncSourceHuggingFaceV1? value)
        {
            value = HuggingFace;
            return IsHuggingFace;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceHuggingFaceV1 PickHuggingFace() => IsHuggingFace
            ? HuggingFace!
            : throw new global::System.InvalidOperationException($"Expected union variant 'HuggingFace' but the value was {ToString()}.");

        /// <summary>
        /// Amazon S3 source.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.VolumeSyncSourceS3V1? S3 { get; init; }
#else
        public global::Baseten.VolumeSyncSourceS3V1? S3 { get; }
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
            out global::Baseten.VolumeSyncSourceS3V1? value)
        {
            value = S3;
            return IsS3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceS3V1 PickS3() => IsS3
            ? S3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'S3' but the value was {ToString()}.");

        /// <summary>
        /// Google Cloud Storage source.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.VolumeSyncSourceGCSV1? Gcs { get; init; }
#else
        public global::Baseten.VolumeSyncSourceGCSV1? Gcs { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gcs))]
#endif
        public bool IsGcs => Gcs != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGcs(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.VolumeSyncSourceGCSV1? value)
        {
            value = Gcs;
            return IsGcs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceGCSV1 PickGcs() => IsGcs
            ? Gcs!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gcs' but the value was {ToString()}.");

        /// <summary>
        /// Azure Blob Storage source.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.VolumeSyncSourceAzureV1? Azure { get; init; }
#else
        public global::Baseten.VolumeSyncSourceAzureV1? Azure { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Azure))]
#endif
        public bool IsAzure => Azure != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAzure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.VolumeSyncSourceAzureV1? value)
        {
            value = Azure;
            return IsAzure;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceAzureV1 PickAzure() => IsAzure
            ? Azure!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Azure' but the value was {ToString()}.");

        /// <summary>
        /// Cloudflare R2 source.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.VolumeSyncSourceR2V1? R2 { get; init; }
#else
        public global::Baseten.VolumeSyncSourceR2V1? R2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(R2))]
#endif
        public bool IsR2 => R2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickR2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.VolumeSyncSourceR2V1? value)
        {
            value = R2;
            return IsR2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceR2V1 PickR2() => IsR2
            ? R2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'R2' but the value was {ToString()}.");

        /// <summary>
        /// CoreWeave object storage source.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.VolumeSyncSourceCoreWeaveV1? Coreweave { get; init; }
#else
        public global::Baseten.VolumeSyncSourceCoreWeaveV1? Coreweave { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Coreweave))]
#endif
        public bool IsCoreweave => Coreweave != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCoreweave(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.VolumeSyncSourceCoreWeaveV1? value)
        {
            value = Coreweave;
            return IsCoreweave;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceCoreWeaveV1 PickCoreweave() => IsCoreweave
            ? Coreweave!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Coreweave' but the value was {ToString()}.");

        /// <summary>
        /// Baseten training artifact source.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.VolumeSyncSourceBasetenTrainingV1? BasetenTraining { get; init; }
#else
        public global::Baseten.VolumeSyncSourceBasetenTrainingV1? BasetenTraining { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BasetenTraining))]
#endif
        public bool IsBasetenTraining => BasetenTraining != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBasetenTraining(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.VolumeSyncSourceBasetenTrainingV1? value)
        {
            value = BasetenTraining;
            return IsBasetenTraining;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceBasetenTrainingV1 PickBasetenTraining() => IsBasetenTraining
            ? BasetenTraining!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BasetenTraining' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source2(global::Baseten.VolumeSyncSourceHuggingFaceV1 value) => new Source2((global::Baseten.VolumeSyncSourceHuggingFaceV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.VolumeSyncSourceHuggingFaceV1?(Source2 @this) => @this.HuggingFace;

        /// <summary>
        ///
        /// </summary>
        public Source2(global::Baseten.VolumeSyncSourceHuggingFaceV1? value)
        {
            HuggingFace = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source2 FromHuggingFace(global::Baseten.VolumeSyncSourceHuggingFaceV1? value) => new Source2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source2(global::Baseten.VolumeSyncSourceS3V1 value) => new Source2((global::Baseten.VolumeSyncSourceS3V1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.VolumeSyncSourceS3V1?(Source2 @this) => @this.S3;

        /// <summary>
        ///
        /// </summary>
        public Source2(global::Baseten.VolumeSyncSourceS3V1? value)
        {
            S3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source2 FromS3(global::Baseten.VolumeSyncSourceS3V1? value) => new Source2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source2(global::Baseten.VolumeSyncSourceGCSV1 value) => new Source2((global::Baseten.VolumeSyncSourceGCSV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.VolumeSyncSourceGCSV1?(Source2 @this) => @this.Gcs;

        /// <summary>
        ///
        /// </summary>
        public Source2(global::Baseten.VolumeSyncSourceGCSV1? value)
        {
            Gcs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source2 FromGcs(global::Baseten.VolumeSyncSourceGCSV1? value) => new Source2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source2(global::Baseten.VolumeSyncSourceAzureV1 value) => new Source2((global::Baseten.VolumeSyncSourceAzureV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.VolumeSyncSourceAzureV1?(Source2 @this) => @this.Azure;

        /// <summary>
        ///
        /// </summary>
        public Source2(global::Baseten.VolumeSyncSourceAzureV1? value)
        {
            Azure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source2 FromAzure(global::Baseten.VolumeSyncSourceAzureV1? value) => new Source2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source2(global::Baseten.VolumeSyncSourceR2V1 value) => new Source2((global::Baseten.VolumeSyncSourceR2V1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.VolumeSyncSourceR2V1?(Source2 @this) => @this.R2;

        /// <summary>
        ///
        /// </summary>
        public Source2(global::Baseten.VolumeSyncSourceR2V1? value)
        {
            R2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source2 FromR2(global::Baseten.VolumeSyncSourceR2V1? value) => new Source2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source2(global::Baseten.VolumeSyncSourceCoreWeaveV1 value) => new Source2((global::Baseten.VolumeSyncSourceCoreWeaveV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.VolumeSyncSourceCoreWeaveV1?(Source2 @this) => @this.Coreweave;

        /// <summary>
        ///
        /// </summary>
        public Source2(global::Baseten.VolumeSyncSourceCoreWeaveV1? value)
        {
            Coreweave = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source2 FromCoreweave(global::Baseten.VolumeSyncSourceCoreWeaveV1? value) => new Source2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source2(global::Baseten.VolumeSyncSourceBasetenTrainingV1 value) => new Source2((global::Baseten.VolumeSyncSourceBasetenTrainingV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.VolumeSyncSourceBasetenTrainingV1?(Source2 @this) => @this.BasetenTraining;

        /// <summary>
        ///
        /// </summary>
        public Source2(global::Baseten.VolumeSyncSourceBasetenTrainingV1? value)
        {
            BasetenTraining = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source2 FromBasetenTraining(global::Baseten.VolumeSyncSourceBasetenTrainingV1? value) => new Source2(value);

        /// <summary>
        ///
        /// </summary>
        public Source2(
            global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminatorType? type,
            global::Baseten.VolumeSyncSourceHuggingFaceV1? huggingFace,
            global::Baseten.VolumeSyncSourceS3V1? s3,
            global::Baseten.VolumeSyncSourceGCSV1? gcs,
            global::Baseten.VolumeSyncSourceAzureV1? azure,
            global::Baseten.VolumeSyncSourceR2V1? r2,
            global::Baseten.VolumeSyncSourceCoreWeaveV1? coreweave,
            global::Baseten.VolumeSyncSourceBasetenTrainingV1? basetenTraining
            )
        {
            Type = type;

            HuggingFace = huggingFace;
            S3 = s3;
            Gcs = gcs;
            Azure = azure;
            R2 = r2;
            Coreweave = coreweave;
            BasetenTraining = basetenTraining;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BasetenTraining as object ??
            Coreweave as object ??
            R2 as object ??
            Azure as object ??
            Gcs as object ??
            S3 as object ??
            HuggingFace as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            HuggingFace?.ToString() ??
            S3?.ToString() ??
            Gcs?.ToString() ??
            Azure?.ToString() ??
            R2?.ToString() ??
            Coreweave?.ToString() ??
            BasetenTraining?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsHuggingFace && !IsS3 && !IsGcs && !IsAzure && !IsR2 && !IsCoreweave && !IsBasetenTraining || !IsHuggingFace && IsS3 && !IsGcs && !IsAzure && !IsR2 && !IsCoreweave && !IsBasetenTraining || !IsHuggingFace && !IsS3 && IsGcs && !IsAzure && !IsR2 && !IsCoreweave && !IsBasetenTraining || !IsHuggingFace && !IsS3 && !IsGcs && IsAzure && !IsR2 && !IsCoreweave && !IsBasetenTraining || !IsHuggingFace && !IsS3 && !IsGcs && !IsAzure && IsR2 && !IsCoreweave && !IsBasetenTraining || !IsHuggingFace && !IsS3 && !IsGcs && !IsAzure && !IsR2 && IsCoreweave && !IsBasetenTraining || !IsHuggingFace && !IsS3 && !IsGcs && !IsAzure && !IsR2 && !IsCoreweave && IsBasetenTraining;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.VolumeSyncSourceHuggingFaceV1, TResult>? huggingFace = null,
            global::System.Func<global::Baseten.VolumeSyncSourceS3V1, TResult>? s3 = null,
            global::System.Func<global::Baseten.VolumeSyncSourceGCSV1, TResult>? gcs = null,
            global::System.Func<global::Baseten.VolumeSyncSourceAzureV1, TResult>? azure = null,
            global::System.Func<global::Baseten.VolumeSyncSourceR2V1, TResult>? r2 = null,
            global::System.Func<global::Baseten.VolumeSyncSourceCoreWeaveV1, TResult>? coreweave = null,
            global::System.Func<global::Baseten.VolumeSyncSourceBasetenTrainingV1, TResult>? basetenTraining = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHuggingFace && huggingFace != null)
            {
                return huggingFace(HuggingFace!);
            }
            else if (IsS3 && s3 != null)
            {
                return s3(S3!);
            }
            else if (IsGcs && gcs != null)
            {
                return gcs(Gcs!);
            }
            else if (IsAzure && azure != null)
            {
                return azure(Azure!);
            }
            else if (IsR2 && r2 != null)
            {
                return r2(R2!);
            }
            else if (IsCoreweave && coreweave != null)
            {
                return coreweave(Coreweave!);
            }
            else if (IsBasetenTraining && basetenTraining != null)
            {
                return basetenTraining(BasetenTraining!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.VolumeSyncSourceHuggingFaceV1>? huggingFace = null,

            global::System.Action<global::Baseten.VolumeSyncSourceS3V1>? s3 = null,

            global::System.Action<global::Baseten.VolumeSyncSourceGCSV1>? gcs = null,

            global::System.Action<global::Baseten.VolumeSyncSourceAzureV1>? azure = null,

            global::System.Action<global::Baseten.VolumeSyncSourceR2V1>? r2 = null,

            global::System.Action<global::Baseten.VolumeSyncSourceCoreWeaveV1>? coreweave = null,

            global::System.Action<global::Baseten.VolumeSyncSourceBasetenTrainingV1>? basetenTraining = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHuggingFace)
            {
                huggingFace?.Invoke(HuggingFace!);
            }
            else if (IsS3)
            {
                s3?.Invoke(S3!);
            }
            else if (IsGcs)
            {
                gcs?.Invoke(Gcs!);
            }
            else if (IsAzure)
            {
                azure?.Invoke(Azure!);
            }
            else if (IsR2)
            {
                r2?.Invoke(R2!);
            }
            else if (IsCoreweave)
            {
                coreweave?.Invoke(Coreweave!);
            }
            else if (IsBasetenTraining)
            {
                basetenTraining?.Invoke(BasetenTraining!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.VolumeSyncSourceHuggingFaceV1>? huggingFace = null,
            global::System.Action<global::Baseten.VolumeSyncSourceS3V1>? s3 = null,
            global::System.Action<global::Baseten.VolumeSyncSourceGCSV1>? gcs = null,
            global::System.Action<global::Baseten.VolumeSyncSourceAzureV1>? azure = null,
            global::System.Action<global::Baseten.VolumeSyncSourceR2V1>? r2 = null,
            global::System.Action<global::Baseten.VolumeSyncSourceCoreWeaveV1>? coreweave = null,
            global::System.Action<global::Baseten.VolumeSyncSourceBasetenTrainingV1>? basetenTraining = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHuggingFace)
            {
                huggingFace?.Invoke(HuggingFace!);
            }
            else if (IsS3)
            {
                s3?.Invoke(S3!);
            }
            else if (IsGcs)
            {
                gcs?.Invoke(Gcs!);
            }
            else if (IsAzure)
            {
                azure?.Invoke(Azure!);
            }
            else if (IsR2)
            {
                r2?.Invoke(R2!);
            }
            else if (IsCoreweave)
            {
                coreweave?.Invoke(Coreweave!);
            }
            else if (IsBasetenTraining)
            {
                basetenTraining?.Invoke(BasetenTraining!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                HuggingFace,
                typeof(global::Baseten.VolumeSyncSourceHuggingFaceV1),
                S3,
                typeof(global::Baseten.VolumeSyncSourceS3V1),
                Gcs,
                typeof(global::Baseten.VolumeSyncSourceGCSV1),
                Azure,
                typeof(global::Baseten.VolumeSyncSourceAzureV1),
                R2,
                typeof(global::Baseten.VolumeSyncSourceR2V1),
                Coreweave,
                typeof(global::Baseten.VolumeSyncSourceCoreWeaveV1),
                BasetenTraining,
                typeof(global::Baseten.VolumeSyncSourceBasetenTrainingV1),
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
        public bool Equals(Source2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.VolumeSyncSourceHuggingFaceV1?>.Default.Equals(HuggingFace, other.HuggingFace) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.VolumeSyncSourceS3V1?>.Default.Equals(S3, other.S3) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.VolumeSyncSourceGCSV1?>.Default.Equals(Gcs, other.Gcs) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.VolumeSyncSourceAzureV1?>.Default.Equals(Azure, other.Azure) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.VolumeSyncSourceR2V1?>.Default.Equals(R2, other.R2) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.VolumeSyncSourceCoreWeaveV1?>.Default.Equals(Coreweave, other.Coreweave) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.VolumeSyncSourceBasetenTrainingV1?>.Default.Equals(BasetenTraining, other.BasetenTraining)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Source2 obj1, Source2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Source2 obj1, Source2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source2 o && Equals(o);
        }
    }
}
