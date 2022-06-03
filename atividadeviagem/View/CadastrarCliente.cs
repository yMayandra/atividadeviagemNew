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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbxNome.Text == "" | tbxEmail.Text == "" | tbxSenha.Text == "" | pbxImage.Image == null)
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Cliente.NomeCli = tbxNome.Text;
                Cliente.EmailCli = tbxEmail.Text;
                Cliente.SenhaCli = tbxSenha.Text;
                if (pbxImage.Image!=null)
                {
                    MemoryStream memoryStream = new MemoryStream();

                    pbxImage.Image.Save(memoryStream, pbxImage.Image.RawFormat);
                    Cliente.ImageCli = memoryStream.ToArray();


                    ManipulacaoCliente manipulacaoCliente = new ManipulacaoCliente();
                    manipulacaoCliente.cadastrarCliente();
                }
            }
            if (Cliente.Retorno == "Sim")
            {
                LimparTela();
                return;
            }
            else if (Cliente.Retorno == "Não") 
            {
                FecharCadastro();
                return;
            }

            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            openFileDialogImage.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg;)" + "|*.jpg;*.png;*.jpeg";
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                pbxImage.Image = Image.FromFile(openFileDialogImage.FileName);
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
                if(ctl is PictureBox)
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
