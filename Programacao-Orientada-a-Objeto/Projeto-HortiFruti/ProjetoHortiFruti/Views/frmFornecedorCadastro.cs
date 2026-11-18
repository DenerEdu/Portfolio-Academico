using System;
using System.Windows.Forms;
using ProjetoHortiFruti.Controllers;
using ProjetoHortiFruti.Models;

namespace ProjetoHortiFruti.Views
{
    public partial class frmFornecedorCadastro : Form
    {
        FornecedorController fornecedorController = new FornecedorController();

        public frmFornecedorCadastro(int Acao = 1, Fornecedor fornecedor = null)
        {
            InitializeComponent();

            if (fornecedor == null)
                Acao = 1;

            if (Acao != 1)
            {
                CarregarDados(fornecedor);

                if (Acao == 3)
                {
                    DesativarCampos();
                    this.Text = "Visualizar Fornecedor";
                }
                else
                    this.Text = "Alterar Fornecedor";
            }
        }

        void DesativarCampos()
        {
            txtRazaoSocial.ReadOnly = true;
            txtNomeFantasia.ReadOnly = true;
            txtCnpj.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtCidade.ReadOnly = true;

            btnSalvar.Visible = false;
            btnCancelar.Text = "OK";
        }

        void CarregarDados(Fornecedor fornecedor)
        {
            txtId.Text = fornecedor.FornecedorId.ToString();
            txtRazaoSocial.Text = fornecedor.RazaoSocial;
            txtNomeFantasia.Text = fornecedor.NomeFantasia;
            txtCnpj.Text = fornecedor.Cnpj;
            txtTelefone.Text = fornecedor.Telefone;
            txtEmail.Text = fornecedor.Email;
            txtEndereco.Text = fornecedor.Endereco;
            txtCidade.Text = fornecedor.Cidade;
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
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = txtRazaoSocial.Text;
            fornecedor.NomeFantasia = txtNomeFantasia.Text;
            fornecedor.Cnpj = txtCnpj.Text;
            fornecedor.Telefone = txtTelefone.Text;
            fornecedor.Email = txtEmail.Text;
            fornecedor.Endereco = txtEndereco.Text;
            fornecedor.Cidade = txtCidade.Text;

            int retorno = 0;
            if (txtId.Text == "")
                retorno = fornecedorController.Inserir(fornecedor);
            else
            {
                fornecedor.FornecedorId = int.Parse(txtId.Text);
                retorno = fornecedorController.Alterar(fornecedor);
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
