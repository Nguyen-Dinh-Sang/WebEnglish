using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Services
{
    public class BaiHocService : IBaiHocService
    {
        public void Create(ChuDeDTO chuDe)
        {
            throw new NotImplementedException();
        }

        public BaiHocDTO GetBaiHoc(int? Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BaiHocDTO> GetBaiHocs()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
