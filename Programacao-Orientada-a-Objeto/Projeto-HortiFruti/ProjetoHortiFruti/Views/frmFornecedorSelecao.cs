using ProjetoHortiFruti.Controllers;
using ProjetoHortiFruti.Models;
using System;
using System.Windows.Forms;

namespace ProjetoHortiFruti.Views
{
    public partial class frmFornecedorSelecao : Form
    {
        FornecedorController fornecedorController = new FornecedorController();
        public Fornecedor fornecedorSelecao;

        public frmFornecedorSelecao(bool ExibirBotaoSelecionar = false)
        {
            InitializeComponent();
            btnSelecionar.Visible = ExibirBotaoSelecionar;
            AtualizarGrid();
        }

        void AtualizarGrid()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = fornecedorController.GetByRazaoSocial(txtRazaoSocial.Text);
            lblRegistros.Text = "Registros encontrados: " + dgvRegistros.RowCount.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmFornecedorCadastro frm = new frmFornecedorCadastro();
            if (frm.ShowDialog() == DialogResult.OK)
                AtualizarGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        Fornecedor GetFornecedor()
        {
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum fornecedor selecionado.", "Informação...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
                return (dgvRegistros.SelectedRows[0].DataBoundItem as Fornecedor);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedorSelecionado = GetFornecedor();
            if (fornecedorSelecionado == null)
                return;

            frmFornecedorCadastro frm = new frmFornecedorCadastro(2, fornecedorSelecionado);
            if (frm.ShowDialog() == DialogResult.OK)
                AtualizarGrid();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedorSelecionado = GetFornecedor();
            if (fornecedorSelecionado == null)
                return;

            frmFornecedorCadastro frm = new frmFornecedorCadastro(3, fornecedorSelecionado);
            frm.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedorSelecionado = GetFornecedor();
            if (fornecedorSelecionado == null)
                return;

            if (MessageBox.Show(
                    "Deseja realmente excluir o registro?",
                    "Confirmação!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (fornecedorController.Excluir(fornecedorSelecionado.FornecedorId) > 0)
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
            fornecedorSelecao = GetFornecedor();
            if (fornecedorSelecao != null)
                this.DialogResult = DialogResult.OK;
        }
    }
}
