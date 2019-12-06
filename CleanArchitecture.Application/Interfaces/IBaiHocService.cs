using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IBaiHocService
    {
        IEnumerable<BaiHocDTO> GetBaiHocs();

        BaiHocDTO GetBaiHoc(int? Id);

        void Create(BaiHocDTO baiHoc);

        void Remove(int? Id);

        ICollection<ChiTietBaiHocDTO> GetChiTiet(int? Id);

        ICollection<BaiKiemTraDTO> GetBaiKiemTra(int? Id);
    }
}
