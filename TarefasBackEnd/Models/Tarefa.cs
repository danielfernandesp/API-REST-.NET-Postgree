using System;

namespace TarefasBackEnd.Models
{
    public class Tarefa
    {
        public Guid ID {get; set;}

        public Guid UsuarioId {get; set;}

        public string Nome {get; set;}

        public bool Concluida {get; set;}
    }
}