namespace SistemaBiblioteca
{
    public abstract class Pessoa
    {
        protected string nome;
        protected string cpf;
        protected string email;

        public Pessoa(string nome, string cpf, string email)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public abstract string GetDescricao();

        public override string ToString()
        {
            return GetDescricao();
        }
    }
}
