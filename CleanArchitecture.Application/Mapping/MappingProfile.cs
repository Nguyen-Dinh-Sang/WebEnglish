using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SaveNguoiDung, NguoiDung>();
            CreateMap<NguoiDung, SaveNguoiDung>();

            CreateMap<ChuDe, ChuDeDTO>();
            CreateMap<ChuDeDTO, ChuDe>();
        }
    }
}
