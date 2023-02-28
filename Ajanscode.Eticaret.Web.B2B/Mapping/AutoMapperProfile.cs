using Ajanscode.Eticaret.Web.Dtos.Concreate;
using Ajanscode.Eticaret.Web.Entities.Concrate;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajanscode.Eticaret.Web.B2B.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<KategoriAddDto, Kategori>();
            CreateMap<Kategori, KategoriAddDto>();
            CreateMap<Kategori, KategoriListDto>();
        }
    }
}
