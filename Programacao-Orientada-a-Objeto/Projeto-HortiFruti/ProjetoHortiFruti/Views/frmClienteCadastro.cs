using System;
using System.Windows.Forms;
using ProjetoHortiFruti.Controllers;
using ProjetoHortiFruti.Models;

namespace ProjetoHortiFruti.Views
{
    public partial class frmClienteCadastro : Form
    {
        ClienteController clienteController = new ClienteController();

        public frmClienteCadastro(int Acao = 1, Cliente cliente = null)
        {
            InitializeComponent();

            if (cliente == null)
                Acao = 1;

            if (Acao != 1)
            {
                CarregarDados(cliente);

                if (Acao == 3)
                {
                    DesativarCampos();
                    this.Text = "Visualizar Cliente";
                }
                else
                    this.Text = "Alterar Cliente";
            }
        }

        void DesativarCampos()
        {
            txtNome.ReadOnly = true;
            txtCpf.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtBairro.ReadOnly = true;
            txtCidade.ReadOnly = true;

            btnSalvar.Visible = false;
            btnCancelar.Text = "OK";
        }

        void CarregarDados(Cliente cliente)
        {
            txtId.Text = cliente.ClienteId.ToString();
            txtNome.Text = cliente.Nome;
            txtCpf.Text = cliente.Cpf;
            txtTelefone.Text = cliente.Telefone;
            txtEmail.Text = cliente.Email;
            txtEndereco.Text = cliente.Endereco;
            txtBairro.Text = cliente.Bairro;
            txtCidade.Text = cliente.Cidade;
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
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;

            int retorno = 0;
            if (txtId.Text == "")
                retorno = clienteController.Inserir(cliente);
            else
            {
                cliente.ClienteId = int.Parse(txtId.Text);
                retorno = clienteController.Alterar(cliente);
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
