using System.Collections.Generic;
using ToDo.Models;

namespace ToDo.Repository
{
    public interface ITarefaRepository
    {
        void Post(Tarefa tarefa);
        Tarefa Get(int id);
        List<Tarefa> Get();
        void Delete(int Id);
        Tarefa Update(Tarefa tarefa);
    }
}