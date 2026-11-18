using System;
using System.Windows.Forms;
using ProjetoHortiFruti.Controllers;
using ProjetoHortiFruti.Models;

namespace ProjetoHortiFruti.Views
{
    public partial class frmUsuarioCadastro : Form
    {
        UsuarioController usuarioController = new UsuarioController();

        public frmUsuarioCadastro(int Acao = 1, Usuario usuario = null)
        {
            InitializeComponent();

            if (usuario == null)
                Acao = 1;

            if (Acao != 1)
            {
                CarregarDados(usuario);

                if (Acao == 3)
                {
                    DesativarCampos();
                    this.Text = "Visualizar Usuário";
                }
                else
                    this.Text = "Alterar Usuário";
            }
        }

        void DesativarCampos()
        {
            txtNome.ReadOnly = true;
            txtCpf.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtCargo.ReadOnly = true;
            txtSetor.ReadOnly = true;
            txtSenha.ReadOnly = true;

            btnSalvar.Visible = false;
            btnCancelar.Text = "OK";
        }

        void CarregarDados(Usuario usuario)
        {
            txtId.Text = usuario.UsuarioId.ToString();
            txtNome.Text = usuario.Nome;
            txtCpf.Text = usuario.Cpf;
            txtTelefone.Text = usuario.Telefone;
            txtEmail.Text = usuario.Email;
            txtCargo.Text = usuario.Cargo;
            txtSetor.Text = usuario.Setor;
            txtSenha.Text = usuario.Senha;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Visible == false)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (MessageBox.Show(
                    "Deseja realmente sair?" + Environment.NewLine + Environment.NewLine +
                    "Ao Sair os dados alterados serão descartados!",
                    "Confirmação!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Cpf = txtCpf.Text;
            usuario.Telefone = txtTelefone.Text;
            usuario.Email = txtEmail.Text;
            usuario.Cargo = txtCargo.Text;
            usuario.Setor = txtSetor.Text;
            usuario.Senha = txtSenha.Text;

            int retorno = 0;
            if (txtId.Text == "")
                retorno = usuarioController.Inserir(usuario);
            else
            {
                usuario.UsuarioId = int.Parse(txtId.Text);
                retorno = usuarioController.Alterar(usuario);
            }

            if (retorno > 0)
            {
                MessageBox.Show(
                    "Cadastro salvo com sucesso!",
                    "Informação!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show(
                    "Falha ao salvar o cadastro!",
                    "Atenção!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }
    }
}
