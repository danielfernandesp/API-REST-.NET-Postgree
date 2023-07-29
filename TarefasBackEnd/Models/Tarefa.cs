using System;
using System.ComponentModel.DataAnnotations;

namespace TarefasBackEnd.Models
{
    public class Tarefa
    {
        public Guid ID {get; set;}

        public Guid UsuarioId {get; set;}

        [Required]
        public string Nome {get; set;}

        public bool Concluida {get; set;}
    }
}