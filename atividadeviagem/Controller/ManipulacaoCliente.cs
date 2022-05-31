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
    class ManipulacaoCliente
    {
        public void cadastrarCliente()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastroCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeCli",Cliente.NomeCli);
                cmd.Parameters.AddWithValue("@emailCli",Cliente.EmailCli);
                cmd.Parameters.AddWithValue("@senhaCli", Cliente.SenhaCli);
                cmd.Parameters.AddWithValue("@imageCli", Cliente.ImageCli);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codCli",SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();
                var resposta = MessageBox.Show("Cadastro efetuado com Sucesso, deseja efetuar um novo registro?," ,
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resposta == DialogResult.Yes)
                {
                    Cliente.Retorno = "Sim";
                        return;
                }
                else
                {
                    Cliente.Retorno = "Não";
                        return;

                }
            }
            catch
            {

            }
        }
    }
}
