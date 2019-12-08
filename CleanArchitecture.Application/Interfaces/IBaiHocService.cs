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

        ChiTietBaiHocDTO GetChiTiet(int? Id);

        BaiKiemTraDTO GetBaiKiemTra(int? Id);

        IEnumerable<CauHoiDTO> GetCauHoi(int? Id);
    }
}
