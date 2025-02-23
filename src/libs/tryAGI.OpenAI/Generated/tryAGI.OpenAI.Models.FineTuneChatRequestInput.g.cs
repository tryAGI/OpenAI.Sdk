
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The per-line training example of a fine-tuning input file for chat models using the supervised method.
    /// </summary>
    public sealed partial class FineTuneChatRequestInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage, global::tryAGI.OpenAI.ChatCompletionRequestUserMessage, global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessage?, global::tryAGI.OpenAI.ChatCompletionRequestToolMessage, global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage>>? Messages { get; set; }

        /// <summary>
        /// A list of tools the model may generate JSON inputs for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// A list of functions the model may generate JSON inputs for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionFunctions>? Functions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneChatRequestInput" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="tools">
        /// A list of tools the model may generate JSON inputs for.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneChatRequestInput(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage, global::tryAGI.OpenAI.ChatCompletionRequestUserMessage, global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessage?, global::tryAGI.OpenAI.ChatCompletionRequestToolMessage, global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage>>? messages,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTool>? tools,
            bool? parallelToolCalls)
        {
            this.Messages = messages;
            this.Tools = tools;
            this.ParallelToolCalls = parallelToolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneChatRequestInput" /> class.
        /// </summary>
        public FineTuneChatRequestInput()
        {
        }
    }
}