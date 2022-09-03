using API_Produtos_2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API_Produtos_2.Dao
{
    public class DaoProduto
    {
        string conexao = @"Data Source=(localdb)\servidorlocal;Initial Catalog=Testes_meus;Integrated Security=True";
        string selectP = @"select 
                            tp.id_produto
	                        ,tp.nm_produto
	                       ,tp.nr_produto
	                        ,tp.dt_cadastro
                          from t_produto tp";
                         
        public List<Produto> GetProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            var produto = new Produto();

            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(selectP, conn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if(reader != null)
                            {
                                while (reader.Read())
                                {
                                    produto.nome = reader["nm_produto"].ToString();
                                    produto.nr_produto = reader.GetDecimal(reader.GetOrdinal("nr_produto"));
                                    
                                    //Adicionando na lista
                                    produtos.Add(produto);
                                }
                            }
                        }
                    }
                }
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }
            return produtos;

        }

        public void InserirProduto(Produto produto)
        {
            List<Produto> produtos = new List<Produto>();
           

            using (SqlConnection con = new SqlConnection(conexao))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(@"insert into t_produto(

                                                                         nm_produto
                                                                         , nr_produto
                                                                         , dt_cadastro
                                                                      )
                                                                      values(@nm_produto , @nr_produto,getdate())", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@nm_produto", produto.nome);
                    cmd.Parameters.AddWithValue("@nr_produto", produto.nr_produto);
                    cmd.ExecuteNonQuery();
                }
            }
 
        }

       
    }
}
