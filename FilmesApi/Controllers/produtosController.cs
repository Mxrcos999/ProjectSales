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
    public class produtosController : ControllerBase
    {
        private BancoContext _context;
        private IMapper _mapper;
        public produtosController(BancoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public void AdicionaProduto( CreateProdutoDto produtoDto)
        {
            Produtos produto = _mapper.Map<Produtos>(produtoDto);

            _context.Produtos.Add(produto);
            _context.SaveChanges();
         //   return CreatedAtAction(nameof(RecuperaFilmesPorId), new { Id = filme.Id }, filme);
        }

        [HttpGet]
        public IActionResult RecuperaProduto()
        {
            var listaDeId = new List<int>();
            return Ok(_context.Produtos);
        }

        [HttpGet("{id}")]
        public IActionResult recuperaProdutoPorId(int id)
        {
            Produtos produto = _context.Produtos.FirstOrDefault(Produtos => Produtos.id == id);
            if(produto != null)
            {
                var produtoDto = _mapper.Map<ReadProdutoDto>(produto);
                

                return Ok(produtoDto);
            }
            return NotFound();
        }

    }
}
