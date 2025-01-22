
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChunkingStrategyRequestParamDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChunkingStrategyRequestParamDiscriminatorTypeJsonConverter))]
        public global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkingStrategyRequestParamDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChunkingStrategyRequestParamDiscriminator(
            global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkingStrategyRequestParamDiscriminator" /> class.
        /// </summary>
        public ChunkingStrategyRequestParamDiscriminator()
        {
        }
    }
}