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
    public class NguoiDungService : INguoiDungService
    {
        private readonly INguoiDungRepository iNguoiDungRepository;
        private readonly IMapper iMapper;

        public NguoiDungService(INguoiDungRepository iNguoiDungRepository, IMapper mapper)
        {
            this.iNguoiDungRepository = iNguoiDungRepository;
            this.iMapper = mapper;
        }
        public IEnumerable<SaveNguoiDung> GetSearchTenNguoiDung(string dataTimKiem, string loaiTimKiem)
        {
            return iMapper.Map<IEnumerable<NguoiDung>, IEnumerable<SaveNguoiDung>>(iNguoiDungRepository.GetSearchTenNguoiDung(dataTimKiem, loaiTimKiem));
        }
        public bool CheckTaiKhoan(string taiKhoan)
        {
            return iNguoiDungRepository.CheckTaiKhoan(taiKhoan);
        }

        public void Create(SaveNguoiDung save)
        {
                var nguoiDung = iMapper.Map<SaveNguoiDung, NguoiDung>(save);
            iNguoiDungRepository.Add(nguoiDung);
        }

        public SaveNguoiDung GetNguoiDung(int? iD)
        {
            var nguoiDung = iNguoiDungRepository.GetNguoiDung(iD);
            var ok = iMapper.Map<NguoiDung, SaveNguoiDung>(nguoiDung);
            return ok;
        }

        public NguoiDungViewModel GetNguoiDungs()
        {
            return new NguoiDungViewModel()
            {
                NguoiDungs = iMapper.Map<IEnumerable<NguoiDung>, IEnumerable<SaveNguoiDung>>(iNguoiDungRepository.GetNguoiDungs())
            };


        }

        public SaveNguoiDung Login(string tenDangNhap, string matKhau)
        {
            return iMapper.Map<NguoiDung, SaveNguoiDung>(iNguoiDungRepository.Login(tenDangNhap, matKhau));
        }
    }
}
