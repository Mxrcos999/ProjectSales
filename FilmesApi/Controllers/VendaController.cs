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
    public class VendaController : ControllerBase
    {
        private BancoContext _context;
        private IMapper _mapper;
        public VendaController(BancoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public void AdicionaVenda(CreateVendaDto vendaDto)
        {
            Vendas venda = _mapper.Map<Vendas>(vendaDto);

            _context.vendas.Add(venda);
            _context.SaveChanges();
        }

        [HttpGet]
        public IActionResult RecuperaVenda()
        {
            return Ok(_context.vendas);
        }

        [HttpGet("{nomeCliente}")]
        public IActionResult recuperaVendaPorNome(string nomeCliente)
        {
            var cliente = _context.vendas;

            if (cliente != null)
            {
                var teste = _context.vendas.ToList();

                return Ok(_context.vendas
                 .Where(x => x.nomeCliente == nomeCliente));
            }
            return NotFound();
        }

    }
}
