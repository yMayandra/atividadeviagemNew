
namespace atividadeviagem.View
{
    partial class TelaPesquisarFuncionario
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscarNomeFun = new System.Windows.Forms.Button();
            this.tbxNomeFun = new System.Windows.Forms.TextBox();
            this.lblPesquisarNomeFun = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxCodFun = new System.Windows.Forms.TextBox();
            this.lblCodFun = new System.Windows.Forms.Label();
            this.btnbuscarCodFun = new System.Windows.Forms.Button();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnDeletarFun = new System.Windows.Forms.Button();
            this.btnAlterarFun = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(12, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(280, 31);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Pesquisar Funcioanrio";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 350);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnBuscarNomeFun);
            this.tabPage1.Controls.Add(this.tbxNomeFun);
            this.tabPage1.Controls.Add(this.lblPesquisarNomeFun);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar Nome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeletarFun);
            this.tabPage2.Controls.Add(this.btnAlterarFun);
            this.tabPage2.Controls.Add(this.tbxSenha);
            this.tabPage2.Controls.Add(this.tbxEmail);
            this.tabPage2.Controls.Add(this.tbxNome);
            this.tabPage2.Controls.Add(this.lblSenha);
            this.tabPage2.Controls.Add(this.lblEmail);
            this.tabPage2.Controls.Add(this.lblNome);
            this.tabPage2.Controls.Add(this.tbxCodFun);
            this.tabPage2.Controls.Add(this.lblCodFun);
            this.tabPage2.Controls.Add(this.btnbuscarCodFun);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(665, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar Codigo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBuscarNomeFun
            // 
            this.btnBuscarNomeFun.Location = new System.Drawing.Point(469, 30);
            this.btnBuscarNomeFun.Name = "btnBuscarNomeFun";
            this.btnBuscarNomeFun.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNomeFun.TabIndex = 6;
            this.btnBuscarNomeFun.Text = "Buscar";
            this.btnBuscarNomeFun.UseVisualStyleBackColor = true;
            // 
            // tbxNomeFun
            // 
            this.tbxNomeFun.Location = new System.Drawing.Point(260, 30);
            this.tbxNomeFun.Name = "tbxNomeFun";
            this.tbxNomeFun.Size = new System.Drawing.Size(194, 23);
            this.tbxNomeFun.TabIndex = 5;
            // 
            // lblPesquisarNomeFun
            // 
            this.lblPesquisarNomeFun.AutoSize = true;
            this.lblPesquisarNomeFun.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPesquisarNomeFun.Location = new System.Drawing.Point(77, 32);
            this.lblPesquisarNomeFun.Name = "lblPesquisarNomeFun";
            this.lblPesquisarNomeFun.Size = new System.Drawing.Size(186, 17);
            this.lblPesquisarNomeFun.TabIndex = 4;
            this.lblPesquisarNomeFun.Text = "Digite o nome do Funcionario ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Senha});
            this.dataGridView1.Location = new System.Drawing.Point(163, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(303, 205);
            this.dataGridView1.TabIndex = 7;
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
            // Senha
            // 
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            // 
            // tbxCodFun
            // 
            this.tbxCodFun.Location = new System.Drawing.Point(257, 35);
            this.tbxCodFun.Name = "tbxCodFun";
            this.tbxCodFun.Size = new System.Drawing.Size(161, 23);
            this.tbxCodFun.TabIndex = 22;
            // 
            // lblCodFun
            // 
            this.lblCodFun.AutoSize = true;
            this.lblCodFun.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodFun.Location = new System.Drawing.Point(65, 38);
            this.lblCodFun.Name = "lblCodFun";
            this.lblCodFun.Size = new System.Drawing.Size(189, 17);
            this.lblCodFun.TabIndex = 21;
            this.lblCodFun.Text = "Digite o Codigo do Funcionario";
            // 
            // btnbuscarCodFun
            // 
            this.btnbuscarCodFun.Location = new System.Drawing.Point(427, 35);
            this.btnbuscarCodFun.Name = "btnbuscarCodFun";
            this.btnbuscarCodFun.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarCodFun.TabIndex = 20;
            this.btnbuscarCodFun.Text = "Buscar ";
            this.btnbuscarCodFun.UseVisualStyleBackColor = true;
            this.btnbuscarCodFun.Click += new System.EventHandler(this.btnbuscarCodFun_Click);
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(142, 185);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(219, 23);
            this.tbxSenha.TabIndex = 28;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(142, 139);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(219, 23);
            this.tbxEmail.TabIndex = 27;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(142, 96);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(219, 23);
            this.tbxNome.TabIndex = 26;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(65, 185);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 19);
            this.lblSenha.TabIndex = 23;
            this.lblSenha.Text = "Senha";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(65, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 19);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "E-mail";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(65, 96);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 19);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "Nome";
            // 
            // btnDeletarFun
            // 
            this.btnDeletarFun.Location = new System.Drawing.Point(343, 266);
            this.btnDeletarFun.Name = "btnDeletarFun";
            this.btnDeletarFun.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarFun.TabIndex = 30;
            this.btnDeletarFun.Text = "Deletar";
            this.btnDeletarFun.UseVisualStyleBackColor = true;
            // 
            // btnAlterarFun
            // 
            this.btnAlterarFun.Location = new System.Drawing.Point(253, 266);
            this.btnAlterarFun.Name = "btnAlterarFun";
            this.btnAlterarFun.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarFun.TabIndex = 29;
            this.btnAlterarFun.Text = "Alterar";
            this.btnAlterarFun.UseVisualStyleBackColor = true;
            // 
            // TelaPesquisarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "TelaPesquisarFuncionario";
            this.Text = "TelaPesquisarFuncionario";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscarNomeFun;
        private System.Windows.Forms.TextBox tbxNomeFun;
        private System.Windows.Forms.Label lblPesquisarNomeFun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.TextBox tbxCodFun;
        private System.Windows.Forms.Label lblCodFun;
        private System.Windows.Forms.Button btnbuscarCodFun;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnDeletarFun;
        private System.Windows.Forms.Button btnAlterarFun;
    }
}