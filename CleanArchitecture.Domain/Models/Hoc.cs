using System;
using System.Collections.Generic;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Domain.Models
{
    public partial class Hoc : IAggregateRoot
    {
        public int Id { get; set; }
        public int? IdthamGiaChuDe { get; set; }
        public int? IdbaiHoc { get; set; }
        public int? Diem { get; set; }

        public virtual BaiHoc IdbaiHocNavigation { get; set; }
        public virtual ThamGiaChuDe IdthamGiaChuDeNavigation { get; set; }
    }
}
