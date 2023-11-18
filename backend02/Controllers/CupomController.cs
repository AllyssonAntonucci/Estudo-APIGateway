using Microsoft.AspNetCore.Mvc;
using modelos;

namespace backend02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CupomController : ControllerBase
    {
        private readonly ILogger<CupomController> _logger;

        public CupomController(ILogger<CupomController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Resgatar")]
        public RespostaCupom Resgatar([FromBody] RequisicaoCupom model)
        {
            return new RespostaCupom
            {
                Valor = model.Valor,
                Id = Guid.NewGuid(),
                Status = new Random().Next(minValue: 0, maxValue: 3) != 1 ? "Sucesso" : "Falha",
            };

        }
    }
}