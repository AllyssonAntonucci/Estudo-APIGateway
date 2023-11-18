using Flurl;
using Flurl.Http;
using frontend01.Models;
using Microsoft.AspNetCore.Mvc;
using modelos;
using System.Diagnostics;

namespace frontend01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly string _url = "https://localhost:9000";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Página inicial acessada.");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ListarPedidos()
        {
            var listaPedidos = await $"{_url}/listar-pedidos".GetJsonAsync<List<Pedidos>>();
            return View("index", listaPedidos);
        }

        public IActionResult ResgatarCupom()
        {
            _logger.LogInformation("Página dos cupons acessada.");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResgatarCupom([Bind("Valor")] modelos.RequisicaoCupom req)
        {
           if(req.Valor <= 0)
           {
                TempData["AlertMessage"] = "O valor do cupom precisa ser maior que zero!";
                return RedirectToAction("ResgatarCupom");
           }
           else
           {
                var listaPedidos = await $"{_url}/resgatar-cupom"
                .PostJsonAsync(req)
                .ReceiveJson<modelos.RespostaCupom>();
                return View("ResgatarCupom", listaPedidos);
           }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}