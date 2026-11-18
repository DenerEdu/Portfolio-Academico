using System;

namespace SistemaBiblioteca
{
    public class Emprestimo
    {
        private DateTime dataEmprestimo;
        private DateTime dataPrevista;
        private DateTime dataDevolucao;
        private bool finalizado;

        private Livro livro;
        private Aluno aluno;
        private Funcionario funcionario;

        public const float VALOR_MULTA_DIA = 2.0f;
        public const int DIAS_PRAZO = 7;

        public Emprestimo(Aluno aluno, Livro livro, Funcionario funcionario, DateTime dataEmprestimo)
        {
            this.aluno = aluno;
            this.livro = livro;
            this.funcionario = funcionario;
            this.dataEmprestimo = dataEmprestimo.Date;
            this.dataPrevista = this.dataEmprestimo.AddDays(DIAS_PRAZO);
            this.finalizado = false;
        }

        public DateTime DataEmprestimo
        {
            get { return dataEmprestimo; }
        }

        public DateTime DataPrevista
        {
            get { return dataPrevista; }
        }

        public DateTime DataDevolucao
        {
            get { return dataDevolucao; }
        }

        public bool Finalizado
        {
            get { return finalizado; }
        }

        public Livro Livro
        {
            get { return livro; }
        }

        public Aluno Aluno
        {
            get { return aluno; }
        }

        public Funcionario Funcionario
        {
            get { return funcionario; }
        }

        public bool EstaAtrasado()
        {
            if (finalizado)
            {
                return dataDevolucao > dataPrevista;
            }
            return DateTime.Today > dataPrevista;
        }

        public float CalcularMulta()
        {
            if (!EstaAtrasado())
            {
                return 0;
            }

            DateTime dataFinal;
            if (finalizado)
                dataFinal = dataDevolucao;
            else
                dataFinal = DateTime.Today;

            int diasAtraso = (dataFinal - dataPrevista).Days;
            return diasAtraso * VALOR_MULTA_DIA;
        }

        public void Finalizar()
        {
            dataDevolucao = DateTime.Today;
            finalizado = true;
            livro.AlterarStatus(StatusLivro.DISPONIVEL);
            aluno.QtdEmprestimos = aluno.QtdEmprestimos - 1;
        }

        public override string ToString()
        {
            string texto = livro.Titulo + " | " + aluno.Nome +
                           " | Emp.: " + dataEmprestimo.ToString("dd/MM/yyyy") +
                           " | Prev.: " + dataPrevista.ToString("dd/MM/yyyy");

            if (finalizado)
                texto += " | Devolvido em " + dataDevolucao.ToString("dd/MM/yyyy");
            else if (EstaAtrasado())
                texto += " | ATRASADO";
            else
                texto += " | Em aberto";

            return texto;
        }
    }
}
