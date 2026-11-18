namespace SistemaBiblioteca
{
    public class Aluno : Pessoa
    {
        private string matricula;
        private string curso;
        private int qtdEmprestimos;

        public Aluno(string nome, string cpf, string email, string matricula, string curso)
            : base(nome, cpf, email)
        {
            this.matricula = matricula;
            this.curso = curso;
            this.qtdEmprestimos = 0;
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public int QtdEmprestimos
        {
            get { return qtdEmprestimos; }
            set { qtdEmprestimos = value; }
        }

        public override string GetDescricao()
        {
            return "Aluno: " + nome + " | Matrícula: " + matricula + " | Curso: " + curso;
        }

        // cada aluno pode ter no máximo 3 empréstimos ao mesmo tempo
        public bool PodeEmprestar()
        {
            return qtdEmprestimos < 3;
        }
    }
}
