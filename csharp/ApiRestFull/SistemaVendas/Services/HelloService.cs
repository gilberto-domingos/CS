using SistemaVendas.Entities;

namespace SistemaVendas.Services
{
    public class HelloService
    {
        public Hello ObterMensagem()
        {
            return new Hello
            {
                Mensagem = "Olá, mundo! API RESTfull"
            };
        }
    }
}