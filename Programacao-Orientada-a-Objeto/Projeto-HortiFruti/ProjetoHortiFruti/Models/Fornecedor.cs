using System.Collections.Generic;

namespace ProjetoHortiFruti.Models
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
    }

    public class FornecedorCollection : List<Fornecedor> { }
}
