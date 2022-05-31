using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace atividadeviagem.Controller
{
    class ManipulacaoPacote
    {
        public void cadastraPacote()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

           /* try
            {
                cmd.Parameters.AddWithValue("@valorPac", "");
                cmd.Parameters.AddWithValue("@origemPac", "");
                cmd.Parameters.AddWithValue("@destinoPac", "");
                cmd.Parameters.AddWithValue("@destinoPac", "");
                cmd.Parameters.AddWithValue("@dataPac", "");
                cmd.Parameters.AddWithValue("@dataPacIda", "");
                cmd.Parameters.AddWithValue("@datapacVlt", "");
                cmd.Parameters.AddWithValue("@descricaoPac", "");
                cmd.Parameters.AddWithValue("@imagePac", "");*/
            }
    }
    }

