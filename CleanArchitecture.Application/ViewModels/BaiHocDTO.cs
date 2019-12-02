using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    class BaiHocDTO
    {
        [Key]
        public int Id { get; set; }
        public int? IdchuDe { get; set; }
        public int? BaiSo { get; set; }
        public string TenBaiHoc { get; set; }
        public DateTime? NgayTao { get; set; }
    }
}
