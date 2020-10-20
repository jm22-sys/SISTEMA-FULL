namespace GUI
{
    partial class FrmListagemPessoas
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
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.dgPessoas = new System.Windows.Forms.DataGridView();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoas)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.dgPessoas);
            this.gbResultados.Location = new System.Drawing.Point(12, 118);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(562, 252);
            this.gbResultados.TabIndex = 0;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // dgPessoas
            // 
            this.dgPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPessoas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPessoas.Location = new System.Drawing.Point(3, 16);
            this.dgPessoas.Name = "dgPessoas";
            this.dgPessoas.Size = new System.Drawing.Size(556, 233);
            this.dgPessoas.TabIndex = 0;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.lblEmail);
            this.gbFiltros.Controls.Add(this.txtEmail);
            this.gbFiltros.Controls.Add(this.btnConfirmar);
            this.gbFiltros.Controls.Add(this.txtNome);
            this.gbFiltros.Controls.Add(this.lblNome);
            this.gbFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(562, 100);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(453, 53);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(66, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(150, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(266, 55);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(222, 58);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Nome:";
            // 
            // FrmListagemPessoas
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 382);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.gbResultados);
            this.Name = "FrmListagemPessoas";
            this.Text = "Listagem de Pessoas";
            this.Load += new System.EventHandler(this.FrmListagemPessoas_Load);
            this.gbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoas)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.DataGridView dgPessoas;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
    }
}