#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// How the connection's secret authenticates with Amazon Bedrock.
    /// </summary>
    public readonly partial struct Auth2 : global::System.IEquatable<Auth2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod? Method { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1? ApiKey { get; init; }
#else
        public global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1? ApiKey { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiKey))]
#endif
        public bool IsApiKey => ApiKey != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApiKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1? value)
        {
            value = ApiKey;
            return IsApiKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1 PickApiKey() => ApiKey is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiKey' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1? AccessKeys { get; init; }
#else
        public global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1? AccessKeys { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AccessKeys))]
#endif
        public bool IsAccessKeys => AccessKeys != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAccessKeys(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1? value)
        {
            value = AccessKeys;
            return IsAccessKeys;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1 PickAccessKeys() => AccessKeys is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AccessKeys' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Auth2(global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1 value) => new Auth2((global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1?(Auth2 @this) => @this.ApiKey;

        /// <summary>
        ///
        /// </summary>
        public Auth2(global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1? value)
        {
            ApiKey = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Auth2 FromApiKey(global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1? value) => new Auth2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Auth2(global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1 value) => new Auth2((global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1?(Auth2 @this) => @this.AccessKeys;

        /// <summary>
        ///
        /// </summary>
        public Auth2(global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1? value)
        {
            AccessKeys = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Auth2 FromAccessKeys(global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1? value) => new Auth2(value);

        /// <summary>
        ///
        /// </summary>
        public Auth2(
            global::Baseten.UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod? method,
            global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1? apiKey,
            global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1? accessKeys
            )
        {
            Method = method;

            ApiKey = apiKey;
            AccessKeys = accessKeys;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AccessKeys as object ??
            ApiKey as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ApiKey?.ToString() ??
            AccessKeys?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsApiKey && !IsAccessKeys || !IsApiKey && IsAccessKeys;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1, TResult>? apiKey = null,
            global::System.Func<global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1, TResult>? accessKeys = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ApiKey is { } __value0 && apiKey != null)
            {
                return apiKey(__value0);
            }
            else if (AccessKeys is { } __value1 && accessKeys != null)
            {
                return accessKeys(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1>? apiKey = null,

            global::System.Action<global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1>? accessKeys = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ApiKey is { } __value0)
            {
                apiKey?.Invoke(__value0);
            }
            else if (AccessKeys is { } __value1)
            {
                accessKeys?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1>? apiKey = null,
            global::System.Action<global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1>? accessKeys = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ApiKey is { } __value0)
            {
                apiKey?.Invoke(__value0);
            }
            else if (AccessKeys is { } __value1)
            {
                accessKeys?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ApiKey,
                typeof(global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1),
                AccessKeys,
                typeof(global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1),
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
        public bool Equals(Auth2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1?>.Default.Equals(ApiKey, other.ApiKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1?>.Default.Equals(AccessKeys, other.AccessKeys)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Auth2 obj1, Auth2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Auth2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Auth2 obj1, Auth2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Auth2 o && Equals(o);
        }
    }
}
