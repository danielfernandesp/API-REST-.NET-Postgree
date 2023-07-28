using Microsoft.AspNetCore.Mvc;

namespace TarefasBackEnd.Controllers
{
    [ApiController]
    [Route("tarefa")]

    public class TarefaController : ControllerBase
    {
        public IActionResult Get(){
            return Ok();
        }
    }
}