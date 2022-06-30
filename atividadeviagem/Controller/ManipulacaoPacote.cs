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
                cmd.Parameters.AddWithValue("@valorPac", Pacote.ValorPac);
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
                    Pacote.Retorno = "Sim";
                    return;
                }
                else
                {
                    Pacote.Retorno = "Não";
                    return;

                }
            }
            catch
            {

            }
        }
        public void pesquisarCodPacote()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisarPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codPac", Pacote.CodPac);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();
                if (arrayDados.Read())
                {
                    Pacote.CodPac = Convert.ToInt32(arrayDados["codFun"]);
                    Pacote.OrigemPac = arrayDados["origemPac"].ToString();
                    Pacote.DestinoPac = arrayDados["destinoPac"].ToString();
                    Pacote.DescricaoPac = arrayDados["descricaoPac"].ToString();
                    Pacote.ImagePac = (System.Array)arrayDados["imagemPac"];
                    Pacote.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Pacote.Retorno = "Não";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void deletarPacote()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codPac", Pacote.CodPac);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pacote excluido com sucesso", "Exclução", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("O Pacote não excluído", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void alterarPacote()
        {

            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codPac", Pacote.CodPac);
                cmd.Parameters.AddWithValue("@origemPac", Pacote.OrigemPac);
                cmd.Parameters.AddWithValue("@destinoPac", Pacote.DescricaoPac);
                cmd.Parameters.AddWithValue("@dataPacIda", Pacote.DataPacIda);
                cmd.Parameters.AddWithValue("@dataPacVlt", Pacote.DataPacVlt);
                cmd.Parameters.AddWithValue("@descricaPac", Pacote.DescricaoPac);
                cmd.Parameters.AddWithValue("@imagePac", Pacote.ImagePac);


                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pacote alterado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("O Pacote não foi alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }


        }

        public static BindingSource pesquisarNomePacote()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisarNomePacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codFun", Pacote.CodPac);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;
            return dados;

        }
    }

    }

