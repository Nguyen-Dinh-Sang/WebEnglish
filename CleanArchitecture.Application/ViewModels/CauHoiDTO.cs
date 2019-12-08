using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class CauHoiDTO
    {
        [Key]
        public int Id { get; set; }
        public int? IdbaiKiemTra { get; set; }
        public string CauHoi1 { get; set; }
        public string DapAnA { get; set; }
        public string DapAnB { get; set; }
        public string DapAnC { get; set; }
        public string DapAnD { get; set; }
        public string DapAnDung { get; set; }
        public string GoiY { get; set; }

        public virtual BaiKiemTraDTO IdbaiKiemTraNavigation { get; set; }
    }
}
