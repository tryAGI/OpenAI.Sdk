
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of tool call. This is always going to be `file_search` for this type of tool call.
    /// </summary>
    public enum RunStepDetailsToolCallsFileSearchObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepDetailsToolCallsFileSearchObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDetailsToolCallsFileSearchObjectType value)
        {
            return value switch
            {
                RunStepDetailsToolCallsFileSearchObjectType.FileSearch => "file_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDetailsToolCallsFileSearchObjectType? ToEnum(string value)
        {
            return value switch
            {
                "file_search" => RunStepDetailsToolCallsFileSearchObjectType.FileSearch,
                _ => null,
            };
        }
    }
}