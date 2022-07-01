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


namespace atividadeviagem.View
{
    public partial class CadastrarVenda : Form
    {
        public CadastrarVenda()
        {
            InitializeComponent();
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            if (tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite o Codigo do Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxNomeCli.Text = string.Empty;

            }
            else
            {

                Cliente.CodCli = Convert.ToInt32(tbxCodCli.Text);
                ManipulacaoCliente manipulacaoCliente = new ManipulacaoCliente();
                manipulacaoCliente.pesquisarCodCliente();
                tbxNomeCli.Text = Cliente.NomeCli;


                if (Cliente.Retorno == "Não")
                {
                    tbxCodCli.Text = string.Empty;
                    tbxCodCli.Focus();
                    tbxCodCli.SelectAll();
                    tbxNomeCli.Text = string.Empty;
                    return;
                }
            }

        }

        private void btnCodFun_Click(object sender, EventArgs e)
        {
            if (tbxCodFun.Text == "")
            {
                MessageBox.Show("Digite o Codigo do Funcionario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxNomeFun.Text = string.Empty;

            }
            else
            {

                Funcionario.CodFun = Convert.ToInt32(tbxCodFun.Text);
                ManipulacaoFuncionario manipulacaoFuncionario = new ManipulacaoFuncionario();
                manipulacaoFuncionario.pesquisarCodFuncionario();
                tbxNomeFun.Text = Funcionario.NomeFun;
            }
        }

        private void btnCodPac_Click(object sender, EventArgs e)
        {
            if (tbxCodPac.Text == "")
            {
                MessageBox.Show("Digite o Codigo do Pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodPac.Text = string.Empty;
                tbxCodPac.Focus();
                tbxCodPac.SelectAll();
                tbxValorPac.Text = string.Empty;

            }
            else
            {
                Pacote.CodPac = Convert.ToInt32(tbxCodPac.Text);
                ManipulacaoPacote manipulacaoPacote = new ManipulacaoPacote();
                manipulacaoPacote.pesquisarCodPacote();

                tbxValorPac.Text = Convert.ToString(Pacote.ValorPac);



                if (Pacote.Retorno == "Não")
                {
                    tbxCodPac.Text = string.Empty;
                    tbxCodPac.Focus();
                    tbxCodPac.SelectAll();
                    tbxValorPac.Text = string.Empty;
                }
            }
        }

        private void btmSalvar_Click(object sender, EventArgs e)
        {
          
            if (tbxValorPac.Text == "" | tbxCodCli.Text == "" | tbxCodFun.Text == "" | tbxCodPac.Text == "")
            {
                MessageBox.Show("Preencha todas as informações corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
            else
            {
                Venda.PagoVen = tbxValorPac.Text.ToString();
                Cliente.CodCli = Convert.ToInt32(tbxCodCli.Text);
                Funcionario.CodFun = Convert.ToInt32(tbxCodFun.Text);
                Pacote.CodPac = Convert.ToInt32(tbxCodPac.Text);
                ManipulacaoVenda manipulaVendas = new ManipulacaoVenda();
                manipulaVendas.cadastraVenda();
            }
            


        }
    }
}
