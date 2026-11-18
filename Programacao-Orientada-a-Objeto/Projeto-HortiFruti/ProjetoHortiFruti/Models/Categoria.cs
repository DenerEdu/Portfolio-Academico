using System.Collections.Generic;

namespace ProjetoHortiFruti.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Setor { get; set; }
        public string TipoArmazenamento { get; set; }
        public string TemperaturaIdeal { get; set; }
        public string Perecivel { get; set; }
        public string Observacao { get; set; }
    }

    public class CategoriaCollection : List<Categoria> { }
}
