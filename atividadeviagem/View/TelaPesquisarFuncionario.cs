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
    public partial class TelaPesquisarFuncionario : Form
    {
        public TelaPesquisarFuncionario()
        {
            InitializeComponent();
        }

        private void btnbuscarCodFun_Click(object sender, EventArgs e)
        {
            if (tbxCodFun.Text == "")
            {
                MessageBox.Show("Digite o Codigo do Funcionario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxEmail.Text = string.Empty;
                tbxNome.Text = string.Empty;
                tbxSenha.Text = string.Empty;

            }
            else
            {

                Funcionario.CodFun = Convert.ToInt32(tbxCodFun.Text);
                ManipulacaoFuncionario manipulacaoFuncionario = new ManipulacaoFuncionario();
                manipulacaoFuncionario.pesquisarCodFuncionario();
                tbxNome.Text = Cliente.NomeCli;
                tbxEmail.Text = Cliente.EmailCli;
                tbxSenha.Text = Cliente.SenhaCli;

            }
        }
    }
}
