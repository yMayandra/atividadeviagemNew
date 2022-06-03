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
    class ManipulacaoPacote
    {
        public void cadastraPacote()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@valorPac",Pacote.ValorPac );
                cmd.Parameters.AddWithValue("@origemPac", Pacote.OrigemPac);
                cmd.Parameters.AddWithValue("@destinoPac", Pacote.DestinoPac);
                cmd.Parameters.AddWithValue("@dataPacIda", Pacote.DataPacIda);
                cmd.Parameters.AddWithValue("@datapacVlt", Pacote.DataPacVlt);
                cmd.Parameters.AddWithValue("@descricaoPac", Pacote.DescricaoPac);
                cmd.Parameters.AddWithValue("@imagePac", Pacote.ImagePac);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codPac", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();
                var resposta = MessageBox.Show("Cadastro efetuado com Sucesso, deseja efetuar um novo registro?,",
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

