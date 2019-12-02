using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models
{
    public partial class ChiTietBaiHoc
    {
        public int Id { get; set; }
        public int? IdbaiHoc { get; set; }
        public string NoiDung { get; set; }
        public string LinkMp3 { get; set; }
        public string GhiChu { get; set; }

        public virtual BaiHoc IdbaiHocNavigation { get; set; }
    }
}
