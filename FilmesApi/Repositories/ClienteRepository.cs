using AutoMapper;
using FluentResults;
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasApi.Interface;

namespace VendasApi.Repositories
{
    public class ClienteRepository : ICliente
    {
        private BancoContext _context;
        private IMapper _mapper;
        public ClienteRepository(BancoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ReadClienteDto> GetCliente()
        {
            try
            {
                List<Clientes> clientes = _context.clientes.ToList();
                if (clientes == null)
                {
                    return null;
                }
                return _mapper.Map<List<ReadClienteDto>>(clientes);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Clientes> GetClienteCpf(string cpf)
        {
              var cliente = _context.clientes;

              if (cliente != null)
              {
                List<Clientes> Cliente = _context.clientes.Where(x => x.Cpf == cpf).ToList();
                return Cliente;


            }
            return null;
        }

        public void SaveCliente(CreateClienteDto clienteDto)
        {
            var cliente = _mapper.Map<Clientes>(clienteDto);
            _context.clientes.Add(cliente);
            _context.SaveChanges();
        }
    }
}
