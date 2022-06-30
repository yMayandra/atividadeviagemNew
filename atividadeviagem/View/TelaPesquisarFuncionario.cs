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

        private void btnAlterarFun_Click(object sender, EventArgs e)
        {
            if (tbxCodFun.Text == "")
            {
                MessageBox.Show("Digite um Código de Funcionario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxEmail.Text = string.Empty;
                tbxNome.Text = string.Empty;
                tbxSenha.Text = string.Empty;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar os dados do Funcionario" + tbxCodFun.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Funcionario.CodFun = Convert.ToInt32(tbxCodFun.Text);
                    Funcionario.NomeFun = tbxNome.Text;
                    Funcionario.EmailFun = tbxEmail.Text;
                    Funcionario.SenhaFun = tbxSenha.Text;

                    ManipulacaoFuncionario manipulacaoFuncionario = new ManipulacaoFuncionario();
                    manipulacaoFuncionario.alterarFuncionario();
                }
            }
        }

        private void btnDeletarFun_Click(object sender, EventArgs e)
        {
            if (tbxCodFun.Text == "")
            {
                MessageBox.Show("Digite um código de Funcionario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;

            }
            else
            {
                var resposta = MessageBox.Show("Deseja excluir Funcionario" + tbxCodFun.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Cliente.CodCli = Convert.ToInt32(tbxCodFun.Text);
                    ManipulacaoFuncionario manipulacaoFuncionario = new ManipulacaoFuncionario();
                    manipulacaoFuncionario.deletarFuncionario();

                    tbxCodFun.Text = string.Empty;
                    tbxCodFun.Focus();
                    tbxCodFun.SelectAll();
                    tbxEmail.Text = string.Empty;
                    tbxNome.Text = string.Empty;
                    tbxSenha.Text = string.Empty;
                }
            }

        }

        private void btnBuscarNomeFun_Click(object sender, EventArgs e)
        {
            if (tbxNomeFun.Text == "")
            {
                MessageBox.Show("Digite o nome do Funcionario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Funcionario.NomeFun= tbxNomeFun.Text;
            dataGridViewFun.DataSource = ManipulacaoFuncionario.pesquisarNomeFuncionario();

            dataGridViewFun.Columns[5].HeaderCell.Value = "Código";

            dataGridViewFun.Columns[0].Visible = false;
            dataGridViewFun.Columns[1].Visible = false;
            dataGridViewFun.Columns[2].Visible = false;
            dataGridViewFun.Columns[3].Visible = false;
            dataGridViewFun.Columns[4].Visible = false;
            dataGridViewFun.Columns[5].Visible = false;
            dataGridViewFun.Columns[6].Visible = false;
            dataGridViewFun.Columns[7].Visible = false;
            dataGridViewFun.Columns[8].Visible = false;
            /* dataGridViewFun.Columns[8].HeaderCell.Value = "Foto";*/
        }
    }
}
