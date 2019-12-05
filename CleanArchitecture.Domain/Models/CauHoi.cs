using System;
using System.Collections.Generic;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Domain.Models
{
    public partial class CauHoi : IAggregateRoot
    {
        public int Id { get; set; }
        public int? IdbaiKiemTra { get; set; }
        public string CauHoi1 { get; set; }
        public string DapAnA { get; set; }
        public string DapAnB { get; set; }
        public string DapAnC { get; set; }
        public string DapAnD { get; set; }
        public string DapAnDung { get; set; }
        public string GoiY { get; set; }

        public virtual BaiKiemTra IdbaiKiemTraNavigation { get; set; }
    }
}
