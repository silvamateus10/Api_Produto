using API_Produtos_2.Repositorio;
using API_Produtos_2.Models;
using API_Produtos_2.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Produtos_2.Controllers
{
    public class ValuesController : ApiController
    {

        private readonly ProdutoRepositorio _produtorepositorio;

        public ValuesController()
        {
            _produtorepositorio = new ProdutoRepositorio();
        }

        // GET api/values
        public IEnumerable<Produto> Get()
        {
            return _produtorepositorio.GetProdutos;
        }


        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] Produto produto)
        {
            _produtorepositorio.InserirProduto(produto);

        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
