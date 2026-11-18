using System.Collections.Generic;

namespace ProjetoHortiFruti.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Setor { get; set; }
        public string Senha { get; set; }
    }

    public class UsuarioCollection : List<Usuario> { }
}
