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
            dtpVlt pacote = new dtpVlt();
            pacote.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CasdastrarVenda venda = new CasdastrarVenda();
            venda.Show();
                
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisarCliente telaPesquisarCliente = new TelaPesquisarCliente();
            telaPesquisarCliente.ShowDialog();
        }

        private void visualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaPesquisarFuncionario telaPesquisarFuncionario = new TelaPesquisarFuncionario();
            telaPesquisarFuncionario.ShowDialog();
        }
    }
}
