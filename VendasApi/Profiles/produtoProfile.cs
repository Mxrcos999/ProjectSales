using AutoMapper;
using data.dtos;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace models
{
    public class produtoProfile : Profile
    {
        public produtoProfile()
        {
            CreateMap<CreateProdutoDto, produto>();
            CreateMap<produto, ReadProdutoDto>();
        }
    }
}
