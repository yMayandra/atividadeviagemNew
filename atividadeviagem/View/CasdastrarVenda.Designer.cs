
namespace atividadeviagem.View
{
    partial class CasdastrarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CasdastrarVenda));
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.lblCodFun = new System.Windows.Forms.Label();
            this.lblCodPac = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastro.Location = new System.Drawing.Point(12, 9);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(474, 76);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Cadastrar Venda";
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Location = new System.Drawing.Point(40, 112);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(86, 15);
            this.lblCodCli.TabIndex = 1;
            this.lblCodCli.Text = "Código Cliente";
            // 
            // lblCodFun
            // 
            this.lblCodFun.AutoSize = true;
            this.lblCodFun.Location = new System.Drawing.Point(33, 200);
            this.lblCodFun.Name = "lblCodFun";
            this.lblCodFun.Size = new System.Drawing.Size(112, 15);
            this.lblCodFun.TabIndex = 2;
            this.lblCodFun.Text = "Codigo Funcionario";
            // 
            // lblCodPac
            // 
            this.lblCodPac.AutoSize = true;
            this.lblCodPac.Location = new System.Drawing.Point(45, 275);
            this.lblCodPac.Name = "lblCodPac";
            this.lblCodPac.Size = new System.Drawing.Size(85, 15);
            this.lblCodPac.TabIndex = 3;
            this.lblCodPac.Text = "Codigo Pacote";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(45, 355);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(81, 15);
            this.lblPago.TabIndex = 4;
            this.lblPago.Text = "Codigo Venda";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 23);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(56, 303);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 23);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(56, 383);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(60, 23);
            this.textBox4.TabIndex = 8;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(448, 369);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // CasdastrarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblCodPac);
            this.Controls.Add(this.lblCodFun);
            this.Controls.Add(this.lblCodCli);
            this.Controls.Add(this.lblCadastro);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CasdastrarVenda";
            this.Text = "CasdastrarVenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.Label lblCodFun;
        private System.Windows.Forms.Label lblCodPac;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnSalvar;
    }
}