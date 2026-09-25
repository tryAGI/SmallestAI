
#nullable enable

namespace SmallestAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessTokenResponse
    {
        /// <summary>
        /// The short-lived token. Always starts with `wat_`. Send it as `Authorization: Bearer &lt;access_token&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// Always `Bearer`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.AccessTokenResponseTokenTypeJsonConverter))]
        public global::SmallestAI.AccessTokenResponseTokenType TokenType { get; set; }

        /// <summary>
        /// Seconds until the token expires, equal to the `ttl_seconds` that was applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresIn { get; set; }

        /// <summary>
        /// Expiry time in UTC (ISO 8601).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenResponse" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// The short-lived token. Always starts with `wat_`. Send it as `Authorization: Bearer &lt;access_token&gt;`.
        /// </param>
        /// <param name="expiresIn">
        /// Seconds until the token expires, equal to the `ttl_seconds` that was applied.
        /// </param>
        /// <param name="expiresAt">
        /// Expiry time in UTC (ISO 8601).
        /// </param>
        /// <param name="tokenType">
        /// Always `Bearer`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessTokenResponse(
            string accessToken,
            int expiresIn,
            global::System.DateTime expiresAt,
            global::SmallestAI.AccessTokenResponseTokenType tokenType)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.TokenType = tokenType;
            this.ExpiresIn = expiresIn;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenResponse" /> class.
        /// </summary>
        public AccessTokenResponse()
        {
        }

    }
}