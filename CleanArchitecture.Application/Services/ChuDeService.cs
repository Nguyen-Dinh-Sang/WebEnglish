using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.Services
{
    public class ChuDeService : IChuDeService
    {
        private readonly IChuDeRepository chuDeRepository;
        private readonly IMapper iMapper;

        public ChuDeService(IChuDeRepository chuDeRepository, IMapper mapper)
        {
            this.chuDeRepository = chuDeRepository;
            this.iMapper = mapper;
        }

        public void Create(ChuDeDTO chuDe)
        {
            chuDeRepository.Create(iMapper.Map<ChuDeDTO, ChuDe>(chuDe));
        }

        public ChuDeDTO GetChuDe(int? Id)
        {
            return iMapper.Map<ChuDe, ChuDeDTO>(chuDeRepository.GetChuDe(Id));
        }

        public IEnumerable<ChuDeDTO> GetChuDes()
        {
            return iMapper.Map<IEnumerable<ChuDe>, IEnumerable<ChuDeDTO>>(chuDeRepository.GetChuDes());
        }

        public void Remove(int? Id)
        {
            chuDeRepository.Remove(Id);
        }
    }
}
