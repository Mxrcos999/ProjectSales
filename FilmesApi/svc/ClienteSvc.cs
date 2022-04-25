using AutoMapper;
using FluentResults;
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendasApi.svc
{
    public class ClienteSvc
    {
        private BancoContext _context;
        private IMapper _mapper;

        public ClienteSvc(BancoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ReadClienteDto RecuperaClientePorId(int id)
        {
            var cliente = _context.clientes.FirstOrDefault(cliente => cliente.id == id);
            if (cliente != null)
            {
                var clienteDto = _mapper.Map<ReadClienteDto>(cliente);

                return clienteDto;
            }
            return null;
        }
        public void AdicionaCliente(CreateClienteDto clienteDto)
        {
            var cliente = _mapper.Map<Clientes>(clienteDto);
            _context.clientes.Add(cliente);
            _context.SaveChanges();

        }
        public Result RecuperaClientePorCpf(string cpf)
        {
            var cliente = _context.clientes;

            if (cliente != null)
            {


                var vCpf = _context.clientes.Where(x => x.Cpf == cpf);
                
               /* Clientes teste;
                teste = (Clientes)vCpf;*/

            }
            return null;
        }
        
    }
}
