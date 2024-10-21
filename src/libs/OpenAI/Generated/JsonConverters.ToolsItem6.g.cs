#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ToolsItem6JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.ToolsItem6>
    {
        /// <inheritdoc />
        public override global::OpenAI.ToolsItem6 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageObjectAttachmentToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageObjectAttachmentToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageObjectAttachmentToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.AssistantToolsCode? assistantCode = default;
            if (discriminator?.Type == global::OpenAI.MessageObjectAttachmentToolDiscriminatorType.CodeInterpreter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantToolsCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantToolsCode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantToolsCode)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantToolsFileSearchTypeOnly? assistantFileSearchTypeOnly = default;
            if (discriminator?.Type == global::OpenAI.MessageObjectAttachmentToolDiscriminatorType.FileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantToolsFileSearchTypeOnly), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantToolsFileSearchTypeOnly> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantToolsFileSearchTypeOnly)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.ToolsItem6(
                discriminator?.Type,
                assistantCode,
                assistantFileSearchTypeOnly
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.ToolsItem6 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAssistantCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantToolsCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantToolsCode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantToolsCode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantCode, typeInfo);
            }
            else if (value.IsAssistantFileSearchTypeOnly)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantToolsFileSearchTypeOnly), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantToolsFileSearchTypeOnly?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantToolsFileSearchTypeOnly).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantFileSearchTypeOnly, typeInfo);
            }
        }
    }
}