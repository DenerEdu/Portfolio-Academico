namespace SistemaBiblioteca
{
    public class Funcionario : Pessoa
    {
        private string cargo;

        public Funcionario(string nome, string cpf, string email, string cargo)
            : base(nome, cpf, email)
        {
            this.cargo = cargo;
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public override string GetDescricao()
        {
            return "Funcionário: " + nome + " | Cargo: " + cargo;
        }
    }
}
