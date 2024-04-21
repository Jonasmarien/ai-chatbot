public interface IOpenAIAssistantFactory {
    Task<IOpenAIAssistant> Create();
}

public class OpenAIAssistantFactory : IOpenAIAssistantFactory
{
    public Task<IOpenAIAssistant> Create()
    {
        throw new NotImplementedException();
    }
}