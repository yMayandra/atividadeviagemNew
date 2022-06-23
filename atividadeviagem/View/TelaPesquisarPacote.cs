using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using atividadeviagem.Model;
using atividadeviagem.Controller;
using System.IO;

namespace atividadeviagem.View
{
    public partial class TelaPesquisarPacote : Form
    {
        public TelaPesquisarPacote()
        {
            InitializeComponent();
        }

 

        private void btnbuscarCodPac_Click(object sender, EventArgs e)
        {
            if (tbxCodPac.Text == "")
            {
                MessageBox.Show("Digite o Codigo do Pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodPac.Text = string.Empty;
                tbxCodPac.Focus();
                tbxCodPac.SelectAll();
                cbxOrigem.Text = string.Empty;
                cbxDestino.Text = string.Empty;
                tbxValor.Text = string.Empty;
                rtxDescricao.Text = string.Empty;
                pbxImagePac.Image = null;
            }
            else
            {
                Pacote.CodPac = Convert.ToInt32(tbxCodPac.Text);
                ManipulacaoPacote manipulacaoPacote = new ManipulacaoPacote();
                manipulacaoPacote.pesquisarCodPacote();

                tbxValor.Text = Convert.ToString(Pacote.ValorPac);
                cbxOrigem.Text = Pacote.DestinoPac;
                rtxDescricao.Text = Pacote.DescricaoPac;

                MemoryStream tt = new MemoryStream((byte[])Pacote.ImagePac);
                pbxImagePac.Image = System.Drawing.Image.FromStream(tt);


                if (Pacote.Retorno == "Não")
                {
                    tbxCodPac.Text = string.Empty;
                    tbxCodPac.Focus();
                    tbxCodPac.SelectAll();
                    cbxOrigem.Text = string.Empty;
                    cbxDestino.Text = string.Empty;
                    tbxValor.Text = string.Empty;
                    rtxDescricao.Text = string.Empty;
                    pbxImagePac.Image = null;
                }
            }

        }

        private void btnBuscarNomePac_Click(object sender, EventArgs e)
        {

        }

        private void btnBucarImgPac_Click(object sender, EventArgs e)
        {

        }
    }
}

