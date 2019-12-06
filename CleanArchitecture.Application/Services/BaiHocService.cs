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
    public class BaiHocService : IBaiHocService
    {
        private readonly IBaiHocRepository baiHocRepository;
        private readonly IMapper iMapper;

        public BaiHocService(IBaiHocRepository baiHocRepository, IMapper mapper)
        {
            this.baiHocRepository = baiHocRepository;
            this.iMapper = mapper;
        }

        public void Create(BaiHocDTO baiHoc)
        {
            baiHocRepository.Add(iMapper.Map<BaiHocDTO, BaiHoc>(baiHoc));
        }

        public BaiHocDTO GetBaiHoc(int? Id)
        {
            return iMapper.Map<BaiHoc, BaiHocDTO>(baiHocRepository.GetBy(Id));
        }

        public IEnumerable<BaiHocDTO> GetBaiHocs()
        {
            return iMapper.Map<IEnumerable<BaiHoc>, IEnumerable<BaiHocDTO>>(baiHocRepository.GetAll());
        }

        public ICollection<BaiKiemTraDTO> GetBaiKiemTra(int? Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<ChiTietBaiHocDTO> GetChiTiet(int? Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int? Id)
        {
            baiHocRepository.Remove(Id);
        }
    }
}
