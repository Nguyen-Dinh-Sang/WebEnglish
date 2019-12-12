using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class ThamGiaChuDeDTO
    {
        [Key]
        public int Id { get; set; }
        public int? IdnguoiDung { get; set; }
        public int? IdchuDe { get; set; }
    }
}
