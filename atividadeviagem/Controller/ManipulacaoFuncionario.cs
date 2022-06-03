using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using atividadeviagem.Model;
using System.Windows.Forms;

namespace atividadeviagem.Controller
{
    class ManipulacaoFuncionario
    {
        public void cadastrarFuncionario()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeFun", Funcionario.NomeFun);
                cmd.Parameters.AddWithValue("@emailFun", Funcionario.EmailFun);
                cmd.Parameters.AddWithValue("@senhaFun", Funcionario.SenhaFun);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codFun", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();
                var resposta = MessageBox.Show("Cadastro Efetivado com Sucesso, deseja efetuar um novo reistro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resposta == DialogResult.Yes)
                {
                    Funcionario.Retorno = "Sim";
                    return;
                }
                else 
                {
                    Funcionario.Retorno = "Não";
                        return;
                }

            }
            catch
            {

            }
        }
    }
}
