using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            string caminho = Path.Combine(Application.StartupPath, "capa.jpg");
            if (File.Exists(caminho))
            {
                picCapa.Image = Image.FromFile(caminho);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FormPrincipal frm = new FormPrincipal();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
