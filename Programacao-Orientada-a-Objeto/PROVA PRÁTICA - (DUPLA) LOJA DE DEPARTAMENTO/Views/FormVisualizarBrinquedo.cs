using System;
using System.Windows.Forms;
using P1POO.Models;

namespace P1POO.Views
{
    public partial class FormVisualizarBrinquedo : Form
    {
        public FormVisualizarBrinquedo(Brinquedo brinquedo)
        {
            InitializeComponent();
            CarregarDados(brinquedo);
        }

        private void CarregarDados(Brinquedo brinquedo)
        {
            if (brinquedo != null)
            {
                txtCodigoBarras.Text = brinquedo.CodigoBarras;
                txtDescricao.Text = brinquedo.Descricao;
                txtPreco.Text = brinquedo.Preco.ToString("C2");
                txtCategoria.Text = brinquedo.Categoria;
                txtIdadeMinima.Text = brinquedo.IdadeMinima.ToString() + " anos";

                if (brinquedo.Fabricante != null)
                {
                    txtFabricante.Text = brinquedo.Fabricante.ObterDados();
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
