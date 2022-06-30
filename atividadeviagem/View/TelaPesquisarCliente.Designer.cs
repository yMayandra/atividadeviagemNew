
namespace atividadeviagem.View
{
    partial class TelaPesquisarCliente
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
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuscarNomeCli = new System.Windows.Forms.Button();
            this.tbxNomeCli = new System.Windows.Forms.TextBox();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxCodCli = new System.Windows.Forms.TextBox();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.btnBucarImgCli = new System.Windows.Forms.Button();
            this.btnDeletarCli = new System.Windows.Forms.Button();
            this.btnbuscarCodCli = new System.Windows.Forms.Button();
            this.btnAlterarCli = new System.Windows.Forms.Button();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Email,
            this.Foto});
            this.dataGridViewCliente.Location = new System.Drawing.Point(66, 59);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.RowHeadersVisible = false;
            this.dataGridViewCliente.RowTemplate.Height = 25;
            this.dataGridViewCliente.Size = new System.Drawing.Size(400, 244);
            this.dataGridViewCliente.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(12, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Pesquisar Cliente";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 337);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscarNomeCli);
            this.tabPage1.Controls.Add(this.tbxNomeCli);
            this.tabPage1.Controls.Add(this.lblNomeCli);
            this.tabPage1.Controls.Add(this.dataGridViewCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar Nome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscarNomeCli
            // 
            this.btnBuscarNomeCli.Location = new System.Drawing.Point(409, 30);
            this.btnBuscarNomeCli.Name = "btnBuscarNomeCli";
            this.btnBuscarNomeCli.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNomeCli.TabIndex = 3;
            this.btnBuscarNomeCli.Text = "Buscar";
            this.btnBuscarNomeCli.UseVisualStyleBackColor = true;
            this.btnBuscarNomeCli.Click += new System.EventHandler(this.btnBuscarNomeCli_Click);
            // 
            // tbxNomeCli
            // 
            this.tbxNomeCli.Location = new System.Drawing.Point(209, 30);
            this.tbxNomeCli.Name = "tbxNomeCli";
            this.tbxNomeCli.Size = new System.Drawing.Size(185, 23);
            this.tbxNomeCli.TabIndex = 2;
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeCli.Location = new System.Drawing.Point(44, 33);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(158, 17);
            this.lblNomeCli.TabIndex = 1;
            this.lblNomeCli.Text = "Digite o nome do Cliente ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbxCodCli);
            this.tabPage2.Controls.Add(this.lblCodCli);
            this.tabPage2.Controls.Add(this.btnBucarImgCli);
            this.tabPage2.Controls.Add(this.btnDeletarCli);
            this.tabPage2.Controls.Add(this.btnbuscarCodCli);
            this.tabPage2.Controls.Add(this.btnAlterarCli);
            this.tabPage2.Controls.Add(this.pbxImage);
            this.tabPage2.Controls.Add(this.tbxSenha);
            this.tabPage2.Controls.Add(this.tbxEmail);
            this.tabPage2.Controls.Add(this.tbxNome);
            this.tabPage2.Controls.Add(this.lblSenha);
            this.tabPage2.Controls.Add(this.lblEmail);
            this.tabPage2.Controls.Add(this.lblNome);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar Codigo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxCodCli
            // 
            this.tbxCodCli.Location = new System.Drawing.Point(188, 42);
            this.tbxCodCli.Name = "tbxCodCli";
            this.tbxCodCli.Size = new System.Drawing.Size(161, 23);
            this.tbxCodCli.TabIndex = 19;
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodCli.Location = new System.Drawing.Point(12, 45);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(162, 17);
            this.lblCodCli.TabIndex = 18;
            this.lblCodCli.Text = "Digite o Codigo do Cliente";
            // 
            // btnBucarImgCli
            // 
            this.btnBucarImgCli.Location = new System.Drawing.Point(371, 211);
            this.btnBucarImgCli.Name = "btnBucarImgCli";
            this.btnBucarImgCli.Size = new System.Drawing.Size(75, 23);
            this.btnBucarImgCli.TabIndex = 17;
            this.btnBucarImgCli.Text = "Pesquisar ";
            this.btnBucarImgCli.UseVisualStyleBackColor = true;
            this.btnBucarImgCli.Click += new System.EventHandler(this.btnBucarImgCli_Click);
            // 
            // btnDeletarCli
            // 
            this.btnDeletarCli.Location = new System.Drawing.Point(250, 269);
            this.btnDeletarCli.Name = "btnDeletarCli";
            this.btnDeletarCli.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarCli.TabIndex = 16;
            this.btnDeletarCli.Text = "Deletar";
            this.btnDeletarCli.UseVisualStyleBackColor = true;
            this.btnDeletarCli.Click += new System.EventHandler(this.btnDeletarCli_Click);
            // 
            // btnbuscarCodCli
            // 
            this.btnbuscarCodCli.Location = new System.Drawing.Point(371, 41);
            this.btnbuscarCodCli.Name = "btnbuscarCodCli";
            this.btnbuscarCodCli.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarCodCli.TabIndex = 15;
            this.btnbuscarCodCli.Text = "Buscar ";
            this.btnbuscarCodCli.UseVisualStyleBackColor = true;
            this.btnbuscarCodCli.Click += new System.EventHandler(this.btnbuscarCodCli_Click);
            // 
            // btnAlterarCli
            // 
            this.btnAlterarCli.Location = new System.Drawing.Point(160, 269);
            this.btnAlterarCli.Name = "btnAlterarCli";
            this.btnAlterarCli.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCli.TabIndex = 14;
            this.btnAlterarCli.Text = "Alterar";
            this.btnAlterarCli.UseVisualStyleBackColor = true;
            this.btnAlterarCli.Click += new System.EventHandler(this.btnAlterarCli_Click);
            // 
            // pbxImage
            // 
            this.pbxImage.BackColor = System.Drawing.Color.Black;
            this.pbxImage.Location = new System.Drawing.Point(338, 86);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(146, 119);
            this.pbxImage.TabIndex = 13;
            this.pbxImage.TabStop = false;
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(66, 182);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(193, 23);
            this.tbxSenha.TabIndex = 12;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(66, 132);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(193, 23);
            this.tbxEmail.TabIndex = 11;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(66, 86);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(193, 23);
            this.tbxNome.TabIndex = 10;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(12, 182);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 19);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(12, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 19);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(12, 86);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 19);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // TelaPesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "TelaPesquisarCliente";
            this.Text = "TelaPesquisarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscarNomeCli;
        private System.Windows.Forms.TextBox tbxNomeCli;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.TextBox tbxCodCli;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.Button btnBucarImgCli;
        private System.Windows.Forms.Button btnDeletarCli;
        private System.Windows.Forms.Button btnbuscarCodCli;
        private System.Windows.Forms.Button btnAlterarCli;
        private System.Windows.Forms.PictureBox pbxImage;
    }
}