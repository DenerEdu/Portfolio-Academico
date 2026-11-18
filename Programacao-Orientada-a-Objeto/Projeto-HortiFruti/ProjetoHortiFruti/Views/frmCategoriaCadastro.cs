using System;
using System.Windows.Forms;
using ProjetoHortiFruti.Controllers;
using ProjetoHortiFruti.Models;

namespace ProjetoHortiFruti.Views
{
    public partial class frmCategoriaCadastro : Form
    {
        CategoriaController categoriaController = new CategoriaController();

        public frmCategoriaCadastro(int Acao = 1, Categoria categoria = null)
        {
            InitializeComponent();

            if (categoria == null)
                Acao = 1;

            if (Acao != 1)
            {
                CarregarDados(categoria);

                if (Acao == 3)
                {
                    DesativarCampos();
                    this.Text = "Visualizar Categoria";
                }
                else
                    this.Text = "Alterar Categoria";
            }
        }

        void DesativarCampos()
        {
            txtNome.ReadOnly = true;
            txtDescricao.ReadOnly = true;
            txtSetor.ReadOnly = true;
            cbxTipoArmazenamento.Enabled = false;
            txtTemperaturaIdeal.ReadOnly = true;
            cbxPerecivel.Enabled = false;
            txtObservacao.ReadOnly = true;

            btnSalvar.Visible = false;
            btnCancelar.Text = "OK";
        }

        void CarregarDados(Categoria categoria)
        {
            txtId.Text = categoria.CategoriaId.ToString();
            txtNome.Text = categoria.Nome;
            txtDescricao.Text = categoria.Descricao;
            txtSetor.Text = categoria.Setor;
            cbxTipoArmazenamento.Text = categoria.TipoArmazenamento;
            txtTemperaturaIdeal.Text = categoria.TemperaturaIdeal;
            cbxPerecivel.Text = categoria.Perecivel;
            txtObservacao.Text = categoria.Observacao;
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
            Categoria categoria = new Categoria();
            categoria.Nome = txtNome.Text;
            categoria.Descricao = txtDescricao.Text;
            categoria.Setor = txtSetor.Text;
            categoria.TipoArmazenamento = cbxTipoArmazenamento.Text;
            categoria.TemperaturaIdeal = txtTemperaturaIdeal.Text;
            categoria.Perecivel = cbxPerecivel.Text;
            categoria.Observacao = txtObservacao.Text;

            int retorno = 0;
            if (txtId.Text == "")
                retorno = categoriaController.Inserir(categoria);
            else
            {
                categoria.CategoriaId = int.Parse(txtId.Text);
                retorno = categoriaController.Alterar(categoria);
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
