using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using P1POO.Controllers;

namespace P1POO.Views
{
    public partial class FormPrincipal : Form
    {
        private BrinquedoController controller;

        public FormPrincipal()
        {
            InitializeComponent();
            controller = new BrinquedoController();
            CarregarImagemFundo();
        }

        private void CarregarImagemFundo()
        {
            string[] caminhos = new string[]
            {
                Path.Combine(Application.StartupPath, "Resources", "background.jpg"),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "background.jpg"),
                Path.Combine(Directory.GetCurrentDirectory(), "Resources", "background.jpg"),
                Path.Combine(Application.StartupPath, "..", "..", "Resources", "background.jpg"),
                Path.Combine(Application.StartupPath, "..", "..", "..", "Resources", "background.jpg")
            };

            foreach (string caminho in caminhos)
            {
                if (File.Exists(caminho))
                {
                    this.BackgroundImage = Image.FromFile(caminho);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                }
            }
        }

        private void menuItemBrinquedos_Click(object sender, EventArgs e)
        {
            FormCadastroBrinquedo formCadastro = new FormCadastroBrinquedo(controller);
            formCadastro.ShowDialog();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
