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
    public partial class TelaPesquisarPacote : Form
    {
        public TelaPesquisarPacote()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

            }

        }
    }
}

