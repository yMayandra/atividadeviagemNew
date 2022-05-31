using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace atividadeviagem.Controller
{
    class ManipulacaoVenda
    {
        public void cadastrarVenda()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastraVenda", cn);
            cmd.CommandType = CommandType.StoredProcedure;

           /* try
            {
               cmd.Parameters.AddWithValue("@codCli", "");
                cmd.Parameters.AddWithValue("@codFun", "");
                cmd.Parameters.AddWithValue("@codPac", "");
                cmd.Parameters.AddWithValue("@pagoVen", "");*/
            }
        }
    }

