using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PedidosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/pedidos
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Pedido 1", "Pedido 2", "Pedido 3"  };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            string pedido = "Pedido " + id.ToString();
            return pedido;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            return "Pedido inserido com sucesso!";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] string value)
        {
            return "Pedido " + id.ToString() + " atualizado com sucesso!";
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            return "Pedido " + id.ToString() + " deletado com sucesso!";
        }
    }

    [Route("api/pagamentos/{idPedido}")]
    [ApiController]
    public class PagamentosController : ControllerBase
    {
        // POST api/pagamentos/{idPedido}
        [HttpPost]
        public ActionResult<string> Post(int idPedido)
        {
            return "Pedido " + idPedido.ToString() + " foi pago com sucesso!";
        }
    }

    [Route("api/cancelamentos/{idPedido}")]
    [ApiController]
    public class CancelamentosController : ControllerBase
    {
        // POST api/cancelamentos/{idPedido}
        [HttpPost]
        public ActionResult<string> Post(int idPedido)
        {
            return "Pedido " + idPedido.ToString() + " foi cancelado com sucesso!";
        }
    }
}
