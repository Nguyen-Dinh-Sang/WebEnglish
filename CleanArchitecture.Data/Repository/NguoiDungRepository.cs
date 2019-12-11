using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Data.Context;
using System.Linq;

namespace CleanArchitecture.Data.Repository
{
    public class NguoiDungRepository : INguoiDungRepository
    {
        private WebEnglishDBContext webEnglishDBContext;

        public NguoiDungRepository(WebEnglishDBContext webEnglishDBContext)
        {
            this.webEnglishDBContext = webEnglishDBContext;
        }
        public ICollection<NguoiDung> GetSearchTenNguoiDung(string dataTimKiem, string loaiTimKiem)
        {
            var nguoiDung = from m in webEnglishDBContext.NguoiDung
                            select m;
            if (!String.IsNullOrEmpty(dataTimKiem) && loaiTimKiem == "tennguoidung")
            {
                nguoiDung = nguoiDung.Where(m => m.TenNguoiDung.Contains(dataTimKiem));
                nguoiDung = nguoiDung.OrderBy(x => x.TenNguoiDung);
            }
            else
            {
                if (!String.IsNullOrEmpty(dataTimKiem) && loaiTimKiem == "tentaikhoan")
                {
                    nguoiDung = nguoiDung.Where(m => m.TaiKhoan.Contains(dataTimKiem));
                    nguoiDung = nguoiDung.OrderBy(x => x.TaiKhoan);
                }
            }
            return nguoiDung.ToList();
        }
        public void Add(NguoiDung nguoi)
        {
            if(nguoi.Id == 0)
            {
                webEnglishDBContext.NguoiDung.Add(nguoi);
                webEnglishDBContext.SaveChanges();
            } else
            {
                NguoiDung findResults = webEnglishDBContext.NguoiDung.Find(nguoi.Id);
                findResults.TenNguoiDung = nguoi.TenNguoiDung;
                findResults.TaiKhoan = nguoi.TaiKhoan;
                findResults.Gmail = nguoi.Gmail;
                findResults.MatKhau = nguoi.MatKhau;
                findResults.SoDienThoai = nguoi.SoDienThoai;
                findResults.VaiTro = nguoi.VaiTro;
                webEnglishDBContext.SaveChanges();
            }
        }

        public bool CheckTaiKhoan(string taiKhoan)
        {
            return webEnglishDBContext.NguoiDung.Count(x => x.TaiKhoan == taiKhoan) > 0;
        }

        public NguoiDung GetNguoiDung(int? iD)
        {
            NguoiDung findResults = webEnglishDBContext.NguoiDung.Find(iD);
            return findResults;
        }

        public IEnumerable<NguoiDung> GetNguoiDungs()
        {
            return webEnglishDBContext.NguoiDung;
        }

        public NguoiDung Login(string tenDangNhap, string matKhau)
        {
            var nguoiDung = from m in webEnglishDBContext.NguoiDung
                             where m.TaiKhoan == tenDangNhap
                             select m;
            if(nguoiDung.Count() > 0)
            {
                if(nguoiDung.First().MatKhau == matKhau)
                {
                    return nguoiDung.First();
                }
                return null;
            }
            return null;
        }
    }
}
