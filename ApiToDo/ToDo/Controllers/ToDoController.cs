using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models;
using ToDo.Repository;

namespace ToDo.Controllers
{
    public class ToDoController : Controller
    {
        readonly ITarefaRepository _tarefaRepository;
        public ToDoController(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        [Route("api/[controller]")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tarefaRepository.Get());
        }

        [Route("api/[controller]/{id}")]
        [HttpGet]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(_tarefaRepository.Get(id));
        }

        [Route("api/[controller]")]
        [HttpPost]
        public IActionResult Post([FromBody]Tarefa tarefa)
        {
            _tarefaRepository.Post(tarefa);
            return Ok(tarefa);
        }

        [Route("api/[controller]/{id}")]
        [HttpDelete]
        public IActionResult Delete([FromRoute] int id)
        {
            _tarefaRepository.Delete(id);
            return Ok();
        }

        [Route("api/[controller]")]
        [HttpPut]
        public IActionResult Update([FromBody] Tarefa tarefa)
        {
            _tarefaRepository.Update(tarefa);
            return Ok(tarefa);
        }

    }
}
