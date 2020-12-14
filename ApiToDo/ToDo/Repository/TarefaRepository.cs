using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Repository
{
    public class TarefaRepository : ITarefaRepository
    {
        AppContext _appContext;

        public TarefaRepository(AppContext appContext)
        {
            _appContext = appContext;
        }
        public void Post(Tarefa tarefa)
        {
            _appContext.Tarefas.Add(tarefa);
            _appContext.SaveChanges();
        }

        public Tarefa Get(int id)
        {
            return _appContext.Tarefas.FirstOrDefault(t => t.Id == id);
        }

        public List<Tarefa> Get()
        {
            return _appContext.Tarefas.ToList();
        }

        public void Delete(int id)
        {
            _appContext.Tarefas.Remove(Get(id));
            _appContext.SaveChanges();
        }

        public Tarefa Update(Tarefa tarefa)
        {
            _appContext.Tarefas.Update(tarefa);
            _appContext.SaveChanges();

            return Get(tarefa.Id);
        }
    }
}
