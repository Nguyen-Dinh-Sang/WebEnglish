using System;
using System.Collections.Generic;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Domain.Models
{
    public partial class ChuDe : IAggregateRoot
    {
        public ChuDe()
        {
            BaiHoc = new HashSet<BaiHoc>();
            ThamGiaChuDe = new HashSet<ThamGiaChuDe>();
        }

        public int Id { get; set; }
        public string TenChuDe { get; set; }
        public string ThongTin { get; set; }
        public DateTime? NgayTao { get; set; }

        public virtual ICollection<BaiHoc> BaiHoc { get; set; }
        public virtual ICollection<ThamGiaChuDe> ThamGiaChuDe { get; set; }
    }
}
