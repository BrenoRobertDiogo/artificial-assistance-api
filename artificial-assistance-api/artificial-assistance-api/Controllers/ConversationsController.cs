using MicrosoFt.AspNetCore.Mvc;

namespace artificial_assistance_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversationsController : ControllerBase
    {
        private readonly ILogger<ConversationsController> logger;
        public ConversationsController()
        {
            this.logger = logger;
        }

        [HttpGet(Name = "Conversation")]
        public IEnumerable<string> List()
        {
            return [""];
        }

        [HttpGet(Name = "Conversation/$id")]
        public string Get(int id)
        {
            return "";
        }

        [HttpPost(Name = "Conversation")]
        public string Post()
        {
            return "";
        }

    }
}
