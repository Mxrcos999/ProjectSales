using AutoMapper;
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
        public void SaveCliente(CreateClienteDto clienteDto)
        {
            var cliente = _mapper.Map<Clientes>(clienteDto);
            _context.clientes.Add(cliente);
            _context.SaveChanges();
        }
    }
}
