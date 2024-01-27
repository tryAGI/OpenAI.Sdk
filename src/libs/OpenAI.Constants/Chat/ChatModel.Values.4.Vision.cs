// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

// ReSharper disable InconsistentNaming

public readonly partial record struct ChatModel
{
    /// <summary>
    /// Ability to understand images, in addition to all other GPT-4 Turbo capabilities.
    /// This is a preview model version and not suited yet for production traffic. <br/>
    /// According https://platform.openai.com/docs/models/gpt-4-and-gpt-4-turbo <br/>
    /// Max input tokens: 128,000 tokens <br/>
    /// Max output tokens: 4,096 tokens <br/>
    /// Training data: Up to Apr 2023 <br/>
    /// </summary>
    internal const string Gpt4_1106_VisionPreviewValue = "gpt-4-1106-vision-preview";
    
    /// <inheritdoc cref="Gpt4_1106_VisionPreviewValue"/>
    /// <remarks>Alias - Currently points to gpt-4-1106-vision-preview.</remarks>
    internal const string Gpt4VisionPreviewValue = "gpt-4-vision-preview";
    
    /// <inheritdoc cref="Gpt4_1106_VisionPreviewValue"/>
    public static ChatModel Gpt4_1106_VisionPreview { get; } = new(
        Gpt4_1106_VisionPreviewValue,
        ContextLength: 128_000,
        PricePerInputTokenInUsd: 0.0100 * 0.001,
        PricePerOutputTokenInUsd: 0.0300 * 0.001);
    
    /// <inheritdoc cref="Gpt4VisionPreviewValue"/>
    public static ChatModel Gpt4VisionPreview { get; } = Gpt4_1106_VisionPreview with
    {
        Value = Gpt4VisionPreviewValue,
    };
}