namespace P1POO.Models
{
    public class Brinquedo : Produto
    {
        private string categoria;
        private int idadeMinima;
        private Fabricante fabricante;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public int IdadeMinima
        {
            get { return idadeMinima; }
            set { idadeMinima = value; }
        }

        public Fabricante Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public Brinquedo()
        {
        }

        public Brinquedo(string codigoBarras, string descricao, decimal preco, string categoria, int idadeMinima, Fabricante fabricante)
            : base(codigoBarras, descricao, preco)
        {
            this.categoria = categoria;
            this.idadeMinima = idadeMinima;
            this.fabricante = fabricante;
        }

        public override string ObterDados()
        {
            return CodigoBarras + " - " + Descricao + " - " + Categoria;
        }

        public string ObterDados(bool incluirFabricante)
        {
            if (incluirFabricante && Fabricante != null)
            {
                return CodigoBarras + " - " + Descricao + " - " + Categoria + " - " + Fabricante.Nome;
            }
            return ObterDados();
        }

        public string ObterDadosCompletos()
        {
            string nomeFabricante = Fabricante != null ? Fabricante.Nome : "";
            return CodigoBarras + " - " + Descricao + " - " + Categoria + " - " + nomeFabricante;
        }

        public override string ToString()
        {
            return ObterDadosCompletos();
        }
    }
}
