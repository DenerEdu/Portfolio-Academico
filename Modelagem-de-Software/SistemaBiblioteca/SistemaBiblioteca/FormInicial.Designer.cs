namespace SistemaBiblioteca
{
    partial class FormInicial
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.picCapa = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapa
            // 
            this.picCapa.Location = new System.Drawing.Point(0, 0);
            this.picCapa.Name = "picCapa";
            this.picCapa.Size = new System.Drawing.Size(784, 400);
            this.picCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCapa.TabIndex = 0;
            this.picCapa.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(0, 410);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(784, 40);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Sistema de Biblioteca";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAluno
            // 
            this.lblAluno.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAluno.Location = new System.Drawing.Point(0, 455);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(784, 25);
            this.lblAluno.TabIndex = 2;
            this.lblAluno.Text = "Aluno: Dener Eduardo  -  RA: 2025101793";
            this.lblAluno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDisciplina.Location = new System.Drawing.Point(0, 480);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(784, 22);
            this.lblDisciplina.TabIndex = 3;
            this.lblDisciplina.Text = "Modelagem de Software I - Sistemas de Informação";
            this.lblDisciplina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.Location = new System.Drawing.Point(262, 515);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(120, 35);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSair.Location = new System.Drawing.Point(402, 515);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 35);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 565);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picCapa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.FormInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
    }
}
