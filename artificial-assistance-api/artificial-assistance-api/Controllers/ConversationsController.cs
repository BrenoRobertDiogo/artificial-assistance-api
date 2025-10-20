using Microsoft.AspNetCore.Mvc;

namespace artificial_assistance_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversationsController : ControllerBase
    {
        private readonly ILogger<ConversationsController> logger;
        public ConversationsController(ILogger<ConversationsController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> List()
        {
            var retorno = new List<string>();
            return retorno;
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "";
        }

        [HttpPost]
        public ActionResult<string> Post()
        {
            return "";
        }
    }
}
