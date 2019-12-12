using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class BaiKiemTraDTO
    {
        [Key]
        public int Id { get; set; }
        public int? IdbaiHoc { get; set; }
        public DateTime? NgayTao { get; set; }
    }
}
