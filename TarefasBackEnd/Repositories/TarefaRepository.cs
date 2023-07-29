using TarefasBackEnd.Models;
using System.Linq;
using System.Collections.Models;

namespace TarefasBackEnd.Repositories
{
    public interface ITarefaRepository
    {
        List<Tarefa> Read();

        void Create(Tarefa tarefa);

        void Delete(Guid id);

        void Update(Tarefa tarefa);

    }

    public class TarefaRepository : ITarefaRepository
    {
        private readonly DataContext _context;

        public TarefaRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(Tarefa tarefa)
        {
            _context.Add(tarefa);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var tarefa = _context.Tarefas.Find(id);
            _context.Entry(tarefa).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public List<Tarefa> Read()
        {
            return _context.Tarefas.ToList();
        }

        public void Update(Tarefa tarefa)
        {
            var _tarefa = _context.Tarefas.Find(tarefa.id);
            _tarefa.Nome = tarefa.Nome;
            _context.Entry(tarefa).State = EntityState.Deleted;
            _context.SaveChanges();
        }
    }

}