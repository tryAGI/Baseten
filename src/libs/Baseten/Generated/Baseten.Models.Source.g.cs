#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Where the new model is created from.
    /// </summary>
    public readonly partial struct Source : global::System.IEquatable<Source>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.CreateModelRequestV1SourceDiscriminatorKind? Kind { get; }

        /// <summary>
        /// Create a model by forking a library listing accessible to the caller's organization.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.LibraryListingSourceV1? LibraryListing { get; init; }
#else
        public global::Baseten.LibraryListingSourceV1? LibraryListing { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LibraryListing))]
#endif
        public bool IsLibraryListing => LibraryListing != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLibraryListing(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.LibraryListingSourceV1? value)
        {
            value = LibraryListing;
            return IsLibraryListing;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.LibraryListingSourceV1 PickLibraryListing() => IsLibraryListing
            ? LibraryListing!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LibraryListing' but the value was {ToString()}.");

        /// <summary>
        /// Create a model from an archive previously uploaded via the credentials<br/>
        /// issued by `POST /v1/prepare_model_upload`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.ModelArchiveSourceV1? ModelArchive { get; init; }
#else
        public global::Baseten.ModelArchiveSourceV1? ModelArchive { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelArchive))]
#endif
        public bool IsModelArchive => ModelArchive != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModelArchive(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.ModelArchiveSourceV1? value)
        {
            value = ModelArchive;
            return IsModelArchive;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Baseten.ModelArchiveSourceV1 PickModelArchive() => IsModelArchive
            ? ModelArchive!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelArchive' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::Baseten.LibraryListingSourceV1 value) => new Source((global::Baseten.LibraryListingSourceV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.LibraryListingSourceV1?(Source @this) => @this.LibraryListing;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::Baseten.LibraryListingSourceV1? value)
        {
            LibraryListing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Source FromLibraryListing(global::Baseten.LibraryListingSourceV1? value) => new Source(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::Baseten.ModelArchiveSourceV1 value) => new Source((global::Baseten.ModelArchiveSourceV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Baseten.ModelArchiveSourceV1?(Source @this) => @this.ModelArchive;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::Baseten.ModelArchiveSourceV1? value)
        {
            ModelArchive = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Source FromModelArchive(global::Baseten.ModelArchiveSourceV1? value) => new Source(value);

        /// <summary>
        /// 
        /// </summary>
        public Source(
            global::Baseten.CreateModelRequestV1SourceDiscriminatorKind? kind,
            global::Baseten.LibraryListingSourceV1? libraryListing,
            global::Baseten.ModelArchiveSourceV1? modelArchive
            )
        {
            Kind = kind;

            LibraryListing = libraryListing;
            ModelArchive = modelArchive;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ModelArchive as object ??
            LibraryListing as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LibraryListing?.ToString() ??
            ModelArchive?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLibraryListing && !IsModelArchive || !IsLibraryListing && IsModelArchive;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.LibraryListingSourceV1, TResult>? libraryListing = null,
            global::System.Func<global::Baseten.ModelArchiveSourceV1, TResult>? modelArchive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLibraryListing && libraryListing != null)
            {
                return libraryListing(LibraryListing!);
            }
            else if (IsModelArchive && modelArchive != null)
            {
                return modelArchive(ModelArchive!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.LibraryListingSourceV1>? libraryListing = null,

            global::System.Action<global::Baseten.ModelArchiveSourceV1>? modelArchive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLibraryListing)
            {
                libraryListing?.Invoke(LibraryListing!);
            }
            else if (IsModelArchive)
            {
                modelArchive?.Invoke(ModelArchive!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.LibraryListingSourceV1>? libraryListing = null,
            global::System.Action<global::Baseten.ModelArchiveSourceV1>? modelArchive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLibraryListing)
            {
                libraryListing?.Invoke(LibraryListing!);
            }
            else if (IsModelArchive)
            {
                modelArchive?.Invoke(ModelArchive!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LibraryListing,
                typeof(global::Baseten.LibraryListingSourceV1),
                ModelArchive,
                typeof(global::Baseten.ModelArchiveSourceV1),
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
        public bool Equals(Source other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.LibraryListingSourceV1?>.Default.Equals(LibraryListing, other.LibraryListing) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.ModelArchiveSourceV1?>.Default.Equals(ModelArchive, other.ModelArchive) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Source obj1, Source obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Source obj1, Source obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source o && Equals(o);
        }
    }
}
