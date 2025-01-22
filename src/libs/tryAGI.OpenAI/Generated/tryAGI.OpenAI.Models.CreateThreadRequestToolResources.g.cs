
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A set of resources that are made available to the assistant's tools in this thread. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
    /// </summary>
    public sealed partial class CreateThreadRequestToolResources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_interpreter")]
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesCodeInterpreter? CodeInterpreter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_search")]
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearch? FileSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequestToolResources" /> class.
        /// </summary>
        /// <param name="codeInterpreter"></param>
        /// <param name="fileSearch"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateThreadRequestToolResources(
            global::tryAGI.OpenAI.CreateThreadRequestToolResourcesCodeInterpreter? codeInterpreter,
            global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearch? fileSearch)
        {
            this.CodeInterpreter = codeInterpreter;
            this.FileSearch = fileSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequestToolResources" /> class.
        /// </summary>
        public CreateThreadRequestToolResources()
        {
        }
    }
}