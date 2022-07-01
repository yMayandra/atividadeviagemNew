
namespace atividadeviagem.View
{
    partial class dtpVlt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dtpVlt));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblDataIda = new System.Windows.Forms.Label();
            this.lblDataVlt = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.rtxDescricao = new System.Windows.Forms.RichTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtpIda = new System.Windows.Forms.DateTimePicker();
            this.dtpVolta = new System.Windows.Forms.DateTimePicker();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.cbxOrigem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(13, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(485, 76);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastrar Pacote";
            // 
            // lblDestino
            // 
            this.lblDestino.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestino.Location = new System.Drawing.Point(35, 137);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(58, 24);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino";
            // 
            // lblOrigem
            // 
            this.lblOrigem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrigem.Location = new System.Drawing.Point(35, 187);
            this.lblOrigem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(67, 19);
            this.lblOrigem.TabIndex = 2;
            this.lblOrigem.Text = "Origem";
            // 
            // lblDataIda
            // 
            this.lblDataIda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataIda.Location = new System.Drawing.Point(35, 287);
            this.lblDataIda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataIda.Name = "lblDataIda";
            this.lblDataIda.Size = new System.Drawing.Size(69, 19);
            this.lblDataIda.TabIndex = 4;
            this.lblDataIda.Text = "Retorno";
            // 
            // lblDataVlt
            // 
            this.lblDataVlt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataVlt.Location = new System.Drawing.Point(35, 242);
            this.lblDataVlt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataVlt.Name = "lblDataVlt";
            this.lblDataVlt.Size = new System.Drawing.Size(49, 19);
            this.lblDataVlt.TabIndex = 5;
            this.lblDataVlt.Text = "Ida";
            // 
            // lblDescricao
            // 
            this.lblDescricao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.Location = new System.Drawing.Point(324, 134);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(75, 19);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição";
            // 
            // pbxImage
            // 
            this.pbxImage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pbxImage.Location = new System.Drawing.Point(628, 137);
            this.pbxImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(189, 137);
            this.pbxImage.TabIndex = 7;
            this.pbxImage.TabStop = false;
            // 
            // rtxDescricao
            // 
            this.rtxDescricao.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.rtxDescricao.ForeColor = System.Drawing.Color.White;
            this.rtxDescricao.Location = new System.Drawing.Point(397, 137);
            this.rtxDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.rtxDescricao.Name = "rtxDescricao";
            this.rtxDescricao.Size = new System.Drawing.Size(189, 137);
            this.rtxDescricao.TabIndex = 8;
            this.rtxDescricao.Text = "";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Location = new System.Drawing.Point(490, 286);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 29);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Location = new System.Drawing.Point(721, 287);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(96, 29);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtpIda
            // 
            this.dtpIda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIda.Location = new System.Drawing.Point(100, 240);
            this.dtpIda.Name = "dtpIda";
            this.dtpIda.Size = new System.Drawing.Size(200, 26);
            this.dtpIda.TabIndex = 14;
            // 
            // dtpVolta
            // 
            this.dtpVolta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVolta.Location = new System.Drawing.Point(100, 281);
            this.dtpVolta.Name = "dtpVolta";
            this.dtpVolta.Size = new System.Drawing.Size(200, 26);
            this.dtpVolta.TabIndex = 15;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(35, 327);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(41, 19);
            this.lblValor.TabIndex = 18;
            this.lblValor.Text = "Valor";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(100, 327);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(200, 26);
            this.tbxValor.TabIndex = 19;
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialog1";
            // 
            // cbxDestino
            // 
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cbxDestino.Location = new System.Drawing.Point(100, 137);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(200, 27);
            this.cbxDestino.TabIndex = 20;
            // 
            // cbxOrigem
            // 
            this.cbxOrigem.FormattingEnabled = true;
            this.cbxOrigem.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cbxOrigem.Location = new System.Drawing.Point(100, 187);
            this.cbxOrigem.Name = "cbxOrigem";
            this.cbxOrigem.Size = new System.Drawing.Size(200, 27);
            this.cbxOrigem.TabIndex = 21;
            // 
            // dtpVlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1029, 570);
            this.Controls.Add(this.cbxOrigem);
            this.Controls.Add(this.cbxDestino);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.dtpVolta);
            this.Controls.Add(this.dtpIda);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.rtxDescricao);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblDataVlt);
            this.Controls.Add(this.lblDataIda);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dtpVlt";
            this.Text = "CadastraPacote";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblDataIda;
        private System.Windows.Forms.Label lblDataVlt;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.RichTextBox rtxDescricao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker dtpIda;
        private System.Windows.Forms.DateTimePicker dtpVolta;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.MaskedTextBox tbxValor;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.ComboBox cbxOrigem;
    }
}