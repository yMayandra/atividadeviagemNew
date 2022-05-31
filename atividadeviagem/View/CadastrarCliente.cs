using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (tbxNome.Text == "" | tbxEmail.Text =="" | tbxSenha.Text == "" |pbxImage.Image == null)
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
