﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class ChuDeDTO
    {
        [Key]
        public int Id { get; set; }
        public string TenChuDe { get; set; }
        public string ThongTin { get; set; }
        public DateTime? NgayTao { get; set; }
    }
}
