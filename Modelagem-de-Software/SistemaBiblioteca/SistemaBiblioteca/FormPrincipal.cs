using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class FormPrincipal : Form
    {
        Biblioteca biblioteca = new Biblioteca("Biblioteca Central");

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // dados iniciais para teste
            biblioteca.CadastrarLivro(new Livro("978-8535914849", "Dom Casmurro", 1899));
            biblioteca.CadastrarLivro(new Livro("978-8573261202", "O Pequeno Príncipe", 1943));
            biblioteca.CadastrarLivro(new Livro("978-8576082675", "Código Limpo", 2008));
            biblioteca.CadastrarAluno(new Aluno("Dener Eduardo", "321.654.987-10", "dener.edu@email.com", "2025101793", "Sistemas de Informação"));
            biblioteca.CadastrarFuncionario(new Funcionario("Jarbas José", "123.222.222-22", "jj.biblioteca@email.com", "Bibliotecário"));

            AtualizarTudo();
        }

        private void AtualizarTudo()
        {
            AtualizarLivros();
            AtualizarAlunos();
            AtualizarFuncionarios();
            AtualizarCombos();
            AtualizarEmprestimos();
        }

        private void AtualizarLivros()
        {
            lstLivros.Items.Clear();
            foreach (Livro l in biblioteca.Livros)
            {
                lstLivros.Items.Add(l);
            }
        }

        private void AtualizarAlunos()
        {
            lstAlunos.Items.Clear();
            foreach (Aluno a in biblioteca.Alunos)
            {
                lstAlunos.Items.Add(a);
            }
        }

        private void AtualizarFuncionarios()
        {
            lstFuncionarios.Items.Clear();
            foreach (Funcionario f in biblioteca.Funcionarios)
            {
                lstFuncionarios.Items.Add(f);
            }
        }

        private void AtualizarCombos()
        {
            cboAluno.Items.Clear();
            foreach (Aluno a in biblioteca.Alunos)
            {
                cboAluno.Items.Add(a);
            }

            cboLivro.Items.Clear();
            foreach (Livro l in biblioteca.Livros)
            {
                if (l.EstaDisponivel())
                {
                    cboLivro.Items.Add(l);
                }
            }

            cboFuncionario.Items.Clear();
            foreach (Funcionario f in biblioteca.Funcionarios)
            {
                cboFuncionario.Items.Add(f);
            }
        }

        private void AtualizarEmprestimos()
        {
            lstEmprestimos.Items.Clear();
            foreach (Emprestimo emp in biblioteca.Emprestimos)
            {
                lstEmprestimos.Items.Add(emp);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTudo();
        }

        // ---------- LIVROS ----------

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            if (txtIsbn.Text == "" || txtTitulo.Text == "" || txtAno.Text == "")
            {
                MessageBox.Show("Preencha todos os campos do livro.");
                return;
            }

            int ano;
            if (!int.TryParse(txtAno.Text, out ano))
            {
                MessageBox.Show("Digite um ano válido.");
                return;
            }

            Livro livro = new Livro(txtIsbn.Text, txtTitulo.Text, ano);
            biblioteca.CadastrarLivro(livro);

            txtIsbn.Clear();
            txtTitulo.Clear();
            txtAno.Clear();
            AtualizarLivros();
            MessageBox.Show("Livro cadastrado com sucesso!");
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (lstLivros.SelectedItem == null)
            {
                MessageBox.Show("Selecione um livro na lista.");
                return;
            }

            Livro livro = (Livro)lstLivros.SelectedItem;
            if (!livro.EstaDisponivel())
            {
                MessageBox.Show("Só é possível reservar livros disponíveis.");
                return;
            }

            livro.AlterarStatus(StatusLivro.RESERVADO);
            AtualizarLivros();
        }

        private void btnDisponibilizar_Click(object sender, EventArgs e)
        {
            if (lstLivros.SelectedItem == null)
            {
                MessageBox.Show("Selecione um livro na lista.");
                return;
            }

            Livro livro = (Livro)lstLivros.SelectedItem;
            if (livro.Status != StatusLivro.RESERVADO)
            {
                MessageBox.Show("Este livro não está reservado.");
                return;
            }

            livro.AlterarStatus(StatusLivro.DISPONIVEL);
            AtualizarLivros();
        }

        // ---------- ALUNOS ----------

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            if (txtNomeAluno.Text == "" || txtCpfAluno.Text == "" || txtMatricula.Text == "")
            {
                MessageBox.Show("Preencha pelo menos nome, CPF e matrícula.");
                return;
            }

            Aluno aluno = new Aluno(txtNomeAluno.Text, txtCpfAluno.Text, txtEmailAluno.Text,
                                    txtMatricula.Text, txtCurso.Text);
            biblioteca.CadastrarAluno(aluno);

            txtNomeAluno.Clear();
            txtCpfAluno.Clear();
            txtEmailAluno.Clear();
            txtMatricula.Clear();
            txtCurso.Clear();
            AtualizarAlunos();
            MessageBox.Show("Aluno cadastrado com sucesso!");
        }

        // ---------- FUNCIONÁRIOS ----------

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            if (txtNomeFunc.Text == "" || txtCpfFunc.Text == "" || txtCargo.Text == "")
            {
                MessageBox.Show("Preencha pelo menos nome, CPF e cargo.");
                return;
            }

            Funcionario func = new Funcionario(txtNomeFunc.Text, txtCpfFunc.Text,
                                               txtEmailFunc.Text, txtCargo.Text);
            biblioteca.CadastrarFuncionario(func);

            txtNomeFunc.Clear();
            txtCpfFunc.Clear();
            txtEmailFunc.Clear();
            txtCargo.Clear();
            AtualizarFuncionarios();
            MessageBox.Show("Funcionário cadastrado com sucesso!");
        }

        // ---------- EMPRÉSTIMOS ----------

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            if (cboAluno.SelectedItem == null || cboLivro.SelectedItem == null || cboFuncionario.SelectedItem == null)
            {
                MessageBox.Show("Selecione o aluno, o livro e o funcionário.");
                return;
            }

            Aluno aluno = (Aluno)cboAluno.SelectedItem;
            Livro livro = (Livro)cboLivro.SelectedItem;
            Funcionario func = (Funcionario)cboFuncionario.SelectedItem;

            try
            {
                Emprestimo emp = biblioteca.RealizarEmprestimo(aluno, livro, func, dtpData.Value);
                MessageBox.Show("Empréstimo realizado!\nDevolução prevista para: " +
                                emp.DataPrevista.ToString("dd/MM/yyyy"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AtualizarCombos();
            AtualizarEmprestimos();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (lstEmprestimos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um empréstimo na lista.");
                return;
            }

            Emprestimo emp = (Emprestimo)lstEmprestimos.SelectedItem;

            try
            {
                float multa = biblioteca.RegistrarDevolucao(emp);
                if (multa > 0)
                    MessageBox.Show("Devolução registrada com atraso.\nMulta: R$ " + multa.ToString("0.00"));
                else
                    MessageBox.Show("Devolução registrada. Sem multa.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AtualizarCombos();
            AtualizarEmprestimos();
        }

        private void btnAtrasados_Click(object sender, EventArgs e)
        {
            List<Emprestimo> atrasados = biblioteca.ListarAtrasados();

            lstEmprestimos.Items.Clear();
            foreach (Emprestimo emp in atrasados)
            {
                lstEmprestimos.Items.Add(emp);
            }

            if (atrasados.Count == 0)
            {
                MessageBox.Show("Nenhum empréstimo atrasado.");
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            AtualizarEmprestimos();
        }
    }
}
