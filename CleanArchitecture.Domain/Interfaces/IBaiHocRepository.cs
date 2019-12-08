﻿using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IBaiHocRepository : IRepository<BaiHoc>
    {
        ChiTietBaiHoc GetChiTietBaiHoc(int? Id);
        BaiKiemTra GetBaiKiemTra(int? Id);
        ICollection<CauHoi> GetCauHoi(int? Id);

        void AddChiTietBaiHoc(ChiTietBaiHoc chiTietBaiHoc);
        void AddBaiKiemTra(BaiKiemTra baiKiemTra);
        void AddCauHoi(IEnumerable<CauHoi> cauHoi);

        void UpdateCauHoi(IEnumerable<CauHoi> cauHoi);
    }
}
