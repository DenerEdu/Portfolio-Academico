using ProjetoHortiFruti.Controllers;
using ProjetoHortiFruti.Models;
using System;
using System.Windows.Forms;

namespace ProjetoHortiFruti.Views
{
    public partial class frmCategoriaSelecao : Form
    {
        CategoriaController categoriaController = new CategoriaController();
        public Categoria categoriaSelecao;

        public frmCategoriaSelecao(bool ExibirBotaoSelecionar = false)
        {
            InitializeComponent();
            btnSelecionar.Visible = ExibirBotaoSelecionar;
            AtualizarGrid();
        }

        void AtualizarGrid()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = categoriaController.GetByName(txtNome.Text);
            lblRegistros.Text = "Registros encontrados: " + dgvRegistros.RowCount.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCategoriaCadastro frm = new frmCategoriaCadastro();
            if (frm.ShowDialog() == DialogResult.OK)
                AtualizarGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        Categoria GetCategoria()
        {
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma categoria selecionada.", "Informação...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
                return (dgvRegistros.SelectedRows[0].DataBoundItem as Categoria);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Categoria categoriaSelecionada = GetCategoria();
            if (categoriaSelecionada == null)
                return;

            frmCategoriaCadastro frm = new frmCategoriaCadastro(2, categoriaSelecionada);
            if (frm.ShowDialog() == DialogResult.OK)
                AtualizarGrid();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Categoria categoriaSelecionada = GetCategoria();
            if (categoriaSelecionada == null)
                return;

            frmCategoriaCadastro frm = new frmCategoriaCadastro(3, categoriaSelecionada);
            frm.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Categoria categoriaSelecionada = GetCategoria();
            if (categoriaSelecionada == null)
                return;

            if (MessageBox.Show(
                    "Deseja realmente excluir o registro?",
                    "Confirmação!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (categoriaController.Excluir(categoriaSelecionada.CategoriaId) > 0)
                {
                    MessageBox.Show(
                        "Cadastro excluído com sucesso!",
                        "Informação!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    AtualizarGrid();
                }
                else
                    MessageBox.Show(
                        "Falha ao excluir o cadastro!",
                        "Atenção!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void Selecionar()
        {
            categoriaSelecao = GetCategoria();
            if (categoriaSelecao != null)
                this.DialogResult = DialogResult.OK;
        }
    }
}
