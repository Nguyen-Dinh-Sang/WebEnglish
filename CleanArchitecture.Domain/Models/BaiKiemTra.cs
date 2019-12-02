using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models
{
    public partial class BaiKiemTra
    {
        public BaiKiemTra()
        {
            CauHoi = new HashSet<CauHoi>();
        }

        public int Id { get; set; }
        public int? IdbaiHoc { get; set; }
        public DateTime? NgayTao { get; set; }

        public virtual BaiHoc IdbaiHocNavigation { get; set; }
        public virtual ICollection<CauHoi> CauHoi { get; set; }
    }
}
