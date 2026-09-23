
#nullable enable

namespace SmallestAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAccessTokenRequest
    {
        /// <summary>
        /// How long the token stays valid, in seconds. Between 30 and 900. Defaults to 300 when omitted.<br/>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_seconds")]
        public int? TtlSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessTokenRequest" /> class.
        /// </summary>
        /// <param name="ttlSeconds">
        /// How long the token stays valid, in seconds. Between 30 and 900. Defaults to 300 when omitted.<br/>
        /// Default Value: 300
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAccessTokenRequest(
            int? ttlSeconds)
        {
            this.TtlSeconds = ttlSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessTokenRequest" /> class.
        /// </summary>
        public CreateAccessTokenRequest()
        {
        }

    }
}