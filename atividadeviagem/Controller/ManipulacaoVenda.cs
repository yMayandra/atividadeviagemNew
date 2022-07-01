using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using atividadeviagem.Model;



namespace atividadeviagem.Controller
{
    class ManipulacaoVenda
    {
        public void cadastraVenda()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastraVenda", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@pagoVen", Venda.PagoVen);
                cmd.Parameters.AddWithValue("@codigoCli", Cliente.CodCli);
                cmd.Parameters.AddWithValue("@codigoFun", Funcionario.CodFun);
                cmd.Parameters.AddWithValue("@codigoPac", Pacote.CodPac);
                SqlParameter nv = cmd.Parameters.AddWithValue("@codVen", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();
                var resposta = MessageBox.Show("Cadastro do Venda efetuado com sucesso, deseja efetuar um novo registro?",
                  "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                  );
                if (resposta == DialogResult.Yes)
                {
                    Venda.Retorno = "Sim";
                    return;
                }
                else
                {
                    Venda.Retorno = "Não";
                    return;
                }
            }
            catch
            {
            }
        }
        public void pesquisaCodVen()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaVenda", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codVen", Venda.CodVen);
                cn.Open();
                var arrayDados = cmd.ExecuteReader();
                if (arrayDados.Read())
                {
                    Venda.CodVen = Convert.ToInt32(arrayDados["codVen"]);
                    Venda.PagoVen = arrayDados["pagoVen"].ToString();
                    Cliente.CodCli = Convert.ToInt32(arrayDados["codCli"]);
                    Funcionario.CodFun = Convert.ToInt32(arrayDados["codFun"]);
                    Pacote.CodPac = Convert.ToInt32(arrayDados["codPac"]);
                    Venda.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Venda.Retorno = "Não";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void deletarVen()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarVenda", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codVen", Venda.CodVen);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Venda excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "O Venda não pôde ser excluido.");
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
        public void alterarVen()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarVenda", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codVen", Venda.CodVen);
                cmd.Parameters.AddWithValue("@pagoVen", Venda.PagoVen);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Venda alterado com sucesso" + Venda.PagoVen + Venda.CodVen, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "A Venda não foi alterada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
    }
}

