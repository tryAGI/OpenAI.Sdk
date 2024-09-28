#nullable enable

namespace OpenAI
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Create a message.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.MessageObject> CreateMessageAsync(
            string threadId,
            global::OpenAI.CreateMessageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a message.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="role">
        /// The role of the entity that is creating the message. Allowed values include:<br/>
        /// - `user`: Indicates the message is sent by an actual user and should be used in most cases to represent user-generated messages.<br/>
        /// - `assistant`: Indicates the message is generated by the assistant. Use this value to insert messages from the assistant into the conversation.
        /// </param>
        /// <param name="content"></param>
        /// <param name="attachments">
        /// A list of files attached to the message, and the tools they should be added to.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maximum of 512 characters long.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.MessageObject> CreateMessageAsync(
            string threadId,
            global::OpenAI.CreateMessageRequestRole role,
            global::OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::OpenAI.OneOf<global::OpenAI.MessageContentImageFileObject, global::OpenAI.MessageContentImageUrlObject, global::OpenAI.MessageRequestContentTextObject>>> content,
            global::System.Collections.Generic.IList<global::OpenAI.CreateMessageRequestAttachment>? attachments = default,
            global::OpenAI.CreateMessageRequestMetadata? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}