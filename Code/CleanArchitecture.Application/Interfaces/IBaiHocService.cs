﻿using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IBaiHocService
    {
        IEnumerable<BaiHocDTO> GetBaiHocTheoTen(string dataTimKiem, string loaiTimKiem);
        IEnumerable<BaiHocDTO> GetBaiHocs();

        BaiHocDTO GetBaiHoc(int? Id);

        void Create(BaiHocDTO baiHoc);

        void Remove(int? Id);

        ChiTietBaiHocDTO GetChiTiet(int? Id);

        BaiKiemTraDTO GetBaiKiemTra(int? Id);

        IEnumerable<CauHoiDTO> GetCauHoi(int? Id);

        int GetIDBaiHoc();

        int GetIDBaiKiemTra();

        void CreateChiTietBaiHoc(ChiTietBaiHocDTO chiTietBaiHoc);

        void CreateBaiKiemTra(BaiKiemTraDTO baiKiemTra);

        void CreateCauHoi(CauHoiDTO cauHoi);

        CauHoiDTO GetCauHoiEdit(int? Id);
    }
}
