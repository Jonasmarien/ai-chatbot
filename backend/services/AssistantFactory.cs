public interface IAssistantFactory {
    public Task<IAssistant> Create();
}

public class AssistantFactory : IAssistantFactory {
    public Task<IAssistant> Create() {
        throw new NotImplementedException();
    }
}