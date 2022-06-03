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
    public partial class CadastrarFuncionario : Form
    {
        public CadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {

        }

        public void LimparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = String.Empty;
                }
            }
        }

        public void FecharCadastro()
        {
            this.Close();
        }

        private void brnSalvar_Click(object sender, EventArgs e)
        {
            if(tbxNome.Text==""| tbxEmail.Text==""| tbxSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Funcionario.NomeFun = tbxNome.Text;
                Funcionario.EmailFun = tbxEmail.Text;
                Funcionario.SenhaFun = tbxSenha.Text;

                ManipulacaoFuncionario manipulacaoFuncionario = new ManipulacaoFuncionario();
                manipulacaoFuncionario.cadastrarFuncionario();
            }

            if(Funcionario.Retorno == "Sim")
            {
                LimparTela();
                return;
            }
            else
            {
                FecharCadastro();
                return;
            }
        }
    }
}
