namespace P1POO.Models
{
    public class Fabricante
    {
        private string cnpj;
        private string nome;

        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Fabricante()
        {
        }

        public Fabricante(string cnpj, string nome)
        {
            this.cnpj = cnpj;
            this.nome = nome;
        }

        public string ObterDados()
        {
            return cnpj + " - " + nome;
        }

        public override string ToString()
        {
            return ObterDados();
        }
    }
}
