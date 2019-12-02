using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Data.Context
{  
    public class WebEnglishDBContext : DbContext
    {
        public WebEnglishDBContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<BaiHoc> BaiHoc { get; set; }
        public virtual DbSet<BaiKiemTra> BaiKiemTra { get; set; }
        public virtual DbSet<CauHoi> CauHoi { get; set; }
        public virtual DbSet<ChiTietBaiHoc> ChiTietBaiHoc { get; set; }
        public virtual DbSet<ChuDe> ChuDe { get; set; }
        public virtual DbSet<Hoc> Hoc { get; set; }
        public virtual DbSet<ThamGiaChuDe> ThamGiaChuDe { get; set; }
    }
}
