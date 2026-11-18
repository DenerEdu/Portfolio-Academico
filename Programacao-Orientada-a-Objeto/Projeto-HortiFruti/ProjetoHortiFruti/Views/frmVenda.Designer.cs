namespace ProjetoHortiFruti.Views
{
    partial class frmVenda
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
            this.grbDadosVenda = new System.Windows.Forms.GroupBox();
            this.txtDataHora = new System.Windows.Forms.TextBox();
            this.txtVendaId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbDadosUsuario = new System.Windows.Forms.GroupBox();
            this.txtUsuarioId = new System.Windows.Forms.TextBox();
            this.btnPesquisarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.grbDadosCliente = new System.Windows.Forms.GroupBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.grbItensVenda = new System.Windows.Forms.GroupBox();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.dgvVendaItens = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidadeItem = new System.Windows.Forms.TextBox();
            this.txtProdutoId = new System.Windows.Forms.TextBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.btnFecharTela = new System.Windows.Forms.Button();
            this.grbDadosVenda.SuspendLayout();
            this.grbDadosUsuario.SuspendLayout();
            this.grbDadosCliente.SuspendLayout();
            this.grbItensVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendaItens)).BeginInit();
            this.SuspendLayout();
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
            this.grbDadosVenda.Size = new System.Drawing.Size(807, 75);
            this.grbDadosVenda.TabIndex = 0;
            this.grbDadosVenda.TabStop = false;
            this.grbDadosVenda.Text = "Dados da Venda";
            // 
            // txtDataHora
            // 
            this.txtDataHora.Location = new System.Drawing.Point(117, 40);
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.ReadOnly = true;
            this.txtDataHora.Size = new System.Drawing.Size(176, 20);
            this.txtDataHora.TabIndex = 3;
            this.txtDataHora.TabStop = false;
            // 
            // txtVendaId
            // 
            this.txtVendaId.Location = new System.Drawing.Point(14, 40);
            this.txtVendaId.Name = "txtVendaId";
            this.txtVendaId.ReadOnly = true;
            this.txtVendaId.Size = new System.Drawing.Size(92, 20);
            this.txtVendaId.TabIndex = 1;
            this.txtVendaId.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data/Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Venda";
            // 
            // grbDadosUsuario
            // 
            this.grbDadosUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDadosUsuario.Controls.Add(this.txtUsuarioId);
            this.grbDadosUsuario.Controls.Add(this.btnPesquisarUsuario);
            this.grbDadosUsuario.Controls.Add(this.label1);
            this.grbDadosUsuario.Controls.Add(this.txtNomeUsuario);
            this.grbDadosUsuario.Location = new System.Drawing.Point(13, 93);
            this.grbDadosUsuario.Name = "grbDadosUsuario";
            this.grbDadosUsuario.Size = new System.Drawing.Size(807, 75);
            this.grbDadosUsuario.TabIndex = 1;
            this.grbDadosUsuario.TabStop = false;
            this.grbDadosUsuario.Text = "Dados do Usuário";
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
            // btnPesquisarUsuario
            // 
            this.btnPesquisarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarUsuario.Location = new System.Drawing.Point(753, 38);
            this.btnPesquisarUsuario.Name = "btnPesquisarUsuario";
            this.btnPesquisarUsuario.Size = new System.Drawing.Size(42, 24);
            this.btnPesquisarUsuario.TabIndex = 3;
            this.btnPesquisarUsuario.Text = "...";
            this.btnPesquisarUsuario.UseVisualStyleBackColor = true;
            this.btnPesquisarUsuario.Click += new System.EventHandler(this.btnPesquisarUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
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
            this.txtNomeUsuario.Size = new System.Drawing.Size(669, 20);
            this.txtNomeUsuario.TabIndex = 2;
            this.txtNomeUsuario.TabStop = false;
            // 
            // grbDadosCliente
            // 
            this.grbDadosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDadosCliente.Controls.Add(this.txtClienteId);
            this.grbDadosCliente.Controls.Add(this.btnPesquisarCliente);
            this.grbDadosCliente.Controls.Add(this.label6);
            this.grbDadosCliente.Controls.Add(this.txtNomeCliente);
            this.grbDadosCliente.Location = new System.Drawing.Point(13, 174);
            this.grbDadosCliente.Name = "grbDadosCliente";
            this.grbDadosCliente.Size = new System.Drawing.Size(807, 75);
            this.grbDadosCliente.TabIndex = 2;
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
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarCliente.Location = new System.Drawing.Point(753, 38);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(42, 24);
            this.btnPesquisarCliente.TabIndex = 3;
            this.btnPesquisarCliente.Text = "...";
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCliente.Location = new System.Drawing.Point(76, 40);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(669, 20);
            this.txtNomeCliente.TabIndex = 2;
            this.txtNomeCliente.TabStop = false;
            // 
            // grbItensVenda
            // 
            this.grbItensVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbItensVenda.Controls.Add(this.btnRemoverItem);
            this.grbItensVenda.Controls.Add(this.dgvVendaItens);
            this.grbItensVenda.Controls.Add(this.btnAdicionarItem);
            this.grbItensVenda.Controls.Add(this.label2);
            this.grbItensVenda.Controls.Add(this.txtQuantidadeItem);
            this.grbItensVenda.Controls.Add(this.txtProdutoId);
            this.grbItensVenda.Controls.Add(this.btnPesquisarProduto);
            this.grbItensVenda.Controls.Add(this.label3);
            this.grbItensVenda.Controls.Add(this.txtDescricao);
            this.grbItensVenda.Location = new System.Drawing.Point(13, 255);
            this.grbItensVenda.Name = "grbItensVenda";
            this.grbItensVenda.Size = new System.Drawing.Size(807, 395);
            this.grbItensVenda.TabIndex = 3;
            this.grbItensVenda.TabStop = false;
            this.grbItensVenda.Text = "Itens da Venda";
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverItem.Location = new System.Drawing.Point(684, 348);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(112, 35);
            this.btnRemoverItem.TabIndex = 8;
            this.btnRemoverItem.Text = "Remover";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
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
            this.dgvVendaItens.Location = new System.Drawing.Point(9, 80);
            this.dgvVendaItens.MultiSelect = false;
            this.dgvVendaItens.Name = "dgvVendaItens";
            this.dgvVendaItens.RowHeadersVisible = false;
            this.dgvVendaItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendaItens.Size = new System.Drawing.Size(789, 258);
            this.dgvVendaItens.TabIndex = 7;
            this.dgvVendaItens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVendaItens_CellFormatting);
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
            this.ValorUnitario.Width = 90;
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
            this.Quantidade.Width = 70;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle3.Format = "N2";
            this.ValorTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.ValorTotal.HeaderText = "Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 90;
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarItem.Location = new System.Drawing.Point(697, 42);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(100, 26);
            this.btnAdicionarItem.TabIndex = 6;
            this.btnAdicionarItem.Text = "Adicionar";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade";
            // 
            // txtQuantidadeItem
            // 
            this.txtQuantidadeItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidadeItem.Location = new System.Drawing.Point(600, 44);
            this.txtQuantidadeItem.MaxLength = 2;
            this.txtQuantidadeItem.Name = "txtQuantidadeItem";
            this.txtQuantidadeItem.Size = new System.Drawing.Size(86, 20);
            this.txtQuantidadeItem.TabIndex = 5;
            this.txtQuantidadeItem.Text = "1";
            // 
            // txtProdutoId
            // 
            this.txtProdutoId.Location = new System.Drawing.Point(14, 44);
            this.txtProdutoId.Name = "txtProdutoId";
            this.txtProdutoId.ReadOnly = true;
            this.txtProdutoId.Size = new System.Drawing.Size(56, 20);
            this.txtProdutoId.TabIndex = 1;
            this.txtProdutoId.TabStop = false;
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarProduto.Location = new System.Drawing.Point(551, 42);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(42, 24);
            this.btnPesquisarProduto.TabIndex = 3;
            this.btnPesquisarProduto.Text = "...";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Produto";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Location = new System.Drawing.Point(78, 44);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(466, 20);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TabStop = false;
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarVenda.Location = new System.Drawing.Point(13, 660);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(170, 35);
            this.btnCancelarVenda.TabIndex = 4;
            this.btnCancelarVenda.Text = "Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarVenda.Location = new System.Drawing.Point(518, 660);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(170, 35);
            this.btnFinalizarVenda.TabIndex = 5;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // btnFecharTela
            // 
            this.btnFecharTela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharTela.Location = new System.Drawing.Point(697, 660);
            this.btnFecharTela.Name = "btnFecharTela";
            this.btnFecharTela.Size = new System.Drawing.Size(123, 35);
            this.btnFecharTela.TabIndex = 6;
            this.btnFecharTela.Text = "Fechar tela";
            this.btnFecharTela.UseVisualStyleBackColor = true;
            this.btnFecharTela.Click += new System.EventHandler(this.btnFecharTela_Click);
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 709);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.btnFecharTela);
            this.Controls.Add(this.grbItensVenda);
            this.Controls.Add(this.grbDadosCliente);
            this.Controls.Add(this.grbDadosUsuario);
            this.Controls.Add(this.grbDadosVenda);
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Venda";
            this.grbDadosVenda.ResumeLayout(false);
            this.grbDadosVenda.PerformLayout();
            this.grbDadosUsuario.ResumeLayout(false);
            this.grbDadosUsuario.PerformLayout();
            this.grbDadosCliente.ResumeLayout(false);
            this.grbDadosCliente.PerformLayout();
            this.grbItensVenda.ResumeLayout(false);
            this.grbItensVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendaItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDadosVenda;
        private System.Windows.Forms.TextBox txtDataHora;
        private System.Windows.Forms.TextBox txtVendaId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbDadosUsuario;
        private System.Windows.Forms.TextBox txtUsuarioId;
        private System.Windows.Forms.Button btnPesquisarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.GroupBox grbDadosCliente;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.GroupBox grbItensVenda;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.DataGridView dgvVendaItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidadeItem;
        private System.Windows.Forms.TextBox txtProdutoId;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Button btnFecharTela;
    }
}
