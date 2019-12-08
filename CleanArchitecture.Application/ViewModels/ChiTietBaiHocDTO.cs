using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class ChiTietBaiHocDTO
    {
        [Key]
        public int Id { get; set; }
        public int? IdbaiHoc { get; set; }
        public string NoiDung { get; set; }
        public string LinkMp3 { get; set; }
        public string GhiChu { get; set; }

        public virtual BaiHocDTO IdbaiHocNavigation { get; set; }
    }
}
