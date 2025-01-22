
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogRateLimitUpdated
    {
        /// <summary>
        /// The rate limit ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The payload used to update the rate limits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes_requested")]
        public global::tryAGI.OpenAI.AuditLogRateLimitUpdatedChangesRequested? ChangesRequested { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogRateLimitUpdated" /> class.
        /// </summary>
        /// <param name="id">
        /// The rate limit ID
        /// </param>
        /// <param name="changesRequested">
        /// The payload used to update the rate limits.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AuditLogRateLimitUpdated(
            string? id,
            global::tryAGI.OpenAI.AuditLogRateLimitUpdatedChangesRequested? changesRequested)
        {
            this.Id = id;
            this.ChangesRequested = changesRequested;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogRateLimitUpdated" /> class.
        /// </summary>
        public AuditLogRateLimitUpdated()
        {
        }
    }
}