public class AzureOpenAIConfiguration {

    public const string SectionKey = "AzureOpenAI";

    /// <summary>
    /// An Azure OpenAI resource URL, e.g. https://my-resource.openai.azure.com
    /// </summary>
    public string ResourceUrl { get; set; } = string.Empty;

    /// <summary>
    /// The API Key for the Azure OpenAI resource.
    /// </summary>
    public string ApiKey { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    public string LanguageModel { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    public string Instructions { get; set; } = string.Empty;
}