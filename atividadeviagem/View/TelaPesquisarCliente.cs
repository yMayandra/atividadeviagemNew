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
    public partial class TelaPesquisarCliente : Form
    {
        public TelaPesquisarCliente()
        {
            InitializeComponent();
        }

        private void btnbuscarCodCli_Click(object sender, EventArgs e)
        {

            if (tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite o Codigo do Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxEmail.Text = string.Empty;
                tbxNome.Text = string.Empty;
                tbxSenha.Text = string.Empty;

            }
            else
            {

                Cliente.CodCli = Convert.ToInt32(tbxCodCli.Text);
                ManipulacaoCliente manipulacaoCliente = new ManipulacaoCliente();
                manipulacaoCliente.pesquisarCodCliente();
                tbxNome.Text = Cliente.NomeCli;
                tbxEmail.Text = Cliente.EmailCli;
                tbxSenha.Text = Cliente.SenhaCli;

                MemoryStream ms = new MemoryStream((byte[])Cliente.ImageCli);
                pbxImage.Image = Image.FromStream(ms);
              
                

                if (Cliente.Retorno == "Não")
                {
                    tbxCodCli.Text = string.Empty;
                    tbxCodCli.Focus();
                    tbxCodCli.SelectAll();
                    tbxNome.Text = string.Empty;
                    tbxEmail.Text = string.Empty;
                    tbxSenha.Text = string.Empty;
                    pbxImage.Image = null;
                    return;
                }
            }

        }

        private void btnBucarImgCli_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarCli_Click(object sender, EventArgs e)
        {
            if (tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite um Código de Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxEmail.Text = string.Empty;
                tbxNome.Text = string.Empty;
                tbxSenha.Text = string.Empty;
                pbxImage.Image = null;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar os dados do cliente " + tbxCodCli.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if(resposta == DialogResult.Yes)
                {
                    Cliente.CodCli = Convert.ToInt32(tbxCodCli.Text);
                    Cliente.NomeCli = tbxNome.Text;
                    Cliente.EmailCli = tbxEmail.Text;
                    Cliente.SenhaCli = tbxSenha.Text;

                    MemoryStream ms = new MemoryStream();
                    pbxImage.Image.Save(ms, pbxImage.Image.RawFormat);
                    Cliente.ImageCli = ms.ToArray();

                    ManipulacaoCliente manipulacaoCliente = new ManipulacaoCliente();
                    manipulacaoCliente.alterarCliente();
                }
            }
        }

        private void btnDeletarCli_Click(object sender, EventArgs e)
        {
            if (tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite um código de Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
                pbxImage.Image = null;
               
            }
            else
            {
                var resposta = MessageBox.Show("Deseja excluir Cliente" + tbxCodCli.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if(resposta == DialogResult.Yes)
                {
                    Cliente.CodCli = Convert.ToInt32(tbxCodCli.Text);
                    ManipulacaoCliente manipulacaoCliente = new ManipulacaoCliente();
                    manipulacaoCliente.deletarCliente();

                    tbxCodCli.Text = string.Empty;
                    tbxCodCli.Focus();
                    tbxCodCli.SelectAll();
                    tbxEmail.Text = string.Empty;
                    tbxNome.Text = string.Empty;
                    tbxSenha.Text = string.Empty;
                    pbxImage.Image = null;
                }
            }
        }

        private void btnBuscarNomeCli_Click(object sender, EventArgs e)
        {
            if (tbxNomeCli.Text == "")
            {
                MessageBox.Show("Digite o nome do Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Cliente.NomeCli = tbxNomeCli.Text;
            dataGridViewCliente.DataSource = ManipulacaoCliente.pesquisarNomeCliente();

            dataGridViewCliente.Columns[0].Visible = false;
            dataGridViewCliente.Columns[1].Visible = false;
            dataGridViewCliente.Columns[2].Visible = false;
            dataGridViewCliente.Columns[3].Visible = false;
            dataGridViewCliente.Columns[4].HeaderCell.Value="Código";
            dataGridViewCliente.Columns[5].HeaderCell.Value = "Nome";
            dataGridViewCliente.Columns[6].HeaderCell.Value = "E-mail";
            dataGridViewCliente.Columns[7].Visible = false;
            dataGridViewCliente.Columns[8].HeaderCell.Value = "Image";
      

        }
    }
    }

