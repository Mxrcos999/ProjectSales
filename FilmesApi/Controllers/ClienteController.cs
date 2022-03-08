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

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private BancoContext _context;
        private IMapper _mapper;
        public ClienteController(BancoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public void AdicionaCliente(CreateClienteDto clienteDto)
        {
            Clientes cliente = _mapper.Map<Clientes>(clienteDto);

            _context.clientes.Add(cliente);
            _context.SaveChanges();
         //   return CreatedAtAction(nameof(RecuperaFilmesPorId), new { Id = filme.Id }, filme);
        }

        [HttpGet]
        public IActionResult RecuperaClientes()
        {
            return Ok(_context.clientes);
        }

        [HttpGet("{Cpf}")]
        public IActionResult recuperaClientePorNome(string cpf)
        {
            var cliente = _context.clientes;
                
            if (cliente != null)
            {
                

                return Ok(_context.clientes
                 .Where(x => x.Cpf == cpf ));
            }
            return NotFound();
        }
   

    }
}
