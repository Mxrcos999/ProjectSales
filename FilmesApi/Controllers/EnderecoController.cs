using AutoMapper;
using FilmesApi.Date;
using FilmesApi.Date.Dtos.endereco;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : Controller
    {
        private FilmeContext _context;
        private IMapper _mapper;
        public EnderecoController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaEndereco([FromBody] CreateEnderecoDto EnderecoDto)
        {
            Endereco endereco = _mapper.Map<Endereco>(EnderecoDto);

            _context.Endereco.Add(endereco);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaEnderecosPorId), new { Id = endereco.Id }, endereco);
        }

        [HttpGet]
        public IActionResult RecuperaEndereco()
        {
            return Ok(_context.Endereco);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEnderecosPorId(int id)
        {
            Endereco endereco = _context.Endereco.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco != null)
            {
                var enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);

                return Ok(enderecoDto);
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        public IActionResult AtualizaEndereco(int id, [FromBody] UpdateEnderecoDto enderecoDto)
        {
            Endereco endereco = _context.Endereco.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null)
            {
                return NotFound();
            }
            _mapper.Map(enderecoDto, endereco);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaEndereco(int id)
        {
            Endereco endereco = _context.Endereco.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null)
            {
                return NotFound();
            }
            _context.Remove(endereco);
            _context.SaveChanges();
            return NoContent();

        }
    }
}
