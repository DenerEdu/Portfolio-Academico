using System.Windows.Forms;
using System.Drawing;

namespace P1POO.Views
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStripPrincipal;
        private ToolStripMenuItem menuCadastros;
        private ToolStripMenuItem menuItemBrinquedos;
        private ToolStripMenuItem menuSair;
        private Label lblTitulo;
        private Label lblParticipantes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripPrincipal = new MenuStrip();
            this.menuCadastros = new ToolStripMenuItem();
            this.menuItemBrinquedos = new ToolStripMenuItem();
            this.menuSair = new ToolStripMenuItem();
            this.lblTitulo = new Label();
            this.lblParticipantes = new Label();

            this.menuStripPrincipal.SuspendLayout();
            this.SuspendLayout();

            this.menuStripPrincipal.BackColor = Color.WhiteSmoke;
            this.menuStripPrincipal.Font = new Font("Segoe UI", 10F);
            this.menuStripPrincipal.Items.AddRange(new ToolStripItem[] {
                this.menuCadastros,
                this.menuSair
            });
            this.menuStripPrincipal.Location = new Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new Size(800, 28);
            this.menuStripPrincipal.TabIndex = 0;

            this.menuCadastros.DropDownItems.AddRange(new ToolStripItem[] {
                this.menuItemBrinquedos
            });
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new Size(88, 24);
            this.menuCadastros.Text = "Cadastros";

            this.menuItemBrinquedos.Name = "menuItemBrinquedos";
            this.menuItemBrinquedos.Size = new Size(180, 24);
            this.menuItemBrinquedos.Text = "Brinquedos";
            this.menuItemBrinquedos.Click += new System.EventHandler(this.menuItemBrinquedos_Click);

            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new Size(46, 24);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = Color.Transparent;
            this.lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.FromArgb(20, 45, 95);
            this.lblTitulo.Location = new Point(30, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(365, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "BrinkStore - Gestão de Brinquedos";

            this.lblParticipantes.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.lblParticipantes.AutoSize = true;
            this.lblParticipantes.BackColor = Color.Transparent;
            this.lblParticipantes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblParticipantes.ForeColor = Color.FromArgb(30, 40, 70);
            this.lblParticipantes.Location = new Point(35, 442);
            this.lblParticipantes.Name = "lblParticipantes";
            this.lblParticipantes.Size = new Size(378, 20);
            this.lblParticipantes.TabIndex = 3;
            this.lblParticipantes.Text = "Participantes: Dener Eduardo e Hernandes Vítor";

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(820, 490);
            this.Controls.Add(this.lblParticipantes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStripPrincipal);
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "FormPrincipal";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cadastro de Brinquedos";
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
