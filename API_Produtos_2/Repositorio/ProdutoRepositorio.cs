using API_Produtos_2.Dao;
using API_Produtos_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Produtos_2.Repositorio
{
    public class ProdutoRepositorio
    {
        private readonly DaoProduto _daoProduto;

        public ProdutoRepositorio()
        {
            _daoProduto = new DaoProduto();
        }

        public List<Produto> GetProdutos
        {
            get
            {
                return _daoProduto.GetProdutos();
            }
        }

        public void InserirProduto(Produto produto)
        {
            _daoProduto.InserirProduto(produto);
        }
    }
}
