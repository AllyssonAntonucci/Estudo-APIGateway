using Microsoft.AspNetCore.Mvc;
using modelos;

namespace backend01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosController : ControllerBase
    {
        private static readonly string[] Dados = new[]
        {
            "Arroz", "Frango", "Batata", "Couve", "Feijão", "Farinha", "Laranja", "Morango", "Ovos", "Banana"
        };

        private readonly ILogger<PedidosController> _logger;

        public PedidosController(ILogger<PedidosController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "ListarPedidos")]
        public IEnumerable<Pedidos> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Pedidos
            {
                Data = DateTime.Now.AddDays(index),
                Id = Guid.NewGuid(),
                Dados = Dados[Random.Shared.Next(Dados.Length)]
            })
            .ToArray();
        }
    }
}