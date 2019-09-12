using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebService.Controllers
{
    [Produces("application/json")]
    [Route("api/Exec1")]
    public class Exec1Controller : Controller
    {
        // GET: api/Exec1
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Exec1/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int area)
        {
            var tmp = "";
            int total;
            int percentualVendas;
            Console.Write("Digite seu nome: ");
            var name = Console.ReadLine();
            Console.Write("Digite seu sálario fixo aqui: ");
            var salarioFixo = Console.ReadLine();
            Console.Write("Coloque o Total de vendas em dinheiro, aqui: ");
            var totalVendas = Console.Read();

        

            percentualVendas = totalVendas / 15.0;





        }

    }
}
