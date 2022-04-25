using models;
using System.Collections.Generic;

namespace VendasApi.Interface
{
    public interface ICliente
    {
        void SaveCliente(CreateClienteDto clienteDto);
        List<ReadClienteDto> GetCliente();
        List<Clientes> GetClienteCpf(string cpf);
    }
}
