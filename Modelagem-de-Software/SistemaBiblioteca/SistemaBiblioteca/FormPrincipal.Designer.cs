namespace SistemaBiblioteca
{
    partial class FormPrincipal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLivros = new System.Windows.Forms.TabPage();
            this.tabAlunos = new System.Windows.Forms.TabPage();
            this.tabFuncionarios = new System.Windows.Forms.TabPage();
            this.tabEmprestimos = new System.Windows.Forms.TabPage();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblTituloLivro = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnDisponibilizar = new System.Windows.Forms.Button();
            this.lstLivros = new System.Windows.Forms.ListBox();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.lblCpfAluno = new System.Windows.Forms.Label();
            this.lblEmailAluno = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtCpfAluno = new System.Windows.Forms.TextBox();
            this.txtEmailAluno = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.lstAlunos = new System.Windows.Forms.ListBox();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblCpfFunc = new System.Windows.Forms.Label();
            this.lblEmailFunc = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.txtCpfFunc = new System.Windows.Forms.TextBox();
            this.txtEmailFunc = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
            this.lstFuncionarios = new System.Windows.Forms.ListBox();
            this.lblEmpAluno = new System.Windows.Forms.Label();
            this.lblEmpLivro = new System.Windows.Forms.Label();
            this.lblEmpFunc = new System.Windows.Forms.Label();
            this.lblEmpData = new System.Windows.Forms.Label();
            this.cboAluno = new System.Windows.Forms.ComboBox();
            this.cboLivro = new System.Windows.Forms.ComboBox();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.lstEmprestimos = new System.Windows.Forms.ListBox();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnAtrasados = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabLivros.SuspendLayout();
            this.tabAlunos.SuspendLayout();
            this.tabFuncionarios.SuspendLayout();
            this.tabEmprestimos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLivros);
            this.tabControl1.Controls.Add(this.tabAlunos);
            this.tabControl1.Controls.Add(this.tabFuncionarios);
            this.tabControl1.Controls.Add(this.tabEmprestimos);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 500);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabLivros
            // 
            this.tabLivros.Controls.Add(this.lblIsbn);
            this.tabLivros.Controls.Add(this.lblTituloLivro);
            this.tabLivros.Controls.Add(this.lblAno);
            this.tabLivros.Controls.Add(this.txtIsbn);
            this.tabLivros.Controls.Add(this.txtTitulo);
            this.tabLivros.Controls.Add(this.txtAno);
            this.tabLivros.Controls.Add(this.btnCadastrarLivro);
            this.tabLivros.Controls.Add(this.btnReservar);
            this.tabLivros.Controls.Add(this.btnDisponibilizar);
            this.tabLivros.Controls.Add(this.lstLivros);
            this.tabLivros.Location = new System.Drawing.Point(4, 22);
            this.tabLivros.Name = "tabLivros";
            this.tabLivros.Padding = new System.Windows.Forms.Padding(3);
            this.tabLivros.Size = new System.Drawing.Size(752, 474);
            this.tabLivros.TabIndex = 0;
            this.tabLivros.Text = "Livros";
            this.tabLivros.UseVisualStyleBackColor = true;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(20, 20);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(35, 13);
            this.lblIsbn.Text = "ISBN:";
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.AutoSize = true;
            this.lblTituloLivro.Location = new System.Drawing.Point(20, 55);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(38, 13);
            this.lblTituloLivro.Text = "Título:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(20, 90);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.Text = "Ano:";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(110, 17);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(200, 20);
            this.txtIsbn.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(110, 52);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(200, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(110, 87);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(200, 20);
            this.txtAno.TabIndex = 3;
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Location = new System.Drawing.Point(110, 122);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(200, 30);
            this.btnCadastrarLivro.TabIndex = 4;
            this.btnCadastrarLivro.Text = "Cadastrar Livro";
            this.btnCadastrarLivro.UseVisualStyleBackColor = true;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(350, 17);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(170, 30);
            this.btnReservar.TabIndex = 5;
            this.btnReservar.Text = "Reservar Livro Selecionado";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnDisponibilizar
            // 
            this.btnDisponibilizar.Location = new System.Drawing.Point(350, 52);
            this.btnDisponibilizar.Name = "btnDisponibilizar";
            this.btnDisponibilizar.Size = new System.Drawing.Size(170, 30);
            this.btnDisponibilizar.TabIndex = 6;
            this.btnDisponibilizar.Text = "Cancelar Reserva";
            this.btnDisponibilizar.UseVisualStyleBackColor = true;
            this.btnDisponibilizar.Click += new System.EventHandler(this.btnDisponibilizar_Click);
            // 
            // lstLivros
            // 
            this.lstLivros.FormattingEnabled = true;
            this.lstLivros.Location = new System.Drawing.Point(20, 170);
            this.lstLivros.Name = "lstLivros";
            this.lstLivros.Size = new System.Drawing.Size(710, 290);
            this.lstLivros.TabIndex = 7;
            // 
            // tabAlunos
            // 
            this.tabAlunos.Controls.Add(this.lblNomeAluno);
            this.tabAlunos.Controls.Add(this.lblCpfAluno);
            this.tabAlunos.Controls.Add(this.lblEmailAluno);
            this.tabAlunos.Controls.Add(this.lblMatricula);
            this.tabAlunos.Controls.Add(this.lblCurso);
            this.tabAlunos.Controls.Add(this.txtNomeAluno);
            this.tabAlunos.Controls.Add(this.txtCpfAluno);
            this.tabAlunos.Controls.Add(this.txtEmailAluno);
            this.tabAlunos.Controls.Add(this.txtMatricula);
            this.tabAlunos.Controls.Add(this.txtCurso);
            this.tabAlunos.Controls.Add(this.btnCadastrarAluno);
            this.tabAlunos.Controls.Add(this.lstAlunos);
            this.tabAlunos.Location = new System.Drawing.Point(4, 22);
            this.tabAlunos.Name = "tabAlunos";
            this.tabAlunos.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlunos.Size = new System.Drawing.Size(752, 474);
            this.tabAlunos.TabIndex = 1;
            this.tabAlunos.Text = "Alunos";
            this.tabAlunos.UseVisualStyleBackColor = true;
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(20, 20);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(38, 13);
            this.lblNomeAluno.Text = "Nome:";
            // 
            // lblCpfAluno
            // 
            this.lblCpfAluno.AutoSize = true;
            this.lblCpfAluno.Location = new System.Drawing.Point(20, 55);
            this.lblCpfAluno.Name = "lblCpfAluno";
            this.lblCpfAluno.Size = new System.Drawing.Size(30, 13);
            this.lblCpfAluno.Text = "CPF:";
            // 
            // lblEmailAluno
            // 
            this.lblEmailAluno.AutoSize = true;
            this.lblEmailAluno.Location = new System.Drawing.Point(20, 90);
            this.lblEmailAluno.Name = "lblEmailAluno";
            this.lblEmailAluno.Size = new System.Drawing.Size(38, 13);
            this.lblEmailAluno.Text = "E-mail:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(20, 125);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(55, 13);
            this.lblMatricula.Text = "Matrícula:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(20, 160);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.Text = "Curso:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(110, 17);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(250, 20);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // txtCpfAluno
            // 
            this.txtCpfAluno.Location = new System.Drawing.Point(110, 52);
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.Size = new System.Drawing.Size(250, 20);
            this.txtCpfAluno.TabIndex = 2;
            // 
            // txtEmailAluno
            // 
            this.txtEmailAluno.Location = new System.Drawing.Point(110, 87);
            this.txtEmailAluno.Name = "txtEmailAluno";
            this.txtEmailAluno.Size = new System.Drawing.Size(250, 20);
            this.txtEmailAluno.TabIndex = 3;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(110, 122);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(250, 20);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(110, 157);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(250, 20);
            this.txtCurso.TabIndex = 5;
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(110, 192);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(250, 30);
            this.btnCadastrarAluno.TabIndex = 6;
            this.btnCadastrarAluno.Text = "Cadastrar Aluno";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // lstAlunos
            // 
            this.lstAlunos.FormattingEnabled = true;
            this.lstAlunos.Location = new System.Drawing.Point(20, 240);
            this.lstAlunos.Name = "lstAlunos";
            this.lstAlunos.Size = new System.Drawing.Size(710, 225);
            this.lstAlunos.TabIndex = 7;
            // 
            // tabFuncionarios
            // 
            this.tabFuncionarios.Controls.Add(this.lblNomeFunc);
            this.tabFuncionarios.Controls.Add(this.lblCpfFunc);
            this.tabFuncionarios.Controls.Add(this.lblEmailFunc);
            this.tabFuncionarios.Controls.Add(this.lblCargo);
            this.tabFuncionarios.Controls.Add(this.txtNomeFunc);
            this.tabFuncionarios.Controls.Add(this.txtCpfFunc);
            this.tabFuncionarios.Controls.Add(this.txtEmailFunc);
            this.tabFuncionarios.Controls.Add(this.txtCargo);
            this.tabFuncionarios.Controls.Add(this.btnCadastrarFunc);
            this.tabFuncionarios.Controls.Add(this.lstFuncionarios);
            this.tabFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tabFuncionarios.Name = "tabFuncionarios";
            this.tabFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabFuncionarios.Size = new System.Drawing.Size(752, 474);
            this.tabFuncionarios.TabIndex = 2;
            this.tabFuncionarios.Text = "Funcionários";
            this.tabFuncionarios.UseVisualStyleBackColor = true;
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(20, 20);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(38, 13);
            this.lblNomeFunc.Text = "Nome:";
            // 
            // lblCpfFunc
            // 
            this.lblCpfFunc.AutoSize = true;
            this.lblCpfFunc.Location = new System.Drawing.Point(20, 55);
            this.lblCpfFunc.Name = "lblCpfFunc";
            this.lblCpfFunc.Size = new System.Drawing.Size(30, 13);
            this.lblCpfFunc.Text = "CPF:";
            // 
            // lblEmailFunc
            // 
            this.lblEmailFunc.AutoSize = true;
            this.lblEmailFunc.Location = new System.Drawing.Point(20, 90);
            this.lblEmailFunc.Name = "lblEmailFunc";
            this.lblEmailFunc.Size = new System.Drawing.Size(38, 13);
            this.lblEmailFunc.Text = "E-mail:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(20, 125);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.Text = "Cargo:";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(110, 17);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(250, 20);
            this.txtNomeFunc.TabIndex = 1;
            // 
            // txtCpfFunc
            // 
            this.txtCpfFunc.Location = new System.Drawing.Point(110, 52);
            this.txtCpfFunc.Name = "txtCpfFunc";
            this.txtCpfFunc.Size = new System.Drawing.Size(250, 20);
            this.txtCpfFunc.TabIndex = 2;
            // 
            // txtEmailFunc
            // 
            this.txtEmailFunc.Location = new System.Drawing.Point(110, 87);
            this.txtEmailFunc.Name = "txtEmailFunc";
            this.txtEmailFunc.Size = new System.Drawing.Size(250, 20);
            this.txtEmailFunc.TabIndex = 3;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(110, 122);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(250, 20);
            this.txtCargo.TabIndex = 4;
            // 
            // btnCadastrarFunc
            // 
            this.btnCadastrarFunc.Location = new System.Drawing.Point(110, 157);
            this.btnCadastrarFunc.Name = "btnCadastrarFunc";
            this.btnCadastrarFunc.Size = new System.Drawing.Size(250, 30);
            this.btnCadastrarFunc.TabIndex = 5;
            this.btnCadastrarFunc.Text = "Cadastrar Funcionário";
            this.btnCadastrarFunc.UseVisualStyleBackColor = true;
            this.btnCadastrarFunc.Click += new System.EventHandler(this.btnCadastrarFunc_Click);
            // 
            // lstFuncionarios
            // 
            this.lstFuncionarios.FormattingEnabled = true;
            this.lstFuncionarios.Location = new System.Drawing.Point(20, 205);
            this.lstFuncionarios.Name = "lstFuncionarios";
            this.lstFuncionarios.Size = new System.Drawing.Size(710, 251);
            this.lstFuncionarios.TabIndex = 6;
            // 
            // tabEmprestimos
            // 
            this.tabEmprestimos.Controls.Add(this.lblEmpAluno);
            this.tabEmprestimos.Controls.Add(this.lblEmpLivro);
            this.tabEmprestimos.Controls.Add(this.lblEmpFunc);
            this.tabEmprestimos.Controls.Add(this.lblEmpData);
            this.tabEmprestimos.Controls.Add(this.cboAluno);
            this.tabEmprestimos.Controls.Add(this.cboLivro);
            this.tabEmprestimos.Controls.Add(this.cboFuncionario);
            this.tabEmprestimos.Controls.Add(this.dtpData);
            this.tabEmprestimos.Controls.Add(this.btnEmprestar);
            this.tabEmprestimos.Controls.Add(this.lstEmprestimos);
            this.tabEmprestimos.Controls.Add(this.btnDevolver);
            this.tabEmprestimos.Controls.Add(this.btnAtrasados);
            this.tabEmprestimos.Controls.Add(this.btnTodos);
            this.tabEmprestimos.Location = new System.Drawing.Point(4, 22);
            this.tabEmprestimos.Name = "tabEmprestimos";
            this.tabEmprestimos.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmprestimos.Size = new System.Drawing.Size(752, 474);
            this.tabEmprestimos.TabIndex = 3;
            this.tabEmprestimos.Text = "Empréstimos";
            this.tabEmprestimos.UseVisualStyleBackColor = true;
            // 
            // lblEmpAluno
            // 
            this.lblEmpAluno.AutoSize = true;
            this.lblEmpAluno.Location = new System.Drawing.Point(20, 20);
            this.lblEmpAluno.Name = "lblEmpAluno";
            this.lblEmpAluno.Size = new System.Drawing.Size(37, 13);
            this.lblEmpAluno.Text = "Aluno:";
            // 
            // lblEmpLivro
            // 
            this.lblEmpLivro.AutoSize = true;
            this.lblEmpLivro.Location = new System.Drawing.Point(20, 55);
            this.lblEmpLivro.Name = "lblEmpLivro";
            this.lblEmpLivro.Size = new System.Drawing.Size(33, 13);
            this.lblEmpLivro.Text = "Livro:";
            // 
            // lblEmpFunc
            // 
            this.lblEmpFunc.AutoSize = true;
            this.lblEmpFunc.Location = new System.Drawing.Point(20, 90);
            this.lblEmpFunc.Name = "lblEmpFunc";
            this.lblEmpFunc.Size = new System.Drawing.Size(65, 13);
            this.lblEmpFunc.Text = "Funcionário:";
            // 
            // lblEmpData
            // 
            this.lblEmpData.AutoSize = true;
            this.lblEmpData.Location = new System.Drawing.Point(20, 125);
            this.lblEmpData.Name = "lblEmpData";
            this.lblEmpData.Size = new System.Drawing.Size(33, 13);
            this.lblEmpData.Text = "Data:";
            // 
            // cboAluno
            // 
            this.cboAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAluno.FormattingEnabled = true;
            this.cboAluno.Location = new System.Drawing.Point(110, 17);
            this.cboAluno.Name = "cboAluno";
            this.cboAluno.Size = new System.Drawing.Size(400, 21);
            this.cboAluno.TabIndex = 1;
            // 
            // cboLivro
            // 
            this.cboLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLivro.FormattingEnabled = true;
            this.cboLivro.Location = new System.Drawing.Point(110, 52);
            this.cboLivro.Name = "cboLivro";
            this.cboLivro.Size = new System.Drawing.Size(400, 21);
            this.cboLivro.TabIndex = 2;
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(110, 87);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(400, 21);
            this.cboFuncionario.TabIndex = 3;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(110, 122);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(120, 20);
            this.dtpData.TabIndex = 4;
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Location = new System.Drawing.Point(110, 157);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(200, 30);
            this.btnEmprestar.TabIndex = 5;
            this.btnEmprestar.Text = "Realizar Empréstimo";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // lstEmprestimos
            // 
            this.lstEmprestimos.FormattingEnabled = true;
            this.lstEmprestimos.Location = new System.Drawing.Point(20, 200);
            this.lstEmprestimos.Name = "lstEmprestimos";
            this.lstEmprestimos.Size = new System.Drawing.Size(710, 212);
            this.lstEmprestimos.TabIndex = 6;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(20, 425);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(180, 30);
            this.btnDevolver.TabIndex = 7;
            this.btnDevolver.Text = "Registrar Devolução";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnAtrasados
            // 
            this.btnAtrasados.Location = new System.Drawing.Point(215, 425);
            this.btnAtrasados.Name = "btnAtrasados";
            this.btnAtrasados.Size = new System.Drawing.Size(180, 30);
            this.btnAtrasados.TabIndex = 8;
            this.btnAtrasados.Text = "Listar Atrasados";
            this.btnAtrasados.UseVisualStyleBackColor = true;
            this.btnAtrasados.Click += new System.EventHandler(this.btnAtrasados_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(410, 425);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(180, 30);
            this.btnTodos.TabIndex = 9;
            this.btnTodos.Text = "Listar Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 524);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca - Controle de Livros e Empréstimos";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLivros.ResumeLayout(false);
            this.tabLivros.PerformLayout();
            this.tabAlunos.ResumeLayout(false);
            this.tabAlunos.PerformLayout();
            this.tabFuncionarios.ResumeLayout(false);
            this.tabFuncionarios.PerformLayout();
            this.tabEmprestimos.ResumeLayout(false);
            this.tabEmprestimos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLivros;
        private System.Windows.Forms.TabPage tabAlunos;
        private System.Windows.Forms.TabPage tabFuncionarios;
        private System.Windows.Forms.TabPage tabEmprestimos;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblTituloLivro;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnCadastrarLivro;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnDisponibilizar;
        private System.Windows.Forms.ListBox lstLivros;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Label lblCpfAluno;
        private System.Windows.Forms.Label lblEmailAluno;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtCpfAluno;
        private System.Windows.Forms.TextBox txtEmailAluno;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.ListBox lstAlunos;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblCpfFunc;
        private System.Windows.Forms.Label lblEmailFunc;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.TextBox txtCpfFunc;
        private System.Windows.Forms.TextBox txtEmailFunc;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Button btnCadastrarFunc;
        private System.Windows.Forms.ListBox lstFuncionarios;
        private System.Windows.Forms.Label lblEmpAluno;
        private System.Windows.Forms.Label lblEmpLivro;
        private System.Windows.Forms.Label lblEmpFunc;
        private System.Windows.Forms.Label lblEmpData;
        private System.Windows.Forms.ComboBox cboAluno;
        private System.Windows.Forms.ComboBox cboLivro;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.ListBox lstEmprestimos;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnAtrasados;
        private System.Windows.Forms.Button btnTodos;
    }
}
