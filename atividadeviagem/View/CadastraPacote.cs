using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using atividadeviagem.Model;
using atividadeviagem.Controller;
using System.IO;


namespace atividadeviagem.View
{
    public partial class dtpVlt : Form
    {
        public dtpVlt()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            openFileDialogImage.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg;)" + "|*.jpg;*.png;*.jpeg";
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                pbxImage.Image = Image.FromFile(openFileDialogImage.FileName);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cbxDestino.Text == "" | cbxOrigem.Text == "" | dtpIda.Value > dtpVolta.Value |tbxValor.Text==""|rtxDescricao==null |pbxImage.Image == null)
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pacote.ValorPac = Convert.ToDouble(tbxValor.Text);
                Pacote.OrigemPac = cbxOrigem.Text;
                Pacote.DestinoPac = cbxDestino.Text;
                Pacote.DataPacIda = dtpIda.Text;
                Pacote.DataPacVlt = dtpVolta.Text;
                Pacote.DescricaoPac = rtxDescricao.Text;
                
               
                if (pbxImage.Image != null)
                {
                    MemoryStream memoryStream = new MemoryStream();

                    pbxImage.Image.Save(memoryStream, pbxImage.Image.RawFormat);
                    Pacote.ImagePac = memoryStream.ToArray();


                    ManipulacaoPacote manipulacaoPacote = new ManipulacaoPacote();
                    manipulacaoPacote.cadastraPacote();
                    
                }
            }
            if (Pacote.Retorno == "Sim")
            {
                LimparTela();
                return;
            }
            else if (Pacote.Retorno == "Não")
            {
                FecharCadastro();
                return;
            }


        }
        public void LimparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = String.Empty;
                }
                if (ctl is PictureBox)
                {
                    pbxImage.Image = null;
                }
            }
        }

        public void FecharCadastro()
        {
            this.Close();
        }
    }

}
