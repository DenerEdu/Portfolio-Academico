using System;
using System.Collections.Generic;

namespace ProjetoHortiFruti.Models
{
    public class Venda
    {
        public int VendaId { get; set; }
        public DateTime DtHora { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public char Status { get; set; }
        public string StatusTratado
        {
            get
            {
                switch (Status)
                {
                    case 'P':
                        return "Pendente";
                    case 'F':
                        return "Finalizada";
                    case 'C':
                        return "Cancelada";
                    default:
                        return "Desconhecido";
                }
            }
        }
    }

    public class VendaCollection : List<Venda> { }
}
