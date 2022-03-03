using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
