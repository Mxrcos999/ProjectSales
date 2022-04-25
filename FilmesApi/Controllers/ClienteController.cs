using Microsoft.AspNetCore.Mvc;
using models;
using VendasApi.Interface;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {

        private readonly ICliente _Icliente;
        public ClienteController(ICliente cliente)
        {

            _Icliente = cliente;
        }

        [HttpPost]
        public void AdicionaCliente(CreateClienteDto clienteDto)
        {
            _Icliente.SaveCliente(clienteDto);

        }

        [HttpGet]
        public IActionResult RecuperaClientes()
        {
            return Ok(_Icliente.GetCliente());
            
           
        }

        [HttpGet("{Cpf}")]
        public IActionResult recuperaClientePorCpf(string Cpf)
        {
            return Ok(_Icliente.GetClienteCpf(Cpf));
        }

    }

}
