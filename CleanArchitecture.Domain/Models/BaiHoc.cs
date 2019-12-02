using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models
{
    public partial class BaiHoc
    {
        public BaiHoc()
        {
            BaiKiemTra = new HashSet<BaiKiemTra>();
            ChiTietBaiHoc = new HashSet<ChiTietBaiHoc>();
            Hoc = new HashSet<Hoc>();
        }

        public int Id { get; set; }
        public int? IdchuDe { get; set; }
        public int? BaiSo { get; set; }
        public string TenBaiHoc { get; set; }
        public DateTime? NgayTao { get; set; }

        public virtual ChuDe IdchuDeNavigation { get; set; }
        public virtual ICollection<BaiKiemTra> BaiKiemTra { get; set; }
        public virtual ICollection<ChiTietBaiHoc> ChiTietBaiHoc { get; set; }
        public virtual ICollection<Hoc> Hoc { get; set; }
    }
}
