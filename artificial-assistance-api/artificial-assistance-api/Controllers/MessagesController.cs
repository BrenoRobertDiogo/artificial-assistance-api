using Microsoft.AspNetCore.Mvc;

namespace artificial_assistance_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessagesController : ControllerBase
    {
        private readonly ILogger<MessagesController> logger;
        public MessagesController(ILogger<MessagesController> logger)
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
