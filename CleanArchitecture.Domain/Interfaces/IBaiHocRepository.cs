using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IBaiHocRepository : IRepository<BaiHoc>
    {
        ChiTietBaiHoc GetChiTietBaiHoc(int? Id);

        ICollection<BaiHoc> Getbaihoc(string dataTimKiem, string loaiTimKiem);
        BaiKiemTra GetBaiKiemTra(int? Id);

        ICollection<CauHoi> GetCauHoi(int? Id);
        CauHoi GetCauHoiEdit(int? Id);

        void AddChiTietBaiHoc(ChiTietBaiHoc chiTietBaiHoc);

        void AddBaiKiemTra(BaiKiemTra baiKiemTra);

        void AddCauHoi(CauHoi cauHoi);

        int GetIDBaiHoc();

        int GetIDBaiKiemTra();
    }
}
