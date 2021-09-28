using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Models;


namespace API.Controllers
{
    [ApiController]
    [Route("api / pessoa")]

        public class PessoaController: ControllerBase
        {

            //--Console.WriteLine("pau no cu do Bruno");

            public PessoaController(DataContext context)
            {
            }

            // POST: api/pessoa/create
            [HttpPost]
            [Route("create")]
            public Pessoa Post(Pessoa pessoa)
            {
                _context.Produtos.Add(produto);                
                return pessoa;
            }
            //Get: api/produto/list
            [HttpGet]
            [Route("list/")]
            public List<Produto> List()
            {
                return _context.Produtos.ToList();
            }

        }

}

