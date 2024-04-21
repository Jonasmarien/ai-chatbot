using AI.Chatbot.API.models;
using Microsoft.AspNetCore.Mvc;

namespace AI.Chatbot.API.controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AssistantController(IAssistant assistant) : ControllerBase
    {
        private readonly IAssistant _assistant = assistant ?? throw new ArgumentNullException(nameof(assistant));

        [HttpPost("conversation")]
        public async Task<IActionResult> StartConversation()
        {
            var conversation = await _assistant.StartConversationAsync();
            return Ok(conversation);
        }
    }
}