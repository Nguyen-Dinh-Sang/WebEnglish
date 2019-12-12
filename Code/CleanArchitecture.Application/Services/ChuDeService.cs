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
        public IEnumerable<ChuDeDTO> GetSearchTenChuDe(string dataTimKiem, string loaiTimKiem)
        {
            return iMapper.Map<IEnumerable<ChuDe>, IEnumerable<ChuDeDTO>>(chuDeRepository.GetSearchTenChuDe(dataTimKiem, loaiTimKiem));
        }
        public ChuDeService(IChuDeRepository chuDeRepository, IMapper mapper)
        {
            this.chuDeRepository = chuDeRepository;
            this.iMapper = mapper;
        }

        public void Create(ChuDeDTO chuDe)
        {
            chuDeRepository.Create(iMapper.Map<ChuDeDTO, ChuDe>(chuDe));
        }

        public ICollection<BaiHocDTO> GetBaiHocs(int? Id)
        {
            return iMapper.Map<ICollection<BaiHoc>, ICollection<BaiHocDTO>>(chuDeRepository.GetBaiHocs(Id));
        }

        public ChuDeDTO GetChuDe(int? Id)
        {
            return iMapper.Map<ChuDe, ChuDeDTO>(chuDeRepository.GetChuDe(Id));
        }

        public IEnumerable<ChuDeDTO> GetChuDes()
        {
            return iMapper.Map<IEnumerable<ChuDe>, IEnumerable<ChuDeDTO>>(chuDeRepository.GetChuDes());
        }

        public ICollection<ThamGiaChuDeDTO> GetThamGiaChuDes(int? Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int? Id)
        {
            chuDeRepository.Remove(Id);
        }
    }
}
