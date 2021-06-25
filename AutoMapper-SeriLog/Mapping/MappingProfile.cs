using AutoMapper;
using AutoMapper_SeriLog.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper_SeriLog.Mapping
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<ProductoRequest, Producto>()
                .ForMember(d => d.Descripcion, o => o.MapFrom(s => s.Description))
                .ForMember(d => d.Precio, o => o.MapFrom(s => s.Price))
                ;

        }

    }
}
