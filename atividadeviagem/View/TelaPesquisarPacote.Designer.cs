
namespace atividadeviagem.View
{
    partial class TelaPesquisarPacote
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataIda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVolta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarNomePac = new System.Windows.Forms.Button();
            this.tbxNomePac = new System.Windows.Forms.TextBox();
            this.lblNomePac = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeletarPac = new System.Windows.Forms.Button();
            this.btnAlterarPac = new System.Windows.Forms.Button();
            this.btnBucarImgPac = new System.Windows.Forms.Button();
            this.rtxDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.cbxOrigem = new System.Windows.Forms.ComboBox();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.dtpVolta = new System.Windows.Forms.DateTimePicker();
            this.dtpIda = new System.Windows.Forms.DateTimePicker();
            this.lblDataVlt = new System.Windows.Forms.Label();
            this.lblDataIda = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.tbxCodPac = new System.Windows.Forms.TextBox();
            this.lblCodPac = new System.Windows.Forms.Label();
            this.btnbuscarCodPac = new System.Windows.Forms.Button();
            this.pbxImagePac = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagePac)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(12, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(214, 31);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Pesquisar Pacote";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 330);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnBuscarNomePac);
            this.tabPage1.Controls.Add(this.tbxNomePac);
            this.tabPage1.Controls.Add(this.lblNomePac);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar Nome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Origem,
            this.Destino,
            this.Descricao,
            this.DataIda,
            this.DataVolta,
            this.Valor,
            this.Image});
            this.dataGridView1.Location = new System.Drawing.Point(6, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(794, 230);
            this.dataGridView1.TabIndex = 7;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Origem
            // 
            this.Origem.HeaderText = "Origem";
            this.Origem.Name = "Origem";
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // DataIda
            // 
            this.DataIda.HeaderText = "Data Ida";
            this.DataIda.Name = "DataIda";
            // 
            // DataVolta
            // 
            this.DataVolta.HeaderText = "Data Volta";
            this.DataVolta.Name = "DataVolta";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            // 
            // btnBuscarNomePac
            // 
            this.btnBuscarNomePac.Location = new System.Drawing.Point(391, 25);
            this.btnBuscarNomePac.Name = "btnBuscarNomePac";
            this.btnBuscarNomePac.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNomePac.TabIndex = 6;
            this.btnBuscarNomePac.Text = "Buscar";
            this.btnBuscarNomePac.UseVisualStyleBackColor = true;
            this.btnBuscarNomePac.Click += new System.EventHandler(this.btnBuscarNomePac_Click);
            // 
            // tbxNomePac
            // 
            this.tbxNomePac.Location = new System.Drawing.Point(191, 25);
            this.tbxNomePac.Name = "tbxNomePac";
            this.tbxNomePac.Size = new System.Drawing.Size(185, 23);
            this.tbxNomePac.TabIndex = 5;
            // 
            // lblNomePac
            // 
            this.lblNomePac.AutoSize = true;
            this.lblNomePac.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomePac.Location = new System.Drawing.Point(6, 28);
            this.lblNomePac.Name = "lblNomePac";
            this.lblNomePac.Size = new System.Drawing.Size(158, 17);
            this.lblNomePac.TabIndex = 4;
            this.lblNomePac.Text = "Digite o nome do Pacote ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pbxImagePac);
            this.tabPage2.Controls.Add(this.btnDeletarPac);
            this.tabPage2.Controls.Add(this.btnAlterarPac);
            this.tabPage2.Controls.Add(this.btnBucarImgPac);
            this.tabPage2.Controls.Add(this.rtxDescricao);
            this.tabPage2.Controls.Add(this.lblDescricao);
            this.tabPage2.Controls.Add(this.tbxValor);
            this.tabPage2.Controls.Add(this.lblValor);
            this.tabPage2.Controls.Add(this.cbxOrigem);
            this.tabPage2.Controls.Add(this.cbxDestino);
            this.tabPage2.Controls.Add(this.dtpVolta);
            this.tabPage2.Controls.Add(this.dtpIda);
            this.tabPage2.Controls.Add(this.lblDataVlt);
            this.tabPage2.Controls.Add(this.lblDataIda);
            this.tabPage2.Controls.Add(this.lblOrigem);
            this.tabPage2.Controls.Add(this.lblDestino);
            this.tabPage2.Controls.Add(this.tbxCodPac);
            this.tabPage2.Controls.Add(this.lblCodPac);
            this.tabPage2.Controls.Add(this.btnbuscarCodPac);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar Codigo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeletarPac
            // 
            this.btnDeletarPac.Location = new System.Drawing.Point(478, 258);
            this.btnDeletarPac.Name = "btnDeletarPac";
            this.btnDeletarPac.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarPac.TabIndex = 38;
            this.btnDeletarPac.Text = "Deletar";
            this.btnDeletarPac.UseVisualStyleBackColor = true;
            // 
            // btnAlterarPac
            // 
            this.btnAlterarPac.Location = new System.Drawing.Point(388, 258);
            this.btnAlterarPac.Name = "btnAlterarPac";
            this.btnAlterarPac.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarPac.TabIndex = 37;
            this.btnAlterarPac.Text = "Alterar";
            this.btnAlterarPac.UseVisualStyleBackColor = true;
            // 
            // btnBucarImgPac
            // 
            this.btnBucarImgPac.Location = new System.Drawing.Point(659, 218);
            this.btnBucarImgPac.Name = "btnBucarImgPac";
            this.btnBucarImgPac.Size = new System.Drawing.Size(75, 23);
            this.btnBucarImgPac.TabIndex = 36;
            this.btnBucarImgPac.Text = "Pesquisar ";
            this.btnBucarImgPac.UseVisualStyleBackColor = true;
            this.btnBucarImgPac.Click += new System.EventHandler(this.btnBucarImgPac_Click);
            // 
            // rtxDescricao
            // 
            this.rtxDescricao.Location = new System.Drawing.Point(374, 68);
            this.rtxDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.rtxDescricao.Name = "rtxDescricao";
            this.rtxDescricao.Size = new System.Drawing.Size(189, 137);
            this.rtxDescricao.TabIndex = 34;
            this.rtxDescricao.Text = "";
            // 
            // lblDescricao
            // 
            this.lblDescricao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.Location = new System.Drawing.Point(301, 68);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(75, 19);
            this.lblDescricao.TabIndex = 33;
            this.lblDescricao.Text = "Descrição";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(80, 258);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(200, 23);
            this.tbxValor.TabIndex = 32;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(15, 258);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(41, 19);
            this.lblValor.TabIndex = 31;
            this.lblValor.Text = "Valor";
            // 
            // cbxOrigem
            // 
            this.cbxOrigem.FormattingEnabled = true;
            this.cbxOrigem.Location = new System.Drawing.Point(80, 118);
            this.cbxOrigem.Name = "cbxOrigem";
            this.cbxOrigem.Size = new System.Drawing.Size(200, 23);
            this.cbxOrigem.TabIndex = 30;
            // 
            // cbxDestino
            // 
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(80, 65);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(200, 23);
            this.cbxDestino.TabIndex = 29;
            // 
            // dtpVolta
            // 
            this.dtpVolta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVolta.Location = new System.Drawing.Point(80, 212);
            this.dtpVolta.Name = "dtpVolta";
            this.dtpVolta.Size = new System.Drawing.Size(200, 23);
            this.dtpVolta.TabIndex = 28;
            // 
            // dtpIda
            // 
            this.dtpIda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIda.Location = new System.Drawing.Point(80, 171);
            this.dtpIda.Name = "dtpIda";
            this.dtpIda.Size = new System.Drawing.Size(200, 23);
            this.dtpIda.TabIndex = 27;
            // 
            // lblDataVlt
            // 
            this.lblDataVlt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataVlt.Location = new System.Drawing.Point(15, 173);
            this.lblDataVlt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataVlt.Name = "lblDataVlt";
            this.lblDataVlt.Size = new System.Drawing.Size(49, 19);
            this.lblDataVlt.TabIndex = 26;
            this.lblDataVlt.Text = "Ida";
            // 
            // lblDataIda
            // 
            this.lblDataIda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataIda.Location = new System.Drawing.Point(15, 218);
            this.lblDataIda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataIda.Name = "lblDataIda";
            this.lblDataIda.Size = new System.Drawing.Size(69, 19);
            this.lblDataIda.TabIndex = 25;
            this.lblDataIda.Text = "Retorno";
            // 
            // lblOrigem
            // 
            this.lblOrigem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrigem.Location = new System.Drawing.Point(15, 118);
            this.lblOrigem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(67, 19);
            this.lblOrigem.TabIndex = 24;
            this.lblOrigem.Text = "Origem";
            // 
            // lblDestino
            // 
            this.lblDestino.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestino.Location = new System.Drawing.Point(15, 68);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(58, 24);
            this.lblDestino.TabIndex = 23;
            this.lblDestino.Text = "Destino";
            // 
            // tbxCodPac
            // 
            this.tbxCodPac.Location = new System.Drawing.Point(191, 22);
            this.tbxCodPac.Name = "tbxCodPac";
            this.tbxCodPac.Size = new System.Drawing.Size(161, 23);
            this.tbxCodPac.TabIndex = 22;
            // 
            // lblCodPac
            // 
            this.lblCodPac.AutoSize = true;
            this.lblCodPac.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodPac.Location = new System.Drawing.Point(15, 25);
            this.lblCodPac.Name = "lblCodPac";
            this.lblCodPac.Size = new System.Drawing.Size(162, 17);
            this.lblCodPac.TabIndex = 21;
            this.lblCodPac.Text = "Digite o Codigo do Pacote";
            // 
            // btnbuscarCodPac
            // 
            this.btnbuscarCodPac.Location = new System.Drawing.Point(374, 21);
            this.btnbuscarCodPac.Name = "btnbuscarCodPac";
            this.btnbuscarCodPac.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarCodPac.TabIndex = 20;
            this.btnbuscarCodPac.Text = "Buscar ";
            this.btnbuscarCodPac.UseVisualStyleBackColor = true;
            this.btnbuscarCodPac.Click += new System.EventHandler(this.btnbuscarCodPac_Click);
            // 
            // pbxImagePac
            // 
            this.pbxImagePac.Location = new System.Drawing.Point(604, 65);
            this.pbxImagePac.Name = "pbxImagePac";
            this.pbxImagePac.Size = new System.Drawing.Size(127, 129);
            this.pbxImagePac.TabIndex = 39;
            this.pbxImagePac.TabStop = false;
            // 
            // TelaPesquisarPacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "TelaPesquisarPacote";
            this.Text = "TelaPesquisarPacote";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagePac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscarNomePac;
        private System.Windows.Forms.TextBox tbxNomePac;
        private System.Windows.Forms.Label lblNomePac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataIda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVolta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.TextBox tbxCodPac;
        private System.Windows.Forms.Label lblCodPac;
        private System.Windows.Forms.Button btnbuscarCodPac;
        private System.Windows.Forms.MaskedTextBox tbxValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cbxOrigem;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.DateTimePicker dtpVolta;
        private System.Windows.Forms.DateTimePicker dtpIda;
        private System.Windows.Forms.Label lblDataVlt;
        private System.Windows.Forms.Label lblDataIda;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.RichTextBox rtxDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnBucarImgPac;
        private System.Windows.Forms.Button btnDeletarPac;
        private System.Windows.Forms.Button btnAlterarPac;
        private System.Windows.Forms.PictureBox pbxImagePac;
    }
}