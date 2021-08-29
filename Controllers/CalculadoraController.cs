using Hiper.HiperDev.Git.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hiper.HiperDev.Git.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        private readonly ICalculadoraServices _calculadoraServices;

        public CalculadoraController(ICalculadoraServices calculadoraServices) =>
            _calculadoraServices = calculadoraServices;

        [HttpGet("somar/{n1:double}/{n2:double}")]
        public IActionResult Somar(double n1, double n2) =>
            Ok(_calculadoraServices.Somar(n1, n2));

        [HttpGet("subtrair/{n1:double}/{n2:double}")]
        public IActionResult Subtrair(double n1, double n2) =>
            Ok(_calculadoraServices.Subtrair(n1, n2));

        [HttpGet("dividir/{n1:double}/{n2:double}")]
        public IActionResult Dividir(double n1, double n2) =>
            Ok(_calculadoraServices.Dividir(n1, n2));

        [HttpGet("multiplicar/{n1:double}/{n2:double}")]
        public IActionResult Multiplicar(double n1, double n2) =>
            Ok(_calculadoraServices.Multiplicar(n1, n2));
    }
}
