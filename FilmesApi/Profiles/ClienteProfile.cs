using AutoMapper;

namespace models
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            {
                CreateMap<CreateClienteDto, Clientes>();
                CreateMap<Clientes, ReadClienteDto>();
            }
        }
    }
}
