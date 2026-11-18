using System.Collections.Generic;

namespace ProjetoHortiFruti.Models
{
    public class VendaItem
    {
        public int VendaItemId { get; set; }
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal
        {
            get
            {
                return Quantidade * ValorUnitario;
            }
        }
    }

    public class VendaItemCollection : List<VendaItem> { }
}
