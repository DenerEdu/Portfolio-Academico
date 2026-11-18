using System.Windows.Forms;
using System.Drawing;

namespace P1POO.Views
{
    partial class FormVisualizarBrinquedo
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblCodigoBarras;
        private TextBox txtCodigoBarras;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Label lblPreco;
        private TextBox txtPreco;
        private Label lblCategoria;
        private TextBox txtCategoria;
        private Label lblIdadeMinima;
        private TextBox txtIdadeMinima;
        private Label lblFabricante;
        private TextBox txtFabricante;
        private Button btnFechar;

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
            this.lblTitulo = new Label();
            this.lblCodigoBarras = new Label();
            this.txtCodigoBarras = new TextBox();
            this.lblDescricao = new Label();
            this.txtDescricao = new TextBox();
            this.lblPreco = new Label();
            this.txtPreco = new TextBox();
            this.lblCategoria = new Label();
            this.txtCategoria = new TextBox();
            this.lblIdadeMinima = new Label();
            this.txtIdadeMinima = new TextBox();
            this.lblFabricante = new Label();
            this.txtFabricante = new TextBox();
            this.btnFechar = new Button();

            this.SuspendLayout();

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.DarkSlateBlue;
            this.lblTitulo.Location = new Point(25, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(248, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Detalhes do Brinquedo";

            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Font = new Font("Segoe UI", 9.5F);
            this.lblCodigoBarras.Location = new Point(25, 65);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new Size(111, 17);
            this.lblCodigoBarras.TabIndex = 1;
            this.lblCodigoBarras.Text = "Código de Barras:";

            this.txtCodigoBarras.Font = new Font("Segoe UI", 9.5F);
            this.txtCodigoBarras.Location = new Point(25, 87);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.ReadOnly = true;
            this.txtCodigoBarras.BackColor = Color.White;
            this.txtCodigoBarras.Size = new Size(380, 24);
            this.txtCodigoBarras.TabIndex = 2;

            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new Font("Segoe UI", 9.5F);
            this.lblDescricao.Location = new Point(25, 125);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new Size(68, 17);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição:";

            this.txtDescricao.Font = new Font("Segoe UI", 9.5F);
            this.txtDescricao.Location = new Point(25, 147);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.BackColor = Color.White;
            this.txtDescricao.Size = new Size(380, 24);
            this.txtDescricao.TabIndex = 4;

            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new Font("Segoe UI", 9.5F);
            this.lblPreco.Location = new Point(25, 185);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new Size(44, 17);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "Preço:";

            this.txtPreco.Font = new Font("Segoe UI", 9.5F);
            this.txtPreco.Location = new Point(25, 207);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.BackColor = Color.White;
            this.txtPreco.Size = new Size(180, 24);
            this.txtPreco.TabIndex = 6;

            this.lblIdadeMinima.AutoSize = true;
            this.lblIdadeMinima.Font = new Font("Segoe UI", 9.5F);
            this.lblIdadeMinima.Location = new Point(225, 185);
            this.lblIdadeMinima.Name = "lblIdadeMinima";
            this.lblIdadeMinima.Size = new Size(91, 17);
            this.lblIdadeMinima.TabIndex = 7;
            this.lblIdadeMinima.Text = "Idade Mínima:";

            this.txtIdadeMinima.Font = new Font("Segoe UI", 9.5F);
            this.txtIdadeMinima.Location = new Point(225, 207);
            this.txtIdadeMinima.Name = "txtIdadeMinima";
            this.txtIdadeMinima.ReadOnly = true;
            this.txtIdadeMinima.BackColor = Color.White;
            this.txtIdadeMinima.Size = new Size(180, 24);
            this.txtIdadeMinima.TabIndex = 8;

            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new Font("Segoe UI", 9.5F);
            this.lblCategoria.Location = new Point(25, 245);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new Size(68, 17);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria:";

            this.txtCategoria.Font = new Font("Segoe UI", 9.5F);
            this.txtCategoria.Location = new Point(25, 267);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.BackColor = Color.White;
            this.txtCategoria.Size = new Size(380, 24);
            this.txtCategoria.TabIndex = 10;

            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Font = new Font("Segoe UI", 9.5F);
            this.lblFabricante.Location = new Point(25, 305);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new Size(158, 17);
            this.lblFabricante.TabIndex = 11;
            this.lblFabricante.Text = "Fabricante (CNPJ - Nome):";

            this.txtFabricante.Font = new Font("Segoe UI", 9.5F);
            this.txtFabricante.Location = new Point(25, 327);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.ReadOnly = true;
            this.txtFabricante.BackColor = Color.White;
            this.txtFabricante.Size = new Size(380, 24);
            this.txtFabricante.TabIndex = 12;

            this.btnFechar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnFechar.Location = new Point(140, 380);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new Size(150, 38);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(435, 440);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtIdadeMinima);
            this.Controls.Add(this.lblIdadeMinima);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.lblCodigoBarras);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVisualizarBrinquedo";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Visualizar Brinquedo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
