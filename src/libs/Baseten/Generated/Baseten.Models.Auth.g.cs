#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// How the connection's secret authenticates with Amazon Bedrock.
    /// </summary>
    public readonly partial struct Auth : global::System.IEquatable<Auth>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionConfigBedrockV1AuthDiscriminatorMethod? Method { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.GridConnectionBedrockApiKeyAuthV1? ApiKey { get; init; }
#else
        public global::Baseten.GridConnectionBedrockApiKeyAuthV1? ApiKey { get; }
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
            out global::Baseten.GridConnectionBedrockApiKeyAuthV1? value)
        {
            value = ApiKey;
            return IsApiKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionBedrockApiKeyAuthV1 PickApiKey() => ApiKey is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiKey' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Baseten.GridConnectionBedrockAccessKeysAuthV1? AccessKeys { get; init; }
#else
        public global::Baseten.GridConnectionBedrockAccessKeysAuthV1? AccessKeys { get; }
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
            out global::Baseten.GridConnectionBedrockAccessKeysAuthV1? value)
        {
            value = AccessKeys;
            return IsAccessKeys;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionBedrockAccessKeysAuthV1 PickAccessKeys() => AccessKeys is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AccessKeys' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Auth(global::Baseten.GridConnectionBedrockApiKeyAuthV1 value) => new Auth((global::Baseten.GridConnectionBedrockApiKeyAuthV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.GridConnectionBedrockApiKeyAuthV1?(Auth @this) => @this.ApiKey;

        /// <summary>
        ///
        /// </summary>
        public Auth(global::Baseten.GridConnectionBedrockApiKeyAuthV1? value)
        {
            ApiKey = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Auth FromApiKey(global::Baseten.GridConnectionBedrockApiKeyAuthV1? value) => new Auth(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Auth(global::Baseten.GridConnectionBedrockAccessKeysAuthV1 value) => new Auth((global::Baseten.GridConnectionBedrockAccessKeysAuthV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Baseten.GridConnectionBedrockAccessKeysAuthV1?(Auth @this) => @this.AccessKeys;

        /// <summary>
        ///
        /// </summary>
        public Auth(global::Baseten.GridConnectionBedrockAccessKeysAuthV1? value)
        {
            AccessKeys = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Auth FromAccessKeys(global::Baseten.GridConnectionBedrockAccessKeysAuthV1? value) => new Auth(value);

        /// <summary>
        ///
        /// </summary>
        public Auth(
            global::Baseten.GridConnectionConfigBedrockV1AuthDiscriminatorMethod? method,
            global::Baseten.GridConnectionBedrockApiKeyAuthV1? apiKey,
            global::Baseten.GridConnectionBedrockAccessKeysAuthV1? accessKeys
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
            global::System.Func<global::Baseten.GridConnectionBedrockApiKeyAuthV1, TResult>? apiKey = null,
            global::System.Func<global::Baseten.GridConnectionBedrockAccessKeysAuthV1, TResult>? accessKeys = null,
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
            global::System.Action<global::Baseten.GridConnectionBedrockApiKeyAuthV1>? apiKey = null,

            global::System.Action<global::Baseten.GridConnectionBedrockAccessKeysAuthV1>? accessKeys = null,
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
            global::System.Action<global::Baseten.GridConnectionBedrockApiKeyAuthV1>? apiKey = null,
            global::System.Action<global::Baseten.GridConnectionBedrockAccessKeysAuthV1>? accessKeys = null,
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
                typeof(global::Baseten.GridConnectionBedrockApiKeyAuthV1),
                AccessKeys,
                typeof(global::Baseten.GridConnectionBedrockAccessKeysAuthV1),
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
        public bool Equals(Auth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Baseten.GridConnectionBedrockApiKeyAuthV1?>.Default.Equals(ApiKey, other.ApiKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Baseten.GridConnectionBedrockAccessKeysAuthV1?>.Default.Equals(AccessKeys, other.AccessKeys)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Auth obj1, Auth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Auth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Auth obj1, Auth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Auth o && Equals(o);
        }
    }
}
