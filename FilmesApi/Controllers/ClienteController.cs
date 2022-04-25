using AutoMapper;
using data.dtos;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasApi.svc;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {

        private ClienteSvc _svc;
        public ClienteController(ClienteSvc svc)
        {

            _svc = svc;
        }

        [HttpPost]
        public void AdicionaCliente(CreateClienteDto clienteDto)
        {
            _svc.AdicionaCliente(clienteDto);

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
