namespace P1POO.Models
{
    public class Produto
    {
        private string codigoBarras;
        private string descricao;
        private decimal preco;

        public string CodigoBarras
        {
            get { return codigoBarras; }
            set { codigoBarras = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public Produto()
        {
        }

        public Produto(string codigoBarras, string descricao, decimal preco)
        {
            this.codigoBarras = codigoBarras;
            this.descricao = descricao;
            this.preco = preco;
        }

        public virtual string ObterDados()
        {
            return codigoBarras + " - " + descricao;
        }

        public override string ToString()
        {
            return ObterDados();
        }
    }
}
