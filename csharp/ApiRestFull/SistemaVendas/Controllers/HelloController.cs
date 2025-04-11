using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Services;
using SistemaVendas.Entities;

namespace SistemaVendas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        private readonly HelloService _helloService;

        public HelloController(HelloService helloService)
        {
            _helloService = helloService;
        }

        [HttpGet]
        public IActionResult GetHello()
        {
            var mensagem = _helloService.ObterMensagem();
            return Ok(mensagem);
        }
    }
}