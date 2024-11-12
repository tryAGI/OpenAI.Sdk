
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The expiration policy for a vector store.
    /// </summary>
    public sealed partial class VectorStoreExpirationAfter
    {
        /// <summary>
        /// Anchor timestamp after which the expiration policy applies. Supported anchors: `last_active_at`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter))]
        public global::OpenAI.VectorStoreExpirationAfterAnchor Anchor { get; set; }

        /// <summary>
        /// The number of days after the anchor time that the vector store will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Days { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreExpirationAfter" /> class.
        /// </summary>
        /// <param name="anchor">
        /// Anchor timestamp after which the expiration policy applies. Supported anchors: `last_active_at`.
        /// </param>
        /// <param name="days">
        /// The number of days after the anchor time that the vector store will expire.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public VectorStoreExpirationAfter(
            int days,
            global::OpenAI.VectorStoreExpirationAfterAnchor anchor)
        {
            this.Days = days;
            this.Anchor = anchor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreExpirationAfter" /> class.
        /// </summary>
        public VectorStoreExpirationAfter()
        {
        }
    }
}