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
    public partial class Menuprincipal : Form
    {
        public Menuprincipal()
        {
            InitializeComponent();
        }

        private void Menuprincipal_Load(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente cliente = new CadastrarCliente();
            cliente.Show();
        }

        private void cadasrtrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario funcionario = new CadastrarFuncionario();
            funcionario.Show();
        }

        private void casatrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastraPacote pacote = new CadastraPacote();
            pacote.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CasdastrarVenda venda = new CasdastrarVenda();
            venda.Show();
        }
    }
}
