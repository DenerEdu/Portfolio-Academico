namespace ProjetoHortiFruti.Views
{
    partial class frmVendaDetalhes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbItensVenda = new System.Windows.Forms.GroupBox();
            this.dgvVendaItens = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataHora = new System.Windows.Forms.TextBox();
            this.txtVendaId = new System.Windows.Forms.TextBox();
            this.grbDadosVenda = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuarioId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.grbDadosUsuario = new System.Windows.Forms.GroupBox();
            this.grbDadosCliente = new System.Windows.Forms.GroupBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.grbItensVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendaItens)).BeginInit();
            this.grbDadosVenda.SuspendLayout();
            this.grbDadosUsuario.SuspendLayout();
            this.grbDadosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "Produto.ProdutoId";
            this.IdProduto.HeaderText = "Código";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            this.IdProduto.Width = 70;
            // 
            // DescricaoProduto
            // 
            this.DescricaoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescricaoProduto.DataPropertyName = "Produto.Descricao";
            this.DescricaoProduto.HeaderText = "Descrição";
            this.DescricaoProduto.Name = "DescricaoProduto";
            this.DescricaoProduto.ReadOnly = true;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle1.Format = "N2";
            this.ValorUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.ValorUnitario.HeaderText = "Valor Unit.";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.ReadOnly = true;
            this.ValorUnitario.Width = 85;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.Quantidade.HeaderText = "Qtd.";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 65;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle3.Format = "N2";
            this.ValorTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.ValorTotal.HeaderText = "Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 85;
            // 
            // grbItensVenda
            // 
            this.grbItensVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbItensVenda.Controls.Add(this.dgvVendaItens);
            this.grbItensVenda.Controls.Add(this.label3);
            this.grbItensVenda.Location = new System.Drawing.Point(13, 255);
            this.grbItensVenda.Name = "grbItensVenda";
            this.grbItensVenda.Size = new System.Drawing.Size(622, 240);
            this.grbItensVenda.TabIndex = 15;
            this.grbItensVenda.TabStop = false;
            this.grbItensVenda.Text = "Itens da Venda";
            // 
            // dgvVendaItens
            // 
            this.dgvVendaItens.AllowUserToAddRows = false;
            this.dgvVendaItens.AllowUserToDeleteRows = false;
            this.dgvVendaItens.AllowUserToOrderColumns = true;
            this.dgvVendaItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendaItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.DescricaoProduto,
            this.ValorUnitario,
            this.Quantidade,
            this.ValorTotal});
            this.dgvVendaItens.Location = new System.Drawing.Point(9, 40);
            this.dgvVendaItens.MultiSelect = false;
            this.dgvVendaItens.Name = "dgvVendaItens";
            this.dgvVendaItens.RowHeadersVisible = false;
            this.dgvVendaItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendaItens.Size = new System.Drawing.Size(604, 190);
            this.dgvVendaItens.TabIndex = 7;
            this.dgvVendaItens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVendaItens_CellFormatting);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Produtos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Venda";
            // 
            // txtDataHora
            // 
            this.txtDataHora.Location = new System.Drawing.Point(117, 40);
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.ReadOnly = true;
            this.txtDataHora.Size = new System.Drawing.Size(176, 20);
            this.txtDataHora.TabIndex = 7;
            this.txtDataHora.TabStop = false;
            // 
            // txtVendaId
            // 
            this.txtVendaId.Location = new System.Drawing.Point(14, 40);
            this.txtVendaId.Name = "txtVendaId";
            this.txtVendaId.ReadOnly = true;
            this.txtVendaId.Size = new System.Drawing.Size(92, 20);
            this.txtVendaId.TabIndex = 5;
            this.txtVendaId.TabStop = false;
            // 
            // grbDadosVenda
            // 
            this.grbDadosVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDadosVenda.Controls.Add(this.txtDataHora);
            this.grbDadosVenda.Controls.Add(this.txtVendaId);
            this.grbDadosVenda.Controls.Add(this.label4);
            this.grbDadosVenda.Controls.Add(this.label5);
            this.grbDadosVenda.Location = new System.Drawing.Point(13, 12);
            this.grbDadosVenda.Name = "grbDadosVenda";
            this.grbDadosVenda.Size = new System.Drawing.Size(622, 75);
            this.grbDadosVenda.TabIndex = 14;
            this.grbDadosVenda.TabStop = false;
            this.grbDadosVenda.Text = "Dados da Venda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data/Hora";
            // 
            // txtUsuarioId
            // 
            this.txtUsuarioId.Location = new System.Drawing.Point(14, 40);
            this.txtUsuarioId.Name = "txtUsuarioId";
            this.txtUsuarioId.ReadOnly = true;
            this.txtUsuarioId.Size = new System.Drawing.Size(52, 20);
            this.txtUsuarioId.TabIndex = 1;
            this.txtUsuarioId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(76, 40);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.ReadOnly = true;
            this.txtNomeUsuario.Size = new System.Drawing.Size(537, 20);
            this.txtNomeUsuario.TabIndex = 2;
            this.txtNomeUsuario.TabStop = false;
            // 
            // grbDadosUsuario
            // 
            this.grbDadosUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDadosUsuario.Controls.Add(this.txtUsuarioId);
            this.grbDadosUsuario.Controls.Add(this.label1);
            this.grbDadosUsuario.Controls.Add(this.txtNomeUsuario);
            this.grbDadosUsuario.Location = new System.Drawing.Point(13, 93);
            this.grbDadosUsuario.Name = "grbDadosUsuario";
            this.grbDadosUsuario.Size = new System.Drawing.Size(622, 75);
            this.grbDadosUsuario.TabIndex = 13;
            this.grbDadosUsuario.TabStop = false;
            this.grbDadosUsuario.Text = "Dados do Usuário";
            // 
            // grbDadosCliente
            // 
            this.grbDadosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDadosCliente.Controls.Add(this.txtClienteId);
            this.grbDadosCliente.Controls.Add(this.label2);
            this.grbDadosCliente.Controls.Add(this.txtNomeCliente);
            this.grbDadosCliente.Location = new System.Drawing.Point(13, 174);
            this.grbDadosCliente.Name = "grbDadosCliente";
            this.grbDadosCliente.Size = new System.Drawing.Size(622, 75);
            this.grbDadosCliente.TabIndex = 16;
            this.grbDadosCliente.TabStop = false;
            this.grbDadosCliente.Text = "Dados do Cliente";
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(14, 40);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.ReadOnly = true;
            this.txtClienteId.Size = new System.Drawing.Size(52, 20);
            this.txtClienteId.TabIndex = 1;
            this.txtClienteId.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCliente.Location = new System.Drawing.Point(76, 40);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(537, 20);
            this.txtNomeCliente.TabIndex = 2;
            this.txtNomeCliente.TabStop = false;
            // 
            // frmVendaDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 510);
            this.Controls.Add(this.grbDadosCliente);
            this.Controls.Add(this.grbItensVenda);
            this.Controls.Add(this.grbDadosVenda);
            this.Controls.Add(this.grbDadosUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVendaDetalhes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes da Venda";
            this.Load += new System.EventHandler(this.frmVendaDetalhes_Load);
            this.grbItensVenda.ResumeLayout(false);
            this.grbItensVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendaItens)).EndInit();
            this.grbDadosVenda.ResumeLayout(false);
            this.grbDadosVenda.PerformLayout();
            this.grbDadosUsuario.ResumeLayout(false);
            this.grbDadosUsuario.PerformLayout();
            this.grbDadosCliente.ResumeLayout(false);
            this.grbDadosCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.GroupBox grbItensVenda;
        private System.Windows.Forms.DataGridView dgvVendaItens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataHora;
        private System.Windows.Forms.TextBox txtVendaId;
        private System.Windows.Forms.GroupBox grbDadosVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuarioId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.GroupBox grbDadosUsuario;
        private System.Windows.Forms.GroupBox grbDadosCliente;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCliente;
    }
}
