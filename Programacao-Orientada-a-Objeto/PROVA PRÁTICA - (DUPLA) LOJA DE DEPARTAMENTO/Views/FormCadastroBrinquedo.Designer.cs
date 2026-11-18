using System.Windows.Forms;
using System.Drawing;

namespace P1POO.Views
{
    partial class FormCadastroBrinquedo
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox gbCadastro;
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
        private Label lblNomeFabricante;
        private TextBox txtNomeFabricante;
        private Label lblCnpjFabricante;
        private TextBox txtCnpjFabricante;
        private Button btnAdicionar;
        private GroupBox gbListagem;
        private ListBox listBoxBrinquedos;
        private Button btnVisualizar;
        private Button btnRemover;

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
            this.gbCadastro = new GroupBox();
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
            this.lblNomeFabricante = new Label();
            this.txtNomeFabricante = new TextBox();
            this.lblCnpjFabricante = new Label();
            this.txtCnpjFabricante = new TextBox();
            this.btnAdicionar = new Button();
            this.gbListagem = new GroupBox();
            this.listBoxBrinquedos = new ListBox();
            this.btnVisualizar = new Button();
            this.btnRemover = new Button();

            this.gbCadastro.SuspendLayout();
            this.gbListagem.SuspendLayout();
            this.SuspendLayout();

            this.gbCadastro.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.gbCadastro.Location = new Point(15, 15);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new Size(380, 480);
            this.gbCadastro.TabIndex = 0;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Cadastro de Brinquedo";

            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new Point(20, 30);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new Size(111, 17);
            this.lblCodigoBarras.Text = "Código de Barras:";

            this.txtCodigoBarras.Location = new Point(20, 52);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new Size(335, 24);
            this.txtCodigoBarras.TabIndex = 1;

            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new Point(20, 85);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new Size(68, 17);
            this.lblDescricao.Text = "Descrição:";

            this.txtDescricao.Location = new Point(20, 107);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new Size(335, 24);
            this.txtDescricao.TabIndex = 2;

            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new Point(20, 140);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new Size(67, 17);
            this.lblPreco.Text = "Preço (R$):";

            this.txtPreco.Location = new Point(20, 162);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new Size(155, 24);
            this.txtPreco.TabIndex = 3;

            this.lblIdadeMinima.AutoSize = true;
            this.lblIdadeMinima.Location = new Point(195, 140);
            this.lblIdadeMinima.Name = "lblIdadeMinima";
            this.lblIdadeMinima.Size = new Size(91, 17);
            this.lblIdadeMinima.Text = "Idade Mínima:";

            this.txtIdadeMinima.Location = new Point(195, 162);
            this.txtIdadeMinima.Name = "txtIdadeMinima";
            this.txtIdadeMinima.Size = new Size(160, 24);
            this.txtIdadeMinima.TabIndex = 4;

            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new Point(20, 195);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new Size(68, 17);
            this.lblCategoria.Text = "Categoria:";

            this.txtCategoria.Location = new Point(20, 217);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new Size(335, 24);
            this.txtCategoria.TabIndex = 5;

            this.lblNomeFabricante.AutoSize = true;
            this.lblNomeFabricante.Location = new Point(20, 255);
            this.lblNomeFabricante.Name = "lblNomeFabricante";
            this.lblNomeFabricante.Size = new Size(128, 17);
            this.lblNomeFabricante.Text = "Nome do Fabricante:";

            this.txtNomeFabricante.Location = new Point(20, 277);
            this.txtNomeFabricante.Name = "txtNomeFabricante";
            this.txtNomeFabricante.Size = new Size(335, 24);
            this.txtNomeFabricante.TabIndex = 6;

            this.lblCnpjFabricante.AutoSize = true;
            this.lblCnpjFabricante.Location = new Point(20, 310);
            this.lblCnpjFabricante.Name = "lblCnpjFabricante";
            this.lblCnpjFabricante.Size = new Size(121, 17);
            this.lblCnpjFabricante.Text = "CNPJ do Fabricante:";

            this.txtCnpjFabricante.Location = new Point(20, 332);
            this.txtCnpjFabricante.Name = "txtCnpjFabricante";
            this.txtCnpjFabricante.Size = new Size(335, 24);
            this.txtCnpjFabricante.TabIndex = 7;

            this.btnAdicionar.BackColor = Color.LightSteelBlue;
            this.btnAdicionar.FlatStyle = FlatStyle.System;
            this.btnAdicionar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAdicionar.Location = new Point(20, 390);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new Size(335, 45);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar Brinquedo";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            this.gbCadastro.Controls.Add(this.btnAdicionar);
            this.gbCadastro.Controls.Add(this.txtCnpjFabricante);
            this.gbCadastro.Controls.Add(this.lblCnpjFabricante);
            this.gbCadastro.Controls.Add(this.txtNomeFabricante);
            this.gbCadastro.Controls.Add(this.lblNomeFabricante);
            this.gbCadastro.Controls.Add(this.txtCategoria);
            this.gbCadastro.Controls.Add(this.lblCategoria);
            this.gbCadastro.Controls.Add(this.txtIdadeMinima);
            this.gbCadastro.Controls.Add(this.lblIdadeMinima);
            this.gbCadastro.Controls.Add(this.txtPreco);
            this.gbCadastro.Controls.Add(this.lblPreco);
            this.gbCadastro.Controls.Add(this.txtDescricao);
            this.gbCadastro.Controls.Add(this.lblDescricao);
            this.gbCadastro.Controls.Add(this.txtCodigoBarras);
            this.gbCadastro.Controls.Add(this.lblCodigoBarras);

            this.gbListagem.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.gbListagem.Location = new Point(410, 15);
            this.gbListagem.Name = "gbListagem";
            this.gbListagem.Size = new Size(490, 480);
            this.gbListagem.TabIndex = 1;
            this.gbListagem.TabStop = false;
            this.gbListagem.Text = "Brinquedos Cadastrados";

            this.listBoxBrinquedos.Font = new Font("Segoe UI", 9.5F);
            this.listBoxBrinquedos.FormattingEnabled = true;
            this.listBoxBrinquedos.HorizontalScrollbar = true;
            this.listBoxBrinquedos.ItemHeight = 17;
            this.listBoxBrinquedos.Location = new Point(20, 30);
            this.listBoxBrinquedos.Name = "listBoxBrinquedos";
            this.listBoxBrinquedos.Size = new Size(450, 378);
            this.listBoxBrinquedos.TabIndex = 9;

            this.btnVisualizar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnVisualizar.Location = new Point(20, 425);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new Size(215, 38);
            this.btnVisualizar.TabIndex = 10;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);

            this.btnRemover.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnRemover.Location = new Point(255, 425);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new Size(215, 38);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);

            this.gbListagem.Controls.Add(this.btnRemover);
            this.gbListagem.Controls.Add(this.btnVisualizar);
            this.gbListagem.Controls.Add(this.listBoxBrinquedos);

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(915, 510);
            this.Controls.Add(this.gbListagem);
            this.Controls.Add(this.gbCadastro);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCadastroBrinquedo";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Consulta de Brinquedos";
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.gbListagem.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
