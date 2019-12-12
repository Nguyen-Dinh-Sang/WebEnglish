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

        public IEnumerable<BaiHocDTO> GetBaiHocTheoTen(string dataTimKiem, string loaiTimKiem)
        {

            return iMapper.Map<IEnumerable<BaiHoc>, IEnumerable<BaiHocDTO>>(baiHocRepository.Getbaihoc(dataTimKiem, loaiTimKiem));
        }
        public BaiHocService(IBaiHocRepository baiHocRepository, IMapper mapper)
        {
            this.baiHocRepository = baiHocRepository;
            this.iMapper = mapper;
        }

        public void Create(BaiHocDTO baiHoc)
        {
            baiHocRepository.Add(iMapper.Map<BaiHocDTO, BaiHoc>(baiHoc));
        }

        public void CreateBaiKiemTra(BaiKiemTraDTO baiKiemTra)
        {
            baiHocRepository.AddBaiKiemTra(iMapper.Map<BaiKiemTraDTO, BaiKiemTra>(baiKiemTra));
        }

        public void CreateCauHoi(CauHoiDTO cauHoi)
        {
            baiHocRepository.AddCauHoi(iMapper.Map<CauHoiDTO, CauHoi>(cauHoi)); 
        }

        public void CreateChiTietBaiHoc(ChiTietBaiHocDTO chiTietBaiHoc)
        {
            baiHocRepository.AddChiTietBaiHoc(iMapper.Map<ChiTietBaiHocDTO, ChiTietBaiHoc>(chiTietBaiHoc));
        }

        public BaiHocDTO GetBaiHoc(int? Id)
        {
            return iMapper.Map<BaiHoc, BaiHocDTO>(baiHocRepository.GetBy(Id));
        }

        public IEnumerable<BaiHocDTO> GetBaiHocs()
        {
            return iMapper.Map<IEnumerable<BaiHoc>, IEnumerable<BaiHocDTO>>(baiHocRepository.GetAll());
        }

        public BaiKiemTraDTO GetBaiKiemTra(int? Id)
        {
            return iMapper.Map<BaiKiemTra, BaiKiemTraDTO>(baiHocRepository.GetBaiKiemTra(Id));
        }

        public IEnumerable<CauHoiDTO> GetCauHoi(int? Id)
        {
            var baiKiemTra = GetBaiKiemTra(Id);
            if (baiKiemTra == null)
            {
                return null;
            }
            return iMapper.Map<IEnumerable<CauHoi>, IEnumerable<CauHoiDTO>>(baiHocRepository.GetCauHoi(baiKiemTra.Id));
        }

        public CauHoiDTO GetCauHoiEdit(int? Id)
        {
            return iMapper.Map<CauHoi,CauHoiDTO>(baiHocRepository.GetCauHoiEdit(Id));
        }

        public ChiTietBaiHocDTO GetChiTiet(int? Id)
        {
            return iMapper.Map<ChiTietBaiHoc, ChiTietBaiHocDTO>(baiHocRepository.GetChiTietBaiHoc(Id));
        }

        public int GetIDBaiHoc()
        {
            return baiHocRepository.GetIDBaiHoc();
        }

        public int GetIDBaiKiemTra()
        {
            return baiHocRepository.GetIDBaiKiemTra();
        }

        public void Remove(int? Id)
        {
            baiHocRepository.Remove(Id);
        }
    }
}
