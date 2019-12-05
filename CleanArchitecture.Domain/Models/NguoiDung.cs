using System;
using System.Collections.Generic;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Domain.Models
{
    public partial class NguoiDung : IAggregateRoot
    {
        public NguoiDung()
        {
            ThamGiaChuDe = new HashSet<ThamGiaChuDe>();
        }

        public int Id { get; set; }
        public string TenNguoiDung { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public DateTime? NgayTao { get; set; }
        public string SoDienThoai { get; set; }
        public string Gmail { get; set; }
        public int? VaiTro { get; set; }

        public virtual ICollection<ThamGiaChuDe> ThamGiaChuDe { get; set; }
    }
}
