using System;
using System.Collections.Generic;

namespace SistemaBiblioteca
{
    public class Biblioteca
    {
        private string nome;
        private List<Livro> livros;
        private List<Emprestimo> emprestimos;
        private List<Aluno> alunos;
        private List<Funcionario> funcionarios;

        public Biblioteca(string nome)
        {
            this.nome = nome;
            livros = new List<Livro>();
            emprestimos = new List<Emprestimo>();
            alunos = new List<Aluno>();
            funcionarios = new List<Funcionario>();
        }

        public string Nome
        {
            get { return nome; }
        }

        public List<Livro> Livros
        {
            get { return livros; }
        }

        public List<Emprestimo> Emprestimos
        {
            get { return emprestimos; }
        }

        public List<Aluno> Alunos
        {
            get { return alunos; }
        }

        public List<Funcionario> Funcionarios
        {
            get { return funcionarios; }
        }

        public void CadastrarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public void CadastrarAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

        public Emprestimo RealizarEmprestimo(Aluno aluno, Livro livro, Funcionario func, DateTime data)
        {
            if (!livro.EstaDisponivel())
            {
                throw new Exception("O livro não está disponível para empréstimo.");
            }

            if (!aluno.PodeEmprestar())
            {
                throw new Exception("O aluno já possui 3 empréstimos em aberto.");
            }

            Emprestimo emp = new Emprestimo(aluno, livro, func, data);
            livro.AlterarStatus(StatusLivro.EMPRESTADO);
            aluno.QtdEmprestimos = aluno.QtdEmprestimos + 1;
            emprestimos.Add(emp);
            return emp;
        }

        public float RegistrarDevolucao(Emprestimo emp)
        {
            if (emp.Finalizado)
            {
                throw new Exception("Este empréstimo já foi finalizado.");
            }

            emp.Finalizar();
            return emp.CalcularMulta();
        }

        public List<Emprestimo> ListarAtrasados()
        {
            List<Emprestimo> atrasados = new List<Emprestimo>();
            foreach (Emprestimo emp in emprestimos)
            {
                if (!emp.Finalizado && emp.EstaAtrasado())
                {
                    atrasados.Add(emp);
                }
            }
            return atrasados;
        }
    }
}
