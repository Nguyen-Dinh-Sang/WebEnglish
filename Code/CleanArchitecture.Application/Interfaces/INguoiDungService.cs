using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface INguoiDungService
    {
        NguoiDungViewModel GetNguoiDungs();

        void Create(SaveNguoiDung save);
        public IEnumerable<SaveNguoiDung> GetSearchTenNguoiDung(string dataTimKiem, string loaiTimKiem);
        SaveNguoiDung GetNguoiDung(int? iD);

        bool CheckTaiKhoan(string taiKhoan);

        public SaveNguoiDung Login(string tenDangNhap, string matKhau);
    }
}
