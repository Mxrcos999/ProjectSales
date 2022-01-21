using AutoMapper;
using FilmesApi.Date.Dtos;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmesDto, Filme>();
            CreateMap<Filme, ReadFIlmesDto>();
            CreateMap<UpdateFilmesDto, Filme>();


        }
    }
}
