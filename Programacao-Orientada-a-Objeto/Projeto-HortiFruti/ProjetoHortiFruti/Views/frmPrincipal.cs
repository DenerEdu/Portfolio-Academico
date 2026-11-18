using System;
using System.Windows.Forms;

namespace ProjetoHortiFruti.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioSelecao frm = new frmUsuarioSelecao();
            frm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteSelecao frm = new frmClienteSelecao();
            frm.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedorSelecao frm = new frmFornecedorSelecao();
            frm.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoriaSelecao frm = new frmCategoriaSelecao();
            frm.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutoSelecao frm = new frmProdutoSelecao();
            frm.ShowDialog();
        }

        private void realizarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda frm = new frmVenda();
            frm.ShowDialog();
        }

        private void historicoDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendaHistorico frm = new frmVendaHistorico();
            frm.ShowDialog();
        }
    }
}
