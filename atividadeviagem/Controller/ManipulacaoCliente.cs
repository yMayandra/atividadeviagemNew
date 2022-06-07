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
                cmd.Parameters.AddWithValue("@nomeCli", Cliente.NomeCli);
                cmd.Parameters.AddWithValue("@emailCli", Cliente.EmailCli);
                cmd.Parameters.AddWithValue("@senhaCli", Cliente.SenhaCli);
                cmd.Parameters.AddWithValue("@imageCli", Cliente.ImageCli);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codCli", SqlDbType.Int);
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
        public void pesquisarCodCliente()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codCli", Cliente.CodCli);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();
                if (arrayDados.Read())
                {
                    Cliente.CodCli = Convert.ToInt32(arrayDados["codCli"]);
                    Cliente.NomeCli = arrayDados["nomeCli"].ToString();
                    Cliente.EmailCli = arrayDados["nomeCli"].ToString();
                    Cliente.SenhaCli = arrayDados["senhaCli"].ToString();
                    Cliente.ImageCli = (System.Array)arrayDados["imagemCli"];
                    Cliente.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cliente.Retorno = "Não";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void deletarCliente()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codCli", Cliente.CodCli);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente excluido com sucesso", "Exclução", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("O Cliente não pode ser excluído", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void alterarCliente()
        {

            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codCli", Cliente.CodCli);
                cmd.Parameters.AddWithValue("@nomeCli", Cliente.NomeCli);
                cmd.Parameters.AddWithValue("@emailCli", Cliente.EmailCli);
                cmd.Parameters.AddWithValue("@senhaCli", Cliente.SenhaCli);
                cmd.Parameters.AddWithValue("@imageCli", Cliente.ImageCli);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente alterado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("O Cliente não foi alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }


        }

        public static BindingSource pesquisarNomeCliente()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisarNomeCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nomeCli", Cliente.NomeCli);
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
