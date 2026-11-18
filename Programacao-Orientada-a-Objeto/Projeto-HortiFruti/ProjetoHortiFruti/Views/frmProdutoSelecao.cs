using ProjetoHortiFruti.Controllers;
using ProjetoHortiFruti.Models;
using System;
using System.Windows.Forms;

namespace ProjetoHortiFruti.Views
{
    public partial class frmProdutoSelecao : Form
    {
        public Produto produtoSelecao;
        ProdutoController produtoController = new ProdutoController();

        public frmProdutoSelecao(bool ExibirBotaoSelecionar = false)
        {
            InitializeComponent();
            btnSelecionar.Visible = ExibirBotaoSelecionar;
            AtualizarGrid();
        }

        void AtualizarGrid()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = produtoController.GetByDescricao(txtDescricao.Text);
            lblRegistros.Text = "Registros encontrados: " + dgvRegistros.RowCount.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmProdutoCadastro frm = new frmProdutoCadastro();
            if (frm.ShowDialog() == DialogResult.OK)
                AtualizarGrid();
        }

        Produto GetProduto()
        {
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.", "Informação...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
                return (dgvRegistros.SelectedRows[0].DataBoundItem as Produto);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado = GetProduto();
            if (produtoSelecionado == null)
                return;

            frmProdutoCadastro frm = new frmProdutoCadastro(2, produtoSelecionado);
            if (frm.ShowDialog() == DialogResult.OK)
                AtualizarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado = GetProduto();

            if (produtoSelecionado == null)
                return;

            if (MessageBox.Show(
                    "Deseja realmente excluir o registro?",
                    "Confirmação!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (produtoController.Excluir(produtoSelecionado.ProdutoId) > 0)
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

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado = GetProduto();
            if (produtoSelecionado == null)
                return;

            frmProdutoCadastro frm = new frmProdutoCadastro(3, produtoSelecionado);
            frm.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void Selecionar()
        {
            produtoSelecao = GetProduto();
            if (produtoSelecao != null)
                this.DialogResult = DialogResult.OK;
        }
    }
}
