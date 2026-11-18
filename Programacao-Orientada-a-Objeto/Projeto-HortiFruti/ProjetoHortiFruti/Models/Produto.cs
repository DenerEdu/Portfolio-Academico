using System.Collections.Generic;

namespace ProjetoHortiFruti.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string UnidadeMedida { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public string Origem { get; set; }
        public string CodigoBarras { get; set; }
    }

    public class ProdutoCollection : List<Produto> { }
}
