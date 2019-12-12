using System;
using System.Collections.Generic;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Domain.Models
{
    public partial class ThamGiaChuDe : IAggregateRoot
    {
        public ThamGiaChuDe()
        {
            Hoc = new HashSet<Hoc>();
        }

        public int Id { get; set; }
        public int? IdnguoiDung { get; set; }
        public int? IdchuDe { get; set; }

        public virtual ChuDe IdchuDeNavigation { get; set; }
        public virtual NguoiDung IdnguoiDungNavigation { get; set; }
        public virtual ICollection<Hoc> Hoc { get; set; }
    }
}
