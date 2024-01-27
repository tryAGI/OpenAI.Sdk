// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ChatModel(
    string Value,
    int ContextLength,
    double PricePerInputTokenInUsd,
    double PricePerOutputTokenInUsd)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Implicitly converts <see cref="ChatModel"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ChatModel model)
    {
        return model.Value;
    }
    
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="inputTokens"></param>
    /// <param name="outputTokens"></param>
    /// <returns></returns>
    public double GetPriceInUsd(
        int inputTokens,
        int outputTokens)
    {
        return inputTokens * PricePerInputTokenInUsd +
               outputTokens * PricePerOutputTokenInUsd;
    }
}