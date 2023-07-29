using Microsoft.AspNetCore.Mvc;
using TarefasBackEnd.Repositories;

namespace TarefasBackEnd.Controllers
{
    [ApiController]
    [Route("tarefa")]

    public class TarefaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromServices]ITarefaRepository repository){

            var tarefas = repository.Read();
            return Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody]TarefaController model, [FromServices]ITarefaRepository repository)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            
            repository.Create(model);

            return Ok();
        }
    }
}