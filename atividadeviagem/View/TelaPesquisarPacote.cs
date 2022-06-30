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
            if (tbxOrigemPac.Text == "")
            {
                MessageBox.Show("Digite o nome do Pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Pacote.OrigemPac = tbxOrigemPac.Text;
            dataGridViewPac.DataSource = ManipulacaoPacote.pesquisarNomePacote();

            dataGridViewPac.Columns[5].HeaderCell.Value = "Código";

            dataGridViewPac.Columns[0].Visible = false;
            dataGridViewPac.Columns[1].Visible = false;
            dataGridViewPac.Columns[2].Visible = false;
            dataGridViewPac.Columns[3].Visible = false;
            dataGridViewPac.Columns[4].Visible = false;
            dataGridViewPac.Columns[5].Visible = false;
            dataGridViewPac.Columns[6].Visible = false;
            dataGridViewPac.Columns[7].Visible = false;
            dataGridViewPac.Columns[8].Visible = false;
            /* dataGridViewPac.Columns[8].HeaderCell.Value = "Foto";*/
        }

        private void btnBucarImgPac_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarPac_Click(object sender, EventArgs e)
        {
            if (tbxCodPac.Text == "")
            {
                MessageBox.Show("Digite o Código do Pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                var resposta = MessageBox.Show("Deseja alterar os dados do Pacote" + tbxCodPac.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Pacote.CodPac = Convert.ToInt32(tbxCodPac.Text);
                    Pacote.DescricaoPac = rtxDescricao.Text;
                    Pacote.OrigemPac = cbxOrigem.Text;
                    Pacote.DestinoPac = cbxDestino.Text;
                   /* Pacote.DataPacIda = dtpIda.Value.ToShortDateString();
                    Pacote.DataPacVlt = dtpIda.Value.ToShortDateString();*/
                    Pacote.ValorPac = Convert.ToDouble(tbxValor.Text);

                    MemoryStream ms = new MemoryStream();
                    pbxImagePac.Image.Save(ms, pbxImagePac.Image.RawFormat);
                    Pacote.ImagePac = ms.ToArray();

                    ManipulacaoPacote manipulacaoPacote = new ManipulacaoPacote();
                    manipulacaoPacote.alterarPacote();


                }
            }
        }

        private void btnDeletarPac_Click(object sender, EventArgs e)
        {
            if (tbxCodPac.Text == "")
            {
                MessageBox.Show("Digite o Código do Pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                var resposta = MessageBox.Show("Deseja excluir Pacote" + tbxCodPac.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Pacote.CodPac = Convert.ToInt32(tbxCodPac.Text);
                    ManipulacaoPacote manipulacaoPacote = new ManipulacaoPacote();
                    manipulacaoPacote.deletarPacote();

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

        private void lblNomePac_Click(object sender, EventArgs e)
        {

        }
    }
}
