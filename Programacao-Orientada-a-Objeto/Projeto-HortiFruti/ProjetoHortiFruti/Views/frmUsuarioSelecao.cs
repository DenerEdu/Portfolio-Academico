using ProjetoHortiFruti.Controllers;
using ProjetoHortiFruti.Models;
using System;
using System.Windows.Forms;

namespace ProjetoHortiFruti.Views
{
    public partial class frmUsuarioSelecao : Form
    {
        UsuarioController usuarioController = new UsuarioController();
        public Usuario usuarioSelecao;

        public frmUsuarioSelecao(bool ExibirBotaoSelecionar = false)
        {
            InitializeComponent();
            btnSelecionar.Visible = ExibirBotaoSelecionar;
            AtualizarGrid();
        }

        void AtualizarGrid()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = usuarioController.GetByName(txtNome.Text);
            lblRegistros.Text = "Registros encontrados: " + dgvRegistros.RowCount.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmUsuarioCadastro frm = new frmUsuarioCadastro();
            if (frm.ShowDialog() == DialogResult.OK)
                AtualizarGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        Usuario GetUsuario()
        {
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum usuário selecionado.", "Informação...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
                return (dgvRegistros.SelectedRows[0].DataBoundItem as Usuario);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Usuario usuarioSelecionado = GetUsuario();
            if (usuarioSelecionado == null)
                return;

            frmUsuarioCadastro frm = new frmUsuarioCadastro(2, usuarioSelecionado);
            if (frm.ShowDialog() == DialogResult.OK)
                AtualizarGrid();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Usuario usuarioSelecionado = GetUsuario();
            if (usuarioSelecionado == null)
                return;

            frmUsuarioCadastro frm = new frmUsuarioCadastro(3, usuarioSelecionado);
            frm.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Usuario usuarioSelecionado = GetUsuario();
            if (usuarioSelecionado == null)
                return;

            if (MessageBox.Show(
                    "Deseja realmente excluir o registro?",
                    "Confirmação!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (usuarioController.Excluir(usuarioSelecionado.UsuarioId) > 0)
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
            usuarioSelecao = GetUsuario();
            if (usuarioSelecao != null)
                this.DialogResult = DialogResult.OK;
        }
    }
}
