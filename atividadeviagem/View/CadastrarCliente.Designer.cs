
namespace atividadeviagem.View
{
    partial class CadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCliente));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(27, 56);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(197, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro Cliente";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(27, 140);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 19);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(27, 186);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 19);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(27, 236);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 19);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(81, 140);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(193, 23);
            this.tbxNome.TabIndex = 4;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(81, 186);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(193, 23);
            this.tbxEmail.TabIndex = 5;
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(81, 236);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(193, 23);
            this.tbxSenha.TabIndex = 6;
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(330, 140);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(146, 119);
            this.pbxImage.TabIndex = 7;
            this.pbxImage.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(199, 281);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(401, 281);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 23);
            this.btnImage.TabIndex = 9;
            this.btnImage.Text = "Pesquisar";
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarCliente";
            this.Text = "CadastrarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnImage;
    }
}