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

        //[HttpGet]
        //public IActionResult RecuperaClientes()
        //{
        //  //  return Ok(_context.clientes);
        //}

        //[HttpGet("{Cpf}")]
        //public IActionResult recuperaClientePorNome(string cpf)
        //{
        //  /*  var cliente = _context.clientes;

        //    if (cliente != null)
        //    {


        //        return Ok(_context.clientes
        //         .Where(x => x.Cpf == cpf ));
        //    }
        //    return NotFound();*/
        //}

    }
    
}
