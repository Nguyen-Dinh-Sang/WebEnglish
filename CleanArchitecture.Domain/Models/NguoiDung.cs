using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class NguoiDung
    {
        //public NguoiDung()
        //{
          //  ThamGiaChuDe = new HashSet<ThamGiaChuDe>();
        //}
        [Key]
        public int Id { get; set; }
        public string TenNguoiDung { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public DateTime? NgayTao { get; set; }
        public string SoDienThoai { get; set; }
        public string Gmail { get; set; }
        public int? VaiTro { get; set; }

        //public virtual ICollection<ThamGiaChuDe> ThamGiaChuDe { get; set; }
    }
}
