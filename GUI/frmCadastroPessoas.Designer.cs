namespace GUI
{
    partial class frmCadastroPessoas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.cbEstadosCivis = new System.Windows.Forms.ComboBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.chkRecebeSMS = new System.Windows.Forms.CheckBox();
            this.chkRecebeEmail = new System.Windows.Forms.CheckBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.CdPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtNAsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecebeEmail = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.recebeSMS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLIstaCP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dt. Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado Civil:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "E-mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefone:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(204, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(45, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(204, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 9;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(204, 74);
            this.mtxtCPF.Mask = "000\\.000\\.000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(100, 20);
            this.mtxtCPF.TabIndex = 10;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(204, 101);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(100, 20);
            this.dtpNascimento.TabIndex = 11;
            // 
            // cbEstadosCivis
            // 
            this.cbEstadosCivis.FormattingEnabled = true;
            this.cbEstadosCivis.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado"});
            this.cbEstadosCivis.Location = new System.Drawing.Point(204, 128);
            this.cbEstadosCivis.Name = "cbEstadosCivis";
            this.cbEstadosCivis.Size = new System.Drawing.Size(100, 21);
            this.cbEstadosCivis.TabIndex = 12;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Checked = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(204, 156);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 13;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(284, 156);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 14;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(204, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(204, 207);
            this.mtxtTelefone.Mask = "(99) 0000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(100, 20);
            this.mtxtTelefone.TabIndex = 16;
            // 
            // chkRecebeSMS
            // 
            this.chkRecebeSMS.AutoSize = true;
            this.chkRecebeSMS.Location = new System.Drawing.Point(204, 234);
            this.chkRecebeSMS.Name = "chkRecebeSMS";
            this.chkRecebeSMS.Size = new System.Drawing.Size(90, 17);
            this.chkRecebeSMS.TabIndex = 17;
            this.chkRecebeSMS.Text = "Recebe SMS";
            this.chkRecebeSMS.UseVisualStyleBackColor = true;
            // 
            // chkRecebeEmail
            // 
            this.chkRecebeEmail.AutoSize = true;
            this.chkRecebeEmail.Location = new System.Drawing.Point(300, 234);
            this.chkRecebeEmail.Name = "chkRecebeEmail";
            this.chkRecebeEmail.Size = new System.Drawing.Size(95, 17);
            this.chkRecebeEmail.TabIndex = 18;
            this.chkRecebeEmail.Text = "Recebe E-mail";
            this.chkRecebeEmail.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.Location = new System.Drawing.Point(167, 257);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 36);
            this.btnInserir.TabIndex = 19;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(255, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvPessoas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan;
            this.dgvPessoas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdPessoa,
            this.Nome,
            this.Cpf,
            this.DtNAsc,
            this.EstadoCivil,
            this.Sexo,
            this.email,
            this.Telefone,
            this.RecebeEmail,
            this.recebeSMS});
            this.dgvPessoas.Location = new System.Drawing.Point(2, 299);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.Size = new System.Drawing.Size(657, 150);
            this.dgvPessoas.TabIndex = 21;
            this.dgvPessoas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoas_CellContentClick);
            // 
            // CdPessoa
            // 
            this.CdPessoa.DataPropertyName = "CdPessoa";
            this.CdPessoa.HeaderText = "Codigo";
            this.CdPessoa.Name = "CdPessoa";
            this.CdPessoa.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "NmPessoa";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "NrCPF";
            this.Cpf.HeaderText = "cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            // 
            // DtNAsc
            // 
            this.DtNAsc.DataPropertyName = "DtNascimento";
            this.DtNAsc.HeaderText = "DtNAsc";
            this.DtNAsc.Name = "DtNAsc";
            this.DtNAsc.ReadOnly = true;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.DataPropertyName = "DsEstadoCivil";
            this.EstadoCivil.HeaderText = "EstadoCivil";
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "DsSexo";
            this.Sexo.HeaderText = "sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "DsEmail";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "NrTelefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // RecebeEmail
            // 
            this.RecebeEmail.DataPropertyName = "BtRecebeSMS";
            this.RecebeEmail.HeaderText = "RecebeEmail";
            this.RecebeEmail.Name = "RecebeEmail";
            this.RecebeEmail.ReadOnly = true;
            this.RecebeEmail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RecebeEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // recebeSMS
            // 
            this.recebeSMS.DataPropertyName = "BtRecebeEmail";
            this.recebeSMS.HeaderText = "recebeSms";
            this.recebeSMS.Name = "recebeSMS";
            this.recebeSMS.ReadOnly = true;
            this.recebeSMS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.recebeSMS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(268, 257);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 36);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Location = new System.Drawing.Point(369, 257);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 36);
            this.btnAtualizar.TabIndex = 23;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.ForeColor = System.Drawing.Color.Blue;
            this.btnLimpar.Location = new System.Drawing.Point(572, 245);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 48);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar tela";
            this.btnLimpar.UseMnemonic = false;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLIstaCP
            // 
            this.btnLIstaCP.BackColor = System.Drawing.Color.Blue;
            this.btnLIstaCP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLIstaCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLIstaCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIstaCP.Location = new System.Drawing.Point(572, 12);
            this.btnLIstaCP.Name = "btnLIstaCP";
            this.btnLIstaCP.Size = new System.Drawing.Size(75, 44);
            this.btnLIstaCP.TabIndex = 25;
            this.btnLIstaCP.Text = "Lista Clientes";
            this.btnLIstaCP.UseVisualStyleBackColor = false;
            this.btnLIstaCP.Click += new System.EventHandler(this.btnLIstaCP_Click);
            // 
            // frmCadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.btnLIstaCP);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvPessoas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.chkRecebeEmail);
            this.Controls.Add(this.chkRecebeSMS);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.rbtnFeminino);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.cbEstadosCivis);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroPessoas";
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.frmCadastroPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.ComboBox cbEstadosCivis;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.CheckBox chkRecebeSMS;
        private System.Windows.Forms.CheckBox chkRecebeEmail;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtNAsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RecebeEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recebeSMS;
        private System.Windows.Forms.Button btnLIstaCP;
    }
}