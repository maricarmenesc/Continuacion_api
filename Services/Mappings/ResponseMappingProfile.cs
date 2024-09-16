using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JaveragesLibrary.Domain.Dtos;
using JaveragesLibrary.Domain.Entities;

namespace JaveragesLibrary.Services.Mappings
{
    public class ResponseMappingProfile : Profile
    {
        public ResponseMappingProfile()
        {
            CreateMap<Manga, MangaDTO>()
                .ForMember(
                dest => dest.PublicationYear,
                opt => opt.MapFrom(src => src.PublicationDate.Date.Year)
            ).AfterMap(
                (src, dest) => {
                    var autores = string.Empty;

                    if(src.Artists.Any())
                        autores = string.Join(", ", src.Artists.Select(x => x.Name));

                    dest.Author = autores;
                }
            );
        }
    }
}