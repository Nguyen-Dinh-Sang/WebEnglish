using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface INguoiDungRepository
    {
        IEnumerable<NguoiDung> GetNguoiDungs();
        void Add(NguoiDung nguoi);
        public ICollection<NguoiDung> GetSearchTenNguoiDung(string dataTimKiem, string loaiTimKiem);
        NguoiDung GetNguoiDung(int? iD);

        public bool CheckTaiKhoan(string taiKhoan);

        public NguoiDung Login(string tenDangNhap, string matKhau);
    }
}