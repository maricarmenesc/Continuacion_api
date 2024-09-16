using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JaveragesLibrary.Domain.Dtos;
using JaveragesLibrary.Domain.Entities;

namespace JaveragesLibrary.Services.Mappings
{
    // . . .
public class RequestCreateMappingProfile : Profile
{
    public RequestCreateMappingProfile()
    {
        CreateMap<MangaCreateDTO, Manga>()
            .AfterMap
						(
                (src, dest) => 
                {
                    dest.PublicationDate = DateTime.Now;
                }
            );
    }
}
}