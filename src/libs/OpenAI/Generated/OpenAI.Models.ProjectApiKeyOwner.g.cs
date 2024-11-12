
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectApiKeyOwner
    {
        /// <summary>
        /// `user` or `service_account`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.ProjectApiKeyOwnerTypeJsonConverter))]
        public global::OpenAI.ProjectApiKeyOwnerType? Type { get; set; }

        /// <summary>
        /// Represents an individual user in a project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::OpenAI.ProjectUser? User { get; set; }

        /// <summary>
        /// Represents an individual service account in a project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account")]
        public global::OpenAI.ProjectServiceAccount? ServiceAccount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectApiKeyOwner" /> class.
        /// </summary>
        /// <param name="type">
        /// `user` or `service_account`
        /// </param>
        /// <param name="user">
        /// Represents an individual user in a project.
        /// </param>
        /// <param name="serviceAccount">
        /// Represents an individual service account in a project.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProjectApiKeyOwner(
            global::OpenAI.ProjectApiKeyOwnerType? type,
            global::OpenAI.ProjectUser? user,
            global::OpenAI.ProjectServiceAccount? serviceAccount)
        {
            this.Type = type;
            this.User = user;
            this.ServiceAccount = serviceAccount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectApiKeyOwner" /> class.
        /// </summary>
        public ProjectApiKeyOwner()
        {
        }
    }
}