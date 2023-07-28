using Microsoft.EntityFrameworkCore;
using TarefasBackEnd.Models;

namespace TarefasBackEnd.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options){ }

        // Aqui é encapsulado todas as operacoes CRUD! O DbConxtextOptions é responsável por fazer tudo
        public DbSet<Tarefa> Tarefas { get; set;}

        public DbSet<Usuario> Usuarios { get; set;}
    }
}