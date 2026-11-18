using System;
using System.Windows.Forms;
using ProjetoHortiFruti.Controllers;
using ProjetoHortiFruti.Models;

namespace ProjetoHortiFruti.Views
{
    public partial class frmProdutoCadastro : Form
    {
        ProdutoController produtoController = new ProdutoController();

        public frmProdutoCadastro(int Acao = 1, Produto produto = null)
        {
            InitializeComponent();

            if (produto == null)
                Acao = 1;

            if (Acao != 1)
            {
                CarregarDados(produto);

                if (Acao == 3)
                {
                    DesativarCampos();
                    this.Text = "Visualizar Produto";
                }
                else
                    this.Text = "Alterar Produto";
            }
        }

        void DesativarCampos()
        {
            txtDescricao.ReadOnly = true;
            cbxCategoria.Enabled = false;
            cbxUnidadeMedida.Enabled = false;
            txtPreco.ReadOnly = true;
            txtEstoque.ReadOnly = true;
            txtOrigem.ReadOnly = true;
            txtCodigoBarras.ReadOnly = true;

            btnSalvar.Visible = false;
            btnCancelar.Text = "OK";
        }

        void CarregarDados(Produto produto)
        {
            txtId.Text = produto.ProdutoId.ToString();
            txtDescricao.Text = produto.Descricao;
            cbxCategoria.Text = produto.Categoria;
            cbxUnidadeMedida.Text = produto.UnidadeMedida;
            txtPreco.Text = produto.Preco.ToString();
            txtEstoque.Text = produto.Estoque.ToString();
            txtOrigem.Text = produto.Origem;
            txtCodigoBarras.Text = produto.CodigoBarras;
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
            decimal preco = 0;
            int estoque = 0;

            if (!decimal.TryParse(txtPreco.Text, out preco))
            {
                MessageBox.Show("Informe um preço válido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreco.Focus();
                return;
            }

            if (!int.TryParse(txtEstoque.Text, out estoque))
            {
                MessageBox.Show("Informe uma quantidade de estoque válida!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstoque.Focus();
                return;
            }

            Produto produto = new Produto();
            produto.Descricao = txtDescricao.Text;
            produto.Categoria = cbxCategoria.Text;
            produto.UnidadeMedida = cbxUnidadeMedida.Text;
            produto.Preco = preco;
            produto.Estoque = estoque;
            produto.Origem = txtOrigem.Text;
            produto.CodigoBarras = txtCodigoBarras.Text;

            int retorno = 0;
            if (txtId.Text == "")
                retorno = produtoController.Inserir(produto);
            else
            {
                produto.ProdutoId = int.Parse(txtId.Text);
                retorno = produtoController.Alterar(produto);
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
