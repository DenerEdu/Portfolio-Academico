using ProjetoHortiFruti.Controllers;
using ProjetoHortiFruti.Models;
using System;
using System.Windows.Forms;

namespace ProjetoHortiFruti.Views
{
    public partial class frmClienteSelecao : Form
    {
        ClienteController clienteController = new ClienteController();
        public Cliente clienteSelecao;

        public frmClienteSelecao(bool ExibirBotaoSelecionar = false)
        {
            InitializeComponent();
            btnSelecionar.Visible = ExibirBotaoSelecionar;
            AtualizarGrid();
        }

        void AtualizarGrid()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = clienteController.GetByName(txtNome.Text);
            lblRegistros.Text = "Registros encontrados: " + dgvRegistros.RowCount.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmClienteCadastro frm = new frmClienteCadastro();
            if (frm.ShowDialog() == DialogResult.OK)
                AtualizarGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        Cliente GetCliente()
        {
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado.", "Informação...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
                return (dgvRegistros.SelectedRows[0].DataBoundItem as Cliente);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = GetCliente();
            if (clienteSelecionado == null)
                return;

            frmClienteCadastro frm = new frmClienteCadastro(2, clienteSelecionado);
            if (frm.ShowDialog() == DialogResult.OK)
                AtualizarGrid();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = GetCliente();
            if (clienteSelecionado == null)
                return;

            frmClienteCadastro frm = new frmClienteCadastro(3, clienteSelecionado);
            frm.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = GetCliente();
            if (clienteSelecionado == null)
                return;

            if (MessageBox.Show(
                    "Deseja realmente excluir o registro?",
                    "Confirmação!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clienteController.Excluir(clienteSelecionado.ClienteId) > 0)
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
            clienteSelecao = GetCliente();
            if (clienteSelecao != null)
                this.DialogResult = DialogResult.OK;
        }
    }
}
