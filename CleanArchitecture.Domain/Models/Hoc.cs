using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models
{
    public partial class Hoc
    {
        public int Id { get; set; }
        public int? IdthamGiaChuDe { get; set; }
        public int? IdbaiHoc { get; set; }
        public int? Diem { get; set; }

        public virtual BaiHoc IdbaiHocNavigation { get; set; }
        public virtual ThamGiaChuDe IdthamGiaChuDeNavigation { get; set; }
    }
}
