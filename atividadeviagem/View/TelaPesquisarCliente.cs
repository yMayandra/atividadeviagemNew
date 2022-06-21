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
    }
    }

